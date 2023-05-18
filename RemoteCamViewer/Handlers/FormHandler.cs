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
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RemoteCamViewer.Handlers
{
    class FormHandler
    {
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
            mainForm.Text = $"{Constants.AppName} {Constants.AppVersion}";
            mainForm.MinimumSize = mainForm.Size;
            mainForm.WindowState = FormWindowState.Maximized;
            mainForm.flpViewer.AutoScroll = true;

            // loading saved config
            ConfigHandler.Instance.Load();

            InitializeAllMetroControls(mainForm);

            mainForm.mlbCamAddress.Text = "Select Remote Cam : ";
            mainForm.mbtnAbout.Text = "&About";
            mainForm.mbtnConfigure.Text = "&Configure";
            mainForm.mbtnStartStop.Text = "&Start";
            mainForm.mbtnExit.Text = "&Exit";

            mainForm.mlbStatus.Text = string.Empty;
            mainForm.mlbStatus.FontWeight = MetroLabelWeight.Bold;
            mainForm.mlbStatus.Style = ConfigHandler.Instance.Config.AppTheme == MetroThemeStyle.Dark ? MetroColorStyle.Yellow : MetroColorStyle.Red;
            RuntimeConfig.Instance.StatusLabel = mainForm.mlbStatus;

            LoadCamAddress(mainForm.mcbCamAddress, true);
            mainForm.mbtnStartStop.Enabled = mainForm.mcbCamAddress.SelectedIndex != -1;

            UpdateStatus($"Welcome to {mainForm.Text} ! Choose a cam from the drop-down and click 'Start'. To manage cam click 'Configure'");
        }

        internal void InitializeForm(ConfigForm configForm)
        {
            configForm.Text = "Configure";

            configForm.Resizable = false;
            configForm.MinimizeBox = configForm.MaximizeBox = false;
            configForm.StartPosition = FormStartPosition.CenterParent;
            configForm.BorderStyle = MetroFormBorderStyle.FixedSingle;

            InitializeAllMetroControls(configForm);

            configForm.mtcTpAppConfig.Text = "Application";
            configForm.mtcTpCamConfig.Text = "Cam";

            configForm.mlbAutoSave.Text = "Auto Save Images :";
            configForm.mlbAutoSavePath.Text = "Auto Save Image Path :";
            configForm.mlbTimeout.Text = "Image Download Timeout :";
            configForm.mlbTheme.Text = "Theme :";
            configForm.mlbStyle.Text = "Style :";

            configForm.mlbEditMode.Text = "Edit Mode :";
            configForm.mlbCamId.Text = "ID :";
            configForm.mlbCamName.Text = "Name :";
            configForm.mlbCamAddress.Text = "Address :";
            configForm.mlbTotalChannel.Text = "Total Channel :";
            configForm.mlbFps.Text = "FPS :";
            configForm.mlbZoom.Text = "Zoom :";

            configForm.mlbCamId.Enabled = configForm.mcbCamId.Enabled = configForm.mbtnDelete.Enabled = configForm.mtglEdit.Checked;
            configForm.mlbAutoSavePath.Enabled = configForm.mtbAutoSavePath.Enabled = configForm.mbtnAutoSavePath.Enabled = configForm.mtglAutoSave.Checked;

            configForm.mtcConfig.SelectedIndex = 0;
            LoadCamIds(configForm.mcbCamId);
            ResetCamConfigForm(configForm);

            // load all available theme and style
            foreach (MetroThemeStyle metroThemeStyle in Enum.GetValues(typeof(MetroThemeStyle)))
                configForm.mcbTheme.Items.Add(metroThemeStyle.ToString());

            foreach (MetroColorStyle metroColorStyle in Enum.GetValues(typeof(MetroColorStyle)))
                configForm.mcbStyle.Items.Add(metroColorStyle.ToString());

            // loading existing config
            configForm.mtglAutoSave.CheckState = ConfigHandler.Instance.Config.AutoSaveImage ? CheckState.Checked : CheckState.Unchecked;
            configForm.mtbAutoSavePath.Text = ConfigHandler.Instance.Config.AutoSaveImageDirectory;
            configForm.mcbTimeout.Text = ConfigHandler.Instance.Config.TimeoutInSecond.ToString();
            configForm.mcbTheme.Text = ConfigHandler.Instance.Config.AppTheme.ToString();
            configForm.mcbStyle.Text = ConfigHandler.Instance.Config.AppStyle.ToString();

            configForm.mbtnAutoSavePath.Text = "...";
            configForm.mbtnSave.Text = "&Save";
            configForm.mbtnDelete.Text = "&Delete";
            configForm.mbtnCancel.Text = "&Cancel";

            configForm.mtcConfig.Refresh();

        }

        internal void ButtonClicks(MainForm mainForm, object sender)
        {
            MetroButton metroButton = (MetroButton)sender;
            switch (metroButton.Name)
            {
                case "mbtnConfigure":
                    UpdateStatus($"Configure application");
                    new ConfigForm().ShowDialog();
                    LoadCamAddress(mainForm.mcbCamAddress, true);
                    mainForm.mbtnStartStop.Enabled = mainForm.mcbCamAddress.SelectedIndex != -1;
                    break;

                case "mbtnAbout":
                    MetroMessageBox.Show(mainForm, "Developed by: Lakhya Jyoti Nath (ljnath)\nEmail: ljnath@ljnath.com\nWebsite: https://ljnath.com", $"{Constants.AppName} {Constants.AppVersion}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NetworkHandler.OpenHomePage();
                    break;

                case "mbtnStartStop":
                    if (metroButton.Text == "&Start")
                    {
                        UpdateStatus("Starting cam viewer");
                        string camAddress = GetCamAddress(mainForm.mcbCamAddress.SelectedItem.ToString().Trim());
                        CamConfig camConfig = ConfigHandler.Instance.FindCamConfig(camAddress);
                        if (camConfig == null || camConfig.ImageSize.Width == 0)
                        {
                            MetroMessageBox.Show(mainForm, "Failed to evaluate cam address from selected cam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        CreatePictureBoxes(mainForm, camConfig);
                        CamHandler.Instance.StartViewer(camConfig, ConfigHandler.Instance.Config.AutoSaveImage, ConfigHandler.Instance.Config.AutoSaveImageDirectory);
                        ConfigHandler.Instance.Save();

                        metroButton.Text = "&Stop";
                    }
                    else if (metroButton.Text == "&Stop")
                    {
                        CamHandler.Instance.StopViewer();
                        mainForm.flpViewer.Controls.Clear();
                        metroButton.Text = "&Start";
                    }
                    break;

                case "mbtnExit":
                    CamHandler.Instance.StopViewer();
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
                    MessageBoxIcon messageBoxIcon = MessageBoxIcon.Information;
                    string message = "Save successful.\nFor theme and style change to take effect, please restart the application.";

                    if (configForm.mtcConfig.SelectedIndex == 1)
                    {
                        CamConfig camConfig = configForm.mtglEdit.CheckState == CheckState.Checked ? ConfigHandler.Instance.FindCamById(configForm.mcbCamId.Text.Trim()) : new CamConfig();

                        camConfig.Name = configForm.mtbCamName.Text.Trim();
                        camConfig.Address = configForm.mtbCamAddress.Text.Trim();
                        camConfig.TotalChannel = Convert.ToInt32(configForm.mcbTotalChannel.SelectedItem) != 0 ? Convert.ToByte(configForm.mcbTotalChannel.SelectedItem) : 1;
                        camConfig.FPS = Convert.ToInt32(configForm.mcbFps.SelectedItem) != 0 ? Convert.ToInt32(configForm.mcbFps.SelectedItem) : 1;
                        camConfig.ImageZoom = Convert.ToInt32(configForm.mcbZoom.SelectedItem) != 0 ? Convert.ToInt32(configForm.mcbZoom.SelectedItem) : 100;

                        if (!camConfig.IsValid())
                        {
                            message = "Cam config cannot be save as either Name or Address is empty.";
                            messageBoxIcon = MessageBoxIcon.Warning;
                        }
                        else if (configForm.mtglEdit.CheckState == CheckState.Unchecked)
                        {
                            ConfigHandler.Instance.AddCamConfig(camConfig);
                            message = "Successfuly saved new cam.";
                        }
                        else if (configForm.mtglEdit.CheckState == CheckState.Checked)
                        {
                            ConfigHandler.Instance.UpdateCamConfig(camConfig);
                            message = "Successfuly updated existing cam config.";
                        }
                    }
                    else if (configForm.mtcConfig.SelectedIndex == 0)
                    {
                        ConfigHandler.Instance.Config.AutoSaveImage = configForm.mtglAutoSave.Checked;
                        ConfigHandler.Instance.Config.AutoSaveImageDirectory = configForm.mtbAutoSavePath.Text.Trim();
                        ConfigHandler.Instance.Config.TimeoutInSecond = Convert.ToInt32(configForm.mcbTimeout.SelectedItem) != 0 ? Convert.ToInt32(configForm.mcbTimeout.SelectedItem) : 10;
                        ConfigHandler.Instance.Config.AppTheme = GetMetroThemeStyleFromSelection(configForm.mcbTheme.SelectedItem.ToString());
                        ConfigHandler.Instance.Config.AppStyle = GetMetroColorStyleFromSelection(configForm.mcbStyle.SelectedItem.ToString());
                    }

                    MetroMessageBox.Show(configForm, message, String.Empty, MessageBoxButtons.OK, messageBoxIcon);
                    ConfigHandler.Instance.Save();

                    // close the form only in case of success message
                    if (messageBoxIcon == MessageBoxIcon.Information)
                        configForm.Close();
                    break;

                case "mbtnDelete":
                    if (configForm.mcbCamId.SelectedIndex == -1)
                        return;

                    string camId = configForm.mcbCamId.Text.Trim();
                    ConfigHandler.Instance.DeleteCamConfig(camId);
                    MetroMessageBox.Show(configForm, $"Successfuly removed remote cam config with ID {camId}", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCamIds(configForm.mcbCamId);
                    ResetCamConfigForm(configForm);
                    UpdateStatus("Removed existing cam");
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
                case "mtglEdit":
                    configForm.mlbCamId.Enabled = configForm.mcbCamId.Enabled = configForm.mbtnDelete.Enabled = configForm.mtglEdit.Checked;
                    FormHandler.Instance.ResetCamConfigForm(configForm);
                    break;

                case "mtglAutoSave":
                    configForm.mlbAutoSavePath.Enabled = configForm.mtbAutoSavePath.Enabled = configForm.mbtnAutoSavePath.Enabled = configForm.mtglAutoSave.Checked;
                    break;

            }
        }

        internal void ReloadCamConfig(ConfigForm configForm)
        {
            string camId = configForm.mcbCamId.Text.Trim();
            CamConfig camConfig = ConfigHandler.Instance.FindCamById(camId);
            if (camConfig != null)
            {
                configForm.mtbCamName.Text = camConfig.Name;
                configForm.mtbCamAddress.Text = camConfig.Address;
                configForm.mcbTotalChannel.Text = camConfig.TotalChannel.ToString();
                configForm.mcbFps.Text = camConfig.FPS.ToString();
                configForm.mcbZoom.Text = camConfig.ImageZoom.ToString();
            }
        }

        internal void ResetCamConfigForm(ConfigForm configForm)
        {
            configForm.mcbTotalChannel.Items.Clear();
            configForm.mcbTotalChannel.Items.AddRange(Enumerable.Range(1, Constants.MaxChannel).Cast<object>().ToArray());

            configForm.mcbFps.Items.Clear();
            configForm.mcbFps.Items.AddRange(Enumerable.Range(1, Constants.MaxFps).Cast<object>().ToArray());

            configForm.mcbZoom.Items.Clear();
            configForm.mcbZoom.Items.AddRange(Enumerable.Range(1, Constants.MaxZoom).Cast<object>().ToArray());

            configForm.mcbTimeout.Items.Clear();
            configForm.mcbTimeout.Items.AddRange(Enumerable.Range(5, Constants.MaxTimeout).Cast<object>().ToArray());

            configForm.mtbCamName.Text = configForm.mtbCamAddress.Text = configForm.mcbTotalChannel.Text = configForm.mcbFps.Text = configForm.mcbZoom.Text = string.Empty;
            configForm.mtbAutoSavePath.Text = configForm.mcbTimeout.Text = string.Empty;
            LoadCamIds(configForm.mcbCamId);
        }

        private void CreatePictureBoxes(MainForm mainForm, CamConfig remoteCamConfig)
        {
            RuntimeConfig.Instance.ViewerPictureBox = new List<PictureBox>();

            int pictureBoxWidth = Convert.ToInt32(remoteCamConfig.ImageSize.Width * remoteCamConfig.ImageZoom / 100);
            int pictureBoxHeight = Convert.ToInt32(remoteCamConfig.ImageSize.Height * remoteCamConfig.ImageZoom / 100);

            for (int i = 0; i < remoteCamConfig.TotalChannel; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Name = $"pictureBox{i}",
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.None
                };
                mainForm.flpViewer.Controls.Add(pictureBox);
                RuntimeConfig.Instance.ViewerPictureBox.Add(pictureBox);
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
            catch
            {
            }
        }

        internal void UpdateStatus(string statusMessage)
        {
            try
            {
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
            catch
            {
            }
        }

        private void InitializeAllMetroControls(MetroForm metroForm)
        {
            metroForm.Theme = ConfigHandler.Instance.Config.AppTheme;
            metroForm.Style = ConfigHandler.Instance.Config.AppStyle;

            foreach (MetroButton control in metroForm.FindAll(new Type[] { typeof(MetroButton) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppStyle;
                control.UseStyleColors = true;
                control.FontWeight = MetroButtonWeight.Bold;
            }

            foreach (MetroPanel control in metroForm.FindAll(new Type[] { typeof(MetroPanel) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppStyle;
                control.UseStyleColors = true;
            }

            foreach (MetroTextBox control in metroForm.FindAll(new Type[] { typeof(MetroTextBox) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppStyle;
                control.UseStyleColors = true;
                control.FontSize = MetroTextBoxSize.Medium;
                control.FontWeight = MetroTextBoxWeight.Bold;
            }

            foreach (MetroLabel control in metroForm.FindAll(new Type[] { typeof(MetroLabel) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppStyle;
                control.UseStyleColors = true;
                control.FontWeight = MetroLabelWeight.Regular;
            }

            foreach (MetroComboBox control in metroForm.FindAll(new Type[] { typeof(MetroComboBox) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppStyle;
                control.UseStyleColors = true;
                control.MaxDropDownItems = 5;
                control.FontWeight = MetroComboBoxWeight.Bold;
            }

            foreach (MetroToggle control in metroForm.FindAll(new Type[] { typeof(MetroToggle) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppStyle;
                control.UseStyleColors = true;
                control.FontWeight = MetroLinkWeight.Bold;
            }


            foreach (MetroTabControl control in metroForm.FindAll(new Type[] { typeof(MetroTabControl) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppStyle;
                control.UseStyleColors = true;
                control.FontWeight = MetroTabControlWeight.Regular;
            }

            foreach (MetroTabPage control in metroForm.FindAll(new Type[] { typeof(MetroTabPage) }))
            {
                control.Theme = ConfigHandler.Instance.Config.AppTheme;
                control.Style = ConfigHandler.Instance.Config.AppStyle;
                control.UseStyleColors = true;
            }
        }

        private void LoadCamAddress(MetroComboBox metroComboBox, bool includeAllDetails = false)
        {
            metroComboBox.Items.Clear();
            if (includeAllDetails)
            {
                ConfigHandler.Instance.Config.CamConfigs.ForEach(camConfig =>
                {
                    metroComboBox.Items.Add($"Name={camConfig.Name} | Total Channel={camConfig.TotalChannel} | FPS={camConfig.FPS} | Zoom={camConfig.ImageZoom} | Address={camConfig.Address}");
                });
            }
            else
            {
                ConfigHandler.Instance.Config.CamConfigs.ForEach(camConfig =>
                {
                    metroComboBox.Items.Add($"{camConfig.Name} | {camConfig.Address}");
                });
            }
            metroComboBox.Refresh();
        }

        private void LoadCamIds(MetroComboBox metroComboBox)
        {
            metroComboBox.Items.Clear();
            ConfigHandler.Instance.Config.CamConfigs.ForEach(camConfig =>
            {
                metroComboBox.Items.Add(camConfig.Id);
            });
            metroComboBox.Refresh();
        }

        private string GetCamAddress(string camAddressWithName)
        {
            string[] tokens = camAddressWithName.Split('|');
            string lastToken = tokens[tokens.Length - 1].Trim();
            return lastToken.Contains("=") ? lastToken.Split('=')[1].Trim() : lastToken;
        }

        private string BrowseForDirectory()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select directory to automatically save cam images",
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = ConfigHandler.Instance.Config.AutoSaveImageDirectory

            };
            return folderBrowserDialog.ShowDialog() == DialogResult.OK ? folderBrowserDialog.SelectedPath : String.Empty;
        }

        private MetroColorStyle GetMetroColorStyleFromSelection(string selectedItem)
        {
            foreach (MetroColorStyle metroColorStyle in Enum.GetValues(typeof(MetroColorStyle)))
                if (metroColorStyle.ToString().Equals(selectedItem))
                    return metroColorStyle;

            return Constants.DefaultStyle;
        }

        private MetroThemeStyle GetMetroThemeStyleFromSelection(string selectedItem)
        {
            foreach (MetroThemeStyle metroThemeStyle in Enum.GetValues(typeof(MetroThemeStyle)))
                if (metroThemeStyle.ToString().Equals(selectedItem))
                    return metroThemeStyle;

            return Constants.DefaultTheme;
        }

    }
}
