
namespace RemoteCamViewer.Forms
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.mpnlCameraConfig = new MetroFramework.Controls.MetroPanel();
            this.mlbCamUrl = new MetroFramework.Controls.MetroLabel();
            this.mbtnDelete = new MetroFramework.Controls.MetroButton();
            this.mcbCamType = new MetroFramework.Controls.MetroComboBox();
            this.mlbCamType = new MetroFramework.Controls.MetroLabel();
            this.mtbCamName = new MetroFramework.Controls.MetroTextBox();
            this.mlbCamName = new MetroFramework.Controls.MetroLabel();
            this.mcbZoomPercent = new MetroFramework.Controls.MetroComboBox();
            this.mlbZoomPercent = new MetroFramework.Controls.MetroLabel();
            this.mcbFps = new MetroFramework.Controls.MetroComboBox();
            this.mlbFps = new MetroFramework.Controls.MetroLabel();
            this.mtbCamNetworkAddress = new MetroFramework.Controls.MetroTextBox();
            this.mcbTotalChannel = new MetroFramework.Controls.MetroComboBox();
            this.mlbTotalChannel = new MetroFramework.Controls.MetroLabel();
            this.mlbCamNetworkAddress = new MetroFramework.Controls.MetroLabel();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mtcConfig = new MetroFramework.Controls.MetroTabControl();
            this.mtcTpAppConfig = new MetroFramework.Controls.MetroTabPage();
            this.mpnlAppConfig = new MetroFramework.Controls.MetroPanel();
            this.mcbColor = new MetroFramework.Controls.MetroComboBox();
            this.mlbColor = new MetroFramework.Controls.MetroLabel();
            this.mcbTheme = new MetroFramework.Controls.MetroComboBox();
            this.mlbTheme = new MetroFramework.Controls.MetroLabel();
            this.mcbNetworkTimeout = new MetroFramework.Controls.MetroComboBox();
            this.mlbNetworkTimeout = new MetroFramework.Controls.MetroLabel();
            this.mtcTpCameraConfig = new MetroFramework.Controls.MetroTabPage();
            this.mtcTpImageVideo = new MetroFramework.Controls.MetroTabPage();
            this.mpnlImageVideo = new MetroFramework.Controls.MetroPanel();
            this.mlbAutoDeleteSourceImage = new MetroFramework.Controls.MetroLabel();
            this.mtglAutoDeleteSourceImage = new MetroFramework.Controls.MetroToggle();
            this.mlbAutoExportVideo = new MetroFramework.Controls.MetroLabel();
            this.mtglAutoExportVideo = new MetroFramework.Controls.MetroToggle();
            this.mbtnAutoSavePath = new MetroFramework.Controls.MetroButton();
            this.mlbAutoSaveImage = new MetroFramework.Controls.MetroLabel();
            this.mtglAutoSaveImage = new MetroFramework.Controls.MetroToggle();
            this.mtbAutoSavePath = new MetroFramework.Controls.MetroTextBox();
            this.mlbAutoSavePath = new MetroFramework.Controls.MetroLabel();
            this.mcbOutputVideoFps = new MetroFramework.Controls.MetroComboBox();
            this.mlbOutputVideoFps = new MetroFramework.Controls.MetroLabel();
            this.mpnlPrimary = new MetroFramework.Controls.MetroPanel();
            this.mpnlSecondary = new MetroFramework.Controls.MetroPanel();
            this.mpnlCameraConfig.SuspendLayout();
            this.mtcConfig.SuspendLayout();
            this.mtcTpAppConfig.SuspendLayout();
            this.mpnlAppConfig.SuspendLayout();
            this.mtcTpCameraConfig.SuspendLayout();
            this.mtcTpImageVideo.SuspendLayout();
            this.mpnlImageVideo.SuspendLayout();
            this.mpnlPrimary.SuspendLayout();
            this.mpnlSecondary.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpnlCameraConfig
            // 
            this.mpnlCameraConfig.Controls.Add(this.mlbCamUrl);
            this.mpnlCameraConfig.Controls.Add(this.mbtnDelete);
            this.mpnlCameraConfig.Controls.Add(this.mcbCamType);
            this.mpnlCameraConfig.Controls.Add(this.mlbCamType);
            this.mpnlCameraConfig.Controls.Add(this.mtbCamName);
            this.mpnlCameraConfig.Controls.Add(this.mlbCamName);
            this.mpnlCameraConfig.Controls.Add(this.mcbZoomPercent);
            this.mpnlCameraConfig.Controls.Add(this.mlbZoomPercent);
            this.mpnlCameraConfig.Controls.Add(this.mcbFps);
            this.mpnlCameraConfig.Controls.Add(this.mlbFps);
            this.mpnlCameraConfig.Controls.Add(this.mtbCamNetworkAddress);
            this.mpnlCameraConfig.Controls.Add(this.mcbTotalChannel);
            this.mpnlCameraConfig.Controls.Add(this.mlbTotalChannel);
            this.mpnlCameraConfig.Controls.Add(this.mlbCamNetworkAddress);
            this.mpnlCameraConfig.HorizontalScrollbarBarColor = true;
            this.mpnlCameraConfig.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlCameraConfig.HorizontalScrollbarSize = 10;
            this.mpnlCameraConfig.Location = new System.Drawing.Point(2, 2);
            this.mpnlCameraConfig.Name = "mpnlCameraConfig";
            this.mpnlCameraConfig.Size = new System.Drawing.Size(536, 291);
            this.mpnlCameraConfig.TabIndex = 0;
            this.mpnlCameraConfig.VerticalScrollbarBarColor = true;
            this.mpnlCameraConfig.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlCameraConfig.VerticalScrollbarSize = 10;
            // 
            // mlbCamUrl
            // 
            this.mlbCamUrl.AutoSize = true;
            this.mlbCamUrl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlbCamUrl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbCamUrl.Location = new System.Drawing.Point(7, 228);
            this.mlbCamUrl.Name = "mlbCamUrl";
            this.mlbCamUrl.Size = new System.Drawing.Size(422, 15);
            this.mlbCamUrl.TabIndex = 21;
            this.mlbCamUrl.Text = "URL format : http://87.224.226.103/webcapture.jpg?command=snap&channel=1";
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Location = new System.Drawing.Point(454, 259);
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.Size = new System.Drawing.Size(75, 29);
            this.mbtnDelete.TabIndex = 7;
            this.mbtnDelete.Text = "metroButton3";
            this.mbtnDelete.UseSelectable = true;
            this.mbtnDelete.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mcbCamType
            // 
            this.mcbCamType.FormattingEnabled = true;
            this.mcbCamType.ItemHeight = 23;
            this.mcbCamType.Location = new System.Drawing.Point(135, 12);
            this.mcbCamType.MaxDropDownItems = 2;
            this.mcbCamType.Name = "mcbCamType";
            this.mcbCamType.Size = new System.Drawing.Size(394, 29);
            this.mcbCamType.TabIndex = 1;
            this.mcbCamType.UseSelectable = true;
            this.mcbCamType.SelectionChangeCommitted += new System.EventHandler(this.AllComboBoxSelectionChangeCommitted);
            // 
            // mlbCamType
            // 
            this.mlbCamType.AutoSize = true;
            this.mlbCamType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbCamType.Location = new System.Drawing.Point(85, 16);
            this.mlbCamType.Name = "mlbCamType";
            this.mlbCamType.Size = new System.Drawing.Size(44, 19);
            this.mlbCamType.TabIndex = 16;
            this.mlbCamType.Text = "Type :";
            // 
            // mtbCamName
            // 
            // 
            // 
            // 
            this.mtbCamName.CustomButton.Image = null;
            this.mtbCamName.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.mtbCamName.CustomButton.Name = "";
            this.mtbCamName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtbCamName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCamName.CustomButton.TabIndex = 1;
            this.mtbCamName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCamName.CustomButton.UseSelectable = true;
            this.mtbCamName.CustomButton.Visible = false;
            this.mtbCamName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbCamName.Lines = new string[] {
        "metroTextBox1"};
            this.mtbCamName.Location = new System.Drawing.Point(135, 47);
            this.mtbCamName.MaxLength = 32767;
            this.mtbCamName.Name = "mtbCamName";
            this.mtbCamName.PasswordChar = '\0';
            this.mtbCamName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCamName.SelectedText = "";
            this.mtbCamName.SelectionLength = 0;
            this.mtbCamName.SelectionStart = 0;
            this.mtbCamName.ShortcutsEnabled = true;
            this.mtbCamName.Size = new System.Drawing.Size(394, 29);
            this.mtbCamName.TabIndex = 2;
            this.mtbCamName.Text = "metroTextBox1";
            this.mtbCamName.UseSelectable = true;
            this.mtbCamName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCamName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbCamName
            // 
            this.mlbCamName.AutoSize = true;
            this.mlbCamName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbCamName.Location = new System.Drawing.Point(77, 52);
            this.mlbCamName.Name = "mlbCamName";
            this.mlbCamName.Size = new System.Drawing.Size(52, 19);
            this.mlbCamName.TabIndex = 14;
            this.mlbCamName.Text = "Name :";
            // 
            // mcbZoomPercent
            // 
            this.mcbZoomPercent.FormattingEnabled = true;
            this.mcbZoomPercent.ItemHeight = 23;
            this.mcbZoomPercent.Location = new System.Drawing.Point(135, 187);
            this.mcbZoomPercent.MaxDropDownItems = 6;
            this.mcbZoomPercent.Name = "mcbZoomPercent";
            this.mcbZoomPercent.Size = new System.Drawing.Size(394, 29);
            this.mcbZoomPercent.TabIndex = 6;
            this.mcbZoomPercent.UseSelectable = true;
            // 
            // mlbZoomPercent
            // 
            this.mlbZoomPercent.AutoSize = true;
            this.mlbZoomPercent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbZoomPercent.Location = new System.Drawing.Point(28, 191);
            this.mlbZoomPercent.Name = "mlbZoomPercent";
            this.mlbZoomPercent.Size = new System.Drawing.Size(101, 19);
            this.mlbZoomPercent.TabIndex = 9;
            this.mlbZoomPercent.Text = "Zoom Percent :";
            // 
            // mcbFps
            // 
            this.mcbFps.FormattingEnabled = true;
            this.mcbFps.ItemHeight = 23;
            this.mcbFps.Location = new System.Drawing.Point(135, 152);
            this.mcbFps.MaxDropDownItems = 5;
            this.mcbFps.Name = "mcbFps";
            this.mcbFps.Size = new System.Drawing.Size(394, 29);
            this.mcbFps.TabIndex = 5;
            this.mcbFps.UseSelectable = true;
            // 
            // mlbFps
            // 
            this.mlbFps.AutoSize = true;
            this.mlbFps.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbFps.Location = new System.Drawing.Point(91, 156);
            this.mlbFps.Name = "mlbFps";
            this.mlbFps.Size = new System.Drawing.Size(38, 19);
            this.mlbFps.TabIndex = 7;
            this.mlbFps.Text = "FPS :";
            // 
            // mtbCamNetworkAddress
            // 
            // 
            // 
            // 
            this.mtbCamNetworkAddress.CustomButton.Image = null;
            this.mtbCamNetworkAddress.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.mtbCamNetworkAddress.CustomButton.Name = "";
            this.mtbCamNetworkAddress.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtbCamNetworkAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCamNetworkAddress.CustomButton.TabIndex = 1;
            this.mtbCamNetworkAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCamNetworkAddress.CustomButton.UseSelectable = true;
            this.mtbCamNetworkAddress.CustomButton.Visible = false;
            this.mtbCamNetworkAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbCamNetworkAddress.Lines = new string[] {
        "metroTextBox1"};
            this.mtbCamNetworkAddress.Location = new System.Drawing.Point(135, 82);
            this.mtbCamNetworkAddress.MaxLength = 32767;
            this.mtbCamNetworkAddress.Name = "mtbCamNetworkAddress";
            this.mtbCamNetworkAddress.PasswordChar = '\0';
            this.mtbCamNetworkAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCamNetworkAddress.SelectedText = "";
            this.mtbCamNetworkAddress.SelectionLength = 0;
            this.mtbCamNetworkAddress.SelectionStart = 0;
            this.mtbCamNetworkAddress.ShortcutsEnabled = true;
            this.mtbCamNetworkAddress.Size = new System.Drawing.Size(394, 29);
            this.mtbCamNetworkAddress.TabIndex = 3;
            this.mtbCamNetworkAddress.Text = "metroTextBox1";
            this.mtbCamNetworkAddress.UseSelectable = true;
            this.mtbCamNetworkAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCamNetworkAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mcbTotalChannel
            // 
            this.mcbTotalChannel.FormattingEnabled = true;
            this.mcbTotalChannel.ItemHeight = 23;
            this.mcbTotalChannel.Location = new System.Drawing.Point(135, 117);
            this.mcbTotalChannel.MaxDropDownItems = 4;
            this.mcbTotalChannel.Name = "mcbTotalChannel";
            this.mcbTotalChannel.Size = new System.Drawing.Size(394, 29);
            this.mcbTotalChannel.TabIndex = 4;
            this.mcbTotalChannel.UseSelectable = true;
            // 
            // mlbTotalChannel
            // 
            this.mlbTotalChannel.AutoSize = true;
            this.mlbTotalChannel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbTotalChannel.Location = new System.Drawing.Point(24, 121);
            this.mlbTotalChannel.Name = "mlbTotalChannel";
            this.mlbTotalChannel.Size = new System.Drawing.Size(105, 19);
            this.mlbTotalChannel.TabIndex = 4;
            this.mlbTotalChannel.Text = "Total Channels :";
            // 
            // mlbCamNetworkAddress
            // 
            this.mlbCamNetworkAddress.AutoSize = true;
            this.mlbCamNetworkAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbCamNetworkAddress.Location = new System.Drawing.Point(8, 87);
            this.mlbCamNetworkAddress.Name = "mlbCamNetworkAddress";
            this.mlbCamNetworkAddress.Size = new System.Drawing.Size(121, 19);
            this.mlbCamNetworkAddress.TabIndex = 2;
            this.mlbCamNetworkAddress.Text = "Network Address :";
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(379, 346);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 29);
            this.mbtnSave.Style = MetroFramework.MetroColorStyle.Black;
            this.mbtnSave.TabIndex = 2;
            this.mbtnSave.Text = "metroButton3";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(460, 346);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 29);
            this.mbtnCancel.TabIndex = 3;
            this.mbtnCancel.Text = "metroButton2";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mtcConfig
            // 
            this.mtcConfig.Controls.Add(this.mtcTpAppConfig);
            this.mtcConfig.Controls.Add(this.mtcTpCameraConfig);
            this.mtcConfig.Controls.Add(this.mtcTpImageVideo);
            this.mtcConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcConfig.Location = new System.Drawing.Point(0, 0);
            this.mtcConfig.Name = "mtcConfig";
            this.mtcConfig.SelectedIndex = 1;
            this.mtcConfig.Size = new System.Drawing.Size(549, 342);
            this.mtcConfig.TabIndex = 1;
            this.mtcConfig.UseSelectable = true;
            // 
            // mtcTpAppConfig
            // 
            this.mtcTpAppConfig.Controls.Add(this.mpnlAppConfig);
            this.mtcTpAppConfig.HorizontalScrollbarBarColor = true;
            this.mtcTpAppConfig.HorizontalScrollbarHighlightOnWheel = false;
            this.mtcTpAppConfig.HorizontalScrollbarSize = 10;
            this.mtcTpAppConfig.Location = new System.Drawing.Point(4, 38);
            this.mtcTpAppConfig.Name = "mtcTpAppConfig";
            this.mtcTpAppConfig.Size = new System.Drawing.Size(541, 300);
            this.mtcTpAppConfig.TabIndex = 0;
            this.mtcTpAppConfig.Text = "metroTabPage1";
            this.mtcTpAppConfig.VerticalScrollbarBarColor = true;
            this.mtcTpAppConfig.VerticalScrollbarHighlightOnWheel = false;
            this.mtcTpAppConfig.VerticalScrollbarSize = 10;
            // 
            // mpnlAppConfig
            // 
            this.mpnlAppConfig.Controls.Add(this.mcbColor);
            this.mpnlAppConfig.Controls.Add(this.mlbColor);
            this.mpnlAppConfig.Controls.Add(this.mcbTheme);
            this.mpnlAppConfig.Controls.Add(this.mlbTheme);
            this.mpnlAppConfig.Controls.Add(this.mcbNetworkTimeout);
            this.mpnlAppConfig.Controls.Add(this.mlbNetworkTimeout);
            this.mpnlAppConfig.HorizontalScrollbarBarColor = true;
            this.mpnlAppConfig.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlAppConfig.HorizontalScrollbarSize = 10;
            this.mpnlAppConfig.Location = new System.Drawing.Point(2, 2);
            this.mpnlAppConfig.Name = "mpnlAppConfig";
            this.mpnlAppConfig.Size = new System.Drawing.Size(536, 291);
            this.mpnlAppConfig.TabIndex = 2;
            this.mpnlAppConfig.VerticalScrollbarBarColor = true;
            this.mpnlAppConfig.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlAppConfig.VerticalScrollbarSize = 10;
            // 
            // mcbColor
            // 
            this.mcbColor.FormattingEnabled = true;
            this.mcbColor.ItemHeight = 23;
            this.mcbColor.Location = new System.Drawing.Point(135, 47);
            this.mcbColor.MaxDropDownItems = 2;
            this.mcbColor.Name = "mcbColor";
            this.mcbColor.Size = new System.Drawing.Size(394, 29);
            this.mcbColor.TabIndex = 1;
            this.mcbColor.UseSelectable = true;
            // 
            // mlbColor
            // 
            this.mlbColor.AutoSize = true;
            this.mlbColor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbColor.Location = new System.Drawing.Point(80, 51);
            this.mlbColor.Name = "mlbColor";
            this.mlbColor.Size = new System.Drawing.Size(49, 19);
            this.mlbColor.TabIndex = 28;
            this.mlbColor.Text = "Color :";
            // 
            // mcbTheme
            // 
            this.mcbTheme.FormattingEnabled = true;
            this.mcbTheme.ItemHeight = 23;
            this.mcbTheme.Location = new System.Drawing.Point(135, 12);
            this.mcbTheme.MaxDropDownItems = 2;
            this.mcbTheme.Name = "mcbTheme";
            this.mcbTheme.Size = new System.Drawing.Size(394, 29);
            this.mcbTheme.TabIndex = 0;
            this.mcbTheme.UseSelectable = true;
            // 
            // mlbTheme
            // 
            this.mlbTheme.AutoSize = true;
            this.mlbTheme.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbTheme.Location = new System.Drawing.Point(72, 16);
            this.mlbTheme.Name = "mlbTheme";
            this.mlbTheme.Size = new System.Drawing.Size(57, 19);
            this.mlbTheme.TabIndex = 26;
            this.mlbTheme.Text = "Theme :";
            // 
            // mcbNetworkTimeout
            // 
            this.mcbNetworkTimeout.FormattingEnabled = true;
            this.mcbNetworkTimeout.ItemHeight = 23;
            this.mcbNetworkTimeout.Location = new System.Drawing.Point(135, 82);
            this.mcbNetworkTimeout.MaxDropDownItems = 2;
            this.mcbNetworkTimeout.Name = "mcbNetworkTimeout";
            this.mcbNetworkTimeout.Size = new System.Drawing.Size(394, 29);
            this.mcbNetworkTimeout.TabIndex = 2;
            this.mcbNetworkTimeout.UseSelectable = true;
            // 
            // mlbNetworkTimeout
            // 
            this.mlbNetworkTimeout.AutoSize = true;
            this.mlbNetworkTimeout.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbNetworkTimeout.Location = new System.Drawing.Point(7, 86);
            this.mlbNetworkTimeout.Name = "mlbNetworkTimeout";
            this.mlbNetworkTimeout.Size = new System.Drawing.Size(122, 19);
            this.mlbNetworkTimeout.TabIndex = 23;
            this.mlbNetworkTimeout.Text = "Network Timeout :";
            // 
            // mtcTpCameraConfig
            // 
            this.mtcTpCameraConfig.Controls.Add(this.mpnlCameraConfig);
            this.mtcTpCameraConfig.HorizontalScrollbarBarColor = true;
            this.mtcTpCameraConfig.HorizontalScrollbarHighlightOnWheel = false;
            this.mtcTpCameraConfig.HorizontalScrollbarSize = 10;
            this.mtcTpCameraConfig.Location = new System.Drawing.Point(4, 38);
            this.mtcTpCameraConfig.Name = "mtcTpCameraConfig";
            this.mtcTpCameraConfig.Size = new System.Drawing.Size(541, 300);
            this.mtcTpCameraConfig.TabIndex = 1;
            this.mtcTpCameraConfig.Text = "metroTabPage2";
            this.mtcTpCameraConfig.VerticalScrollbarBarColor = true;
            this.mtcTpCameraConfig.VerticalScrollbarHighlightOnWheel = false;
            this.mtcTpCameraConfig.VerticalScrollbarSize = 10;
            // 
            // mtcTpImageVideo
            // 
            this.mtcTpImageVideo.Controls.Add(this.mpnlImageVideo);
            this.mtcTpImageVideo.HorizontalScrollbarBarColor = true;
            this.mtcTpImageVideo.HorizontalScrollbarHighlightOnWheel = false;
            this.mtcTpImageVideo.HorizontalScrollbarSize = 10;
            this.mtcTpImageVideo.Location = new System.Drawing.Point(4, 38);
            this.mtcTpImageVideo.Name = "mtcTpImageVideo";
            this.mtcTpImageVideo.Size = new System.Drawing.Size(541, 300);
            this.mtcTpImageVideo.TabIndex = 2;
            this.mtcTpImageVideo.Text = "metroTabPage1";
            this.mtcTpImageVideo.VerticalScrollbarBarColor = true;
            this.mtcTpImageVideo.VerticalScrollbarHighlightOnWheel = false;
            this.mtcTpImageVideo.VerticalScrollbarSize = 10;
            // 
            // mpnlImageVideo
            // 
            this.mpnlImageVideo.Controls.Add(this.mlbAutoDeleteSourceImage);
            this.mpnlImageVideo.Controls.Add(this.mtglAutoDeleteSourceImage);
            this.mpnlImageVideo.Controls.Add(this.mlbAutoExportVideo);
            this.mpnlImageVideo.Controls.Add(this.mtglAutoExportVideo);
            this.mpnlImageVideo.Controls.Add(this.mbtnAutoSavePath);
            this.mpnlImageVideo.Controls.Add(this.mlbAutoSaveImage);
            this.mpnlImageVideo.Controls.Add(this.mtglAutoSaveImage);
            this.mpnlImageVideo.Controls.Add(this.mtbAutoSavePath);
            this.mpnlImageVideo.Controls.Add(this.mlbAutoSavePath);
            this.mpnlImageVideo.Controls.Add(this.mcbOutputVideoFps);
            this.mpnlImageVideo.Controls.Add(this.mlbOutputVideoFps);
            this.mpnlImageVideo.HorizontalScrollbarBarColor = true;
            this.mpnlImageVideo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlImageVideo.HorizontalScrollbarSize = 10;
            this.mpnlImageVideo.Location = new System.Drawing.Point(1, 3);
            this.mpnlImageVideo.Name = "mpnlImageVideo";
            this.mpnlImageVideo.Size = new System.Drawing.Size(538, 294);
            this.mpnlImageVideo.TabIndex = 3;
            this.mpnlImageVideo.VerticalScrollbarBarColor = true;
            this.mpnlImageVideo.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlImageVideo.VerticalScrollbarSize = 10;
            // 
            // mlbAutoDeleteSourceImage
            // 
            this.mlbAutoDeleteSourceImage.AutoSize = true;
            this.mlbAutoDeleteSourceImage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbAutoDeleteSourceImage.Location = new System.Drawing.Point(19, 72);
            this.mlbAutoDeleteSourceImage.Name = "mlbAutoDeleteSourceImage";
            this.mlbAutoDeleteSourceImage.Size = new System.Drawing.Size(182, 19);
            this.mlbAutoDeleteSourceImage.TabIndex = 37;
            this.mlbAutoDeleteSourceImage.Text = "Auto Delete Source Images :";
            // 
            // mtglAutoDeleteSourceImage
            // 
            this.mtglAutoDeleteSourceImage.AutoSize = true;
            this.mtglAutoDeleteSourceImage.Location = new System.Drawing.Point(207, 75);
            this.mtglAutoDeleteSourceImage.Name = "mtglAutoDeleteSourceImage";
            this.mtglAutoDeleteSourceImage.Size = new System.Drawing.Size(80, 17);
            this.mtglAutoDeleteSourceImage.TabIndex = 2;
            this.mtglAutoDeleteSourceImage.Text = "Off";
            this.mtglAutoDeleteSourceImage.UseSelectable = true;
            // 
            // mlbAutoExportVideo
            // 
            this.mlbAutoExportVideo.AutoSize = true;
            this.mlbAutoExportVideo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbAutoExportVideo.Location = new System.Drawing.Point(73, 43);
            this.mlbAutoExportVideo.Name = "mlbAutoExportVideo";
            this.mlbAutoExportVideo.Size = new System.Drawing.Size(128, 19);
            this.mlbAutoExportVideo.TabIndex = 35;
            this.mlbAutoExportVideo.Text = "Auto Export Video :";
            // 
            // mtglAutoExportVideo
            // 
            this.mtglAutoExportVideo.AutoSize = true;
            this.mtglAutoExportVideo.Location = new System.Drawing.Point(207, 45);
            this.mtglAutoExportVideo.Name = "mtglAutoExportVideo";
            this.mtglAutoExportVideo.Size = new System.Drawing.Size(80, 17);
            this.mtglAutoExportVideo.TabIndex = 1;
            this.mtglAutoExportVideo.Text = "Off";
            this.mtglAutoExportVideo.UseSelectable = true;
            this.mtglAutoExportVideo.CheckStateChanged += new System.EventHandler(this.AllToggleCheckStateChanged);
            // 
            // mbtnAutoSavePath
            // 
            this.mbtnAutoSavePath.Location = new System.Drawing.Point(498, 105);
            this.mbtnAutoSavePath.Name = "mbtnAutoSavePath";
            this.mbtnAutoSavePath.Size = new System.Drawing.Size(34, 29);
            this.mbtnAutoSavePath.TabIndex = 4;
            this.mbtnAutoSavePath.Text = "metroButton3";
            this.mbtnAutoSavePath.UseSelectable = true;
            this.mbtnAutoSavePath.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mlbAutoSaveImage
            // 
            this.mlbAutoSaveImage.AutoSize = true;
            this.mlbAutoSaveImage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbAutoSaveImage.Location = new System.Drawing.Point(75, 14);
            this.mlbAutoSaveImage.Name = "mlbAutoSaveImage";
            this.mlbAutoSaveImage.Size = new System.Drawing.Size(126, 19);
            this.mlbAutoSaveImage.TabIndex = 33;
            this.mlbAutoSaveImage.Text = "Auto Save Images :";
            // 
            // mtglAutoSaveImage
            // 
            this.mtglAutoSaveImage.AutoSize = true;
            this.mtglAutoSaveImage.Location = new System.Drawing.Point(207, 15);
            this.mtglAutoSaveImage.Name = "mtglAutoSaveImage";
            this.mtglAutoSaveImage.Size = new System.Drawing.Size(80, 17);
            this.mtglAutoSaveImage.TabIndex = 0;
            this.mtglAutoSaveImage.Text = "Off";
            this.mtglAutoSaveImage.UseSelectable = true;
            this.mtglAutoSaveImage.CheckStateChanged += new System.EventHandler(this.AllToggleCheckStateChanged);
            // 
            // mtbAutoSavePath
            // 
            // 
            // 
            // 
            this.mtbAutoSavePath.CustomButton.Image = null;
            this.mtbAutoSavePath.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.mtbAutoSavePath.CustomButton.Name = "";
            this.mtbAutoSavePath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtbAutoSavePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbAutoSavePath.CustomButton.TabIndex = 1;
            this.mtbAutoSavePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbAutoSavePath.CustomButton.UseSelectable = true;
            this.mtbAutoSavePath.CustomButton.Visible = false;
            this.mtbAutoSavePath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbAutoSavePath.Lines = new string[] {
        "metroTextBox1"};
            this.mtbAutoSavePath.Location = new System.Drawing.Point(207, 105);
            this.mtbAutoSavePath.MaxLength = 32767;
            this.mtbAutoSavePath.Name = "mtbAutoSavePath";
            this.mtbAutoSavePath.PasswordChar = '\0';
            this.mtbAutoSavePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbAutoSavePath.SelectedText = "";
            this.mtbAutoSavePath.SelectionLength = 0;
            this.mtbAutoSavePath.SelectionStart = 0;
            this.mtbAutoSavePath.ShortcutsEnabled = true;
            this.mtbAutoSavePath.Size = new System.Drawing.Size(285, 29);
            this.mtbAutoSavePath.TabIndex = 3;
            this.mtbAutoSavePath.Text = "metroTextBox1";
            this.mtbAutoSavePath.UseSelectable = true;
            this.mtbAutoSavePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbAutoSavePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbAutoSavePath
            // 
            this.mlbAutoSavePath.AutoSize = true;
            this.mlbAutoSavePath.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbAutoSavePath.Location = new System.Drawing.Point(91, 109);
            this.mlbAutoSavePath.Name = "mlbAutoSavePath";
            this.mlbAutoSavePath.Size = new System.Drawing.Size(110, 19);
            this.mlbAutoSavePath.TabIndex = 32;
            this.mlbAutoSavePath.Text = "Auto Save Path :";
            // 
            // mcbOutputVideoFps
            // 
            this.mcbOutputVideoFps.FormattingEnabled = true;
            this.mcbOutputVideoFps.ItemHeight = 23;
            this.mcbOutputVideoFps.Location = new System.Drawing.Point(207, 140);
            this.mcbOutputVideoFps.MaxDropDownItems = 2;
            this.mcbOutputVideoFps.Name = "mcbOutputVideoFps";
            this.mcbOutputVideoFps.Size = new System.Drawing.Size(325, 29);
            this.mcbOutputVideoFps.TabIndex = 5;
            this.mcbOutputVideoFps.UseSelectable = true;
            // 
            // mlbOutputVideoFps
            // 
            this.mlbOutputVideoFps.AutoSize = true;
            this.mlbOutputVideoFps.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbOutputVideoFps.Location = new System.Drawing.Point(75, 145);
            this.mlbOutputVideoFps.Name = "mlbOutputVideoFps";
            this.mlbOutputVideoFps.Size = new System.Drawing.Size(126, 19);
            this.mlbOutputVideoFps.TabIndex = 26;
            this.mlbOutputVideoFps.Text = "Output Video FPS :";
            // 
            // mpnlPrimary
            // 
            this.mpnlPrimary.Controls.Add(this.mpnlSecondary);
            this.mpnlPrimary.Controls.Add(this.mbtnCancel);
            this.mpnlPrimary.Controls.Add(this.mbtnSave);
            this.mpnlPrimary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnlPrimary.HorizontalScrollbarBarColor = true;
            this.mpnlPrimary.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlPrimary.HorizontalScrollbarSize = 10;
            this.mpnlPrimary.Location = new System.Drawing.Point(20, 60);
            this.mpnlPrimary.Name = "mpnlPrimary";
            this.mpnlPrimary.Size = new System.Drawing.Size(557, 387);
            this.mpnlPrimary.TabIndex = 21;
            this.mpnlPrimary.VerticalScrollbarBarColor = true;
            this.mpnlPrimary.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlPrimary.VerticalScrollbarSize = 10;
            // 
            // mpnlSecondary
            // 
            this.mpnlSecondary.Controls.Add(this.mtcConfig);
            this.mpnlSecondary.HorizontalScrollbarBarColor = true;
            this.mpnlSecondary.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlSecondary.HorizontalScrollbarSize = 10;
            this.mpnlSecondary.Location = new System.Drawing.Point(0, 3);
            this.mpnlSecondary.Name = "mpnlSecondary";
            this.mpnlSecondary.Size = new System.Drawing.Size(549, 342);
            this.mpnlSecondary.TabIndex = 21;
            this.mpnlSecondary.VerticalScrollbarBarColor = true;
            this.mpnlSecondary.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlSecondary.VerticalScrollbarSize = 10;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 467);
            this.Controls.Add(this.mpnlPrimary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.mpnlCameraConfig.ResumeLayout(false);
            this.mpnlCameraConfig.PerformLayout();
            this.mtcConfig.ResumeLayout(false);
            this.mtcTpAppConfig.ResumeLayout(false);
            this.mpnlAppConfig.ResumeLayout(false);
            this.mpnlAppConfig.PerformLayout();
            this.mtcTpCameraConfig.ResumeLayout(false);
            this.mtcTpImageVideo.ResumeLayout(false);
            this.mpnlImageVideo.ResumeLayout(false);
            this.mpnlImageVideo.PerformLayout();
            this.mpnlPrimary.ResumeLayout(false);
            this.mpnlSecondary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroPanel mpnlCameraConfig;
        internal MetroFramework.Controls.MetroButton mbtnCancel;
        internal MetroFramework.Controls.MetroComboBox mcbZoomPercent;
        internal MetroFramework.Controls.MetroLabel mlbZoomPercent;
        internal MetroFramework.Controls.MetroComboBox mcbFps;
        internal MetroFramework.Controls.MetroLabel mlbFps;
        internal MetroFramework.Controls.MetroTextBox mtbCamNetworkAddress;
        internal MetroFramework.Controls.MetroComboBox mcbTotalChannel;
        internal MetroFramework.Controls.MetroLabel mlbTotalChannel;
        internal MetroFramework.Controls.MetroLabel mlbCamNetworkAddress;
        internal MetroFramework.Controls.MetroButton mbtnSave;
        internal MetroFramework.Controls.MetroTextBox mtbCamName;
        internal MetroFramework.Controls.MetroLabel mlbCamName;
        internal MetroFramework.Controls.MetroComboBox mcbCamType;
        internal MetroFramework.Controls.MetroLabel mlbCamType;
        internal MetroFramework.Controls.MetroButton mbtnDelete;
        internal MetroFramework.Controls.MetroTabControl mtcConfig;
        internal MetroFramework.Controls.MetroTabPage mtcTpAppConfig;
        internal MetroFramework.Controls.MetroPanel mpnlAppConfig;
        internal MetroFramework.Controls.MetroTabPage mtcTpCameraConfig;
        internal MetroFramework.Controls.MetroPanel mpnlPrimary;
        internal MetroFramework.Controls.MetroComboBox mcbNetworkTimeout;
        internal MetroFramework.Controls.MetroLabel mlbNetworkTimeout;
        internal MetroFramework.Controls.MetroPanel mpnlSecondary;
        internal MetroFramework.Controls.MetroComboBox mcbColor;
        internal MetroFramework.Controls.MetroLabel mlbColor;
        internal MetroFramework.Controls.MetroComboBox mcbTheme;
        internal MetroFramework.Controls.MetroLabel mlbTheme;
        internal MetroFramework.Controls.MetroTabPage mtcTpImageVideo;
        internal MetroFramework.Controls.MetroPanel mpnlImageVideo;
        internal MetroFramework.Controls.MetroButton mbtnAutoSavePath;
        internal MetroFramework.Controls.MetroLabel mlbAutoSaveImage;
        internal MetroFramework.Controls.MetroToggle mtglAutoSaveImage;
        internal MetroFramework.Controls.MetroTextBox mtbAutoSavePath;
        internal MetroFramework.Controls.MetroLabel mlbAutoSavePath;
        internal MetroFramework.Controls.MetroComboBox mcbOutputVideoFps;
        internal MetroFramework.Controls.MetroLabel mlbOutputVideoFps;
        internal MetroFramework.Controls.MetroLabel mlbCamUrl;
        internal MetroFramework.Controls.MetroLabel mlbAutoExportVideo;
        internal MetroFramework.Controls.MetroToggle mtglAutoExportVideo;
        internal MetroFramework.Controls.MetroLabel mlbAutoDeleteSourceImage;
        internal MetroFramework.Controls.MetroToggle mtglAutoDeleteSourceImage;
    }
}