using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBobb;

namespace NinaCommanderv2._0
{
    class EditMenu
    {
        public void open(object sender, MouseEventArgs e, AlphaBlendTextBox Path, string dirPath, ListView list)
        {
            var senderList = (ListView)sender;
            var clickedItem = senderList.HitTest(e.Location).Item;
            string clicked = clickedItem.Text.ToString();
            string getPath = "";

            if (clicked.StartsWith("["))
            {
                if (clicked == "[..]")
                {
                    string[] currentPath = dirPath.Split('\\');
                    for (int i = 0; i < currentPath.Length - 2; i++)
                    {
                        getPath += currentPath[i];
                        getPath += "\\";
                    }
                    Path.Text = getPath;
                }
                else
                {
                    getPath = clicked.Substring(1, clicked.Length - 2);
                    Path.Text = dirPath + getPath + "\\";
                }

            }
            else
            {

                Path.Text = dirPath + clicked;
            }

        }

        public void openRightClick(AlphaBlendTextBox Path, string dirPath, ListView list)
        {
            string clicked = "";

            foreach (ListViewItem item in list.SelectedItems)
            {
                clicked = item.Text;
            }
            string getPath = "";

            if (clicked.StartsWith("["))
            {
                if (clicked == "[..]")
                {
                    string[] currentPath = dirPath.Split('\\');
                    for (int i = 0; i < currentPath.Length - 2; i++)
                    {
                        getPath += currentPath[i];
                        getPath += "\\";
                    }
                    Path.Text = getPath;
                }
                else
                {
                    getPath = clicked.Substring(1, clicked.Length - 2);
                    Path.Text = dirPath + getPath + "\\";
                }

            }
            else
            {
                Path.Text = dirPath + clicked;
            }
        }
        public void copy(object sender, KeyEventArgs e, string destination, string dirPath, ListView list)
        {

            ListView lvTemp = (ListView)sender;
            string selected = "";
            string getPath = "";
            if (e.KeyCode == Keys.F5)
            {
                foreach (ListViewItem item in list.SelectedItems)
                {
                    selected += item.Text;

                }
                if (selected.StartsWith("["))
                {
                    if (selected == "[..]")
                    {
                        
                    }
                    else
                    {
                        getPath = dirPath + selected.Substring(1, selected.Length - 2 ) + "\\*.*";
                    }

                }
                else
                {
                    getPath = dirPath + selected;
                }
                CopyAndMove copy = new CopyAndMove(getPath, destination + "*.*", "copy");
                copy.Show();
            }
        }
        public void copyRightClick(AlphaBlendTextBox destination, string dirPath, ListView list)
        {
            string selected = "";
            string getPath = "";
            foreach (ListViewItem item in list.SelectedItems)
            {
                selected += item.Text;

            }
            if (selected.StartsWith("["))
            {
                if (selected == "[..]")
                {

                }
                else
                {
                    getPath = dirPath + selected.Substring(1, selected.Length - 2) + "\\*.*";
                }

            }
            else
            {
                getPath = dirPath + selected;
            }
            string destinationPath = destination.Text;
            CopyAndMove copy = new CopyAndMove(getPath, destinationPath + "*.*", "copy");
            copy.Show();
        }

