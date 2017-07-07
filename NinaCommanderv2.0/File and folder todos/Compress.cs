using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinaCommanderv2._0
{
    class Compress
    {


        string getPath;
        string destination;
        string pw;
        public Compress(string path, string destination, string pw)
        {
            getPath = path;
            this.destination = destination;
            this.pw = pw;
        }

        public void CompressingFolderZip(string getExtension)
        {

            FileAttributes attr = File.GetAttributes(@"" + getPath);

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                CompressingFolder(getPath, destination, pw);

            }
            else
            {
                CompressingFile(getPath, destination, pw);
            }

        }
        public void CompressingFolder(string path, string destination, string pw)
        {
            using (ZipFile zip = new ZipFile())
            {
                string password = "";
                if (isPwAdded(pw))
                {
                    password = pw;
                }
                zip.Password = password;
                DirectoryInfo dir = new DirectoryInfo(path);
                zip.AddDirectory(path, dir.Name);
                zip.Save(destination);
            }
        }

        public void CompressingFile (string path, string destination, string pw)
        {
            using (ZipFile zip = new ZipFile())
            {
                if (isPwAdded(pw))
                {
                    zip.Password = pw;
                }
                FileInfo file = new FileInfo(path);
                zip.AddFile(path).FileName = file.Name;
                zip.Save(destination);
            }
        }
        public bool isPwAdded(string pw)
        {
            if (pw == "add password if you want..." || pw == "")
            {
                return false;
            }
            return true;
        }
    }
}
