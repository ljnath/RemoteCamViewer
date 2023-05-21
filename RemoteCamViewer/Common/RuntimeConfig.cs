using MetroFramework.Controls;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace RemoteCamViewer.Common
{
    /// <summary>
    /// Singleton class to keep track of runtime data
    /// </summary>
    class RuntimeConfig
    {
        private static readonly RuntimeConfig runtimeConfig = new RuntimeConfig();
        private static readonly object padlock = new object();

        private RuntimeConfig()
        {
            // private constructor for singleton class
        }

        internal static RuntimeConfig Instance
        {
            get
            {
                lock (padlock)
                {
                    return runtimeConfig ?? new RuntimeConfig();
                }
            }
        }

        internal List<Thread> ViewerThreads { get; set; } = new List<Thread>();
        internal List<PictureBox> ViewerPictureBoxes { get; set; } = new List<PictureBox>();
        internal MetroLabel StatusLabel { get; set; } = new MetroLabel();
        internal string ActiveCameraID { get; set; }
    }
}
