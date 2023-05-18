using MetroFramework.Forms;
using RemoteCamViewer.Handlers;
using RemoteCamViewer.Handlers.IO;
using System;
using System.Windows.Forms;

namespace RemoteCamViewer.Forms
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            FormHandler.Instance.InitializeForm(this);
        }

        private void AllButtonClick(object sender, EventArgs e)
        {
            FormHandler.Instance.ButtonClicks(this, sender);
        }

        private void mcbCamAddress_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mbtnStartStop.Enabled = mcbCamAddress.SelectedIndex != -1;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CamHandler.Instance.StopViewer();
        }

        private void MainForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NetworkHandler.OpenHomePage();
        }
    }
}
