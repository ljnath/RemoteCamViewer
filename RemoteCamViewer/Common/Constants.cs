using MetroFramework;
using System;
using System.IO;
using System.Reflection;

namespace RemoteCamViewer.Common
{
    class Constants
    {
        internal static string ApplicationName => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        internal static string ApplicationVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
        internal static string ApplicationLocalDirectory
        {
            get
            {
                string appDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString(), "Lakhya's Innovation Inc.", Constants.ApplicationName);
                if (!Directory.Exists(appDirectory))
                    Directory.CreateDirectory(appDirectory);

                return appDirectory;
            }
        }
        internal static string ConfigFilePath => Path.Combine(ApplicationLocalDirectory, "app.config");
        internal static string LogFilePath => Path.Combine(ApplicationLocalDirectory, "logs", "remotecamviewer.log");
        internal static MetroThemeStyle DefaultTheme => MetroThemeStyle.Dark;
        internal static MetroColorStyle DefaultColor => MetroColorStyle.Red;
        internal static int MaxChannel => 64;
        internal static int MaxFps => 30;
        internal static int MaxZoom => 100;
        internal static int MaxTimeout => 60;
        internal static int DefaultVideoFPS => 5;
        internal static int DefaultNetworkTimeout=> 10;
    }
}
