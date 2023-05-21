using log4net;
using RemoteCamViewer.Common;
using RemoteCamViewer.Models;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace RemoteCamViewer.Handlers.IO
{
    class DiskHandler
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly DiskHandler diskHandler = new DiskHandler();

        private static readonly object padlock = new object();

        private DiskHandler()
        {
            // private constructor for singleton class
        }

        internal static DiskHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    return diskHandler ?? new DiskHandler();
                }
            }
        }

        internal void SaveConfigurationToFile()
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(Constants.ConfigFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    binaryFormatter.Serialize(fileStream, ConfigHandler.Instance.Config);
                }
                FormHandler.Instance.ShowStatusMessage("Successfully saved current settings");
            }
            catch (Exception ex)
            {
                log.Error($"Failed to save configuration file {Constants.ConfigFilePath}. Error={ex}");
                FormHandler.Instance.ShowStatusMessage("Failed to save settings");

            }
        }

        internal void LoadConfigurationFromFile()
        {
            if (File.Exists(Constants.ConfigFilePath))
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    using (FileStream fileStream = new FileStream(Constants.ConfigFilePath, FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        ConfigHandler.Instance.Config = (AllConfig)binaryFormatter.Deserialize(fileStream);
                    }
                    FormHandler.Instance.ShowStatusMessage("Successfully loaded saved settings");
                }
                catch (Exception ex)
                {
                    log.Error($"Failed to loaded existing configuration file {Constants.ConfigFilePath}. Error={ex}");
                    FormHandler.Instance.ShowStatusMessage("Failed to load saved settings");
                    //CleanupConfig();
                }
            }
        }

        private void CleanupConfig()
        {
            try
            {
                if (File.Exists(Constants.ConfigFilePath))
                {
                    File.Delete(Constants.ConfigFilePath);
                    log.Error($"Successfully deleted existing configuration file {Constants.ConfigFilePath}");
                }
            }
            catch (Exception ex)
            {
                log.Error($"Failed to delete configuration file {Constants.ConfigFilePath}. Error={ex}");
                FormHandler.Instance.ShowStatusMessage("Save settings is corrupt; reloaded default settings");
            }
        }

        internal void DeleteDirectoryForcefully(string directoryPath)
        {
            while (Directory.Exists(directoryPath))
            {
                try
                {
                    Directory.Delete(directoryPath, true);
                }
                catch
                {
                    Thread.Sleep(50);
                }
            }
        }
    }
}
