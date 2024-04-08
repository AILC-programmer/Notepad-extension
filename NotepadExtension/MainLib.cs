using Explorer.PluginManager;
using System.Drawing;

namespace NotepadExtension
{
    [Command("Notepad")]
    [ShortcutKeys('N')]
    [ToolTipText("Notepad plulgin")]
    public class MainLib : ICommand
    {
        public void run()
        {
            new MainForm().Show();
        }

        public Image setImage()
        {
            return Properties.Resources.AILC_notepad_Icon;
        }
    }
}
