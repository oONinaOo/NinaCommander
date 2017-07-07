using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBobb;

namespace NinaCommanderv2._0
{
    class Content
    {
        ImageList contentImage = new ImageList();
        EditMenu menu = new EditMenu();
        private ImageList addImages(ImageList list)
        {
            contentImage.Images.Add("files", Properties.Resources.files);
            contentImage.Images.Add("folder", Properties.Resources.folder);
            contentImage.Images.Add("up", Properties.Resources.up);
            return list;
        }
        public ListView getContent(int left, int top, ListView contentPanel, Panel ContentPanel, AlphaBlendTextBox Path, string path)
        {
            addImages(contentImage);
            contentPanel.SmallImageList = contentImage;
            contentPanel.Name = "LeftContent";
            contentPanel.Location = new Point(left, top);
            contentPanel.Width = 520;
            contentPanel.Height = 348;
            contentPanel.View = View.Details;
            contentPanel.BackColor = Color.FromArgb(54, 54, 54);
            contentPanel.ForeColor = Color.White;
            ContentPanel.Controls.Add(contentPanel);
            contentPanel.BorderStyle = BorderStyle.None;
            
            if (path.Split('\\').Length != 2)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "[..]";
                item.SubItems.Add("");
                item.SubItems.Add("<DIR>");
                contentPanel.Items.Add(item);
                item.ImageKey = "up";

            }

            DirectoryInfo getDirectories = new DirectoryInfo(path);
            DirectoryInfo[] directories = getDirectories.GetDirectories();
            FileInfo[] files = getDirectories.GetFiles();

            foreach(DirectoryInfo dir in directories)
            {
                string attributes = dir.Attributes.ToString();
                string[] getAttributes = attributes.Split(',');
                string size = "<DIR>";
                long totalsize = 0;
                ListViewItem item = new ListViewItem();
                if (getAttributes[0] == "Hidden")
                {
                    item.ForeColor = Color.DarkGray;
                }
                item.Text = "[" + dir.Name + "]";
                item.SubItems.Add(dir.LastWriteTime.ToString());
                item.SubItems.Add(size);
                contentPanel.Items.Add(item);
                item.ImageKey = "folder";

            }
            foreach(FileInfo info in files)
            {
                string attributes = info.Attributes.ToString();
                string[] getAttributes = attributes.Split(',');
                long size = info.Length;
                ListViewItem item = new ListViewItem();
                if (getAttributes[0] == "Hidden")
                {
                    item.ForeColor = Color.DarkGray;
                }
                item.Text = info.Name;
                item.SubItems.Add(info.LastWriteTime.ToString());
                item.SubItems.Add(size.ToString("N0"));
                contentPanel.Items.Add(item);
                item.ImageKey = "files";
            }
            return contentPanel;

        }

    }
}
