using File_Extension_Checker.assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        //-------------------------Variables-----------------------------
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
        private List<fileObject> fileCorrection = new List<fileObject>();
        public static List<string> fileHexData = new List<string>();
        OpenFileDialog ofd = new OpenFileDialog();
        //-------------------------Variables-----------------------------
        //-------------------------Functions-----------------------------
        private void clearall()
        {
            txt_output.Text = "";
        }
        private string FileByteScan(string filedirectory)
        {
            try
            {
                using (var file = File.Open(filedirectory, FileMode.Open))
                {
                    int i = 0;
                    int bytes;
                    string eachfilehex = "";
                    while ((bytes = file.ReadByte()) >= 0)
                    {

                        i++;
                        string s = bytes.ToString("X");
                        if (s.Length < 2)
                        {
                            s = "0" + s;
                        }
                        eachfilehex = eachfilehex + s;
                        if (i == 16)
                        {
                            return eachfilehex;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("File Un-readable: "+e);
            }
            return "";
        }
    //-------------------------Functions-----------------------------
    //-------------------------Form Events-----------------------------
    private void btn_SelectFiles_Click(object sender, EventArgs e)
        {
            clearall();
            ofd.Multiselect = true;
            ofd.ShowDialog();
            foreach (string file in ofd.FileNames)
            {
                txt_output.Text += Path.GetFileName(file);
                txt_output.Text += Environment.NewLine;
                fileObjects.Add(new fileObject(Path.GetExtension(file), file, FileByteScan(file)));
            } 
        }
        private void btn_ScanFiles_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileObjects.Count-1; i++)
            {
                for (int j = 0; j < filetpyes.Count-1; j++)
                {
                    if (fileObjects[i].fileHeaderInfo.Contains(filetpyes[j].fileHeader))
                    {
                        if (fileObjects[i].fileExtension!=filetpyes[j].fileExtention)
                        {
                            fileObjects[i].fileExtension = filetpyes[j].fileExtention;
                            fileCorrection.Add(fileObjects[i]);
                            txt_output.Text += "File type did not match extension :" +Path.GetFileName(fileObjects[i].fileDirectory)+" : "+ filetpyes[j].fileExtention;
                            txt_output.Text += Environment.NewLine;
                        }
                        
                    }

                }
            }
        }
        private void btn_FixFIles_Click(object sender, EventArgs e)
        {

        }
        //-------------------------Form Events-----------------------------
    }
}
