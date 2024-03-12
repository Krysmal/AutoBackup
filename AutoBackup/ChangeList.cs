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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
