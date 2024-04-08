using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NotepadExtension
{
    public partial class MainForm : Form
    {
        bool isMaximized = false;

        ToolStripLabel selectedDocument;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TextAreaRichTextBox.AllowDrop = true;
            TextAreaRichTextBox.DragDrop += TextAreaRichTextBox_DragDrop;
            TextAreaRichTextBox.DragEnter += TextAreaRichTextBox_DragEnter;
            SetDocDetails();
            SetSettings();
        }

        private void TextAreaRichTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TextAreaRichTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            try
            {
                string text;
                Encoding encoding;

                string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                Documents.Open(path, out text, out encoding);
                AddDocument(path, text, encoding);
                TextAreaRichTextBox.Text = text;
                TextAreaRichTextBox.SelectionStart = TextAreaRichTextBox.Text.Length;
            }
            catch (Exception ex)
            {
                Extentions.MessageBox.Run(ex.Message, "Draging file error", "", "OK");
            }
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
            => CloseLabel.BackColor = Color.Transparent;

        private void CloseLabel_MouseEnter(object sender, EventArgs e)
            => CloseLabel.BackColor = Color.Red;

        private void CloseLabel_Click(object sender, EventArgs e) => Close();

        private void MinimizeLabel_Click(object sender, EventArgs e)
            => WindowState = FormWindowState.Minimized;

        private void MaximizeLabel_Click(object sender, EventArgs e)
        {
            WindowState = isMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
            isMaximized = !isMaximized;
        }

        private void MaximizeLabel_MouseEnter(object sender, EventArgs e)
            => MaximizeLabel.BackColor = Color.LightBlue;

        private void MaximizeLabel_MouseLeave(object sender, EventArgs e)
            => MaximizeLabel.BackColor = Color.Transparent;

        private void MinimizeLabel_MouseEnter(object sender, EventArgs e)
            => MinimizeLabel.BackColor = Color.LightBlue;

        private void MinimizeLabel_MouseLeave(object sender, EventArgs e)
            => MinimizeLabel.BackColor = Color.Transparent;

        private void TextAreaRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedDocument == null) createNewDocument(TextAreaRichTextBox.Text);

            ((DocumentModel)selectedDocument.Tag).Text = TextAreaRichTextBox.Text;

            SetDocDetails(((DocumentModel)selectedDocument.Tag).Encoding);
        }

        private void TopBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TopBarPanel.Capture = this.Capture = false;

            const int wm_nclButtonDown = 0X00A1;
            const int HTCaption = 2;
            Message msg = Message.Create(Handle, wm_nclButtonDown, new IntPtr(HTCaption), IntPtr.Zero);
            DefWndProc(ref msg);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Encoding encoding;
                string text;
                string path = Documents.Open(out encoding, out text);
                AddDocument(path, text, encoding);
                TextAreaRichTextBox.Text = text;
                TextAreaRichTextBox.SelectionStart = TextAreaRichTextBox.Text.Length;
                ((DocumentModel)selectedDocument.Tag).IsSaved = true;
            }
            catch (Exception ex)
            {
                Extentions.MessageBox.Run(ex.Message, "Open");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.Save((DocumentModel)selectedDocument.Tag);
            ((DocumentModel)selectedDocument.Tag).IsSaved = true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.SaveAs((DocumentModel)selectedDocument.Tag);
            ((DocumentModel)selectedDocument.Tag).IsSaved = true;
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.Remove((DocumentModel)selectedDocument.Tag);
            TopToolStrip.Items.Remove(selectedDocument);
            TextAreaRichTextBox.Text = "";
            selectedDocument = null;

            if (TopToolStrip.Items.Count == 1)
            {
                SaveSituationLabel.Visible = false;
                FileEncodingLabel.Visible = false;
                return;
            }
            var item = TopToolStrip.Items[TopToolStrip.Items.Count - 1];
            if (!(item is ToolStripLabel)) return;

            selectedDocument = (ToolStripLabel)item;
            selectedDocument.ForeColor = Color.White;
            TextAreaRichTextBox.Text = ((DocumentModel)selectedDocument.Tag).Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            Properties.Settings.Default.BackgroundColor = colorDialog1.Color;
            Properties.Settings.Default.Save();
            SetSettings();
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            Properties.Settings.Default.FontColor = colorDialog1.Color;
            Properties.Settings.Default.Save();
            SetSettings();
        }


        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.OK) return;
            Properties.Settings.Default.Font = fontDialog1.Font;
            Properties.Settings.Default.Save();
            SetSettings();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextAreaRichTextBox.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextAreaRichTextBox.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextAreaRichTextBox.Paste();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            selectedDocument.ForeColor = Color.Black;
            selectedDocument = (ToolStripLabel)sender;
            selectedDocument.ForeColor = Color.White;
            TextAreaRichTextBox.Text = ((DocumentModel)selectedDocument.Tag).Text;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            var obj = (ToolStripLabel)sender;
            if (selectedDocument.Equals(obj)) return;

            obj.ForeColor = Color.Black;
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            var obj = (ToolStripLabel)sender;
            if (selectedDocument.Equals(obj)) return;

            obj.ForeColor = Color.PaleTurquoise;
        }

        private void newTextToolStripMenuItem_Click(object sender, EventArgs e)
         => createNewDocument();

        private void AddDocument(string path, string text, Encoding encoding)
        {
            if (string.IsNullOrEmpty(path)) return;
            var label = new ToolStripLabel();
            if (selectedDocument != null)
                selectedDocument.ForeColor = Color.Black;
            label.ForeColor = Color.White;
            string name = Extentions.Tools.NameHandler.LogicalName(Path.GetFileNameWithoutExtension(path), 20);
            label.Text = name;
            label.Tag = new DocumentModel()
            {
                Text = text,
                Encoding = encoding,
                Name = name,
                Path = path,
            };

            ((DocumentModel)label.Tag).IsSavedValueChanged += model =>
            {
                SaveSituationLabel.Visible = true;
                if (model.IsSaved)
                    SaveSituationLabel.Text = "Saved";
                else
                    SaveSituationLabel.Text = "Not saved";
            };
            label.Click += Label_Click;
            label.MouseEnter += Label_MouseEnter;
            label.MouseLeave += Label_MouseLeave;

            selectedDocument = label;
            TopToolStrip.Items.Add(label);
            SetDocDetails(encoding);
        }

        private void SetDocDetails(Encoding encoding = null)
        {
            DocumentsCountLabel.Text = $"Documents: {Documents.Count}";
            var text = TextAreaRichTextBox.Text;
            LInesCountLabel.Text = $"Lines: {Extentions.Tools.Texts.GetLines(text).Length}";
            WordsCountLabel.Text = $"Words: {Extentions.Tools.Texts.GetWords(text).Length}";
            CharactersLabel.Text = $"Chars: {text.Length}";
            if (encoding == null)
                FileEncodingLabel.Visible = false;
            else
            {
                FileEncodingLabel.Visible = true;
                FileEncodingLabel.Text = $"Encoding: {encoding.EncodingName}";
            }
        }

        void createNewDocument(string text = "")
        {
            var name = Documents.CreateNew(ref text);
            AddDocument(name, text, Encoding.UTF8);
            TextAreaRichTextBox.Text = text;
            TextAreaRichTextBox.SelectionStart = TextAreaRichTextBox.Text.Length;
        }

        void SetSettings()
        {
            TextAreaRichTextBox.BackColor = Properties.Settings.Default.BackgroundColor;
            TextAreaRichTextBox.ForeColor = Properties.Settings.Default.FontColor;
            TextAreaRichTextBox.Font = Properties.Settings.Default.Font;
        }
    }
}
