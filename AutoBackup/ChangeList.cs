using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoBackup
{
    public partial class ChangeList : Form
    {
        
        public List<string> CopyListD { get; set; }
        public List<string> CopyListF { get; set; }

        public string pathTo { get; set; }

        public string pathFrom { get; set; }

        

        public ChangeList()
        {
            InitializeComponent();

            this.Load+=new EventHandler(DataLoad);

            
            
        }
        
        public void DataLoad(object sender, EventArgs e)
        {
            listBox1.Items.Add("Foldery: ");
            foreach (string item in CopyListD)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("Pliki: ");
            foreach (string item in CopyListF)
            {
                listBox1.Items.Add(item);
            }

        }
        static void CopyDir(string from, string to, bool filesToo)
        {
            

            if (!Directory.Exists(to))
            {
                Directory.CreateDirectory(to);
            }

            if(filesToo)
            {
                copyFile(from, to);
            }

            filesToo = true;


            string[] dirs = Directory.GetDirectories(from);


            foreach (string dir in dirs)
            {
                string dirName = Path.GetFileName(dir);
                string dirTo = Path.Combine(to, dirName);
                CopyDir(dir, dirTo, true);
            }
        }

        static void copyFile(string from, string to)
        {
            if (!Directory.Exists(to))
            {
                Directory.CreateDirectory(to);
            }


            string[] files = Directory.GetFiles(from);


            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string fileTo = Path.Combine(to, fileName);
                File.Copy(file, fileTo, true);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {

            CopyDir(pathFrom, pathTo, true);

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            CopyDir(pathFrom, pathTo, false);

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            copyFile(pathFrom, pathTo);

            this.Close();
        }
    }
}
