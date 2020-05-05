using System;
using System.IO;
using System.Windows.Forms;

namespace FolderCompare
{
    public class FileData 
    {
        public FileData() { }
        public FileData(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
        }
        public string FileName { get { return FileInfo.Name; } }
        public string Extension { get { return FileInfo.Extension; } }
        public long Size { get { return FileInfo.Length; } }
        public string FullName { get { return FileInfo.FullName; } }
        public string Directory { get { return FileInfo.DirectoryName; } }
        private FileInfo FileInfo { get; set; }

        public override bool Equals(object obj)
        {
            FileData file = (FileData)obj;
            if (FileName.ToLower() == file.FileName.ToLower())
                return true;
            try
            {
                string name1 = FileName.Split('-')[1].ToLower();
                string name2 = file.FileName.Split('-')[1].ToLower();
                if (name1 == name2)
                {
                    if (MessageBox.Show($@"Partial name match:{Environment.NewLine}
                                    {FileName}{Environment.NewLine}
                                    {file.FileName}{Environment.NewLine}{Environment.NewLine}
                                    Confirm match?", "Partial match", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        return true;
                }
            }
            catch
            {
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }
        public void DeleteFile()
        {
            try
            {
                FileInfo.Delete();
            }
            catch (Exception exception)
            {
                _ = MessageBox.Show($"Unable to delete file: {Environment.NewLine}{exception.Message}");
            }
        }
    }
}
