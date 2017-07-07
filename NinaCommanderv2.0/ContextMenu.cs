using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBobb;

namespace NinaCommanderv2._0
{
    class ContextMenu
    {
        EditMenu menu = new EditMenu();
        public void getContectMenu(ListView contentPanel, MouseEventArgs ep, AlphaBlendTextBox Path, string path)
        {
            ContextMenuStrip rightClickMenu = new ContextMenuStrip();
            rightClickMenu.Items.Clear();

            rightClickMenu.Items.Add("Open").Name = "Open";
            int indexopen = rightClickMenu.Items.IndexOfKey("Open");
            rightClickMenu.Items[indexopen].Image = Properties.Resources.open;

            rightClickMenu.Items.Add("Copy").Name = "Copy";
            int indexcopy = rightClickMenu.Items.IndexOfKey("Copy");
            rightClickMenu.Items[indexcopy].Image = Properties.Resources.copy;

            rightClickMenu.Items.Add("Move").Name = "Move";
            int indexmove = rightClickMenu.Items.IndexOfKey("Move");
            rightClickMenu.Items[indexmove].Image = Properties.Resources.move;

            rightClickMenu.Items.Add("Delete").Name = "Delete";
            int indexdelete = rightClickMenu.Items.IndexOfKey("Delete");
            rightClickMenu.Items[indexdelete].Image = Properties.Resources.delete;



            string clicked = "";

            foreach (ListViewItem item in contentPanel.SelectedItems)
            {
                clicked = item.Text;
            }
            if (!clicked.StartsWith("["))
            {
                FileInfo file = new FileInfo(path + clicked);
                if (file.Extension == ".zip" || file.Extension == ".gz" || file.Extension == ".tar")
                {
                    rightClickMenu.Items.Add("Decompress").Name = "Decompress";
                    int indexdecompress = rightClickMenu.Items.IndexOfKey("Decompress");
                    rightClickMenu.Items[indexdecompress].Image = Properties.Resources.decompress;
                }

                if (file.Attributes.HasFlag(FileAttributes.Encrypted)) {
                    rightClickMenu.Items.Add("Decrypt").Name = "Decrypt";
                    int indexdecrypt = rightClickMenu.Items.IndexOfKey("Decrypt");
                    rightClickMenu.Items[indexdecrypt].Image = Properties.Resources.decrypt;
                }
                if (!file.Attributes.HasFlag(FileAttributes.Encrypted))
                {
                    rightClickMenu.Items.Add("Encrypt").Name = "Encrypt";
                    int indexencrypt = rightClickMenu.Items.IndexOfKey("Encrypt");
                    rightClickMenu.Items[indexencrypt].Image = Properties.Resources.encrypt;
                }
            }

            rightClickMenu.Items.Add("Properties").Name = "Properties";

            int indexprop = rightClickMenu.Items.IndexOfKey("Properties");
            rightClickMenu.Items[indexprop].Font = new Font(rightClickMenu.Font, FontStyle.Bold);
            rightClickMenu.Items[indexprop].Image = Properties.Resources.prop;

            rightClickMenu.ItemClicked += new ToolStripItemClickedEventHandler((sender, e) => item_Click(sender, e, ep, Path, path, contentPanel, rightClickMenu));

            Point pt = contentPanel.PointToScreen(ep.Location);

            rightClickMenu.Show(pt);

        }
        public void item_Click(Object sender, ToolStripItemClickedEventArgs e, MouseEventArgs ep, AlphaBlendTextBox Path, string dirPath, ListView list, ContextMenuStrip rightClickMenu)
        {
            switch(e.ClickedItem.Name.ToString())
            {
                case "Open":

                    menu.openRightClick(Path, dirPath, list);
                    break;

                case "Copy":

                    menu.copyRightClick(Path, dirPath, list);
                    break;

                case "Move":

                    menu.moveRightClick(Path, dirPath, list);
                    break;

                case "Delete":

                    menu.deleteRightClick(dirPath, list);
                    break;

                case "Properties":

                    Property properties = new Property(menu.getPath(dirPath,list));
                    properties.Show();
                    break;

                case "Decompress":

                    menu.decompress(dirPath, list);
                    break;

                case "Encrypt":

                    menu.encryptFile(dirPath, list);
                    break;

                case "Decrypt":

                    menu.decryptFile(dirPath, list);
                    break;



            }
            
            
        }

    }
}
