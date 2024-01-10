using System.Windows.Forms;
using System.Xml.Linq;

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
                string[] foldery = Directory.GetDirectories(path);
                string[] pliki = Directory.GetFiles(path);



                listBox1.Items.Add("Foldery: ");

                foreach (string folder in foldery)
                {
                    listBox1.Items.Add(folder);
                }
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("Pliki: ");

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