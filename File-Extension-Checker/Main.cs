using File_Extension_Checker.assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Extension_Checker
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            Console.WriteLine();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private List<fileObject> fileObjects = new List<fileObject>();
        private List<fileType> filetpyes = new List<fileType>() {
            new fileType(".png", "89504E47"),
            new fileType(".exe", "4D5A5000"),
            new fileType(".exe", "4D5A9000"),
            new fileType(".bmp", "424DF8A9"),
            new fileType(".bmp", "424D6225"),
            new fileType(".bmp", "424D7603"),
            new fileType(".gif", "474946383961"),
            new fileType(".gif", "474946383761"),
            new fileType(".jpeg", "FFD8FFE1"),
            new fileType(".jpeg", "FFD8FFE0"),
            new fileType(".jpeg", "FFD8FFFE"),
            new fileType(".rar", "52617221"),
        };
        
        private void btn_SelectFiles_Click(object sender, EventArgs e)
        {

        }


        private void btn_ScanFiles_Click(object sender, EventArgs e)
        {

        }

        private void btn_FixFIles_Click(object sender, EventArgs e)
        {

        }
    }
}
