using System.IO;
using System.Windows.Forms;

namespace FolderCompare
{
    public class ReadFolder
    {
        public FileInfo[] Files { get; private set; }
        public string SelectFolder(string folder)
        {
            string selected = "";
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (!string.IsNullOrEmpty(folder))
                    folderBrowser.SelectedPath = folder;
                DialogResult result = folderBrowser.ShowDialog();
                if (result == DialogResult.OK)
                    selected = folderBrowser.SelectedPath;
            }
            return selected;
        }

        public void GetFiles(string folder)
        {
            Files = null;
            DirectoryInfo info;
            info = new DirectoryInfo(folder);
            Files = info.GetFiles();
        }
    }
}
