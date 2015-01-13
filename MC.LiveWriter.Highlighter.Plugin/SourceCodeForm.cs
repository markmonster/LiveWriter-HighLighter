using System.Windows.Forms;
using WindowsLive.Writer.Api;

namespace MC.LiveWriter.Highlighter.Plugin
{
    public partial class SourceCodeForm : Form
    {
        private readonly SmartSourceEditor _smartSourceEditor;
        private ISmartContent _smartContent;

        public SourceCodeForm(SmartSourceEditor smartSourceEditor = null)
        {
            _smartSourceEditor = smartSourceEditor ?? new SmartSourceEditor();
            InitializeComponent();
            SettingsPanel.Controls.Add(_smartSourceEditor);
            Shown +=
                (s, e) => { SourceCodeTextBox.Text = SmartContent.Properties[HighlightedContent.SourceProperty]; };
            OkButton.Click +=
                (s, e) =>
                    {
                        SmartContent.Properties[HighlightedContent.SourceProperty] = SourceCodeTextBox.Text;
                        _smartSourceEditor.MarkContentAsEdited();
                        DialogResult = DialogResult.OK;
                    };
            CancelButton.Click +=
                (s, e) =>
                    {
                        DialogResult = DialogResult.Cancel;
                        Close();
                    };
        }

        public ISmartContent SmartContent
        {
            get { return _smartContent; }
            set
            {
                _smartContent = value;
                _smartSourceEditor.SelectedContent = _smartContent;
            }
        }

        private void SelectAll(object sender, KeyPressEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyChar == (char) Keys.A)
                ((TextBox) sender).SelectAll();
        }
    }
}