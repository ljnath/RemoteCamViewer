
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
            this.mpnlCam = new MetroFramework.Controls.MetroPanel();
            this.mbtnDelete = new MetroFramework.Controls.MetroButton();
            this.mlbEditMode = new MetroFramework.Controls.MetroLabel();
            this.mtglEdit = new MetroFramework.Controls.MetroToggle();
            this.mcbCamId = new MetroFramework.Controls.MetroComboBox();
            this.mlbCamId = new MetroFramework.Controls.MetroLabel();
            this.mtbCamName = new MetroFramework.Controls.MetroTextBox();
            this.mlbCamName = new MetroFramework.Controls.MetroLabel();
            this.mcbZoom = new MetroFramework.Controls.MetroComboBox();
            this.mlbZoom = new MetroFramework.Controls.MetroLabel();
            this.mcbFps = new MetroFramework.Controls.MetroComboBox();
            this.mlbFps = new MetroFramework.Controls.MetroLabel();
            this.mtbCamAddress = new MetroFramework.Controls.MetroTextBox();
            this.mcbTotalChannel = new MetroFramework.Controls.MetroComboBox();
            this.mlbTotalChannel = new MetroFramework.Controls.MetroLabel();
            this.mlbCamAddress = new MetroFramework.Controls.MetroLabel();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mtcConfig = new MetroFramework.Controls.MetroTabControl();
            this.mtcTpAppConfig = new MetroFramework.Controls.MetroTabPage();
            this.mpnlApp = new MetroFramework.Controls.MetroPanel();
            this.mcbStyle = new MetroFramework.Controls.MetroComboBox();
            this.mlbStyle = new MetroFramework.Controls.MetroLabel();
            this.mcbTheme = new MetroFramework.Controls.MetroComboBox();
            this.mlbTheme = new MetroFramework.Controls.MetroLabel();
            this.mbtnAutoSavePath = new MetroFramework.Controls.MetroButton();
            this.mlbAutoSave = new MetroFramework.Controls.MetroLabel();
            this.mtglAutoSave = new MetroFramework.Controls.MetroToggle();
            this.mcbTimeout = new MetroFramework.Controls.MetroComboBox();
            this.mlbTimeout = new MetroFramework.Controls.MetroLabel();
            this.mtbAutoSavePath = new MetroFramework.Controls.MetroTextBox();
            this.mlbAutoSavePath = new MetroFramework.Controls.MetroLabel();
            this.mtcTpCamConfig = new MetroFramework.Controls.MetroTabPage();
            this.mpnlPrimary = new MetroFramework.Controls.MetroPanel();
            this.mpnlSecondary = new MetroFramework.Controls.MetroPanel();
            this.mpnlCam.SuspendLayout();
            this.mtcConfig.SuspendLayout();
            this.mtcTpAppConfig.SuspendLayout();
            this.mpnlApp.SuspendLayout();
            this.mtcTpCamConfig.SuspendLayout();
            this.mpnlPrimary.SuspendLayout();
            this.mpnlSecondary.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpnlCam
            // 
            this.mpnlCam.Controls.Add(this.mbtnDelete);
            this.mpnlCam.Controls.Add(this.mlbEditMode);
            this.mpnlCam.Controls.Add(this.mtglEdit);
            this.mpnlCam.Controls.Add(this.mcbCamId);
            this.mpnlCam.Controls.Add(this.mlbCamId);
            this.mpnlCam.Controls.Add(this.mtbCamName);
            this.mpnlCam.Controls.Add(this.mlbCamName);
            this.mpnlCam.Controls.Add(this.mcbZoom);
            this.mpnlCam.Controls.Add(this.mlbZoom);
            this.mpnlCam.Controls.Add(this.mcbFps);
            this.mpnlCam.Controls.Add(this.mlbFps);
            this.mpnlCam.Controls.Add(this.mtbCamAddress);
            this.mpnlCam.Controls.Add(this.mcbTotalChannel);
            this.mpnlCam.Controls.Add(this.mlbTotalChannel);
            this.mpnlCam.Controls.Add(this.mlbCamAddress);
            this.mpnlCam.HorizontalScrollbarBarColor = true;
            this.mpnlCam.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlCam.HorizontalScrollbarSize = 10;
            this.mpnlCam.Location = new System.Drawing.Point(3, 6);
            this.mpnlCam.Name = "mpnlCam";
            this.mpnlCam.Size = new System.Drawing.Size(526, 291);
            this.mpnlCam.TabIndex = 0;
            this.mpnlCam.VerticalScrollbarBarColor = true;
            this.mpnlCam.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlCam.VerticalScrollbarSize = 10;
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Location = new System.Drawing.Point(433, 251);
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.Size = new System.Drawing.Size(75, 29);
            this.mbtnDelete.TabIndex = 19;
            this.mbtnDelete.Text = "metroButton3";
            this.mbtnDelete.UseSelectable = true;
            this.mbtnDelete.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mlbEditMode
            // 
            this.mlbEditMode.AutoSize = true;
            this.mlbEditMode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbEditMode.Location = new System.Drawing.Point(45, 11);
            this.mlbEditMode.Name = "mlbEditMode";
            this.mlbEditMode.Size = new System.Drawing.Size(79, 19);
            this.mlbEditMode.TabIndex = 18;
            this.mlbEditMode.Text = "Edit Mode :";
            // 
            // mtglEdit
            // 
            this.mtglEdit.AutoSize = true;
            this.mtglEdit.Location = new System.Drawing.Point(129, 11);
            this.mtglEdit.Name = "mtglEdit";
            this.mtglEdit.Size = new System.Drawing.Size(80, 17);
            this.mtglEdit.TabIndex = 0;
            this.mtglEdit.Text = "Off";
            this.mtglEdit.UseSelectable = true;
            this.mtglEdit.CheckStateChanged += new System.EventHandler(this.AllToggleCheckStateChanged);
            // 
            // mcbCamId
            // 
            this.mcbCamId.FormattingEnabled = true;
            this.mcbCamId.ItemHeight = 23;
            this.mcbCamId.Location = new System.Drawing.Point(129, 41);
            this.mcbCamId.MaxDropDownItems = 2;
            this.mcbCamId.Name = "mcbCamId";
            this.mcbCamId.Size = new System.Drawing.Size(378, 29);
            this.mcbCamId.TabIndex = 15;
            this.mcbCamId.UseSelectable = true;
            this.mcbCamId.SelectionChangeCommitted += new System.EventHandler(this.mcbCamId_SelectionChangeCommitted);
            // 
            // mlbCamId
            // 
            this.mlbCamId.AutoSize = true;
            this.mlbCamId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbCamId.Location = new System.Drawing.Point(94, 45);
            this.mlbCamId.Name = "mlbCamId";
            this.mlbCamId.Size = new System.Drawing.Size(30, 19);
            this.mlbCamId.TabIndex = 16;
            this.mlbCamId.Text = "ID :";
            // 
            // mtbCamName
            // 
            // 
            // 
            // 
            this.mtbCamName.CustomButton.Image = null;
            this.mtbCamName.CustomButton.Location = new System.Drawing.Point(350, 1);
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
            this.mtbCamName.Location = new System.Drawing.Point(129, 76);
            this.mtbCamName.MaxLength = 32767;
            this.mtbCamName.Name = "mtbCamName";
            this.mtbCamName.PasswordChar = '\0';
            this.mtbCamName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCamName.SelectedText = "";
            this.mtbCamName.SelectionLength = 0;
            this.mtbCamName.SelectionStart = 0;
            this.mtbCamName.ShortcutsEnabled = true;
            this.mtbCamName.Size = new System.Drawing.Size(378, 29);
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
            this.mlbCamName.Location = new System.Drawing.Point(72, 81);
            this.mlbCamName.Name = "mlbCamName";
            this.mlbCamName.Size = new System.Drawing.Size(52, 19);
            this.mlbCamName.TabIndex = 14;
            this.mlbCamName.Text = "Name :";
            // 
            // mcbZoom
            // 
            this.mcbZoom.FormattingEnabled = true;
            this.mcbZoom.ItemHeight = 23;
            this.mcbZoom.Location = new System.Drawing.Point(129, 216);
            this.mcbZoom.MaxDropDownItems = 6;
            this.mcbZoom.Name = "mcbZoom";
            this.mcbZoom.Size = new System.Drawing.Size(378, 29);
            this.mcbZoom.TabIndex = 4;
            this.mcbZoom.UseSelectable = true;
            // 
            // mlbZoom
            // 
            this.mlbZoom.AutoSize = true;
            this.mlbZoom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbZoom.Location = new System.Drawing.Point(72, 220);
            this.mlbZoom.Name = "mlbZoom";
            this.mlbZoom.Size = new System.Drawing.Size(52, 19);
            this.mlbZoom.TabIndex = 9;
            this.mlbZoom.Text = "Zoom :";
            // 
            // mcbFps
            // 
            this.mcbFps.FormattingEnabled = true;
            this.mcbFps.ItemHeight = 23;
            this.mcbFps.Location = new System.Drawing.Point(129, 181);
            this.mcbFps.MaxDropDownItems = 5;
            this.mcbFps.Name = "mcbFps";
            this.mcbFps.Size = new System.Drawing.Size(378, 29);
            this.mcbFps.TabIndex = 3;
            this.mcbFps.UseSelectable = true;
            // 
            // mlbFps
            // 
            this.mlbFps.AutoSize = true;
            this.mlbFps.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbFps.Location = new System.Drawing.Point(86, 185);
            this.mlbFps.Name = "mlbFps";
            this.mlbFps.Size = new System.Drawing.Size(38, 19);
            this.mlbFps.TabIndex = 7;
            this.mlbFps.Text = "FPS :";
            // 
            // mtbCamAddress
            // 
            // 
            // 
            // 
            this.mtbCamAddress.CustomButton.Image = null;
            this.mtbCamAddress.CustomButton.Location = new System.Drawing.Point(350, 1);
            this.mtbCamAddress.CustomButton.Name = "";
            this.mtbCamAddress.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtbCamAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCamAddress.CustomButton.TabIndex = 1;
            this.mtbCamAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCamAddress.CustomButton.UseSelectable = true;
            this.mtbCamAddress.CustomButton.Visible = false;
            this.mtbCamAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbCamAddress.Lines = new string[] {
        "metroTextBox1"};
            this.mtbCamAddress.Location = new System.Drawing.Point(129, 111);
            this.mtbCamAddress.MaxLength = 32767;
            this.mtbCamAddress.Name = "mtbCamAddress";
            this.mtbCamAddress.PasswordChar = '\0';
            this.mtbCamAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCamAddress.SelectedText = "";
            this.mtbCamAddress.SelectionLength = 0;
            this.mtbCamAddress.SelectionStart = 0;
            this.mtbCamAddress.ShortcutsEnabled = true;
            this.mtbCamAddress.Size = new System.Drawing.Size(378, 29);
            this.mtbCamAddress.TabIndex = 3;
            this.mtbCamAddress.Text = "metroTextBox1";
            this.mtbCamAddress.UseSelectable = true;
            this.mtbCamAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCamAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mcbTotalChannel
            // 
            this.mcbTotalChannel.FormattingEnabled = true;
            this.mcbTotalChannel.ItemHeight = 23;
            this.mcbTotalChannel.Location = new System.Drawing.Point(129, 146);
            this.mcbTotalChannel.MaxDropDownItems = 4;
            this.mcbTotalChannel.Name = "mcbTotalChannel";
            this.mcbTotalChannel.Size = new System.Drawing.Size(378, 29);
            this.mcbTotalChannel.TabIndex = 2;
            this.mcbTotalChannel.UseSelectable = true;
            // 
            // mlbTotalChannel
            // 
            this.mlbTotalChannel.AutoSize = true;
            this.mlbTotalChannel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbTotalChannel.Location = new System.Drawing.Point(19, 150);
            this.mlbTotalChannel.Name = "mlbTotalChannel";
            this.mlbTotalChannel.Size = new System.Drawing.Size(105, 19);
            this.mlbTotalChannel.TabIndex = 4;
            this.mlbTotalChannel.Text = "Total Channels :";
            // 
            // mlbCamAddress
            // 
            this.mlbCamAddress.AutoSize = true;
            this.mlbCamAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbCamAddress.Location = new System.Drawing.Point(59, 116);
            this.mlbCamAddress.Name = "mlbCamAddress";
            this.mlbCamAddress.Size = new System.Drawing.Size(65, 19);
            this.mlbCamAddress.TabIndex = 2;
            this.mlbCamAddress.Text = "Address :";
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(380, 351);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 29);
            this.mbtnSave.TabIndex = 7;
            this.mbtnSave.Text = "metroButton3";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(461, 351);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 29);
            this.mbtnCancel.TabIndex = 8;
            this.mbtnCancel.Text = "metroButton2";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mtcConfig
            // 
            this.mtcConfig.Controls.Add(this.mtcTpAppConfig);
            this.mtcConfig.Controls.Add(this.mtcTpCamConfig);
            this.mtcConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcConfig.Location = new System.Drawing.Point(0, 0);
            this.mtcConfig.Name = "mtcConfig";
            this.mtcConfig.SelectedIndex = 0;
            this.mtcConfig.Size = new System.Drawing.Size(549, 342);
            this.mtcConfig.TabIndex = 20;
            this.mtcConfig.UseSelectable = true;
            // 
            // mtcTpAppConfig
            // 
            this.mtcTpAppConfig.Controls.Add(this.mpnlApp);
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
            // mpnlApp
            // 
            this.mpnlApp.Controls.Add(this.mcbStyle);
            this.mpnlApp.Controls.Add(this.mlbStyle);
            this.mpnlApp.Controls.Add(this.mcbTheme);
            this.mpnlApp.Controls.Add(this.mlbTheme);
            this.mpnlApp.Controls.Add(this.mbtnAutoSavePath);
            this.mpnlApp.Controls.Add(this.mlbAutoSave);
            this.mpnlApp.Controls.Add(this.mtglAutoSave);
            this.mpnlApp.Controls.Add(this.mcbTimeout);
            this.mpnlApp.Controls.Add(this.mlbTimeout);
            this.mpnlApp.Controls.Add(this.mtbAutoSavePath);
            this.mpnlApp.Controls.Add(this.mlbAutoSavePath);
            this.mpnlApp.HorizontalScrollbarBarColor = true;
            this.mpnlApp.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlApp.HorizontalScrollbarSize = 10;
            this.mpnlApp.Location = new System.Drawing.Point(3, 3);
            this.mpnlApp.Name = "mpnlApp";
            this.mpnlApp.Size = new System.Drawing.Size(538, 294);
            this.mpnlApp.TabIndex = 2;
            this.mpnlApp.VerticalScrollbarBarColor = true;
            this.mpnlApp.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlApp.VerticalScrollbarSize = 10;
            // 
            // mcbStyle
            // 
            this.mcbStyle.FormattingEnabled = true;
            this.mcbStyle.ItemHeight = 23;
            this.mcbStyle.Location = new System.Drawing.Point(188, 143);
            this.mcbStyle.MaxDropDownItems = 2;
            this.mcbStyle.Name = "mcbStyle";
            this.mcbStyle.Size = new System.Drawing.Size(301, 29);
            this.mcbStyle.TabIndex = 27;
            this.mcbStyle.UseSelectable = true;
            // 
            // mlbStyle
            // 
            this.mlbStyle.AutoSize = true;
            this.mlbStyle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbStyle.Location = new System.Drawing.Point(138, 147);
            this.mlbStyle.Name = "mlbStyle";
            this.mlbStyle.Size = new System.Drawing.Size(45, 19);
            this.mlbStyle.TabIndex = 28;
            this.mlbStyle.Text = "Style :";
            // 
            // mcbTheme
            // 
            this.mcbTheme.FormattingEnabled = true;
            this.mcbTheme.ItemHeight = 23;
            this.mcbTheme.Location = new System.Drawing.Point(188, 108);
            this.mcbTheme.MaxDropDownItems = 2;
            this.mcbTheme.Name = "mcbTheme";
            this.mcbTheme.Size = new System.Drawing.Size(301, 29);
            this.mcbTheme.TabIndex = 25;
            this.mcbTheme.UseSelectable = true;
            // 
            // mlbTheme
            // 
            this.mlbTheme.AutoSize = true;
            this.mlbTheme.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbTheme.Location = new System.Drawing.Point(126, 112);
            this.mlbTheme.Name = "mlbTheme";
            this.mlbTheme.Size = new System.Drawing.Size(57, 19);
            this.mlbTheme.TabIndex = 26;
            this.mlbTheme.Text = "Theme :";
            // 
            // mbtnAutoSavePath
            // 
            this.mbtnAutoSavePath.Location = new System.Drawing.Point(495, 38);
            this.mbtnAutoSavePath.Name = "mbtnAutoSavePath";
            this.mbtnAutoSavePath.Size = new System.Drawing.Size(34, 29);
            this.mbtnAutoSavePath.TabIndex = 21;
            this.mbtnAutoSavePath.Text = "metroButton3";
            this.mbtnAutoSavePath.UseSelectable = true;
            this.mbtnAutoSavePath.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mlbAutoSave
            // 
            this.mlbAutoSave.AutoSize = true;
            this.mlbAutoSave.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbAutoSave.Location = new System.Drawing.Point(57, 12);
            this.mlbAutoSave.Name = "mlbAutoSave";
            this.mlbAutoSave.Size = new System.Drawing.Size(126, 19);
            this.mlbAutoSave.TabIndex = 24;
            this.mlbAutoSave.Text = "Auto Save Images :";
            // 
            // mtglAutoSave
            // 
            this.mtglAutoSave.AutoSize = true;
            this.mtglAutoSave.Location = new System.Drawing.Point(188, 12);
            this.mtglAutoSave.Name = "mtglAutoSave";
            this.mtglAutoSave.Size = new System.Drawing.Size(80, 17);
            this.mtglAutoSave.TabIndex = 19;
            this.mtglAutoSave.Text = "Off";
            this.mtglAutoSave.UseSelectable = true;
            this.mtglAutoSave.CheckStateChanged += new System.EventHandler(this.AllToggleCheckStateChanged);
            // 
            // mcbTimeout
            // 
            this.mcbTimeout.FormattingEnabled = true;
            this.mcbTimeout.ItemHeight = 23;
            this.mcbTimeout.Location = new System.Drawing.Point(188, 73);
            this.mcbTimeout.MaxDropDownItems = 2;
            this.mcbTimeout.Name = "mcbTimeout";
            this.mcbTimeout.Size = new System.Drawing.Size(301, 29);
            this.mcbTimeout.TabIndex = 22;
            this.mcbTimeout.UseSelectable = true;
            // 
            // mlbTimeout
            // 
            this.mlbTimeout.AutoSize = true;
            this.mlbTimeout.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbTimeout.Location = new System.Drawing.Point(8, 77);
            this.mlbTimeout.Name = "mlbTimeout";
            this.mlbTimeout.Size = new System.Drawing.Size(175, 19);
            this.mlbTimeout.TabIndex = 23;
            this.mlbTimeout.Text = "Image Download TImeout :";
            // 
            // mtbAutoSavePath
            // 
            // 
            // 
            // 
            this.mtbAutoSavePath.CustomButton.Image = null;
            this.mtbAutoSavePath.CustomButton.Location = new System.Drawing.Point(273, 1);
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
            this.mtbAutoSavePath.Location = new System.Drawing.Point(188, 38);
            this.mtbAutoSavePath.MaxLength = 32767;
            this.mtbAutoSavePath.Name = "mtbAutoSavePath";
            this.mtbAutoSavePath.PasswordChar = '\0';
            this.mtbAutoSavePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbAutoSavePath.SelectedText = "";
            this.mtbAutoSavePath.SelectionLength = 0;
            this.mtbAutoSavePath.SelectionStart = 0;
            this.mtbAutoSavePath.ShortcutsEnabled = true;
            this.mtbAutoSavePath.Size = new System.Drawing.Size(301, 29);
            this.mtbAutoSavePath.TabIndex = 20;
            this.mtbAutoSavePath.Text = "metroTextBox1";
            this.mtbAutoSavePath.UseSelectable = true;
            this.mtbAutoSavePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbAutoSavePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbAutoSavePath
            // 
            this.mlbAutoSavePath.AutoSize = true;
            this.mlbAutoSavePath.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbAutoSavePath.Location = new System.Drawing.Point(31, 42);
            this.mlbAutoSavePath.Name = "mlbAutoSavePath";
            this.mlbAutoSavePath.Size = new System.Drawing.Size(152, 19);
            this.mlbAutoSavePath.TabIndex = 21;
            this.mlbAutoSavePath.Text = "Auto Save Image Path :";
            // 
            // mtcTpCamConfig
            // 
            this.mtcTpCamConfig.Controls.Add(this.mpnlCam);
            this.mtcTpCamConfig.HorizontalScrollbarBarColor = true;
            this.mtcTpCamConfig.HorizontalScrollbarHighlightOnWheel = false;
            this.mtcTpCamConfig.HorizontalScrollbarSize = 10;
            this.mtcTpCamConfig.Location = new System.Drawing.Point(4, 38);
            this.mtcTpCamConfig.Name = "mtcTpCamConfig";
            this.mtcTpCamConfig.Size = new System.Drawing.Size(541, 300);
            this.mtcTpCamConfig.TabIndex = 1;
            this.mtcTpCamConfig.Text = "metroTabPage2";
            this.mtcTpCamConfig.VerticalScrollbarBarColor = true;
            this.mtcTpCamConfig.VerticalScrollbarHighlightOnWheel = false;
            this.mtcTpCamConfig.VerticalScrollbarSize = 10;
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
            this.mpnlPrimary.Size = new System.Drawing.Size(549, 391);
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
            this.ClientSize = new System.Drawing.Size(589, 471);
            this.Controls.Add(this.mpnlPrimary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.mpnlCam.ResumeLayout(false);
            this.mpnlCam.PerformLayout();
            this.mtcConfig.ResumeLayout(false);
            this.mtcTpAppConfig.ResumeLayout(false);
            this.mpnlApp.ResumeLayout(false);
            this.mpnlApp.PerformLayout();
            this.mtcTpCamConfig.ResumeLayout(false);
            this.mpnlPrimary.ResumeLayout(false);
            this.mpnlSecondary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroPanel mpnlCam;
        internal MetroFramework.Controls.MetroButton mbtnCancel;
        internal MetroFramework.Controls.MetroComboBox mcbZoom;
        internal MetroFramework.Controls.MetroLabel mlbZoom;
        internal MetroFramework.Controls.MetroComboBox mcbFps;
        internal MetroFramework.Controls.MetroLabel mlbFps;
        internal MetroFramework.Controls.MetroTextBox mtbCamAddress;
        internal MetroFramework.Controls.MetroComboBox mcbTotalChannel;
        internal MetroFramework.Controls.MetroLabel mlbTotalChannel;
        internal MetroFramework.Controls.MetroLabel mlbCamAddress;
        internal MetroFramework.Controls.MetroButton mbtnSave;
        internal MetroFramework.Controls.MetroTextBox mtbCamName;
        internal MetroFramework.Controls.MetroLabel mlbCamName;
        internal MetroFramework.Controls.MetroToggle mtglEdit;
        internal MetroFramework.Controls.MetroComboBox mcbCamId;
        internal MetroFramework.Controls.MetroLabel mlbCamId;
        internal MetroFramework.Controls.MetroLabel mlbEditMode;
        internal MetroFramework.Controls.MetroButton mbtnDelete;
        internal MetroFramework.Controls.MetroTabControl mtcConfig;
        internal MetroFramework.Controls.MetroTabPage mtcTpAppConfig;
        internal MetroFramework.Controls.MetroPanel mpnlApp;
        internal MetroFramework.Controls.MetroTabPage mtcTpCamConfig;
        internal MetroFramework.Controls.MetroPanel mpnlPrimary;
        internal MetroFramework.Controls.MetroButton mbtnAutoSavePath;
        internal MetroFramework.Controls.MetroLabel mlbAutoSave;
        internal MetroFramework.Controls.MetroToggle mtglAutoSave;
        internal MetroFramework.Controls.MetroComboBox mcbTimeout;
        internal MetroFramework.Controls.MetroLabel mlbTimeout;
        internal MetroFramework.Controls.MetroTextBox mtbAutoSavePath;
        internal MetroFramework.Controls.MetroLabel mlbAutoSavePath;
        private MetroFramework.Controls.MetroPanel mpnlSecondary;
        internal MetroFramework.Controls.MetroComboBox mcbStyle;
        internal MetroFramework.Controls.MetroLabel mlbStyle;
        internal MetroFramework.Controls.MetroComboBox mcbTheme;
        internal MetroFramework.Controls.MetroLabel mlbTheme;
    }
}