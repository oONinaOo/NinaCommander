using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinaCommanderv2._0
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string text)
        {
            InitializeComponent();
            ErrorText.Text = text;
            ErrorText.Cursor = Cursors.Arrow;
            ErrorText.ForeColor = Color.White;
            
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

    }
}
