using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsLive.Writer.Api;

namespace MC.LiveWriter.Highlighter.Plugin
{
    public partial class SmartSourceEditor : SmartContentEditor
    {
        private ISmartContent _selectedContent;

        public SmartSourceEditor()
        {
            InitializeComponent();
            ShowEditorButton = false;
            ErrorProvider.SetIconPadding(HighlightedLinesTextBox, -20);
            EditorButton.Click +=
                (s, e) =>
                    {
                        var codeForm = new SourceCodeForm {SmartContent = SelectedContent};
                        Enabled = false;
                        if (codeForm.ShowDialog() == DialogResult.OK)
                        {
                            InitializeControls(SelectedContent);
                            MarkContentAsEdited();
                        }
                        Enabled = true;
                    };
            IList list = new ArrayList();
            foreach (var pair in HighlightedContent.Brushes)
            {
                list.Add(pair);
            }
            LanguageComboBox.DataSource = list;
            LanguageComboBox.ValueMember = "Value";
            LanguageComboBox.DisplayMember = "Key";
            LanguageComboBox.SelectedValueChanged +=
                (s, e) =>
                    {
                        SelectedContent.Properties[HighlightedContent.BrushProperty] =
                            LanguageComboBox.SelectedValue.ToString();
                        MarkContentAsEdited();
                    };
            ShowLineNumbersCheckBox.CheckedChanged +=
                (s, e) =>
                    {
                        SelectedContent.Properties[HighlightedContent.ShowLineNumbersProperty] =
                            ShowLineNumbersCheckBox.Checked.ToString().ToLower();
                        MarkContentAsEdited();
                    };
            ShowToolbarCheckBox.CheckedChanged +=
                (s, e) =>
                    {
                        SelectedContent.Properties[HighlightedContent.ShowToolbarProperty] =
                            ShowToolbarCheckBox.Checked.ToString().ToLower();
                        MarkContentAsEdited();
                    };
            FirstLineNumberNumericUpDown.ValueChanged +=
                (s, e) =>
                    {
                        SelectedContent.Properties[HighlightedContent.FirstLineNumberProperty] =
                            FirstLineNumberNumericUpDown.Value.ToString();
                        MarkContentAsEdited();
                    };
            HighlightedLinesTextBox.TextChanged +=
                (s, e) =>
                    {
                        SelectedContent.Properties[HighlightedContent.LineNumbersToHighlightProperty] =
                            HighlightedLinesTextBox.Text;
                        MarkContentAsEdited();
                    };
            CollapseCodeCheckBox.CheckedChanged +=
                (s, e) =>
                    {
                        SelectedContent.Properties[HighlightedContent.CollapseProperty] =
                            CollapseCodeCheckBox.Checked.ToString().ToLower();
                        MarkContentAsEdited();
                    };
        }

        public bool ShowEditorButton
        {
            get { return EditorButton.Visible; }
            set { EditorButton.Visible = value; }
        }

        public override ISmartContent SelectedContent
        {
            get { return _selectedContent; }
            set
            {
                _selectedContent = value;
                InitializeControls(value);
            }
        }

        private void InitializeControls(ISmartContent value)
        {
            if (value != null)
            {
                string selectedValue = value.Properties[HighlightedContent.BrushProperty];
                if (string.IsNullOrEmpty(selectedValue))
                    selectedValue = HighlightedContent.DefaultBrush;
                LanguageComboBox.SelectedValue = selectedValue;
                ShowLineNumbersCheckBox.Checked =
                    bool.Parse(SelectedContent.Properties[HighlightedContent.ShowLineNumbersProperty]);
                ShowToolbarCheckBox.Checked =
                    bool.Parse(SelectedContent.Properties[HighlightedContent.ShowToolbarProperty]);
                FirstLineNumberNumericUpDown.Value =
                    decimal.Parse(SelectedContent.Properties[HighlightedContent.FirstLineNumberProperty]);
                HighlightedLinesTextBox.Text =
                    SelectedContent.Properties[HighlightedContent.LineNumbersToHighlightProperty];
                CollapseCodeCheckBox.Checked =
                    bool.Parse(SelectedContent.Properties[HighlightedContent.CollapseProperty]);
            }
        }

        public void MarkContentAsEdited()
        {
            OnContentEdited();
        }

        private void HighlightedLinesTextBoxValidating(object sender, CancelEventArgs e)
        {
            HighlightedLinesTextBox.Text = HighlightedLinesTextBox.Text.Trim();
            Match match = new Regex("^[0-9]+(,[ ]*[0-9]+)*$").Match(HighlightedLinesTextBox.Text);
            if (!string.IsNullOrEmpty(HighlightedLinesTextBox.Text) && !match.Success || match.Index != 0)
            {
                ErrorProvider.SetError(HighlightedLinesTextBox, "Please use comma-separated numbers. 1, 3, 12");
            }
            else
            {
                ErrorProvider.SetError(HighlightedLinesTextBox, string.Empty);
            }
        }
    }
}