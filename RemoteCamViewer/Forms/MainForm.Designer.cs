
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
            this.mpnlConfig = new MetroFramework.Controls.MetroPanel();
            this.mlbStatus = new MetroFramework.Controls.MetroLabel();
            this.mbtnConfigure = new MetroFramework.Controls.MetroButton();
            this.mbtnExit = new MetroFramework.Controls.MetroButton();
            this.mcbCamAddress = new MetroFramework.Controls.MetroComboBox();
            this.mbtnStartStop = new MetroFramework.Controls.MetroButton();
            this.mbtnAbout = new MetroFramework.Controls.MetroButton();
            this.mlbCamAddress = new MetroFramework.Controls.MetroLabel();
            this.flpViewer = new System.Windows.Forms.FlowLayoutPanel();
            this.mpnlConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpnlConfig
            // 
            this.mpnlConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpnlConfig.Controls.Add(this.mlbStatus);
            this.mpnlConfig.Controls.Add(this.mbtnConfigure);
            this.mpnlConfig.Controls.Add(this.mbtnExit);
            this.mpnlConfig.Controls.Add(this.mcbCamAddress);
            this.mpnlConfig.Controls.Add(this.mbtnStartStop);
            this.mpnlConfig.Controls.Add(this.mbtnAbout);
            this.mpnlConfig.Controls.Add(this.mlbCamAddress);
            this.mpnlConfig.HorizontalScrollbarBarColor = true;
            this.mpnlConfig.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlConfig.HorizontalScrollbarSize = 10;
            this.mpnlConfig.Location = new System.Drawing.Point(5, 62);
            this.mpnlConfig.Name = "mpnlConfig";
            this.mpnlConfig.Size = new System.Drawing.Size(791, 69);
            this.mpnlConfig.TabIndex = 2;
            this.mpnlConfig.VerticalScrollbarBarColor = true;
            this.mpnlConfig.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlConfig.VerticalScrollbarSize = 10;
            // 
            // mlbStatus
            // 
            this.mlbStatus.AutoSize = true;
            this.mlbStatus.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlbStatus.Location = new System.Drawing.Point(151, 46);
            this.mlbStatus.Name = "mlbStatus";
            this.mlbStatus.Size = new System.Drawing.Size(114, 15);
            this.mlbStatus.TabIndex = 5;
            this.mlbStatus.Text = "Select Remote Cam : ";
            // 
            // mbtnConfigure
            // 
            this.mbtnConfigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnConfigure.Location = new System.Drawing.Point(500, 14);
            this.mbtnConfigure.Name = "mbtnConfigure";
            this.mbtnConfigure.Size = new System.Drawing.Size(90, 29);
            this.mbtnConfigure.TabIndex = 1;
            this.mbtnConfigure.Text = "metroButton4";
            this.mbtnConfigure.UseSelectable = true;
            this.mbtnConfigure.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mbtnExit
            // 
            this.mbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnExit.Location = new System.Drawing.Point(692, 14);
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(90, 29);
            this.mbtnExit.TabIndex = 4;
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
            this.mcbCamAddress.Location = new System.Drawing.Point(151, 14);
            this.mcbCamAddress.Name = "mcbCamAddress";
            this.mcbCamAddress.Size = new System.Drawing.Size(247, 29);
            this.mcbCamAddress.TabIndex = 0;
            this.mcbCamAddress.UseSelectable = true;
            this.mcbCamAddress.SelectionChangeCommitted += new System.EventHandler(this.mcbCamAddress_SelectionChangeCommitted);
            // 
            // mbtnStartStop
            // 
            this.mbtnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnStartStop.Location = new System.Drawing.Point(404, 14);
            this.mbtnStartStop.Name = "mbtnStartStop";
            this.mbtnStartStop.Size = new System.Drawing.Size(90, 29);
            this.mbtnStartStop.TabIndex = 3;
            this.mbtnStartStop.Text = "metroButton2";
            this.mbtnStartStop.UseSelectable = true;
            this.mbtnStartStop.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mbtnAbout
            // 
            this.mbtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAbout.Location = new System.Drawing.Point(596, 14);
            this.mbtnAbout.Name = "mbtnAbout";
            this.mbtnAbout.Size = new System.Drawing.Size(90, 29);
            this.mbtnAbout.TabIndex = 2;
            this.mbtnAbout.Text = "metroButton1";
            this.mbtnAbout.UseSelectable = true;
            this.mbtnAbout.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // mlbCamAddress
            // 
            this.mlbCamAddress.AutoSize = true;
            this.mlbCamAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbCamAddress.Location = new System.Drawing.Point(12, 18);
            this.mlbCamAddress.Name = "mlbCamAddress";
            this.mlbCamAddress.Size = new System.Drawing.Size(138, 19);
            this.mlbCamAddress.TabIndex = 2;
            this.mlbCamAddress.Text = "Select Remote Cam : ";
            // 
            // flpViewer
            // 
            this.flpViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpViewer.Location = new System.Drawing.Point(5, 137);
            this.flpViewer.Name = "flpViewer";
            this.flpViewer.Size = new System.Drawing.Size(791, 398);
            this.flpViewer.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 548);
            this.Controls.Add(this.flpViewer);
            this.Controls.Add(this.mpnlConfig);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Form1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mpnlConfig.ResumeLayout(false);
            this.mpnlConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal MetroFramework.Controls.MetroPanel mpnlConfig;
        internal System.Windows.Forms.FlowLayoutPanel flpViewer;
        internal MetroFramework.Controls.MetroButton mbtnStartStop;
        internal MetroFramework.Controls.MetroButton mbtnAbout;
        internal MetroFramework.Controls.MetroLabel mlbCamAddress;
        internal MetroFramework.Controls.MetroButton mbtnConfigure;
        internal MetroFramework.Controls.MetroButton mbtnExit;
        internal MetroFramework.Controls.MetroComboBox mcbCamAddress;
        internal MetroFramework.Controls.MetroLabel mlbStatus;
    }
}

