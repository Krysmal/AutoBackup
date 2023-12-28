using System.Windows.Forms;

namespace AutoBackup
{
    public partial class Form1 : Form
    {
        string path;
        string[] files;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path=textBox1.Text;
            
            if (Directory.Exists(path))
            {
                
                string[] pliki = Directory.GetFiles(path);

               

                
                foreach (string element in pliki)
                {
                    listBox1.Items.Add(element);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("b³êdna œcie¿ka");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}