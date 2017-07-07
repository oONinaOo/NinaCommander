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
    public partial class Rename : Form
    {
        private string path;
        public Rename(string path)
        {
            InitializeComponent();
            this.path = path;
            
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

        private void ok_Click(object sender, EventArgs e)
        {
            FileAttributes attr = File.GetAttributes(@"" + path);

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                string[] pathSplit = path.Split('\\');
                string newPath = "";
                for (int i = 0; i < pathSplit.Length - 1; i++)
                {
                    newPath += pathSplit[i] += "\\";
                }
                DirectoryInfo dir = new DirectoryInfo(path);
                dir.MoveTo(dir.Parent.FullName + "\\" + newName.Text);
            }
            else
            {
                string[] pathSplit = path.Split('\\');
                string newPath = "";
                for (int i = 0; i < pathSplit.Length - 1; i++)
                {
                    newPath += pathSplit[i] += "\\";
                }
                FileInfo file = new FileInfo(path);
                file.MoveTo(newPath + newName.Text + file.Extension);
            }
            System.Threading.Thread.Sleep(1000);
            Close();
        }

        private void ok_MouseEnter(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok_over;
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok;
        }

 
    }
}
