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
    public partial class CompressForm : Form
    {
        public CompressForm(string path)
        {
            InitializeComponent();
            getPath.Text = path;
            zip.CheckedChanged += new EventHandler((sender, e) => ARadioButton_CheckedChanged(sender, e, path));
            tar.CheckedChanged += new EventHandler((sender, e) => ARadioButton_CheckedChanged(sender, e, path));
            gz.CheckedChanged += new EventHandler((sender, e) => ARadioButton_CheckedChanged(sender, e, path));
            compressingBG.DoWork += new DoWorkEventHandler((sender, e) => compressingBG_DoWork(sender, e, getPath.Text, after.Text));
            progress.ProgressColor = Color.FromArgb(255, 90, 0);
            progress.Hide();

        }

        private void compressingBG_DoWork(object sender, DoWorkEventArgs e, string path, string destination)
        {
            progress.Show();
            Compress compressingBG = new Compress(getPath.Text, after.Text, pw.Text);
            compressingBG.CompressingFolderZip(after.Text);
        }

        protected void ARadioButton_CheckedChanged(object sender, EventArgs e, string path)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    after.Text = getCompressExtension(path);
                }
            }
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
            string afterText = "After compression: ";

            compressingBG.RunWorkerAsync();
            for (int i = 0; i <= 100; i++)
            {
                compressingBG.ReportProgress(i);
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

        private string getCompressExtension(string path)
        {

            string ex = "";
            if (zip.Checked)
            {
                ex = "zip";
            }
            if (tar.Checked)
            {
                ex = "tar";
            }
            if (gz.Checked)
            {
                ex = "gz";
            }

            FileAttributes attr = File.GetAttributes(@"" + path);

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                after.Text = path.Substring(0, path.Length - 1);
            }
            else
            {
                after.Text = path.Substring(0, path.Length - 4);
            }

            string result = after.Text += "." + ex;
            return result;
        }

        private void compressingBG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            progresstext.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void compressingBG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }

        private void pw_Enter(object sender, EventArgs e)
        {
            pw.Text = "";
            pw.ForeColor = Color.Black;
            pw.PasswordChar = '*';
        }
    }
}
