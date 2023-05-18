using RemoteCamViewer.Handlers.IO;
using RemoteCamViewer.Models;
using System;
using System.Linq;

namespace RemoteCamViewer.Handlers
{
    class ConfigHandler
    {
        private readonly static ConfigHandler configHandler = new ConfigHandler();

        private static readonly object padlock = new object();

        private ConfigHandler()
        {
            // private constructor for singleton class
        }

        internal static ConfigHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    return configHandler ?? new ConfigHandler();
                }
            }
        }

        internal GenericConfig Config { get; set; } = new GenericConfig();


        public void UpdateCamConfig(CamConfig remoteCamConfig)
        {
            CamConfig existingCamConfig = Config.CamConfigs.FirstOrDefault(c => c.Id.Equals(remoteCamConfig.Id));
            if (existingCamConfig != null)
            {
                existingCamConfig.Name = remoteCamConfig.Name;
                existingCamConfig.Address = remoteCamConfig.Address;
                existingCamConfig.FPS = remoteCamConfig.FPS;
                existingCamConfig.ImageZoom = remoteCamConfig.ImageZoom;
                existingCamConfig.TotalChannel = remoteCamConfig.TotalChannel;
                Save();
            }
        }

        public void AddCamConfig(CamConfig remoteCamConfig)
        {
            Config.CamConfigs.Add(remoteCamConfig);
            Save();
        }

        public CamConfig FindCamConfig(string camAddress)
        {
            return Config.CamConfigs.FirstOrDefault(config => config.Address.Equals(camAddress)) ?? null;
        }

        public CamConfig FindCamById(string camId)
        {
            if (!string.IsNullOrEmpty(camId))
                return Config.CamConfigs.FirstOrDefault(config => config.Id.Equals(camId)) ?? new CamConfig();

            return new CamConfig();
        }

        public void DeleteCamConfig(string camId)
        {
            Config.CamConfigs.RemoveAll(config => config.Id.Equals(camId));
            Save();
        }

        internal void Save()
        {
            DiskHandler.Instance.SaveConfigurationToFile();
        }

        internal void Load()
        {
            DiskHandler.Instance.LoadConfigurationFromFile();
        }
    }
}
