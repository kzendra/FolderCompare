using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FolderCompare
{
    public partial class Form1 : Form
    {
        ReadFolder read = new ReadFolder();
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(OnFormClose);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBaseFolder.Text = Config.BaseFolder;
            lblCompareFolder.Text = Config.CompareFolder;
            if (!string.IsNullOrEmpty(Config.BaseFolder))
                gridBase.DataSource = GetFiles(Config.BaseFolder);
            if (!string.IsNullOrEmpty(Config.CompareFolder))
                gridCompare.DataSource = GetFiles(Config.CompareFolder);
        }

        private void BtnSelectBase_Click(object sender, EventArgs e)
        {
            (gridBase.DataSource, lblBaseFolder.Text) = SelectFolder(Config.BaseFolder);

        }
        private void BtnSelectCompare_Click(object sender, EventArgs e)
        {
            (gridCompare.DataSource, lblCompareFolder.Text) = SelectFolder(Config.CompareFolder);
        }

        private (List<FileData>, string) SelectFolder(string selected)
        {
            string folder = read.SelectFolder(selected);
            return (GetFiles(folder), folder); 
        }
        private List<FileData> GetFiles(string selected)
        {
            List<FileData> files = new List<FileData>();
            read.GetFiles(selected);
            if (read.Files != null)
                files = read.Files.Select(x => new FileData(x)).ToList();
            return files;
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {

            Config.BaseFolder = lblBaseFolder.Text;
            Config.CompareFolder = lblCompareFolder.Text;
        }

        private void BtnCompareFolders_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblBaseFolder.Text) || string.IsNullOrEmpty(lblCompareFolder.Text))
            { 
                MessageBox.Show("Select both folders before rnning compare");
                return;
            }
            List<FileData> compareFolder = GetFiles(lblCompareFolder.Text);
            List<FileData> baseFolder = GetFiles(lblBaseFolder.Text);
            foreach (var fileData in compareFolder)
            {
                lblComparingFile.Text = fileData.FileName;
                lblComparingFile.Refresh();
                if (baseFolder.Contains(fileData))
                    fileData.DeleteFile();
            }
        }
    }
}
