using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NotepadExtension
{
    internal static class Documents
    {
        static SaveFileDialog saveDialog = new SaveFileDialog();

        static List<string> documents = new List<string>();
        static List<string> textFiles = new List<string>();

        public static int Count { get => documents.Count + textFiles.Count; }

        public static string CreateNew(ref string text)
        {
            var name = $"New text {textFiles.Count + 1}";
            if (string.IsNullOrEmpty(text))
                text = "This is new text document";
            textFiles.Add(name);
            return name;
        }

        public static void Remove(DocumentModel model)
        {
            if (!model.IsSaved)
                Save(model);

            if (textFiles.Contains(model.Path))
                textFiles.Remove(model.Path);
            else if (documents.Contains(model.Path))
                documents.Remove(model.Path);
        }

        public static string Open(params string[] paths)
        {
            foreach (var path in paths)
            {

            }
            return "";
        }

        public static void Open(string path, out string text, out Encoding encoding)
        {
            try
            {
                text = "";
                encoding = Encoding.UTF8;
                open(path, ref text, ref encoding);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This method can open text files
        /// </summary>
        /// <param name="encoding">Set the files encoding parameter</param>
        /// <param name="text">Set the Text parameter</param>
        /// <returns>This method returns the file path</returns>

        public static string Open(out Encoding encoding, out string text)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            text = "";
            encoding = null;

            openDialog.Title = "Open one text document";
            openDialog.Filter = "Text file|*.txt|All files|*.*";

            var lastPath = Properties.Settings.Default.LastOpenPath;

            if (!string.IsNullOrEmpty(lastPath))
                openDialog.InitialDirectory = lastPath;

            openDialog.Multiselect = false;

            if (openDialog.ShowDialog() != DialogResult.OK) return null;
            return open(openDialog.FileName, ref text, ref encoding);
        }

        private static string open(string path, ref string text, ref Encoding encoding)
        {
            try
            {
                if (documents.Contains(path)) throw new System.Exception
                       ($"The file with name: ({Path.GetFileNameWithoutExtension(path)}) was opened.");

                Properties.Settings.Default.LastOpenPath =
                    Path.GetFullPath(Path.Combine(path, ".."));
                Properties.Settings.Default.Save();

                using (var stream = new StreamReader(path))
                {
                    encoding = stream.CurrentEncoding;
                    text = stream.ReadToEnd();
                }
                documents.Add(path);
                return path;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Save(DocumentModel model)
        {
            bool changed = false;
            try
            {
                if (documents.Contains(model.Path))
                {
                    if (File.Exists(model.Path))
                        File.Delete(model.Path);
                    File.WriteAllText(model.Path, model.Text, model.Encoding);
                    return;
                }

                if (textFiles.Contains(model.Path))
                {
                    textFiles.Remove(model.Path);
                    documents.Add(model.Path);
                    changed = true;
                }
                save(model.Path, model.Text, model.Encoding);
            }
            catch (Exception ex)
            {
                if (changed)
                {
                    documents.Remove(model.Path);
                    textFiles.Add(model.Path);
                }
                throw ex;
            }
        }

        public static void SaveAs(DocumentModel model)
        {
            bool changed = false;
            try
            {
                if (textFiles.Contains(model.Path))
                {
                    textFiles.Remove(model.Path);
                    documents.Add(model.Path);
                    changed = true;
                }
                save(model.Path, model.Text, model.Encoding);
            }
            catch (Exception ex)
            {
                if (changed)
                {
                    documents.Remove(model.Path);
                    textFiles.Add(model.Path);
                }
                throw ex;
            }
        }

        private static void save(string path, string text, Encoding encoding)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.InitialDirectory = path;
                saveDialog.Filter = "Text file|*.txt|All files|*.*";
                saveDialog.FileName = Path.GetFileName(path);

                if (saveDialog.ShowDialog() == DialogResult.OK)

                    using (StreamWriter writer = new StreamWriter(saveDialog.OpenFile(), encoding))
                        writer.Write(text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
