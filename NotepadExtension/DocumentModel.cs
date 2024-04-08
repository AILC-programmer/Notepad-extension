using System;
using System.Text;

namespace NotepadExtension
{
    internal class DocumentModel
    {
        public string Path { get; set; }

        private string text;

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                IsSaved = false;
            }
        }
        public string Name { get; set; }
        public Encoding Encoding { get; set; }

        private bool isSaved;
        public bool IsSaved
        {
            get
            {
                return isSaved;
            }
            set
            {
                isSaved = value;
                if (IsSavedValueChanged != null)
                    IsSavedValueChanged(this);
            }
        }

        public event Action<DocumentModel> IsSavedValueChanged;

    }
}
