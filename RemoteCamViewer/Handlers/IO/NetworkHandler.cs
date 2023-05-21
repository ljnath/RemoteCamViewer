using log4net;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading;

namespace RemoteCamViewer.Handlers.IO
{
    class NetworkHandler
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static byte[] DownloadDataFromUrl(string imageUrl, int timeoutInSec)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = new TimeSpan(0, 0, timeoutInSec);
                    return client.GetByteArrayAsync(imageUrl).Result;
                }
            }
            catch (ThreadAbortException threadAbortException)
            {
                //log.Error($"Download from {imageUrl} failed due to timeout");
            }
            catch (Exception ex)
            {
                //log.Error($"Failed to download data from {imageUrl}. Error={ex}");
            }
            return new byte[] { };
        }


        internal static Image GetImageFromUrl(string imageUrl, int timeoutInSec)
        {
            byte[] imageDataStream = DownloadDataFromUrl(imageUrl, timeoutInSec);
            return Image.FromStream(new MemoryStream(imageDataStream));
        }

        internal static void OpenHomePage()
        {
            System.Diagnostics.Process.Start("https://ljnath.com");
        }
    }
}
