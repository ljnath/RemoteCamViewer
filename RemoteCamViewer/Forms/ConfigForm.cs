using MetroFramework.Forms;
using RemoteCamViewer.Handlers;

namespace RemoteCamViewer.Forms
{
    public partial class ConfigForm : MetroForm
    {
        public ConfigForm()
        {
            InitializeComponent();
            FormHandler.Instance.InitializeForm(this);
        }

        private void AllButtonClick(object sender, System.EventArgs e)
        {
            FormHandler.Instance.ButtonClicks(this, sender);
        }

        private void AllToggleCheckStateChanged(object sender, System.EventArgs e)
        {
            FormHandler.Instance.ToogleCheckedChange(this, sender);
        }

        private void mcbCamId_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            FormHandler.Instance.ReloadCamConfig(this);
        }
    }
}
