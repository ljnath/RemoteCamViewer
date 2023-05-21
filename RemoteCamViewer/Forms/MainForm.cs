using MetroFramework.Forms;
using RemoteCamViewer.Handlers;
using RemoteCamViewer.Handlers.IO;
using System;
using System.Collections.Generic;
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

        private void AllMetroComboBoxSelectionChangeCommitted(object sender, EventArgs e)
        {
            FormHandler.Instance.ComboBoxSelectedChangeCommitted(this, sender);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CameraHandler.Instance.StopViewer();
        }

        private void MainForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NetworkHandler.OpenHomePage();
        }

        private void AllComboxBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            FormHandler.Instance.ComboBoxSelectedChangeCommitted(this, sender);
        }
    }
}
