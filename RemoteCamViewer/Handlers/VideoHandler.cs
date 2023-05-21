using Accord.Video.FFMPEG;
using log4net;
using RemoteCamViewer.Handlers.IO;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RemoteCamViewer.Handlers
{
    class VideoHandler
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Method to convert images in imageDirectory to video file
        /// </summary>
        /// <param name="imageDirectory"></param>
        /// <param name="fps"></param>
        /// <param name="deleteSourceDirectory"></param>
        internal void CreateVideoFromImages(string imageDirectory, int fps, bool deleteSourceImages)
        {
            string directoryName = Path.GetFileName(imageDirectory);
            string outputVideoFilePath = Path.Combine(Path.GetDirectoryName(imageDirectory), $"{directoryName}_{DateTime.Now:HHmmss}.mp4");
            try
            {
                string[] allJpgFiles = Directory.GetFiles(imageDirectory, "*.jpg", SearchOption.TopDirectoryOnly);
                log.Debug($"Total number of JPEG images in {imageDirectory} is {allJpgFiles.Length}. Process will skip when no valid image files are found");

                if (allJpgFiles.Length == 0)
                    return;

                Image firstJpgImage = Image.FromFile(allJpgFiles[0]);
                short imageBitCount = (short)Image.GetPixelFormatSize(firstJpgImage.PixelFormat);
                int videoWidth = firstJpgImage.Width;
                int videoHeight = firstJpgImage.Height;

                // Create a new video writer to join all images into a single MP4 video
                using (VideoFileWriter videoFileWriter = new VideoFileWriter())
                {
                    videoFileWriter.Open(outputVideoFilePath, videoWidth, videoHeight, fps, VideoCodec.MPEG4);
                    allJpgFiles.ToList().ForEach(imageFilePath =>
                    {
                        using (Image imageFrame = Image.FromFile(imageFilePath))
                        {
                            videoFileWriter.WriteVideoFrame((Bitmap)imageFrame);
                        }
                    });
                    videoFileWriter.Close();
                }

                if (deleteSourceImages)
                    DiskHandler.Instance.DeleteDirectoryForcefully(imageDirectory);

                log.Debug($"Successfully exported video file {outputVideoFilePath} from {allJpgFiles.Length} images under {imageDirectory} with {fps} FPS");
            }
            catch (Exception ex)
            {
                log.Error($"Failed to export images from {imageDirectory} to video files {outputVideoFilePath}. Error={ex}");
            }
        }
    }
}
