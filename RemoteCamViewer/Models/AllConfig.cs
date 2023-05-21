using MetroFramework;
using RemoteCamViewer.Common;
using System;
using System.Collections.Generic;

namespace RemoteCamViewer.Models
{
    [Serializable]
    class AllConfig
    {
        public List<Camera> Cameras { get; set; } = new List<Camera>();


        #region Image configuration
        public bool AutoSaveImage { get; set; } = false;
        public string AutoSaveDirectory { get; set; } = Environment.CurrentDirectory;
        #endregion

        #region Video configuration
        public bool AutoExportVideo { get; set; } = false;
        public bool AutoDeleteSourceImages { get; set; } = true;
        public int OutputVideoFPS { get; set; } = Constants.DefaultVideoFPS;
        #endregion

        #region General application configuration
        public int NetworkTimeout { get; set; } = Constants.DefaultNetworkTimeout;
        public MetroThemeStyle AppTheme { get; set; } = Constants.DefaultTheme;
        public MetroColorStyle AppColor { get; set; } = Constants.DefaultColor;
        #endregion

        public bool ValidateImageConfig()
        {
            if (AutoSaveImage && !string.IsNullOrWhiteSpace(AutoSaveDirectory))
                return true;
            else if (!AutoSaveImage)
                return true;

            return false;
        }
    }
}
