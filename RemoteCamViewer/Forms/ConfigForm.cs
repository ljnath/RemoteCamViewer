using MetroFramework.Forms;
using RemoteCamViewer.Handlers;

namespace RemoteCamViewer.Forms
{
    public partial class ConfigForm : MetroForm
    {
        internal string CameraID { get; set; } = string.Empty;

        // contructor to use the same form for editing an existing camera
        public ConfigForm(string cameraID)
        {
            CameraID = cameraID;
            InitializeForm();
        }

        public ConfigForm()
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeComponent();
            FormHandler.Instance.InitializeForm(this);
        }

        private void AllButtonClick(object sender, System.EventArgs e)
        {
            FormHandler.Instance.ButtonClicks(this, sender);
        }

        private void AllComboBoxSelectionChangeCommitted(object sender, System.EventArgs e)
        {
            FormHandler.Instance.ComboBoxSelectedChangeCommitted(this, sender);
        }

        private void AllToggleCheckStateChanged(object sender, System.EventArgs e)
        {
            FormHandler.Instance.ToogleCheckedChange(this, sender);
        }
    }
}
