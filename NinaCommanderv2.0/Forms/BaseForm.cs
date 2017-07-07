using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ZBobb;
using System.IO;
using System.Diagnostics;
using ZBobb;

namespace NinaCommanderv2._0
{
    public partial class BaseForm : Form
    {
        private const int WM_DEVICECHANGE = 0x219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVTYP_VOLUME = 0x00000002;
        private Diagnostics diagnostics = new Diagnostics();
        private SelectDrives drives = new SelectDrives();
        private Content list = new Content();
        private string startPathL = "C:\\";
        private string startPathR = "C:\\";
        private ListView LeftContent = new ListView();
        private ListView RightContent = new ListView();
        private EditMenu menu = new EditMenu();
        private ContextMenu context = new ContextMenu();
        int items;

        public BaseForm()
        {
            InitializeComponent();
            diagnostics.getDiagnosticPanel(DiagnosticPanel);

            //leftdrives
            drives.getDrives(LeftDrives, LeftPath);

            //rightdrives
            drives.getDrives(RightDrives, RightPath);

            //leftcontent
            LeftContent = list.getContent(1, 1, LeftContent, LeftContentPanel, LeftPath, startPathL);
            LeftContent.KeyDown += new KeyEventHandler((sender, e) => keypressed(sender, e, LeftPath, LeftPath.Text, LeftContent));
            LeftContent.MouseClick += new MouseEventHandler((sender, e) => Leftcontent_rightClick(sender, e, LeftContent, LeftPath, startPathL));
            LeftContent.MouseDoubleClick += new MouseEventHandler((sender, e) => LeftContent_MouseDoubleClick(sender, e, LeftPath, startPathL, LeftContent));
            ListViewColoring.colorListViewHeader(ref LeftContent, Color.FromArgb(54, 54, 54), Color.White);
            items = LeftContent.Items.Count;

            //rightcontent
            RightContent = list.getContent(1, 1, RightContent, RightContentPanel, RightPath, startPathR);
            RightContent.KeyDown += new KeyEventHandler((sender, e) => keypressed(sender, e, RightPath, RightPath.Text, RightContent));
            RightContent.MouseClick += new MouseEventHandler((sender, e) => Leftcontent_rightClick(sender, e, RightContent, RightPath, startPathR));
            RightContent.MouseDoubleClick += new MouseEventHandler((sender, e) => LeftContent_MouseDoubleClick(sender, e, RightPath, startPathR, RightContent));
            ListViewColoring.colorListViewHeader(ref RightContent, Color.FromArgb(54, 54, 54), Color.White);

            systemtimer.Start();

        
    }
        private void LeftContent_MouseDoubleClick(object sender, MouseEventArgs e, AlphaBlendTextBox Path, string dirPath, ListView list)
        {
            menu.open(sender, e, Path, dirPath, list);
        }

        private void Leftcontent_rightClick(object sender, MouseEventArgs e, ListView leftContent, AlphaBlendTextBox path, string startPathL)
        {
            if (e.Button == MouseButtons.Right)
            {
                context.getContectMenu(leftContent, e, path, startPathL);
            }
        }

