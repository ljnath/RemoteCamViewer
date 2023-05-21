using System;
using System.Collections;
using System.Drawing;
using System.Web.Script.Serialization;

namespace RemoteCamViewer.Models
{
    [Serializable]
    public class Camera
    {
        private BitArray activeChannels = new BitArray(1, true);
        private int totalChannels = 1;

        public Camera()
        {
        }

        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string NetworkAddress { get; set; }
        public int FPS { get; set; } = 1;
        public Size ImageSize { get; set; } = new Size(0, 0);
        public int ZoomPercent { get; set; } = 100;
        public CameraType Type { get; set; } = CameraType.Hi3516;

        public int TotalChannel
        {
            get
            {
                return totalChannels;
            }
            set
            {
                // reset active channel if channel count changes
                if (value != totalChannels || activeChannels == null)
                    ActiveChannels = new BitArray(value, true);

                totalChannels = value;
            }
        }

        // to keep track of all active channel for this camera
        public BitArray ActiveChannels
        {
            get
            {
                if (activeChannels.Count == 0)
                    activeChannels = new BitArray(TotalChannel, true);
                return activeChannels;
            }
            set
            {
                activeChannels = value;
            }
        }
        public bool IsValid()
        {
            return !String.IsNullOrWhiteSpace(Name) && !String.IsNullOrWhiteSpace(NetworkAddress);
        }
        public bool IsValidImageSize()
        {
            return ImageSize.Width > 0 && ImageSize.Height > 0;
        }
        public override string ToString()
        {
            return new JavaScriptSerializer().Serialize(this);
        }
    }
}
