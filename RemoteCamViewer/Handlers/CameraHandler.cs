using log4net;
using RemoteCamViewer.Common;
using RemoteCamViewer.Extensions;
using RemoteCamViewer.Handlers.IO;
using RemoteCamViewer.Models;
using RemoteCamViewer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace RemoteCamViewer.Handlers
{
    class CameraHandler
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly static CameraHandler cameraHandler = new CameraHandler();

        private static readonly object padlock = new object();

        private CameraHandler()
        {
            // private constructor for singleton class
        }

        internal static CameraHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    return cameraHandler ?? new CameraHandler();
                }
            }
        }


        internal void StartViewer(Camera camera)
        {
            RuntimeConfig.Instance.ViewerThreads = new List<Thread>();
            int viewerPictureBoxIndex = -1;

            for (int i = 0; i < camera.TotalChannel; i++)
            {
                // no point of creating viewer thread of inactive camera channel
                if (!camera.ActiveChannels.Get(i))
                    continue;

                int channelNumber = camera.GetChannelNumberFromIndex(i);
                FormHandler.Instance.ShowStatusMessage($"Starting camera viewer for channel {channelNumber} in a seperate thread");
                Thread viewerThread = new Thread(() =>
                StartViewer(
                    camera,
                    ++viewerPictureBoxIndex,
                    channelNumber,
                    ConfigHandler.Instance.Config));

                RuntimeConfig.Instance.ViewerThreads.Add(viewerThread);

                // start the viewer thread and wait for 50ms before creating the next thread
                viewerThread.Start();
                Thread.Sleep(50);
            }
        }

        private void StartViewer(Camera camera, int pictureBoxIndex, int channelNumber, AllConfig allConfig)
        {
            log.Debug($"Starting viewer thread for channel {channelNumber} for camera ID {camera.ID}");
            string imageUrl = camera.GetImageUrl(channelNumber);
            if (string.IsNullOrWhiteSpace(imageUrl))
                log.Warn($"Failed to start camera viewer as invaid image is evaluated for channel {channelNumber} for camera ID {camera.ID}");

            int networkInterval = GetNetworkInterval(camera.FPS);
            int networkTimeout = ConfigHandler.Instance.Config.NetworkTimeout;


            string imageSaveDirectory = null;

            if (!string.IsNullOrWhiteSpace(allConfig.AutoSaveDirectory) && allConfig.AutoSaveImage)
            {
                imageSaveDirectory = camera.GetImageSaveDirectory(channelNumber, allConfig.AutoSaveDirectory);

                // create directory is missing
                if (!Directory.Exists(imageSaveDirectory))
                    Directory.CreateDirectory(imageSaveDirectory);
            }

            Image offlineImage = Resources.offline;


            while (true)
            {
                try
                {
                    // Check if the thread needs to be terminated
                    if (RuntimeConfig.Instance.ViewerThreads[pictureBoxIndex].ThreadState != ThreadState.Running)
                        break;

                    Image downloadedImage = NetworkHandler.GetImageFromUrl(imageUrl, networkTimeout);
                    FormHandler.Instance.SetPictureBoxImage(RuntimeConfig.Instance.ViewerPictureBoxes[pictureBoxIndex], downloadedImage);
                    FormHandler.Instance.ShowStatusMessage($"Refreshed image for channel {channelNumber}");

                    if (imageSaveDirectory != null)
                        downloadedImage.Save(Path.Combine(imageSaveDirectory, $"{DateTime.Now:yyyyMMdd_HHmmssfff}.jpg"), ImageFormat.Jpeg);
                }
                catch
                {
                    FormHandler.Instance.SetPictureBoxImage(RuntimeConfig.Instance.ViewerPictureBoxes[pictureBoxIndex], offlineImage);
                    FormHandler.Instance.ShowStatusMessage($"Failed to refresh image for channel {channelNumber} due to Network Error");
                }
                Thread.Sleep(networkInterval);
            }
        }

        internal void StopViewer()
        {
            FormHandler.Instance.ShowStatusMessage("Requesting all viewer threads to stop...");
            RuntimeConfig.Instance.ViewerThreads.ForEach(thread =>
            {
                thread.Abort();
            });
        }

        internal void ExportVideo(Camera camera)
        {
            int activeChannelCount = camera.ActiveChannels.Cast<bool>().Count(value => value == true);

            // Create a CountdownEvent with the desired count
            CountdownEvent countdownEvent = new CountdownEvent(activeChannelCount);

            log.Info("Initiating process to export all saved images to video file");
            FormHandler.Instance.ShowStatusMessage("Exporting all saved images for each channel to seperate video files per channel. Please wait ...");
            for (int i = 0; i < camera.TotalChannel; i++)
            {
                // skipping inactive channel
                if (!camera.ActiveChannels.Get(i))
                    continue;

                int channelNumber = camera.GetChannelNumberFromIndex(i);

                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += (sender, args) =>
                {
                    bool autoDeleteSource = ConfigHandler.Instance.Config.AutoDeleteSourceImages;

                    string sourceImagesPath = camera.GetImageSaveDirectory(channelNumber, ConfigHandler.Instance.Config.AutoSaveDirectory);
                    VideoHandler videoHandler = new VideoHandler();
                    videoHandler.CreateVideoFromImages(sourceImagesPath, ConfigHandler.Instance.Config.OutputVideoFPS, autoDeleteSource);

                    // Signal the completion
                    countdownEvent.Signal();
                };
                worker.RunWorkerAsync();
            }

            countdownEvent.Wait();

            log.Info($"Successfully exported all saved images to video for camera ID {camera.ID}");
            FormHandler.Instance.ShowStatusMessage("Sucessfully exported video from all saved images");
        }

        internal void EvaluateCameraImageSize(ref Camera camera)
        {
            if (!camera.IsValidImageSize())
            {
                FormHandler.Instance.ShowStatusMessage("Evaluating camera image size, this may take upto 10 seconds");
                try
                {
                    log.Debug($"Image size of camera is missing, evaluating default image size by downloading a sample image from channel 1. Curent camera= {camera}");
                    int channelNumber = camera.GetChannelNumberFromIndex(0);
                    Image cameraImage = NetworkHandler.GetImageFromUrl(camera.GetImageUrl(channelNumber), 10);
                    camera.ImageSize = cameraImage.Size;
                    ConfigHandler.Instance.Save();
                }
                catch (Exception ex)
                {
                    log.Error($"Failed to evaluate image size for camera with ID {camera.ID}. Error= {ex}");
                }
            }
        }

        private int GetNetworkInterval(int fps)
        {
            return Convert.ToInt32(1000 / fps);
        }
    }
}
