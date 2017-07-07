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
    public partial class DecompressForm : Form
    {
        public DecompressForm(string path)
        {
            InitializeComponent();
            getPath.Text = path;
            FileInfo file = new FileInfo(path);
            after.Text = file.DirectoryName + "\\" + file.Name.Split('.')[0] + "\\";
            pw.TextChanged += new EventHandler((sender, e) => pwTextChanged(sender, e, pw.Text));
            decompressingBG.DoWork += new DoWorkEventHandler((sender, e) => decompressingBG_DoWork(sender, e, getPath.Text, after.Text));
            progress.ProgressColor = Color.FromArgb(255, 90, 0);
            progress.Hide();

        }

        private void decompressingBG_DoWork(object sender, DoWorkEventArgs e, string path, string destination)
        {
            progress.Show();
            Decompress decompressing = new Decompress(getPath.Text, after.Text, pw.Text, pw);
            decompressing.DecompressingFolder(getPath.Text, after.Text, pw.Text, pw);
            if (decompressingBG.CancellationPending == true)
            {
                e.Cancel = true;
                return;
            }
        }

        private void pwTextChanged(object sender, EventArgs e, string text)
        {
            if (text == "Provide password for compressing!")
            {
                decompressingBG.CancelAsync();
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
            decompressingBG.RunWorkerAsync();
            for (int i = 0; i <= 100; i++)
            {
                decompressingBG.ReportProgress(i);
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

        private void compressingBG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            progresstext.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void compressingBG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progress.Value = 0;
                progresstext.Text = "0 %";
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }
        private void pw_Enter(object sender, EventArgs e)
        {
            pw.Text = "";
            pw.ForeColor = Color.Black;
            pw.PasswordChar = '*';
        }

    }
}
