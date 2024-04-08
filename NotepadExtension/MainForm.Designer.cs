namespace NotepadExtension
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
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.MaximizeLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TextAreaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ButtomToolStrip = new System.Windows.Forms.ToolStrip();
            this.CharactersLabel = new System.Windows.Forms.ToolStripLabel();
            this.WordsCountLabel = new System.Windows.Forms.ToolStripLabel();
            this.LInesCountLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DocumentsCountLabel = new System.Windows.Forms.ToolStripLabel();
            this.FileEncodingLabel = new System.Windows.Forms.ToolStripLabel();
            this.SaveSituationLabel = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.UITitle = new System.Windows.Forms.Label();
            this.TopBarPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TopToolStrip.SuspendLayout();
            this.ButtomToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.SlateGray;
            this.TopBarPanel.Controls.Add(this.UITitle);
            this.TopBarPanel.Controls.Add(this.MinimizeLabel);
            this.TopBarPanel.Controls.Add(this.MaximizeLabel);
            this.TopBarPanel.Controls.Add(this.CloseLabel);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1159, 31);
            this.TopBarPanel.TabIndex = 0;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseDown);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.Location = new System.Drawing.Point(1076, 6);
            this.MinimizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(20, 18);
            this.MinimizeLabel.TabIndex = 2;
            this.MinimizeLabel.Text = "̶";
            this.MinimizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            this.MinimizeLabel.MouseEnter += new System.EventHandler(this.MinimizeLabel_MouseEnter);
            this.MinimizeLabel.MouseLeave += new System.EventHandler(this.MinimizeLabel_MouseLeave);
            // 
            // MaximizeLabel
            // 
            this.MaximizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeLabel.Location = new System.Drawing.Point(1104, 6);
            this.MaximizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximizeLabel.Name = "MaximizeLabel";
            this.MaximizeLabel.Size = new System.Drawing.Size(20, 18);
            this.MaximizeLabel.TabIndex = 1;
            this.MaximizeLabel.Text = "■";
            this.MaximizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaximizeLabel.Click += new System.EventHandler(this.MaximizeLabel_Click);
            this.MaximizeLabel.MouseEnter += new System.EventHandler(this.MaximizeLabel_MouseEnter);
            this.MaximizeLabel.MouseLeave += new System.EventHandler(this.MaximizeLabel_MouseLeave);
            // 
            // CloseLabel
            // 
            this.CloseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseLabel.BackColor = System.Drawing.Color.Transparent;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.Location = new System.Drawing.Point(1132, 6);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(20, 18);
            this.CloseLabel.TabIndex = 1;
            this.CloseLabel.Text = "X";
            this.CloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TextAreaRichTextBox);
            this.MainPanel.Controls.Add(this.TopToolStrip);
            this.MainPanel.Controls.Add(this.ButtomToolStrip);
            this.MainPanel.Controls.Add(this.menuStrip1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 31);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1159, 672);
            this.MainPanel.TabIndex = 1;
            // 
            // TextAreaRichTextBox
            // 
            this.TextAreaRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextAreaRichTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAreaRichTextBox.Location = new System.Drawing.Point(0, 55);
            this.TextAreaRichTextBox.Name = "TextAreaRichTextBox";
            this.TextAreaRichTextBox.Size = new System.Drawing.Size(1159, 592);
            this.TextAreaRichTextBox.TabIndex = 4;
            this.TextAreaRichTextBox.Text = "";
            this.TextAreaRichTextBox.TextChanged += new System.EventHandler(this.TextAreaRichTextBox_TextChanged);
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.BackColor = System.Drawing.Color.CadetBlue;
            this.TopToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.TopToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TopToolStrip.Location = new System.Drawing.Point(0, 28);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(1159, 27);
            this.TopToolStrip.TabIndex = 4;
            this.TopToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NotepadExtension.Properties.Resources.close_circle_fill;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Close the current text document";
            this.toolStripButton1.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // ButtomToolStrip
            // 
            this.ButtomToolStrip.BackColor = System.Drawing.Color.SlateGray;
            this.ButtomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ButtomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CharactersLabel,
            this.WordsCountLabel,
            this.LInesCountLabel,
            this.toolStripSeparator1,
            this.DocumentsCountLabel,
            this.FileEncodingLabel,
            this.SaveSituationLabel});
            this.ButtomToolStrip.Location = new System.Drawing.Point(0, 647);
            this.ButtomToolStrip.Name = "ButtomToolStrip";
            this.ButtomToolStrip.Size = new System.Drawing.Size(1159, 25);
            this.ButtomToolStrip.TabIndex = 3;
            this.ButtomToolStrip.Text = "toolStrip1";
            // 
            // CharactersLabel
            // 
            this.CharactersLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CharactersLabel.Name = "CharactersLabel";
            this.CharactersLabel.Size = new System.Drawing.Size(48, 22);
            this.CharactersLabel.Text = "Chars:";
            // 
            // WordsCountLabel
            // 
            this.WordsCountLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.WordsCountLabel.Name = "WordsCountLabel";
            this.WordsCountLabel.Size = new System.Drawing.Size(70, 22);
            this.WordsCountLabel.Text = "Worlds: 0";
            // 
            // LInesCountLabel
            // 
            this.LInesCountLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LInesCountLabel.Name = "LInesCountLabel";
            this.LInesCountLabel.Size = new System.Drawing.Size(42, 22);
            this.LInesCountLabel.Text = "Lines";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // DocumentsCountLabel
            // 
            this.DocumentsCountLabel.BackColor = System.Drawing.Color.SlateGray;
            this.DocumentsCountLabel.Name = "DocumentsCountLabel";
            this.DocumentsCountLabel.Size = new System.Drawing.Size(84, 22);
            this.DocumentsCountLabel.Text = "Documents";
            // 
            // FileEncodingLabel
            // 
            this.FileEncodingLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FileEncodingLabel.Name = "FileEncodingLabel";
            this.FileEncodingLabel.Size = new System.Drawing.Size(71, 22);
            this.FileEncodingLabel.Text = "Encoding";
            this.FileEncodingLabel.Visible = false;
            // 
            // SaveSituationLabel
            // 
            this.SaveSituationLabel.Name = "SaveSituationLabel";
            this.SaveSituationLabel.Size = new System.Drawing.Size(111, 22);
            this.SaveSituationLabel.Text = "toolStripLabel1";
            this.SaveSituationLabel.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTextToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeTabToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTextToolStripMenuItem
            // 
            this.newTextToolStripMenuItem.Name = "newTextToolStripMenuItem";
            this.newTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTextToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.newTextToolStripMenuItem.Text = "New text";
            this.newTextToolStripMenuItem.Click += new System.EventHandler(this.newTextToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.closeTabToolStripMenuItem.Text = "Close tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.fontStyleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontColorToolStripMenuItem.Text = "Font color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // fontStyleToolStripMenuItem
            // 
            this.fontStyleToolStripMenuItem.Name = "fontStyleToolStripMenuItem";
            this.fontStyleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontStyleToolStripMenuItem.Text = "Font style";
            this.fontStyleToolStripMenuItem.Click += new System.EventHandler(this.fontStyleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // UITitle
            // 
            this.UITitle.AutoSize = true;
            this.UITitle.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UITitle.Location = new System.Drawing.Point(5, 5);
            this.UITitle.Name = "UITitle";
            this.UITitle.Size = new System.Drawing.Size(156, 21);
            this.UITitle.TabIndex = 3;
            this.UITitle.Text = "Notepad (AILC)";
            this.UITitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 703);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseDown);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.ButtomToolStrip.ResumeLayout(false);
            this.ButtomToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label MaximizeLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.RichTextBox TextAreaRichTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip ButtomToolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontStyleToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripLabel WordsCountLabel;
        private System.Windows.Forms.ToolStripLabel LInesCountLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel CharactersLabel;
        private System.Windows.Forms.ToolStripLabel DocumentsCountLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel FileEncodingLabel;
        private System.Windows.Forms.ToolStripLabel SaveSituationLabel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label UITitle;
    }
}