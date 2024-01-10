using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoBackup
{
    public partial class Form1 : Form
    {
        string pathFrom,pathTo;
        string[] files;
        public Form1()
        {
            InitializeComponent();
        }

        
        

           private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            pathFrom=textBox1.Text;
            pathTo = textBox2.Text;
            if (Directory.Exists(pathFrom))
            {
                string[] foldery = Directory.GetDirectories(pathFrom);
                string[] pliki = Directory.GetFiles(pathFrom);

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
                System.Windows.Forms.MessageBox.Show("b³êdna œcie¿ka wejœciowa");
            }

            

            if (Directory.Exists(pathTo))
            {
                string[] foldery = Directory.GetDirectories(pathTo);
                string[] pliki = Directory.GetFiles(pathTo);

                listBox2.Items.Add("Foldery: ");

                foreach (string folder in foldery)
                {
                    listBox2.Items.Add(folder);
                }
                listBox2.Items.Add("");
                listBox2.Items.Add("");
                listBox2.Items.Add("");
                listBox2.Items.Add("Pliki: ");

                foreach (string element in pliki)
                {

                    listBox2.Items.Add(element);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("b³êdna œcie¿ka wyjœciowa");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "z")
            {
                textBox1.Text = string.Empty;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "do")
            {
                textBox2.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}