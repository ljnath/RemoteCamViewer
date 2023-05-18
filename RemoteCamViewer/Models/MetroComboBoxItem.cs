using MetroFramework;

namespace RemoteCamViewer.Models
{
    class MetroComboBoxItem
    {
        public string DisplayText { get; set; }
        public string Value { get; set; }

        public MetroThemeStyle ThemeValue { get; set; }

        public MetroColorStyle StyleValue { get; set; }


        public MetroComboBoxItem(string displayText, string value)
        {
            DisplayText = displayText;
            Value = value;
        }

        public MetroComboBoxItem(string displayText, MetroThemeStyle value)
        {
            DisplayText = displayText;
            ThemeValue = value;
        }

        public MetroComboBoxItem(string displayText, MetroColorStyle value)
        {
            DisplayText = displayText;
            StyleValue = value;
        }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}
