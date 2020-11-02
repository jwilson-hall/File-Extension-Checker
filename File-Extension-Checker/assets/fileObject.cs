using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Extension_Checker.assets
{
    class fileObject
    {
        public string fileExtension { get; set; }
        public string fileHeaderInfo { get; set; }
        public string fileDirectory { get; set; }

        public fileObject(string fExtension, string fHeader, string fDirectory)
        {
            this.fileExtension = fExtension;
            this.fileDirectory = fDirectory;
            this.fileHeaderInfo = fHeader;
        }
    }
}
