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
    public partial class CopyAndMove : Form
    {
        public CopyAndMove(string source, string destination, string action)
        {
            InitializeComponent();
            if (action == "copy")
            {
                title.Text = "Copying";
            }
            if (action == "move")
            {
                title.Text = "Move To";
            }
            ok.Click += (sender, e) => ok_Click(sender, e, source, destination);
            originalPath.Text = source;
            destinationPath.Text = destination;
            string sourcepath = originalPath.Text.Substring(0, originalPath.Text.Length - 3);
            bgwork.DoWork += new DoWorkEventHandler((sender, e) => bgwork_DoWork(sender, e, source, destination, action));
            progress.Hide();
            progresstext.Hide();
            progress.ProgressColor = Color.FromArgb(255, 90, 0);
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

        private void ok_Click(object sender, EventArgs e, string source, string destination)
        {
            progress.Show();
            progresstext.Text = progress.Value.ToString() + " %";
            progresstext.Show();
            bgwork.RunWorkerAsync();
            for (int i = 0; i <= 100; i++)
            {
                bgwork.ReportProgress(i);
            }

        }

        private void ok_MouseEnter(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok_over;
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok;
        }

        private void bgwork_DoWork(object sender, DoWorkEventArgs e, string source, string destination, string action)
        {
            if (originalPath.Text[originalPath.Text.Length-1] == '*')
            {
                string sourcepath = originalPath.Text.Substring(0, originalPath.Text.Length - 3);
                string destinationpath = destinationPath.Text.Substring(0, destinationPath.Text.Length - 3);
                DirectoryCopy(sourcepath, destinationpath, HasSubfolder(sourcepath));
                if (action == "move")
                {
                    DirectoryDelete(sourcepath);
                }
            }

            else
            {
                File.Copy(originalPath.Text, destinationPath.Text);
                if (action == "move")
                {
                    File.Delete(originalPath.Text);
                }
            }
            
        }

        private void bgwork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            progresstext.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {

            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                ErrorForm error = new ErrorForm("Directory does not exist!");
                error.Show();
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
        static bool HasSubfolder(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] subdirs = directory.GetDirectories();
            return (subdirs.Length != 0);
        }

        private void bgwork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }

        public void DirectoryDelete(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                dir.Delete(true);
            }
            directory.Delete(true);
        }
    }
}
