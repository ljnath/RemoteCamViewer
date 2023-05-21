using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Repository.Hierarchy;
using RemoteCamViewer.Common;
using RemoteCamViewer.Forms;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace RemoteCamViewer
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string applicationGUID = Assembly.GetExecutingAssembly().GetCustomAttribute<GuidAttribute>().Value.ToUpper();
            using (Mutex mutex = new Mutex(false, $@"Global\{applicationGUID}"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show($"{Constants.ApplicationName} is already running.\nRunning multiple instance of this application is not allowed.", Constants.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InitiailizeLogger();
                log.InfoFormat($"Starting {Constants.ApplicationName} {Constants.ApplicationVersion} ; Developed by ljnath (https://ljnath.com)");


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }


        private static void InitiailizeLogger()
        {
            XmlConfigurator.Configure();
            var appender = (LogManager.GetRepository() as Hierarchy).Root.Appenders
                .OfType<FileAppender>()
                .First();

            appender.File = Constants.LogFilePath;
            appender.ActivateOptions();
        }
    }
}
