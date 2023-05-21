using RemoteCamViewer.Handlers.IO;
using RemoteCamViewer.Models;
using System;
using System.Collections;
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

        internal AllConfig Config { get; set; } = new AllConfig();



        internal void UpdateCamera(Camera camera)
        {
            Camera existingCamConfig = Config.Cameras.FirstOrDefault(c => c.ID.Equals(camera.ID));
            if (existingCamConfig != null)
            {
                existingCamConfig.Type = camera.Type;
                existingCamConfig.Name = camera.Name;
                existingCamConfig.NetworkAddress = camera.NetworkAddress;
                existingCamConfig.FPS = camera.FPS;
                existingCamConfig.ZoomPercent = camera.ZoomPercent;
                existingCamConfig.TotalChannel = camera.TotalChannel;


                Save();
            }
        }

        internal void AddCamera(Camera camera)
        {
            Config.Cameras.Add(camera);
            Save();
        }

        internal void DeleteCamera(string cameraId)
        {
            Config.Cameras.RemoveAll(config => config.ID.Equals(cameraId));
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