        public void move(object sender, KeyEventArgs e, string destination, string dirPath, ListView list)
        {
            ListView lvTemp = (ListView)sender;
            string selected = "";
            string getPath = "";
            if (e.KeyCode == Keys.F6)
            {
                foreach (ListViewItem item in list.SelectedItems)
                {
                    selected += item.Text;

                }
                if (selected.StartsWith("["))
                {
                    if (selected == "[..]")
                    {

                    }
                    else
                    {
                        getPath = dirPath + selected.Substring(1, selected.Length - 2) + "\\*.*";
                    }

                }
                else
                {
                    getPath = dirPath + selected;
                }
                CopyAndMove copy = new CopyAndMove(getPath, destination + "*.*", "move");
                copy.Show();
            }
        }
        public void moveRightClick(AlphaBlendTextBox destination, string dirPath, ListView list)
        {
            string selected = "";
            string getPath = "";
            foreach (ListViewItem item in list.SelectedItems)
            {
                selected += item.Text;

            }
            if (selected.StartsWith("["))
            {
                if (selected == "[..]")
                {

                }
                else
                {
                    getPath = dirPath + selected.Substring(1, selected.Length - 2) + "\\*.*";
                }

            }
            else
            {
                getPath = dirPath + selected;
            }
            string destinationPath = destination.Text;
            CopyAndMove copy = new CopyAndMove(getPath, destinationPath + "*.*", "move");
            copy.Show();
        }
        public void delete(object sender, KeyEventArgs e, string dirPath, ListView list)
        {
            ListView lvTemp = (ListView)sender;
            string selected = "";
            string getPath = "";
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in list.SelectedItems)
                {
                    selected += item.Text;

                }
                if (selected.StartsWith("["))
                {
                    if (selected == "[..]")
                    {

                    }
                    else
                    {
                        getPath = dirPath + selected.Substring(1, selected.Length - 2) + "\\";
                    }

                }
                else
                {
                    getPath = dirPath + selected;
                }
                Delete delete = new Delete(getPath);
                delete.Show();
            }
        }
        public void deleteRightClick(string dirPath, ListView list)
        {
            string selected = "";
            string getPath = "";
            foreach (ListViewItem item in list.SelectedItems)
            {
                selected += item.Text;

            }
            if (selected.StartsWith("["))
            {
               if (selected == "[..]")
                {
                }
                else
                {
                    getPath = dirPath + selected.Substring(1, selected.Length - 2) + "\\";
                }

            }
            else
            {
                getPath = dirPath + selected;
            }
            Delete delete = new Delete(getPath);
            delete.Show();
        }

        public void compress(object sender, KeyEventArgs e, string dirPath, ListView list)
        {
            ListView lvTemp = (ListView)sender;
            string selected = "";
            string getPath = "";
            if (e.KeyCode == Keys.F8)
            {
                foreach (ListViewItem item in list.SelectedItems)
                {
                    selected += item.Text;

                }
                if (selected.StartsWith("["))
                {
                    if (selected == "[..]")
                    {

                    }
                    else
                    {
                        getPath = dirPath + selected.Substring(1, selected.Length - 2) + "\\";
                    }

                }
                else
                {
                    getPath = dirPath + selected;
                }
                CompressForm compression = new CompressForm(getPath);
                compression.Show();
            }
        }

        public void decompress(string dirPath, ListView list)
        {
            string selected = "";
            string getPath = "";
            foreach (ListViewItem item in list.SelectedItems)
            {
              selected += item.Text;
            }
               
            getPath = dirPath + selected;
            DecompressForm decompression = new DecompressForm(getPath);
            decompression.Show();
        }

        public string getPath(string dirPath, ListView list)
        {
            string selected = "";
            string getPath = "";
            foreach (ListViewItem item in list.SelectedItems)
            {
                selected += item.Text;

            }
            if (selected.StartsWith("["))
            {
                if (selected == "[..]")
                {
                }
                else
                {
                    getPath = dirPath + selected.Substring(1, selected.Length - 2) + "\\";
                }

            }
            else
            {
                getPath = dirPath + selected;
            }
            return getPath;
        }
        public void encryptFile(string dirPath, ListView list)
        {
            string selected = "";
            string getPath = "";
            foreach (ListViewItem item in list.SelectedItems)
            {
                selected += item.Text;
            }
            getPath = dirPath + selected;
            FileInfo file = new FileInfo(getPath);
            file.Encrypt();
        }

        public void decryptFile(string dirPath, ListView list)
        {
            string selected = "";
            string getPath = "";
            foreach (ListViewItem item in list.SelectedItems)
            {
                selected += item.Text;
            }
            getPath = dirPath + selected;
            FileInfo file = new FileInfo(getPath);
            file.Decrypt();
        }
    }

}
