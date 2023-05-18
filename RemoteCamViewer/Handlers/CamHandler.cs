using RemoteCamViewer.Common;
using RemoteCamViewer.Exceptions;
using RemoteCamViewer.Handlers.IO;
using RemoteCamViewer.Models;
using RemoteCamViewer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RemoteCamViewer.Handlers
{
    class CamHandler
    {
        private readonly static CamHandler camHandler = new CamHandler();

        private static readonly object padlock = new object();

        private CamHandler()
        {
            // private constructor for singleton class
        }

        internal static CamHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    return camHandler ?? new CamHandler();
                }
            }
        }


        internal void StartViewer(CamConfig camConfig, bool sutoSaveImage, string autoSaveDirectory)
        {
            RuntimeConfig.Instance.ViewerThreads = new List<Thread>();

            for (int i = 0; i < camConfig.TotalChannel; i++)
            {
                FormHandler.Instance.UpdateStatus($"Starting viewer thread to handle channel {i + 1}");
                Thread viewerThread = new Thread(() => StartViewer(camConfig.Address, camConfig.FPS, i, sutoSaveImage, autoSaveDirectory));
                RuntimeConfig.Instance.ViewerThreads.Add(viewerThread);

                viewerThread.Start();
                Thread.Sleep(50);
            }
        }


        private void StartViewer(string camAddress, int fps, int channelNumber, bool autoSaveImage, string autoSaveDirectory)
        {
            string remoteImageUrl = RuntimeConfig.Instance.GetImageUrl(camAddress, channelNumber + 1);
            string imageSaveDirectory = Path.Combine(new string[] { autoSaveDirectory, "RemoteCamViewer", $"{camAddress.Replace(":", "_")}", $"Channel_{channelNumber + 1}" });

            int refreshInterval = GetRefrshInterval(fps);
            int imageDownloadTimout = ConfigHandler.Instance.Config.TimeoutInSecond;

            Image offlineImage = Resources.offline;

            // create save directory if missing and auto-save is enable
            if (autoSaveImage && !Directory.Exists(imageSaveDirectory))
                Directory.CreateDirectory(imageSaveDirectory);

            while (true)
            {
                try
                {
                    // Check if the thread needs to be terminated
                    if (RuntimeConfig.Instance.ViewerThreads[channelNumber].ThreadState == ThreadState.AbortRequested)
                        break;

                    Image camImage = NetworkHandler.GetImageFromUrl(remoteImageUrl, imageDownloadTimout);
                    FormHandler.Instance.SetPictureBoxImage(RuntimeConfig.Instance.ViewerPictureBox[channelNumber], camImage);
                    FormHandler.Instance.UpdateStatus($"Updated image for channel {channelNumber + 1}");

                    if (autoSaveImage && !string.IsNullOrWhiteSpace(autoSaveDirectory))
                        camImage.Save(Path.Combine(imageSaveDirectory, $"{DateTime.Now:yyyyMMdd_HHmmssfff}.jpg"), ImageFormat.Jpeg);
                }
                catch (MissingCamException ex)
                {
                    FormHandler.Instance.SetPictureBoxImage(RuntimeConfig.Instance.ViewerPictureBox[channelNumber], offlineImage);
                    FormHandler.Instance.UpdateStatus($"Failed to load image for channel {channelNumber + 1}. Error: Network Error");
                    break;
                }
                catch
                {
                    FormHandler.Instance.SetPictureBoxImage(RuntimeConfig.Instance.ViewerPictureBox[channelNumber], Resources.offline);
                    FormHandler.Instance.UpdateStatus($"Failed to load image for channel {channelNumber + 1}. Error: Network Error");
                }
                Thread.Sleep(refreshInterval);
            }

        }

        internal void StopViewer()
        {
            FormHandler.Instance.UpdateStatus("Stopping all viewer threads ...");
            RuntimeConfig.Instance.ViewerThreads.ForEach(thread =>
            {
                thread.Abort();
            });
        }


        private int GetRefrshInterval(int fps)
        {
            return Convert.ToInt32(1000 / fps);
        }

    }
}
