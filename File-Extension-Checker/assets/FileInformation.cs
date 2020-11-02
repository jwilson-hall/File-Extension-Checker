using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Extension_Checker.assets
{
    class FileInformation
    {
        public Dictionary<string, string> headerPlusExtension { get; set; } = new Dictionary<string, string> { { ".png", "89504E47" },{ ".jpg", "FFD8FF" } };
        public void main()
        {
            
        }
    }
}
