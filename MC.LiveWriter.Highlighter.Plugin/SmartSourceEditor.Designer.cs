namespace MC.LiveWriter.Highlighter.Plugin
{
    partial class SmartSourceEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EditorButton = new System.Windows.Forms.Button();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.ShowLineNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowToolbarCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstLineNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.firstLineNumberLabel = new System.Windows.Forms.Label();
            this.HighlightedLinesTextBox = new System.Windows.Forms.TextBox();
            this.HighlightedLinesLabel = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CollapseCodeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.FirstLineNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EditorButton
            // 
            this.EditorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorButton.Location = new System.Drawing.Point(4, 4);
            this.EditorButton.Name = "EditorButton";
            this.EditorButton.Size = new System.Drawing.Size(193, 23);
            this.EditorButton.TabIndex = 0;
            this.EditorButton.Text = "Edit Code";
            this.EditorButton.UseVisualStyleBackColor = true;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(4, 34);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(193, 23);
            this.LanguageComboBox.TabIndex = 1;
            // 
            // ShowLineNumbersCheckBox
            // 
            this.ShowLineNumbersCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowLineNumbersCheckBox.AutoSize = true;
            this.ShowLineNumbersCheckBox.Location = new System.Drawing.Point(4, 64);
            this.ShowLineNumbersCheckBox.Name = "ShowLineNumbersCheckBox";
            this.ShowLineNumbersCheckBox.Size = new System.Drawing.Size(127, 19);
            this.ShowLineNumbersCheckBox.TabIndex = 2;
            this.ShowLineNumbersCheckBox.Text = "Show Linenumbers";
            this.ShowLineNumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowToolbarCheckBox
            // 
            this.ShowToolbarCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowToolbarCheckBox.AutoSize = true;
            this.ShowToolbarCheckBox.Location = new System.Drawing.Point(4, 89);
            this.ShowToolbarCheckBox.Name = "ShowToolbarCheckBox";
            this.ShowToolbarCheckBox.Size = new System.Drawing.Size(99, 19);
            this.ShowToolbarCheckBox.TabIndex = 3;
            this.ShowToolbarCheckBox.Text = "Show Toolbar";
            this.ShowToolbarCheckBox.UseVisualStyleBackColor = true;
            // 
            // FirstLineNumberNumericUpDown
            // 
            this.FirstLineNumberNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstLineNumberNumericUpDown.Location = new System.Drawing.Point(141, 114);
            this.FirstLineNumberNumericUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.FirstLineNumberNumericUpDown.Name = "FirstLineNumberNumericUpDown";
            this.FirstLineNumberNumericUpDown.Size = new System.Drawing.Size(56, 23);
            this.FirstLineNumberNumericUpDown.TabIndex = 4;
            this.FirstLineNumberNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // firstLineNumberLabel
            // 
            this.firstLineNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstLineNumberLabel.AutoSize = true;
            this.firstLineNumberLabel.Location = new System.Drawing.Point(3, 116);
            this.firstLineNumberLabel.Name = "firstLineNumberLabel";
            this.firstLineNumberLabel.Size = new System.Drawing.Size(96, 15);
            this.firstLineNumberLabel.TabIndex = 5;
            this.firstLineNumberLabel.Text = "First line number";
            // 
            // HighlightedLinesTextBox
            // 
            this.HighlightedLinesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighlightedLinesTextBox.Location = new System.Drawing.Point(6, 169);
            this.HighlightedLinesTextBox.Name = "HighlightedLinesTextBox";
            this.HighlightedLinesTextBox.Size = new System.Drawing.Size(191, 23);
            this.HighlightedLinesTextBox.TabIndex = 6;
            this.HighlightedLinesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HighlightedLinesTextBoxValidating);
            // 
            // HighlightedLinesLabel
            // 
            this.HighlightedLinesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighlightedLinesLabel.AutoSize = true;
            this.HighlightedLinesLabel.Location = new System.Drawing.Point(3, 142);
            this.HighlightedLinesLabel.Name = "HighlightedLinesLabel";
            this.HighlightedLinesLabel.Size = new System.Drawing.Size(97, 15);
            this.HighlightedLinesLabel.TabIndex = 7;
            this.HighlightedLinesLabel.Text = "Highlighted lines";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // CollapseCodeCheckBox
            // 
            this.CollapseCodeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CollapseCodeCheckBox.AutoSize = true;
            this.CollapseCodeCheckBox.Location = new System.Drawing.Point(4, 198);
            this.CollapseCodeCheckBox.Name = "CollapseCodeCheckBox";
            this.CollapseCodeCheckBox.Size = new System.Drawing.Size(102, 19);
            this.CollapseCodeCheckBox.TabIndex = 8;
            this.CollapseCodeCheckBox.Text = "Collapse Code";
            this.CollapseCodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SmartSourceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CollapseCodeCheckBox);
            this.Controls.Add(this.HighlightedLinesLabel);
            this.Controls.Add(this.HighlightedLinesTextBox);
            this.Controls.Add(this.firstLineNumberLabel);
            this.Controls.Add(this.FirstLineNumberNumericUpDown);
            this.Controls.Add(this.ShowToolbarCheckBox);
            this.Controls.Add(this.ShowLineNumbersCheckBox);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.EditorButton);
            this.Name = "SmartSourceEditor";
            ((System.ComponentModel.ISupportInitialize)(this.FirstLineNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditorButton;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.CheckBox ShowLineNumbersCheckBox;
        private System.Windows.Forms.CheckBox ShowToolbarCheckBox;
        private System.Windows.Forms.NumericUpDown FirstLineNumberNumericUpDown;
        private System.Windows.Forms.Label firstLineNumberLabel;
        private System.Windows.Forms.TextBox HighlightedLinesTextBox;
        private System.Windows.Forms.Label HighlightedLinesLabel;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.CheckBox CollapseCodeCheckBox;
    }
}