        private void keypressed(object sender, KeyEventArgs e, AlphaBlendTextBox path,  string destination, ListView listView)
        {
            menu.copy(sender, e, destination, startPathL, listView);
            menu.move(sender, e, destination, startPathL, listView);
            menu.delete(sender, e, startPathL, listView);
            menu.compress(sender, e, startPathL, listView);
            if (e.KeyCode == Keys.Enter)
            {
                menu.openRightClick(path, startPathL, listView);
            }
            if (e.KeyCode == Keys.F3)
            {
                SearchForm searching = new SearchForm(startPathL);
                searching.Show();
            }

            if (e.KeyCode == Keys.F4)
            {
                menu.getPath(startPathL, listView);
                Rename rename = new Rename(menu.getPath(startPathL, listView));
                rename.Show();
            }

            if (e.KeyCode == Keys.F7)
            {
                NewDirectory newdir = new NewDirectory(startPathL);
                newdir.Show();
                
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.Image = Properties.Resources.exit_over;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.Image = Properties.Resources.exit;
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize.Image = Properties.Resources.down_over;
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.Image = Properties.Resources.down;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_DEVICECHANGE:
                    switch ((int)m.WParam)
                    {
                        case DBT_DEVICEARRIVAL:
                            DiagnosticPanel.Controls.Clear();
                            LeftDrives.Controls.Clear();
                            RightDrives.Controls.Clear();
                            drives.getDrives(LeftDrives, LeftPath);
                            drives.getDrives(RightDrives, RightPath);
                            diagnostics.getDiagnosticPanel(DiagnosticPanel);


                            int devType = Marshal.ReadInt32(m.LParam, 4);
                            if (devType == DBT_DEVTYP_VOLUME)
                            {
                                DevBroadcastVolume vol;
                                vol = (DevBroadcastVolume)
                                   Marshal.PtrToStructure(m.LParam,
                                   typeof(DevBroadcastVolume));
                            }

                            break;

                        case DBT_DEVICEREMOVECOMPLETE:
                            DiagnosticPanel.Controls.Clear();
                            LeftDrives.Controls.Clear();
                            RightDrives.Controls.Clear();
                            drives.getDrives(LeftDrives, LeftPath);
                            drives.getDrives(RightDrives, RightPath);
                            diagnostics.getDiagnosticPanel(DiagnosticPanel);
                            break;

                    }
                    break;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FileAttributes attrL = File.GetAttributes(@"" + LeftPath.Text);
            FileAttributes attrR = File.GetAttributes(@"" + RightPath.Text);
            int itemsCounted = LeftContent.Items.Count;

            if ((attrL & FileAttributes.Directory) == FileAttributes.Directory )
            {
                if (startPathL != LeftPath.Text)
                {
                    try
                    {
                        ListView newcontent = new ListView();
                        newcontent = list.getContent(1, 1, LeftContent, LeftContentPanel, LeftPath, LeftPath.Text);

                        startPathL = LeftPath.Text;
                        LeftContent.Clear();
                        LeftContent = list.getContent(1, 1, LeftContent, LeftContentPanel, LeftPath, startPathL);
                        LeftContentPanel.Controls.Add(LeftContent);
                        ListViewColoring.colorListViewHeader(ref LeftContent, Color.FromArgb(54, 54, 54), Color.White);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        LeftPath.Text = startPathL;
                        CustomException exception = new CustomException(ex.Message);
                    }

                }
            }
            else
            {
                if (startPathL != LeftPath.Text)
                {
                    string getFilePath = LeftPath.Text;
                    LeftPath.Text = startPathL;

                    try
                    {
                        Process startApp = new Process();
                        startApp.StartInfo.FileName = @"" + getFilePath;
                        startApp.Start();
                    }
                    catch (Exception ex)
                    {
                        CustomException exception = new CustomException(ex.Message);
                    }

                }

            }

            filewatcher.RunWorkerAsync();
            //watcher.Changed += new FileSystemEventHandler(OnChanged);

        }

        private delegate void OnChangedHandler(object sender, FileSystemEventArgs e);
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (InvokeRequired){
                Invoke(new OnChangedHandler(OnChanged), new object[] { sender, e });
                
        }
            
            else
            {
                LeftContent.Clear();
                LeftContent = list.getContent(1, 1, LeftContent, LeftContentPanel, LeftPath, startPathL);
                LeftContentPanel.Controls.Add(LeftContent);
                ListViewColoring.colorListViewHeader(ref LeftContent, Color.FromArgb(54, 54, 54), Color.White);
            }
            
        }

        private void LeftPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            systemtimer.Stop();
            if (e.KeyChar == (char)13)
            {
                if (startPathL != LeftPath.Text)
                {
                    startPathL = LeftPath.Text;
                    LeftContent.Clear();
                    char lastChar = startPathL[startPathL.Length - 1];
                    if (lastChar != '\\')
                    {
                        startPathL += "\\";
                        LeftPath.Text += "\\";
                    }
                    LeftContent = list.getContent(1, 1, LeftContent, LeftContentPanel, LeftPath, startPathL);
                    LeftContentPanel.Controls.Add(LeftContent);
                    ListViewColoring.colorListViewHeader(ref LeftContent, Color.FromArgb(54, 54, 54), Color.White);
                    systemtimer.Start();

                }
            }
            
        }

        private void filewatcher_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker filewatcher = sender as BackgroundWorker;
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = startPathL;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.EnableRaisingEvents = true;
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnChanged);
            watcher.Changed += new FileSystemEventHandler(OnChanged);

        }
    }
}
