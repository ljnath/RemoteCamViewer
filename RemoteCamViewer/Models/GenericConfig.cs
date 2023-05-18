using MetroFramework;
using RemoteCamViewer.Common;
using System;
using System.Collections.Generic;

namespace RemoteCamViewer.Models
{
    [Serializable]
    class GenericConfig
    {
        public List<CamConfig> CamConfigs { get; set; } = new List<CamConfig>();
        public int ImagePerRow { get; set; }
        public int TimeoutInSecond { get; set; } = 10;
        public bool AutoSaveImage { get; set; } = false;
        public string AutoSaveImageDirectory { get; set; } = Environment.CurrentDirectory;
        public MetroThemeStyle AppTheme { get; set; } = Constants.DefaultTheme;
        public MetroColorStyle AppStyle { get; set; } = Constants.DefaultStyle;
    }
}
