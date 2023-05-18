using RemoteCamViewer.Common;
using RemoteCamViewer.Models;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RemoteCamViewer.Handlers.IO
{
    class DiskHandler
    {
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
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(Constants.ConfigFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binaryFormatter.Serialize(fileStream, ConfigHandler.Instance.Config);
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
                        ConfigHandler.Instance.Config = (GenericConfig)binaryFormatter.Deserialize(fileStream);
                    }
                }
                catch
                {
                    CleanupConfig();
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
                }
            }
            catch
            {
            }
        }
    }
}
