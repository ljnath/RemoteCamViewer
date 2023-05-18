using MetroFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCamViewer.Common
{
    class Constants
    {
        internal static string AppName => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        internal static string AppVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
        internal static string AppDirectory
        {
            get
            {
                string appDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString(), "Lakhya's Innovation Inc.", "Remote Cam Viewer");
                if (!Directory.Exists(appDirectory))
                    Directory.CreateDirectory(appDirectory);
                return appDirectory;
            }
        }
        internal static string ConfigFilePath => Path.Combine(AppDirectory, "app.config");
        internal static MetroThemeStyle DefaultTheme => MetroThemeStyle.Dark;
        internal static MetroColorStyle DefaultStyle => MetroColorStyle.Red;

        internal static int MaxChannel = 64;
        internal static int MaxFps = 30;
        internal static int MaxZoom = 100;
        internal static int MaxTimeout = 60;
    }
}
