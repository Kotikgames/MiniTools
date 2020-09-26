using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace MiniTools
{
    public partial class FileTextFind : Form
    {
        private List<string> filesList = new List<string>();
        private bool StopAll = false;
        public FileTextFind()
        {
            InitializeComponent();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            foreachFiles.RunWorkerAsync();
        }

        private void addFiles_Click(object sender, EventArgs e) => openFileDialog.ShowDialog();

        private void foreachFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            files.Groups.Clear();
            panel.Enabled = false;
            foreach (string s in openFileDialog.FileNames)
            {
                if (StopAll) break;
                filesList.Add(s);
                ListViewItem item = new ListViewItem(new string[] { Path.GetFileName(s), "" });
                files.Items.Add(item);
            }
            panel.Enabled = true;
        }

        private void foreachFilesFromDir_DoWork(object sender, DoWorkEventArgs e)
        {
            files.Groups.Clear();
            panel.Enabled = false;
            foreach (string s in Directory.GetFiles(addDirDialog.SelectedPath, "*.*", SearchOption.TopDirectoryOnly))
            {
                if (StopAll) break;
                filesList.Add(s);
                ListViewItem item = new ListViewItem(new string[] { Path.GetFileName(s), ""});
                files.Items.Add(item);
            }
            panel.Enabled = true;
        }

        private void addDir_Click(object sender, EventArgs e)
        {
            if(addDirDialog.ShowDialog() == DialogResult.OK)
            {
                foreachFilesFromDir.RunWorkerAsync();
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            files.Groups.Clear();
            find.RunWorkerAsync();
        }   private void find_DoWork(object sender, DoWorkEventArgs e)
        {
            files.Items.Clear();
            panel.Enabled = false;
            foreach (string path in filesList)
            {
                if (StopAll) break;
                string text = File.ReadAllText(path);
                Regex regex = new Regex(findText.Text, RegexOptions.IgnoreCase);
                ListViewGroup group = new ListViewGroup(Path.GetFileName(path));
                files.Groups.Add(group);

                foreach (Match match in regex.Matches(text))
                {
                    ListViewItem item = new ListViewItem(new string[] { Path.GetFileName(path), (match.Index+1).ToString() }, group);
                    files.Items.Add(item);
                }
            }
            panel.Enabled = true;
        }

        private void FileTextFind_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAll = true;
        }
    }
}
