using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NinaCommanderv2._0
{
    class ListViewColoring
    {
        //List view header formatters
        public static void colorListViewHeader(ref ListView list, Color backColor, Color foreColor)
        {
            ColumnHeader name = new ColumnHeader();
            ColumnHeader modified = new ColumnHeader();
            ColumnHeader size = new ColumnHeader();
            name.Width = 210;
            modified.Width = 150;
            size.Width = 143;
            name.Text = "Name";
            modified.Text = "Modified";
            size.Text = "Size (KB)";
            list.Columns.Add(name);
            list.Columns.Add(modified);
            list.Columns.Add(size);
            list.OwnerDraw = true;
            list.DrawColumnHeader +=
                new DrawListViewColumnHeaderEventHandler
                (
                    (sender, e) => headerDraw(sender, e, backColor, foreColor)
                );
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);

        }
        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);
            e.Graphics.DrawString(e.Header.Text, e.Font, new SolidBrush(foreColor), e.Bounds);
            Color normalBorder = SystemColors.InactiveBorder;
            Brush borderBrush = new SolidBrush(normalBorder);
            e.Graphics.DrawLine(new Pen(borderBrush, 2.0F), e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            e.Graphics.DrawLine(new Pen(borderBrush, 2.0F), e.Bounds.X, e.Bounds.Y, e.Bounds.Left, e.Bounds.Right);
            e.Graphics.DrawLine(new Pen(borderBrush, 2.0F), e.Bounds.Left, e.Bounds.Top + 1, e.Bounds.Right, e.Bounds.Top + 1);

        }
        private static void bodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

    }
}
