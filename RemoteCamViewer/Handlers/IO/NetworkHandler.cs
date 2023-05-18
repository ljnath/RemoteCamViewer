using RemoteCamViewer.Exceptions;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;

namespace RemoteCamViewer.Handlers.IO
{
    class NetworkHandler
    {
        private static byte[] DownloadImage(string imageUrl, int timeoutInSec)
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new System.TimeSpan(0, 0, timeoutInSec);
                return client.GetByteArrayAsync(imageUrl).Result;
            }
        }


        internal static Image GetImageFromUrl(string imageUrl, int timeoutInSec)
        {
            byte[] imageDataStream = DownloadImage(imageUrl, timeoutInSec);
            return Image.FromStream(new MemoryStream(imageDataStream));
        }

        internal static void OpenHomePage()
        {
            System.Diagnostics.Process.Start("https://ljnath.com");
        }
    }
}
