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
    public partial class Delete : Form
    {
        public Delete(string source)
        {
            InitializeComponent();
            beSure.Text = "Are you sure you want to delete: " + source;
            beSure.Cursor = Cursors.Arrow;
            beSure.ForeColor = Color.White;
            yes.Click += new EventHandler((sender, e) => yes_Click(sender, e, source));
            
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

        private void yes_Click(object sender, EventArgs e, string source)
        {
            FileAttributes attr = File.GetAttributes(@"" + source);

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                DirectoryDelete(source);
            }
            else
            {
                File.Delete(source);
            }
            System.Threading.Thread.Sleep(1000);
            Close();
        }

        private void yes_MouseEnter(object sender, EventArgs e)
        {
            yes.Image = Properties.Resources.ok_over;
        }

        private void yes_MouseLeave(object sender, EventArgs e)
        {
            yes.Image = Properties.Resources.ok;
        }

        private void no_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void no_MouseEnter(object sender, EventArgs e)
        {
            no.Image = Properties.Resources.exit_over_dialog;
        }

        private void no_MouseLeave(object sender, EventArgs e)
        {
            no.Image = Properties.Resources.exit_dialog;
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
