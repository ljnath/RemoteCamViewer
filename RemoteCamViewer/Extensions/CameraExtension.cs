using RemoteCamViewer.Common;
using RemoteCamViewer.Models;
using System;
using System.IO;

namespace RemoteCamViewer.Extensions
{
    /// <summary>
    /// Extension class for common Camera operation
    /// </summary>
    internal static class CameraExtension
    {
        /// <summary>
        /// Method to evaluate camera channel number from selection index.
        /// As selection index ideally starts from 0 and some camera's channel starts from 0 while other starts from 1.
        /// 
        /// - Hi3516    : channel number starts from 1
        /// - Defeway   : channel number starts from 0
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static int GetChannelNumberFromIndex(this Camera camera, int index)
        {
            int channelNumber = index;
            switch (camera.Type)
            {

                case CameraType.Hi3516:
                    channelNumber = index + 1;
                    break;

                    //case CameraType.Defeway:
                    //    channelNumber = index;
                    //    break;
            }
            return channelNumber;
        }

        internal static string GetImageUrl(this Camera camera, int channelNumber)
        {
            string cameraUrl = string.Empty;
            if (camera.Type == CameraType.Hi3516)
                cameraUrl = $"http://{camera.NetworkAddress}/webcapture.jpg?command=snap&channel={channelNumber}";
            else if (camera.Type == CameraType.Defeway)
                cameraUrl = $"http://{camera.NetworkAddress}/cgi-bin/snapshot.cgi?chn={channelNumber}&u=admin&p=";
            return cameraUrl;
        }

        internal static string GetImageSaveDirectory(this Camera camera, int channelNumber, string autoSaveDirectory)
        {
            return Path.Combine(new string[] { autoSaveDirectory, Constants.ApplicationName, $"{camera.NetworkAddress.Replace(":", "_")}", $"{DateTime.Now:yyyyMMdd}_Channel_{channelNumber}" });
        }

    }
}
