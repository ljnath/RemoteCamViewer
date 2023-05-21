using System;

namespace RemoteCamViewer.Extensions
{

    public class CameraUrlAttribute : Attribute
    {
        public string Value { get; }

        public CameraUrlAttribute(string value)
        {
            Value = value;
        }
    }
}
