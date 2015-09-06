using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;
using WindowsLive.Writer.Api;

namespace MC.LiveWriter.Highlighter.Plugin
{
    /// <summary>
    /// Plugin that works together with SyntaxHighlighter 3.0.83
    /// http://alexgorbatchev.com/SyntaxHighlighter/
    /// </summary>
    [WriterPlugin("BF48545B-72FC-48CD-B241-BB2967E2EF01", "Code", ImagePath = "Code.gif")]
    [InsertableContentSource("Code", SidebarText = "Code")]
    public class HighlightedContent : SmartContentSource
    {
        public const string SourceProperty = "Source";
        public const string BrushProperty = "Brush";
        public const string DefaultBrush = "csharp";
        public const string ShowLineNumbersProperty = "ShowLineNumbers";
        public const bool DefaultShowLineNumbers = true;
        public const string FirstLineNumberProperty = "FirstLineNumber";
        public const string DefaultFirstLineNumber = "1";
        public const string LineNumbersToHighlightProperty = "LineNumbersToHighlight";
        public const string DefaultLineNumbersToHighlight = "";
        public const string ShowToolbarProperty = "ShowToolbar";
        public const bool DefaultShowToolbar = false;
        public const string CollapseProperty = "Collapse";
        public const bool DefaultCollapse = false;

        public static readonly IDictionary<string, string> Brushes =
            new Dictionary<string, string>
                {
                    {"C#","csharp"},
                    {"CSS", "css"},
                    {"Javascript", "js"},
                    {"Plain", "text"},
                    {"SQL", "sql"},
                    {"XML", "xml"},
                };

        public override DialogResult CreateContent(IWin32Window dialogOwner, ISmartContent newContent)
        {
            if (!newContent.Properties.Contains(BrushProperty))
                newContent.Properties[BrushProperty] = DefaultBrush;
            if (!newContent.Properties.Contains(ShowLineNumbersProperty))
                newContent.Properties[ShowLineNumbersProperty] = DefaultShowLineNumbers.ToString().ToLower();
            if (!newContent.Properties.Contains(ShowToolbarProperty))
                newContent.Properties[ShowToolbarProperty] = DefaultShowToolbar.ToString().ToLower();
            if (!newContent.Properties.Contains(FirstLineNumberProperty))
                newContent.Properties[FirstLineNumberProperty] = DefaultFirstLineNumber;
            if (!newContent.Properties.Contains(LineNumbersToHighlightProperty))
                newContent.Properties[LineNumbersToHighlightProperty] = DefaultLineNumbersToHighlight;
            if (!newContent.Properties.Contains(CollapseProperty))
                newContent.Properties[CollapseProperty] = DefaultCollapse.ToString().ToLower();
            var sourceCodeForm = new SourceCodeForm {SmartContent = newContent};
            return sourceCodeForm.ShowDialog(dialogOwner);
        }

        public override string GeneratePublishHtml(ISmartContent content, IPublishingContext publishingContext)
        {
            string highlightedLines = content.Properties[LineNumbersToHighlightProperty].Trim();
            if (!string.IsNullOrEmpty(highlightedLines))
            {
                highlightedLines = string.Format("highlight: [{0}]", highlightedLines);
            }
            return string.Format(@"<pre class=""brush:{1}; gutter:{2}; first-line: {4}; tab-size: 4; toolbar: {3}; collapse: {6}; {5}"">{0}</pre>", 
                HttpUtility.HtmlEncode(content.Properties[SourceProperty]),
                content.Properties[BrushProperty],
                content.Properties[ShowLineNumbersProperty].ToLower(),
                content.Properties[ShowToolbarProperty].ToLower(),
                content.Properties[FirstLineNumberProperty],
                highlightedLines,
                content.Properties[CollapseProperty].ToLower());
        }

        public override SmartContentEditor CreateEditor(ISmartContentEditorSite editorSite)
        {
            var sourceEditor = new SmartSourceEditor {ShowEditorButton = true};
            return sourceEditor;
        }
    }
}