using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NinaCommanderv2._0
{

    class Diagnostics
    {
        public string CalcSpace(long available, long total)
        {
            string result = "";
            if (available / 1024 / 1024 > 1000)
            {
                result += "\nFree: " + available / 1014 / 1024 / 1024 + " GB";
            }
            else
            {
                result += "\nFree: " + available / 1014 / 1024 + " MB";
            }
            if (total / 1024 / 1024 > 1000)
            {
                result += " Total: " + total / 1014 / 1024 / 1024 + " GB";
            }
            else
            {
                result += " Total: " + total / 1014 / 1024 + " MB";
            }
            return result;
        }

        public void getDiagnosticPanel(Panel DiagnosticPanel)
        {
           DriveInfo[] drives = DriveInfo.GetDrives();
            int startWidth = 10;
            int progressBarStartWidth = 82;
            int driverID = 1;
            foreach (DriveInfo driver in drives)
            {
                PictureBox actualDrive = new PictureBox();
                actualDrive.Parent = DiagnosticPanel;
                Label actualDriveText = new Label();
                Bunifu.Framework.UI.BunifuProgressBar diskSpace = new Bunifu.Framework.UI.BunifuProgressBar();
                diskSpace.BringToFront();
                diskSpace.ProgressColor = System.Drawing.Color.FromArgb(255, 90, 0);
                diskSpace.BackColor = Color.Black;
                actualDrive.Name = "actualDrive" + driverID;
                actualDriveText.Text = "Drive name: " + driver.Name + "\nType: " + driver.DriveType;

                if (driver.DriveType.ToString() == "Fixed")
                {
                    DirectoryInfo dirs = new DirectoryInfo(driver.Name.ToString());
                    DirectoryInfo [] getDirs = dirs.GetDirectories();
                    foreach (DirectoryInfo dirname in getDirs)
                    {
                        if (dirname.Name == "Windows")
                        {
                            actualDrive.Image = Properties.Resources.win;
                            continue;
                        }
                        else
                        {
                            actualDrive.Image = Properties.Resources.hdd;
                        }
                    }
                    double total = Convert.ToDouble(driver.TotalSize);
                    double free = Convert.ToDouble(driver.TotalFreeSpace);
                    diskSpace.Value = 100 - (int)Math.Ceiling(free / total * 100);
                    actualDriveText.Text += "\n" + CalcSpace(driver.TotalFreeSpace, driver.TotalSize);

                }
                if (driver.DriveType.ToString() == "Removable")
                {
                    actualDrive.Image = Properties.Resources.usb;
                    double total = Convert.ToDouble(driver.TotalSize);
                    double free = Convert.ToDouble(driver.TotalFreeSpace);
                    diskSpace.Value = 100 - (int)Math.Ceiling(free / total * 100);
                    actualDriveText.Text += "\n " + CalcSpace(driver.TotalFreeSpace, driver.TotalSize);
                }
                if (driver.DriveType.ToString() == "CDRom")
                {
                    actualDrive.Image = Properties.Resources.cd;
                    if (driver.IsReady)
                    {
                        actualDriveText.Text += "\n\n Disk inside";
                    }
                    else
                    {
                        actualDriveText.Text += "\n\n Empty drive";
                    }
                }
                actualDrive.Location = new Point(startWidth, 40);
                actualDrive.Visible = true;
                actualDrive.Width = 75;
                actualDrive.Height = 63;
                actualDriveText.Location = new Point(startWidth + 80, 40);
                actualDriveText.Width = 150;
                actualDriveText.Height = 63;
                actualDriveText.ForeColor = Color.White;
                diskSpace.Location = new Point(startWidth + 82, 70);
                diskSpace.Width = 130;
                diskSpace.Height = 8;
                DiagnosticPanel.Controls.Add(actualDrive);
                DiagnosticPanel.Controls.Add(actualDriveText);
                DiagnosticPanel.Controls.Add(diskSpace);
                driverID++;
                startWidth += 230;
                progressBarStartWidth += 230;
                actualDriveText.SendToBack();

            }
        }

    }
}
