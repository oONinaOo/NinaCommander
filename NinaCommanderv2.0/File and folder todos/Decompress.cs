using Ionic.Zip;
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
    class Decompress
    {
        string getPath;
        string destination;
        string pw;
        TextBox getPw;
        public Decompress(string path, string destination, string pw, TextBox getPw)
        {
            getPath = path;
            this.destination = destination;
            this.pw = pw;
            this.getPw = getPw;
        }

        public void CompressingFolderZip(string getExtension)
        {

           DecompressingFolder(getPath, destination, pw, getPw);

        }
        public void DecompressingFolder(string path, string TargetDir, string pw, TextBox getPw)
        {
            using (ZipFile zip = ZipFile.Read(path))
            {
                foreach (ZipEntry e in zip)
                {
                    if (e.UsesEncryption)
                    {
                        if (pw == "provide password..." || pw == "")
                        {
                            getPw.Text = "Provide password for compressing!";
                            getPw.ForeColor = Color.Black;

                        }
                        else
                        {
                            e.Password = pw;
                            e.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                        }
                    }
                    else
                    {
                        e.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                    }
                    
                }
            }
        }
    }
}
