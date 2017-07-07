using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ZBobb;

namespace NinaCommanderv2._0
{
    class SelectDrives
    {
        public void getDrives(Panel DrivePanel, AlphaBlendTextBox Path)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            int startWidth = 5;
            int driverID = 1;
            foreach (DriveInfo driver in drives)
            {
                Bunifu.Framework.UI.BunifuImageButton actualDrive = new Bunifu.Framework.UI.BunifuImageButton();
                actualDrive.Parent = DrivePanel;
                actualDrive.Name = "actualDrive" + driverID;
                actualDrive.BackColor = Color.Transparent;
                actualDrive.Width = 27;
                actualDrive.Height = 27;
                actualDrive.Location = new Point(startWidth, 2);
                actualDrive.Zoom = 0;
                actualDrive.Cursor = Cursors.Hand;
                actualDrive.Click += new EventHandler((sender, e) => actualDrive_Click(sender, e, Path, driver.Name, driver.IsReady));             
                
                Label DriveName = new Label();
                DriveName.Width = 35;
                DriveName.Height = 27;
                DriveName.Text = driver.Name;
                DriveName.ForeColor = Color.White;
                DriveName.BackColor = Color.Transparent;
                DriveName.Location = new Point(startWidth + actualDrive.Width + 5, 10);



                if (driver.DriveType.ToString() == "Fixed")
                {
                    actualDrive.Image = Properties.Resources.mini_hdd;
                }
                if (driver.DriveType.ToString() == "Removable")
                {
                    actualDrive.Image = Properties.Resources.mini_usb;
                }
                if (driver.DriveType.ToString() == "CDRom")
                {
                    actualDrive.Image = Properties.Resources.mini_cd;
                }
                driverID++;
                startWidth += 67;
                DrivePanel.Controls.Add(actualDrive);
                DrivePanel.Controls.Add(DriveName);

            }
        }
        void actualDrive_Click(object sender, EventArgs e, AlphaBlendTextBox Path, string name, bool ready)
        {

            Bunifu.Framework.UI.BunifuImageButton buttonThatWasClicked = (Bunifu.Framework.UI.BunifuImageButton)sender;
            if (ready)
            {
                Path.Text = name;
            }
            else
            {
                CustomException exception = new CustomException("Drive is not ready!");
            }
            

        }

    }
}
