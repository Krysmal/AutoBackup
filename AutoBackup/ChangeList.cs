using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup
{
    public partial class ChangeList : Form
    {
        public List<string> CopyList { get; set; }
        
        public ChangeList()
        {
            InitializeComponent();

            this.Load+=new EventHandler(DataLoad);

            
            
        }
        
        public void DataLoad(object sender, EventArgs e)
        {
            listBox1.DataSource = this.CopyList;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
