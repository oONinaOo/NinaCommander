using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinaCommanderv2._0
{
    public partial class SearchForm : Form
    {
        private string path;
        public SearchForm(string path)
        {
            InitializeComponent();
            this.path = path;
            searchDir.Text = path;
            pattern.Text = "*.*";
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
            result.Items.Clear();
            searchResult(pattern.Text);
        }

        private void ok_MouseEnter(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok_over;
        
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok;
        }

        public void searchResult(string text)
        {
            string pattern = text;

            DirectoryInfo dirInfo = new DirectoryInfo(searchDir.Text);

            recursiveSearch(dirInfo, pattern, result);


            if (result.Items.Count == 0)
            {
                result.Items.Add("No match found");
            }
        }

        private void recursiveSearch(DirectoryInfo dir_info, string pattern, ListBox lstResults)
        {

            try
            {
                if (!pattern.Contains("*"))
                {
                    pattern = "*" + pattern + "*";
                }
                string[] dirs = Directory.GetDirectories(@"" + dir_info.FullName, pattern);
                foreach (string dir in dirs)
                {
                    lstResults.Items.Add(dir);
                }

                string[] file_infos = Directory.GetFiles(@"" + dir_info.FullName, pattern);
                foreach (string file in file_infos)
                {
                    lstResults.Items.Add(file);
                }

                DirectoryInfo[] subdirs = dir_info.GetDirectories();
                foreach (DirectoryInfo subdir in subdirs)
                {
                    recursiveSearch(subdir, pattern, lstResults);
                }

            }
            catch
            {

            }
        }

        private void result_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process startApp = new Process();
            startApp.StartInfo.FileName = @"" + result.SelectedItem;
            startApp.Start();
        }
    }
}
