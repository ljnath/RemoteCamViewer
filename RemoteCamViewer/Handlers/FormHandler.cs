using log4net;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using RemoteCamViewer.Common;
using RemoteCamViewer.Extensions;
using RemoteCamViewer.Forms;
using RemoteCamViewer.Handlers.IO;
using RemoteCamViewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace RemoteCamViewer.Handlers
{
    class FormHandler
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly FormHandler formHandler = new FormHandler();
        private static readonly object padlock = new object();

        private FormHandler()
        {
            // private constructor for singleton class
        }

        internal static FormHandler Instance
        {
            get
            {
                lock (padlock)
                    return formHandler ?? new FormHandler();
            }
        }

        internal void InitializeForm(MainForm mainForm)
        {
            mainForm.Text = $"{Constants.ApplicationName} {Constants.ApplicationVersion}";
            mainForm.MinimumSize = mainForm.Size;
            mainForm.WindowState = FormWindowState.Maximized;
            mainForm.flpViewer.AutoScroll = true;
            mainForm.flpChannelSelection.AutoScroll = true;

            // loading saved config
            ConfigHandler.Instance.Load();

            // initialize all metro controls
            InitializeAllMetroControls(mainForm);

            // load all cameras from saved config to UI
            LoadCameraDetails(mainForm.mcbCamAddress);

            // customize UI labels
            mainForm.mlbSelectCamera.Text = "Select Camera : ";
            mainForm.mcbCamAddress.PromptText = "Choose existing camera or add new camera in Settings";
            mainForm.mbtnRefresh.Text = "&Refresh";
            mainForm.mbtnEdit.Text = "E&dit";
            mainForm.mbtnSettings.Text = "&Settings";
            mainForm.mbtnStartStop.Text = "Start";
            mainForm.mbtnAbout.Text = "&About";
            mainForm.mbtnExit.Text = "E&xit";

            // edit and start/stop button are disabled by default, will be enabled when a camera is selected
            mainForm.mbtnEdit.Enabled = mainForm.mbtnStartStop.Enabled = mainForm.mcbCamAddress.SelectedIndex != -1;

            // configured the status label
            mainForm.mlbStatus.Text = string.Empty;
            mainForm.mlbStatus.FontWeight = MetroLabelWeight.Bold;
            mainForm.mlbStatus.Style = ConfigHandler.Instance.Config.AppTheme == MetroThemeStyle.Dark ? MetroColorStyle.Yellow : MetroColorStyle.Red;
            RuntimeConfig.Instance.StatusLabel = mainForm.mlbStatus;

            ShowStatusMessage($"Welcome to {mainForm.Text}! Choose a camera from the drop-down and click 'Start'. To manage camera click 'Settings'");
        }

        internal void InitializeForm(ConfigForm configForm)
        {
            configForm.Text = "Settings";

            configForm.Resizable = false;
            configForm.MinimizeBox = configForm.MaximizeBox = false;
            configForm.StartPosition = FormStartPosition.CenterParent;
            configForm.BorderStyle = MetroFormBorderStyle.FixedSingle;

            // initialize all metro controls
            InitializeAllMetroControls(configForm);

            // General tab is selected by default
            configForm.mtcConfig.SelectedIndex = 0;

            configForm.mtcTpAppConfig.Text = "General";
            configForm.mtcTpCameraConfig.Text = "Camera";
            configForm.mtcTpImageVideo.Text = "Export";

            configForm.mbtnSave.Text = "&Save";
            configForm.mbtnCancel.Text = "&Cancel";

            // general tab page
            configForm.mlbTheme.Text = "Theme :";
            configForm.mlbColor.Text = "Color :";
            configForm.mlbNetworkTimeout.Text = "Network Timeout :";

            configForm.mcbNetworkTimeout.Items.AddRange(Enumerable.Range(1, Constants.MaxTimeout).Cast<object>().ToArray());

            // load all available theme and style
            foreach (MetroThemeStyle metroThemeStyle in Enum.GetValues(typeof(MetroThemeStyle)))
                configForm.mcbTheme.Items.Add(metroThemeStyle.ToString());

            foreach (MetroColorStyle metroColorStyle in Enum.GetValues(typeof(MetroColorStyle)))
                configForm.mcbColor.Items.Add(metroColorStyle.ToString());


            // camera tab page
            configForm.mlbCamType.Text = "Type :";
            configForm.mlbCamName.Text = "Name :";
            configForm.mlbCamNetworkAddress.Text = "Network Address :";
            configForm.mlbTotalChannel.Text = "Total Channel :";
            configForm.mlbFps.Text = "FPS :";
            configForm.mlbZoomPercent.Text = "Zoom Percent :";
            configForm.mbtnDelete.Text = "&Delete";
            configForm.mbtnDelete.Visible = false;

            foreach (CameraType cameraType in Enum.GetValues(typeof(CameraType)))
                configForm.mcbCamType.Items.Add(cameraType.ToString());

            configForm.mcbTotalChannel.Items.AddRange(Enumerable.Range(1, Constants.MaxChannel).Cast<object>().ToArray());
            configForm.mcbFps.Items.AddRange(Enumerable.Range(1, Constants.MaxFps).Cast<object>().ToArray());
            configForm.mcbZoomPercent.Items.AddRange(Enumerable.Range(1, Constants.MaxZoom).Cast<object>().ToArray());

            configForm.mcbCamType.SelectedIndex = 0;
            configForm.mtbCamName.Text = string.Empty;
            configForm.mtbCamNetworkAddress.Text = string.Empty;
            configForm.mcbTotalChannel.SelectedIndex = 0;
            configForm.mcbFps.SelectedIndex = 0;
            configForm.mcbZoomPercent.Text = "50";

            // export tab page
            configForm.mlbAutoSaveImage.Text = "Auto Save Images :";
            configForm.mlbAutoExportVideo.Text = "Auto Export Video :";
            configForm.mlbAutoDeleteSourceImage.Text = "Auto Delete Source Images :";
            configForm.mlbAutoSavePath.Text = "Auto Save Path :";
            configForm.mlbOutputVideoFps.Text = "Output Video FPS:";
            configForm.mbtnAutoSavePath.Text = "...";
            configForm.mcbOutputVideoFps.Items.AddRange(Enumerable.Range(1, Constants.MaxFps).Cast<object>().ToArray());

            // by default all controls expect auto export image should be disable
            configForm.mlbAutoSavePath.Enabled = configForm.mtbAutoSavePath.Enabled = configForm.mbtnAutoSavePath.Enabled = configForm.mtglAutoSaveImage.Checked;
            configForm.mlbAutoExportVideo.Enabled = configForm.mtglAutoExportVideo.Enabled = configForm.mtglAutoSaveImage.Checked;
            configForm.mlbAutoDeleteSourceImage.Enabled = configForm.mtglAutoDeleteSourceImage.Enabled = configForm.mtglAutoSaveImage.Checked;
            configForm.mlbOutputVideoFps.Enabled = configForm.mcbOutputVideoFps.Enabled = configForm.mtglAutoExportVideo.Checked;

            // loading existing config
            configForm.mcbTheme.Text = ConfigHandler.Instance.Config.AppTheme.ToString();
            configForm.mcbColor.Text = ConfigHandler.Instance.Config.AppColor.ToString();
            configForm.mcbNetworkTimeout.Text = ConfigHandler.Instance.Config.NetworkTimeout.ToString();

            configForm.mtglAutoSaveImage.CheckState = ConfigHandler.Instance.Config.AutoSaveImage ? CheckState.Checked : CheckState.Unchecked;
            configForm.mtglAutoExportVideo.CheckState = ConfigHandler.Instance.Config.AutoExportVideo ? CheckState.Checked : CheckState.Unchecked;
            configForm.mtglAutoDeleteSourceImage.CheckState = ConfigHandler.Instance.Config.AutoDeleteSourceImages ? CheckState.Checked : CheckState.Unchecked;
            configForm.mtbAutoSavePath.Text = ConfigHandler.Instance.Config.AutoSaveDirectory;
            configForm.mcbOutputVideoFps.Text = ConfigHandler.Instance.Config.OutputVideoFPS.ToString();

            // in case of edit mode
            if (!string.IsNullOrWhiteSpace(configForm.CameraID))
            {
                configForm.Text = "Edit Camera";
                configForm.mtcConfig.SelectedIndex = 1;
                configForm.mpnlAppConfig.Visible = configForm.mpnlImageVideo.Visible = false;

                Camera camera = configForm.CameraID.GetCameraFromId();
                log.Debug($"Editing existing camera. Camera {camera}");
                if (camera != null)
                {
                    configForm.mcbCamType.Text = camera.Type.ToString();
                    configForm.mtbCamName.Text = camera.Name;
                    configForm.mtbCamNetworkAddress.Text = camera.NetworkAddress;
                    configForm.mcbTotalChannel.Text = camera.TotalChannel.ToString();
                    configForm.mcbFps.Text = camera.FPS.ToString();
                    configForm.mcbZoomPercent.Text = camera.ZoomPercent.ToString();

                    configForm.mbtnDelete.Visible = true;
                }
            }
        }

        internal void ButtonClicks(MainForm mainForm, object sender_button)
        {
            MetroButton metroButton = (MetroButton)sender_button;
            switch (metroButton.Name)
            {
                case "mbtnRefresh":
                    LoadCameraDetails(mainForm.mcbCamAddress);

                    // auto select the first camera from the list or select the last active one; if cameras are present
                    if (mainForm.mcbCamAddress.Items.Count > 0)
                    {
                        mainForm.mcbCamAddress.SelectedIndex = 0;
                        if (RuntimeConfig.Instance.ViewerThreads.Count != 0 && RuntimeConfig.Instance.ActiveCameraID != null)
                        {
                            for (int i = 0; i < mainForm.mcbCamAddress.Items.Count; i++)
                                if (mainForm.mcbCamAddress.Items[i].ToString().Contains(RuntimeConfig.Instance.ActiveCameraID))
                                {
                                    mainForm.mcbCamAddress.SelectedIndex = i;
                                    break;
                                }
                        }
                    }
                    ShowStatusMessage($"Refreshed list of available cameras. Total cameras available is {mainForm.mcbCamAddress.Items.Count}");
                    break;

                case "mbtnEdit":
                    // cannot edit when no camera is selected
                    if (mainForm.mcbCamAddress.SelectedIndex == -1)
                        return;

                    Camera selectedCameraToEdit = mainForm.mcbCamAddress.SelectedItem.ToString().Trim().GetCameraFromSelectionText();
                    ShowStatusMessage($"Editing existing camera with ID {selectedCameraToEdit.ID}");
                    new ConfigForm(selectedCameraToEdit.ID).ShowDialog();

                    // auto refresh after edit
                    mainForm.mbtnRefresh.PerformClick();
                    break;

                case "mbtnSettings":
                    ShowStatusMessage("Configure application, camera, image and video settings");
                    new ConfigForm().ShowDialog();
                    InitializeAllMetroControls(mainForm);
                    InitializeAllMetroCheckBox(mainForm);
                    break;

                case "mbtnAbout":
                    string aboutMessage = $"Developed by: Lakhya Jyoti Nath (ljnath)\nContact: ljnath@ljnath.com / https://ljnath.com\n\n" +
                        $"The RamoteCamViewer is a desktop application developed using the .NET framework. It provides users with the ability to view remote unauthenticated cameras over the internet." +
                        $" The primary functionality of the application is to download images from the camera at regular intervals and display them within the desktop application.\n Visit insecam.org to get list of open cameras; check image address to find the camera Type and network address and add the same in this application.";

                    MetroMessageBox.Show(mainForm, aboutMessage, $"About", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NetworkHandler.OpenHomePage();
                    break;

                case "mbtnStartStop":
                    if (metroButton.Text == "Start")
                    {
                        ShowStatusMessage("Initializing camera viewer...");
                        Camera selectedCameraToView = mainForm.mcbCamAddress.SelectedItem.ToString().Trim().GetCameraFromSelectionText();
                        log.Info($"Initializing camera viewer for currently selected camera {selectedCameraToView}");
                        if (selectedCameraToView == null)
                        {
                            ShowStatusMessage("Failed to initiating camera viewer as not camera is selected to view");
                            return;
                        }
                        CameraHandler.Instance.EvaluateCameraImageSize(ref selectedCameraToView);

                        // validating camera image size; this is mandatory as the picture box size depends on the image size
                        if (!selectedCameraToView.IsValidImageSize())
                        {
                            ShowStatusMessage("Failed to evaludate camera image size; please retry after sometime");
                            return;
                        }

                        AddViewerPictureBoxes(mainForm, selectedCameraToView);
                        CameraHandler.Instance.StartViewer(selectedCameraToView);
                        RuntimeConfig.Instance.ActiveCameraID = selectedCameraToView.ID;
                        metroButton.Text = "Stop";
                    }
                    else if (metroButton.Text == "Stop")
                    {
                        CameraHandler.Instance.StopViewer();    // stop all viewer threads
                        mainForm.flpViewer.Controls.Clear();    // remove all viewer picture boxes
                        foreach (Control control in mainForm.flpViewer.Controls)
                            control.Dispose();

                        // exporting video; disabled UI control until all videos are exported
                        mainForm.mpnlPrimary.Enabled = false;
                        Camera activeCamera = RuntimeConfig.Instance.ActiveCameraID.GetCameraFromId();
                        if (ConfigHandler.Instance.Config.AutoExportVideo && activeCamera != null)
                        {
                            CameraHandler.Instance.ExportVideo(activeCamera);
                            MetroMessageBox.Show(mainForm, "Successfully exported videos from all saved images", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        mainForm.mpnlPrimary.Enabled = true;

                        RuntimeConfig.Instance.ActiveCameraID = null;
                        metroButton.Text = "Start";
                    }
                    break;

                case "mbtnExit":
                    // Stopping any running viewer before exit
                    CameraHandler.Instance.StopViewer();
                    Application.Exit();
                    break;
            }
        }

        internal void ButtonClicks(ConfigForm configForm, object sender)
        {
            MetroButton metroButton = (MetroButton)sender;
            switch (metroButton.Name)
            {
                case "mbtnSave":
                    bool validConfig = true;

                    MessageBoxIcon messageBoxIcon = MessageBoxIcon.Information;
                    string message = "Save successful.";

                    ConfigHandler.Instance.Config.AppTheme = configForm.mcbTheme.SelectedItem.ToString().GetMetroThemeStyle();
                    ConfigHandler.Instance.Config.AppColor = configForm.mcbColor.SelectedItem.ToString().GetMetroColorStyle();
                    ConfigHandler.Instance.Config.NetworkTimeout = Convert.ToInt32(configForm.mcbNetworkTimeout.SelectedItem) != 0 ? Convert.ToInt32(configForm.mcbNetworkTimeout.SelectedItem) : Constants.DefaultNetworkTimeout;

                    ConfigHandler.Instance.Config.AutoSaveImage = configForm.mtglAutoSaveImage.Checked;
                    ConfigHandler.Instance.Config.AutoExportVideo = configForm.mtglAutoExportVideo.Checked;
                    ConfigHandler.Instance.Config.AutoDeleteSourceImages = configForm.mtglAutoDeleteSourceImage.Checked;
                    ConfigHandler.Instance.Config.AutoSaveDirectory = configForm.mtbAutoSavePath.Text.Trim();
                    ConfigHandler.Instance.Config.OutputVideoFPS = Convert.ToInt32(configForm.mcbOutputVideoFps.SelectedItem) != 0 ? Convert.ToInt32(configForm.mcbOutputVideoFps.SelectedItem) : Constants.DefaultVideoFPS;

                    if (!ConfigHandler.Instance.Config.ValidateImageConfig())
                    {
                        validConfig = false;
                        message = "Image config in invalid. Make sure that auto-save directory is populated when auto-save is enabled";
                        messageBoxIcon = MessageBoxIcon.Warning;
                    }

                    // validate camera details only when the camera tab is active
                    if (configForm.mtcConfig.SelectedIndex == 1)
                    {
                        Camera camera = configForm.CameraID.GetCameraFromId();
                        if (camera == null)
                            camera = new Camera();

                        camera.Type = configForm.mcbCamType.Text.GetCameraTypeFromSelectionText();
                        camera.Name = configForm.mtbCamName.Text.Trim();
                        camera.NetworkAddress = configForm.mtbCamNetworkAddress.Text.Trim();
                        camera.TotalChannel = Convert.ToInt32(configForm.mcbTotalChannel.SelectedItem) != 0 ? Convert.ToByte(configForm.mcbTotalChannel.SelectedItem) : 1;
                        camera.FPS = Convert.ToInt32(configForm.mcbFps.SelectedItem) != 0 ? Convert.ToInt32(configForm.mcbFps.SelectedItem) : 1;
                        camera.ZoomPercent = Convert.ToInt32(configForm.mcbZoomPercent.SelectedItem) != 0 ? Convert.ToInt32(configForm.mcbZoomPercent.SelectedItem) : 100;


                        if (!camera.IsValid())
                        {
                            validConfig = false;
                            message = "A camera should have both 'Name' and 'Network Address'.";
                            messageBoxIcon = MessageBoxIcon.Warning;
                        }

                        else if (string.IsNullOrWhiteSpace(configForm.CameraID))
                        {
                            ConfigHandler.Instance.AddCamera(camera);
                            message = "Successfuly saved settings and added new camera.";
                        }
                        else if (!string.IsNullOrWhiteSpace(configForm.CameraID))
                        {
                            ConfigHandler.Instance.UpdateCamera(camera);
                            message = $"Successfuly updated existing camera with ID {configForm.CameraID}";
                        }
                    }

                    if (validConfig)
                        ConfigHandler.Instance.Save();

                    ShowStatusMessage($"{message}");
                    MetroMessageBox.Show(configForm, message, String.Empty, MessageBoxButtons.OK, messageBoxIcon);

                    // close the form only in case of success message
                    if (messageBoxIcon == MessageBoxIcon.Information)
                        configForm.Close();

                    break;

                case "mbtnDelete":
                    if (configForm.mcbCamType.SelectedIndex == -1)
                        return;

                    ConfigHandler.Instance.DeleteCamera(configForm.CameraID);
                    MetroMessageBox.Show(configForm, $"Successfuly deleted existing camera with ID {configForm.CameraID}", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowStatusMessage($"Deleted existing camera with ID {configForm.CameraID}");
                    configForm.Close();
                    break;

                case "mbtnAutoSavePath":
                    string savePath = BrowseForDirectory();
                    if (!string.IsNullOrWhiteSpace(savePath))
                        configForm.mtbAutoSavePath.Text = savePath;
                    break;

                case "mbtnCancel":
                    configForm.Close();
                    break;
            }
        }

        internal void ToogleCheckedChange(ConfigForm configForm, object sender)
        {
            MetroToggle metroButton = (MetroToggle)sender;
            switch (metroButton.Name)
            {
                case "mtglAutoSaveImage":
                    // when auto-saved is enabled, then export video specific control should be enabled
                    configForm.mlbAutoSavePath.Enabled = configForm.mtbAutoSavePath.Enabled = configForm.mbtnAutoSavePath.Enabled = configForm.mtglAutoSaveImage.Checked;
                    configForm.mlbAutoExportVideo.Enabled = configForm.mtglAutoExportVideo.Enabled = configForm.mtglAutoSaveImage.Checked;
                    configForm.mlbAutoDeleteSourceImage.Enabled = configForm.mtglAutoDeleteSourceImage.Enabled = configForm.mtglAutoSaveImage.Checked;

                    configForm.mtglAutoExportVideo.Checked = configForm.mtglAutoDeleteSourceImage.Checked = configForm.mtglAutoSaveImage.Checked;

                    if (configForm.mtglAutoSaveImage.Checked)
                    {
                        configForm.mtglAutoExportVideo.Checked = ConfigHandler.Instance.Config.AutoExportVideo;
                        configForm.mtglAutoDeleteSourceImage.Checked = ConfigHandler.Instance.Config.AutoDeleteSourceImages;
                    }
                    break;

                case "mtglAutoExportVideo":
                    configForm.mlbOutputVideoFps.Enabled = configForm.mcbOutputVideoFps.Enabled = configForm.mtglAutoExportVideo.Checked;
                    configForm.mlbAutoDeleteSourceImage.Enabled = configForm.mtglAutoDeleteSourceImage.Enabled = configForm.mtglAutoExportVideo.Checked;
                    configForm.mtglAutoDeleteSourceImage.Checked = configForm.mtglAutoExportVideo.Checked;

                    if (configForm.mtglAutoExportVideo.Checked)
                    {
                        configForm.mtglAutoDeleteSourceImage.Checked = ConfigHandler.Instance.Config.AutoDeleteSourceImages;
                    }
                    break;
            }
        }

        internal void ComboBoxSelectedChangeCommitted(MainForm mainForm, object sender)
        {
            MetroComboBox metroComboBox = (MetroComboBox)sender;
            switch (metroComboBox.Name)
            {
                case "mcbCamAddress":
                    mainForm.mbtnStartStop.Enabled = mainForm.mbtnEdit.Enabled = mainForm.mlbSelectCamera.Visible = metroComboBox.SelectedIndex != -1;
                    AddChannelSelection(mainForm);
                    break;
            }
        }

        internal void ComboBoxSelectedChangeCommitted(ConfigForm configForm, object sender)
        {
            MetroComboBox metroComboBox = (MetroComboBox)sender;
            switch (metroComboBox.Name)
            {
                case "mcbCamType":
                    CameraType cameraType = metroComboBox.Text.GetCameraTypeFromSelectionText();
                    CameraUrlAttribute attribute = (CameraUrlAttribute)Attribute.GetCustomAttribute(cameraType.GetType().GetField(cameraType.ToString()), typeof(CameraUrlAttribute));
                    configForm.mlbCamUrl.Text = $"URL format= {attribute.Value}";
                    break;
            }
        }

        private void AddViewerPictureBoxes(MainForm mainForm, Camera camera)
        {
            RuntimeConfig.Instance.ViewerPictureBoxes = new List<PictureBox>();

            int pictureBoxWidth = Convert.ToInt32(camera.ImageSize.Width * (camera.ZoomPercent - 1) / 100);
            int pictureBoxHeight = Convert.ToInt32(camera.ImageSize.Height * camera.ZoomPercent / 100);

            for (int i = 0; i < camera.TotalChannel; i++)
            {
                // don't create picture boxes for inactive camera channels
                if (!camera.ActiveChannels.Get(i))
                    continue;

                PictureBox pictureBox = new PictureBox
                {
                    Name = $"pictureBox{i}",
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.None
                };
                mainForm.flpViewer.Controls.Add(pictureBox);
                RuntimeConfig.Instance.ViewerPictureBoxes.Add(pictureBox);
            }
        }

        internal void SetPictureBoxImage(PictureBox pictureBox, Image image)
        {
            try
            {
                if (pictureBox.InvokeRequired)
                {
                    pictureBox.Invoke(new Action(() =>
                    {
                        pictureBox.Image = image;
                        pictureBox.Refresh();
                    }));
                }
                else
                {
                    pictureBox.Image = image;
                    pictureBox.Refresh();
                }
            }
            catch (Exception ex)
            {
                log.Error($"Faied to update picture in camera picture box. Error= {ex}");
            }
        }

        internal void ShowStatusMessage(string statusMessage)
        {
            try
            {
                //statusMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {statusMessage}";
                if (RuntimeConfig.Instance.StatusLabel.InvokeRequired)
                {
                    RuntimeConfig.Instance.StatusLabel.Invoke(new Action(() =>
                    {
                        RuntimeConfig.Instance.StatusLabel.Text = statusMessage;
                        RuntimeConfig.Instance.StatusLabel.Refresh();
                    }));
                }
                else
                {
                    RuntimeConfig.Instance.StatusLabel.Text = statusMessage;
                    RuntimeConfig.Instance.StatusLabel.Refresh();
                }
            }

            catch (InvalidAsynchronousStateException ex)
            {
                //log.Error($"Faied to update status on UI as the source thread has exited");
            }
            catch (Exception ex)
            {
                log.Error($"Faied to update status on UI. Error= {ex}");
            }
        }

        private void AddChannelSelection(MainForm mainForm)
        {
            Camera activeCamera = mainForm.mcbCamAddress.SelectedItem.ToString().Trim().GetCameraFromSelectionText();
            if (activeCamera == null)
                return;

            mainForm.flpChannelSelection.Controls.Clear();
            foreach (Control control in mainForm.flpChannelSelection.Controls)
                control.Dispose();

            for (int i = 0; i < activeCamera.TotalChannel; i++)
            {
                MetroCheckBox channelCheckBox = new MetroCheckBox
                {
                    Checked = activeCamera.ActiveChannels.Get(i),
                    Text = $"Channel {i + 1}"
                };

                channelCheckBox.CheckedChanged += (sender, e) =>
                {
                    MetroCheckBox metroCheckBox = (MetroCheckBox)sender;
                    string channelName = metroCheckBox.Text;
                    int channelNumber = Convert.ToInt32(channelName.Split(' ')[1]);

                    activeCamera.ActiveChannels.Set(channelNumber - 1, metroCheckBox.Checked);
                    ConfigHandler.Instance.Save();
                };


                mainForm.flpChannelSelection.Controls.Add(channelCheckBox);
            }
            InitializeAllMetroCheckBox(mainForm);
        }

        private void InitializeAllMetroControls(MetroForm metroForm)
        {
            metroForm.Theme = ConfigHandler.Instance.Config.AppTheme;
            metroForm.Style = ConfigHandler.Instance.Config.AppColor;
            metroForm.Refresh();

            foreach (MetroButton control in metroForm.FindAll(new Type[] { typeof(MetroButton) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppColor;
                control.UseStyleColors = true;
                control.FontWeight = MetroButtonWeight.Bold;
                control.Refresh();
            }

            foreach (MetroPanel control in metroForm.FindAll(new Type[] { typeof(MetroPanel) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppColor;
                control.UseStyleColors = true;
                control.Refresh();
            }

            foreach (MetroTextBox control in metroForm.FindAll(new Type[] { typeof(MetroTextBox) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppColor;
                control.UseStyleColors = true;
                control.FontSize = MetroTextBoxSize.Medium;
                control.FontWeight = MetroTextBoxWeight.Bold;
                control.Refresh();
            }

            foreach (MetroLabel control in metroForm.FindAll(new Type[] { typeof(MetroLabel) }))
            {
                // skip ui customization from status label
                if (control == RuntimeConfig.Instance.StatusLabel)
                    continue;

                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppColor;
                control.UseStyleColors = true;
                control.FontWeight = MetroLabelWeight.Regular;
                control.Refresh();
            }

            foreach (MetroComboBox control in metroForm.FindAll(new Type[] { typeof(MetroComboBox) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppColor;
                control.UseStyleColors = true;
                control.FontWeight = MetroComboBoxWeight.Regular;
                control.MaxDropDownItems = 10;
                control.Refresh();
            }

            foreach (MetroToggle control in metroForm.FindAll(new Type[] { typeof(MetroToggle) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppColor;
                control.UseStyleColors = true;
                control.FontWeight = MetroLinkWeight.Bold;
                control.Refresh();
            }


            foreach (MetroTabControl control in metroForm.FindAll(new Type[] { typeof(MetroTabControl) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppColor;
                control.UseStyleColors = true;
                control.FontWeight = MetroTabControlWeight.Regular;
                control.Refresh();
            }

            foreach (MetroTabPage control in metroForm.FindAll(new Type[] { typeof(MetroTabPage) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppColor;
                control.UseStyleColors = true;
                control.Refresh();
            }
        }

        private void InitializeAllMetroCheckBox(MetroForm metroForm)
        {
            foreach (MetroCheckBox control in metroForm.FindAll(new Type[] { typeof(MetroCheckBox) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppColor;
                control.UseStyleColors = true;
                control.Refresh();
            }
        }

        private void LoadCameraDetails(MetroComboBox metroComboBox)
        {
            ConfigHandler.Instance.Load();
            metroComboBox.Items.Clear();
            ConfigHandler.Instance.Config.Cameras.ForEach(camera =>
            {
                metroComboBox.Items.Add($"Name={camera.Name} | Type={camera.Type} | Network Address={camera.NetworkAddress} | Total Channel={camera.TotalChannel} | FPS={camera.FPS} | Zoom Percent={camera.ZoomPercent} | ID={camera.ID}");
            });
            metroComboBox.Refresh();
        }

        private string BrowseForDirectory()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select directory to automatically save camera images",
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = ConfigHandler.Instance.Config.AutoSaveDirectory

            };
            return folderBrowserDialog.ShowDialog() == DialogResult.OK ? folderBrowserDialog.SelectedPath : String.Empty;
        }
    }
}
