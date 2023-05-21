
namespace RemoteCamViewer.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mpnlPrimary = new MetroFramework.Controls.MetroPanel();
            this.flpChannelSelection = new System.Windows.Forms.FlowLayoutPanel();
            this.mbtnRefresh = new MetroFramework.Controls.MetroButton();
            this.mbtnEdit = new MetroFramework.Controls.MetroButton();
            this.mbtnSettings = new MetroFramework.Controls.MetroButton();
            this.mbtnExit = new MetroFramework.Controls.MetroButton();
            this.mcbCamAddress = new MetroFramework.Controls.MetroComboBox();
            this.mbtnStartStop = new MetroFramework.Controls.MetroButton();
            this.mbtnAbout = new MetroFramework.Controls.MetroButton();
            this.mlbSelectCamera = new MetroFramework.Controls.MetroLabel();
            this.mlbStatus = new MetroFramework.Controls.MetroLabel();
            this.flpViewer = new System.Windows.Forms.FlowLayoutPanel();
            this.mpnlSecondary = new MetroFramework.Controls.MetroPanel();
            this.mpnlPrimary.SuspendLayout();
            this.mpnlSecondary.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpnlPrimary
            // 
            this.mpnlPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpnlPrimary.Controls.Add(this.flpChannelSelection);
            this.mpnlPrimary.Controls.Add(this.mbtnRefresh);
            this.mpnlPrimary.Controls.Add(this.mbtnEdit);
            this.mpnlPrimary.Controls.Add(this.mbtnSettings);
            this.mpnlPrimary.Controls.Add(this.mbtnExit);
            this.mpnlPrimary.Controls.Add(this.mcbCamAddress);
            this.mpnlPrimary.Controls.Add(this.mbtnStartStop);
            this.mpnlPrimary.Controls.Add(this.mbtnAbout);
            this.mpnlPrimary.Controls.Add(this.mlbSelectCamera);
            this.mpnlPrimary.HorizontalScrollbarBarColor = true;
            this.mpnlPrimary.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlPrimary.HorizontalScrollbarSize = 10;
            this.mpnlPrimary.Location = new System.Drawing.Point(5, 62);
            this.mpnlPrimary.Name = "mpnlPrimary";
            this.mpnlPrimary.Size = new System.Drawing.Size(898, 87);
            this.mpnlPrimary.TabIndex = 2;
            this.mpnlPrimary.VerticalScrollbarBarColor = true;
            this.mpnlPrimary.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlPrimary.VerticalScrollbarSize = 10;
            // 
            // flpChannelSelection
            // 
            this.flpChannelSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpChannelSelection.AutoScroll = true;
            this.flpChannelSelection.Location = new System.Drawing.Point(122, 48);
            this.flpChannelSelection.Name = "flpChannelSelection";
            this.flpChannelSelection.Size = new System.Drawing.Size(746, 36);
            this.flpChannelSelection.TabIndex = 7;
            // 
            // mbtnRefresh
            // 
            this.mbtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnRefresh.Location = new System.Drawing.Point(378, 13);
            this.mbtnRefresh.Name = "mbtnRefresh";
            this.mbtnRefresh.Size = new System.Drawing.Size(80, 29);
            this.mbtnRefresh.TabIndex = 1;
            this.mbtnRefresh.Text = "metroButton2";
            this.mbtnRefresh.UseSelectable = true;
            this.mbtnRefresh.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mbtnEdit
            // 
            this.mbtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnEdit.Location = new System.Drawing.Point(464, 13);
            this.mbtnEdit.Name = "mbtnEdit";
            this.mbtnEdit.Size = new System.Drawing.Size(80, 29);
            this.mbtnEdit.TabIndex = 2;
            this.mbtnEdit.Text = "metroButton2";
            this.mbtnEdit.UseSelectable = true;
            this.mbtnEdit.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mbtnSettings
            // 
            this.mbtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnSettings.Location = new System.Drawing.Point(550, 13);
            this.mbtnSettings.Name = "mbtnSettings";
            this.mbtnSettings.Size = new System.Drawing.Size(80, 29);
            this.mbtnSettings.TabIndex = 3;
            this.mbtnSettings.Text = "metroButton4";
            this.mbtnSettings.UseSelectable = true;
            this.mbtnSettings.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mbtnExit
            // 
            this.mbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnExit.Location = new System.Drawing.Point(808, 13);
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(80, 29);
            this.mbtnExit.TabIndex = 6;
            this.mbtnExit.Text = "metroButton3";
            this.mbtnExit.UseSelectable = true;
            this.mbtnExit.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mcbCamAddress
            // 
            this.mcbCamAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcbCamAddress.FormattingEnabled = true;
            this.mcbCamAddress.ItemHeight = 23;
            this.mcbCamAddress.Location = new System.Drawing.Point(122, 13);
            this.mcbCamAddress.Name = "mcbCamAddress";
            this.mcbCamAddress.Size = new System.Drawing.Size(250, 29);
            this.mcbCamAddress.TabIndex = 0;
            this.mcbCamAddress.UseSelectable = true;
            this.mcbCamAddress.SelectedIndexChanged += new System.EventHandler(this.AllComboxBoxSelectedIndexChanged);
            this.mcbCamAddress.SelectionChangeCommitted += new System.EventHandler(this.AllMetroComboBoxSelectionChangeCommitted);
            // 
            // mbtnStartStop
            // 
            this.mbtnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnStartStop.Location = new System.Drawing.Point(636, 13);
            this.mbtnStartStop.Name = "mbtnStartStop";
            this.mbtnStartStop.Size = new System.Drawing.Size(80, 29);
            this.mbtnStartStop.TabIndex = 4;
            this.mbtnStartStop.Text = "metroButton2";
            this.mbtnStartStop.UseSelectable = true;
            this.mbtnStartStop.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mbtnAbout
            // 
            this.mbtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAbout.Location = new System.Drawing.Point(722, 13);
            this.mbtnAbout.Name = "mbtnAbout";
            this.mbtnAbout.Size = new System.Drawing.Size(80, 29);
            this.mbtnAbout.TabIndex = 5;
            this.mbtnAbout.Text = "metroButton1";
            this.mbtnAbout.UseSelectable = true;
            this.mbtnAbout.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mlbSelectCamera
            // 
            this.mlbSelectCamera.AutoSize = true;
            this.mlbSelectCamera.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbSelectCamera.Location = new System.Drawing.Point(10, 17);
            this.mlbSelectCamera.Name = "mlbSelectCamera";
            this.mlbSelectCamera.Size = new System.Drawing.Size(106, 19);
            this.mlbSelectCamera.TabIndex = 2;
            this.mlbSelectCamera.Text = "Select Camera : ";
            // 
            // mlbStatus
            // 
            this.mlbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mlbStatus.AutoSize = true;
            this.mlbStatus.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlbStatus.Location = new System.Drawing.Point(5, 555);
            this.mlbStatus.Name = "mlbStatus";
            this.mlbStatus.Size = new System.Drawing.Size(114, 15);
            this.mlbStatus.TabIndex = 5;
            this.mlbStatus.Text = "Select Remote Cam : ";
            // 
            // flpViewer
            // 
            this.flpViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpViewer.Location = new System.Drawing.Point(0, 0);
            this.flpViewer.Name = "flpViewer";
            this.flpViewer.Size = new System.Drawing.Size(898, 397);
            this.flpViewer.TabIndex = 3;
            // 
            // mpnlSecondary
            // 
            this.mpnlSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpnlSecondary.Controls.Add(this.flpViewer);
            this.mpnlSecondary.HorizontalScrollbarBarColor = true;
            this.mpnlSecondary.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlSecondary.HorizontalScrollbarSize = 10;
            this.mpnlSecondary.Location = new System.Drawing.Point(5, 155);
            this.mpnlSecondary.Name = "mpnlSecondary";
            this.mpnlSecondary.Size = new System.Drawing.Size(898, 397);
            this.mpnlSecondary.TabIndex = 4;
            this.mpnlSecondary.VerticalScrollbarBarColor = true;
            this.mpnlSecondary.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlSecondary.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbtnExit;
            this.ClientSize = new System.Drawing.Size(911, 575);
            this.Controls.Add(this.mpnlSecondary);
            this.Controls.Add(this.mpnlPrimary);
            this.Controls.Add(this.mlbStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Form1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mpnlPrimary.ResumeLayout(false);
            this.mpnlPrimary.PerformLayout();
            this.mpnlSecondary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal MetroFramework.Controls.MetroPanel mpnlPrimary;
        internal System.Windows.Forms.FlowLayoutPanel flpViewer;
        internal MetroFramework.Controls.MetroButton mbtnStartStop;
        internal MetroFramework.Controls.MetroButton mbtnAbout;
        internal MetroFramework.Controls.MetroLabel mlbSelectCamera;
        internal MetroFramework.Controls.MetroButton mbtnSettings;
        internal MetroFramework.Controls.MetroButton mbtnExit;
        internal MetroFramework.Controls.MetroComboBox mcbCamAddress;
        internal MetroFramework.Controls.MetroLabel mlbStatus;
        internal MetroFramework.Controls.MetroPanel mpnlSecondary;
        internal MetroFramework.Controls.MetroButton mbtnEdit;
        internal MetroFramework.Controls.MetroButton mbtnRefresh;
        internal System.Windows.Forms.FlowLayoutPanel flpChannelSelection;
    }
}

