using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinaCommanderv2._0
{
    public partial class Property : Form
    {
        long getSize = 0;
        long size1 = 0;
        public Property(string path)
        {
            InitializeComponent();
            calcSpace.DoWork += new DoWorkEventHandler((sender, e) => calcSpace_DoWork(sender, e, path, HasSubfolder(path)));
            ok.Click += new EventHandler((sender, e) => ok_Click(sender, e, path));
            isReadOnlych.Checked = false;
            isHiddench.Checked = false;

            FileAttributes attr = File.GetAttributes(@"" + path);

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                icon.Image = Properties.Resources.prop_folder;
                fillDirProperties(path);
            }
            else
            {
                icon.Image = Properties.Resources.prop_file;
                fillFileProperties(path);
            }

        }

        private void fillDirProperties(string path)
        {
            calcSpace.RunWorkerAsync();

            DirectoryInfo directory = new DirectoryInfo(path);
            location.Text = directory.Parent.FullName;
            size.Text = "Calculating ...";
            created.Text = directory.CreationTime.ToString();
            modified.Text = directory.LastAccessTime.ToString();
            name.Text = directory.Name;
            bool isReadOnly = ((File.GetAttributes(path) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly);
            bool isHidden = ((File.GetAttributes(path) & FileAttributes.Hidden) == FileAttributes.Hidden);

            if (isReadOnly)
            {
                isReadOnlych.Checked = true;
            }
            if (isHidden)
            {
                isHiddench.Checked = true;
            }

        }

        private void fillFileProperties(string path)
        {
            string[] pathSplit = path.Split('\\');
            string newPath = "";
            for (int i = 0; i < pathSplit.Length - 1; i++)
            {
                newPath += pathSplit[i] += "\\";
            }

            FileInfo file = new FileInfo(path);

            location.Text = newPath;
            size.Text = getDirSpace(file.Length);
            created.Text = file.CreationTime.ToString();
            modified.Text = file.LastAccessTime.ToString();
            name.Text = file.Name;
            bool isReadOnly = ((File.GetAttributes(path) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly);
            bool isHidden = ((File.GetAttributes(path) & FileAttributes.Hidden) == FileAttributes.Hidden);

            if (isReadOnly)
            {
                isReadOnlych.Checked = true;
            }
            if (isHidden)
            {
                isHiddench.Checked = true;
            }

        }

        private long getDirectorySize(string path, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            if (!dir.Exists)
            {
                ErrorForm error = new ErrorForm("Directory does not exist!");
                error.Show();
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                size1 += file.Length;
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    getDirectorySize(subdir.FullName, copySubDirs);
                }
            }
            return size1;
        }
        static bool HasSubfolder(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] subdirs = directory.GetDirectories();
            return (subdirs.Length != 0);
        }

        private void calcSpace_DoWork(object sender, DoWorkEventArgs e, string path, bool hasSub)
        {
            getSize = getDirectorySize(path, hasSub);
        }

        private void calcSpace_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            size.Text = getDirSpace(getSize);
        }

        public string getDirSpace(long size)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            long len = size;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            return result;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.Image = Properties.Resources.exit_over_dialog;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.Image = Properties.Resources.exit_dialog;
        }

        private void ok_MouseEnter(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok_over;
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok;
        }

        private void ok_Click(object sender, EventArgs e, string path)
        {
            File.SetAttributes(path, FileAttributes.Normal);

            if (isReadOnlych.Checked)
            {
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.ReadOnly);
            }
            if (isHiddench.Checked)
            {
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
            }
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }
    }
}
