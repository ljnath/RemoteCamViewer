using RemoteCamViewer.Common;
using RemoteCamViewer.Handlers.IO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RemoteCamViewer.Models
{
    [Serializable]
    public class CamConfig
    {
        private Size imageSize = new Size(0, 0);

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Address { get; set; }
        public int FPS { get; set; } = 1;
        public Size ImageSize
        {
            get
            {
                // fetch image size if it is not saved
                if (imageSize.Width == 0 || imageSize.Height == 0)
                {
                    try
                    {
                        string imageUrl = RuntimeConfig.Instance.GetImageUrl(Address, 1);
                        Image firstChannelImage = NetworkHandler.GetImageFromUrl(imageUrl, 10);
                        imageSize = firstChannelImage.Size;
                    }
                    catch
                    {
                        MessageBox.Show("Failed to detect image size from remote cam.\nMake sure that the remote com config is correct.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return imageSize;

            }
        }

        public int ImageZoom { get; set; } = 100;
        public int TotalChannel { get; set; } = 1;

        public CamConfig()
        {
        }
        public bool IsValid()
        {
            return !String.IsNullOrWhiteSpace(Name) && !String.IsNullOrWhiteSpace(Address);
        }
    }
}
