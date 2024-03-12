using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoBackup
{
    public partial class Form1 : Form
    {
        string pathFrom,pathTo;
        string[] files;
        ChangeList ChangeListWindow;
        public Form1()
        {
            InitializeComponent();
            
        }

        string[] DirFrom;
        string[] FilesFrom;
        string[] DirTo;
        string[] FilesTo;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            pathFrom=textBox1.Text;
            pathTo = textBox2.Text;
            if (Directory.Exists(pathFrom))
            {
                DirFrom = Directory.GetDirectories(pathFrom);
                FilesFrom = Directory.GetFiles(pathFrom);

                listBox1.Items.Add("Foldery: ");

                foreach (string dir in DirFrom)
                {
                    listBox1.Items.Add(dir);
                }
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("Pliki: ");

                foreach (string element in FilesFrom)
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
                DirTo = Directory.GetDirectories(pathTo);
                FilesTo = Directory.GetFiles(pathTo);

                listBox2.Items.Add("Foldery: ");

                foreach (string element in DirTo)
                {
                    listBox2.Items.Add(element);
                }
                listBox2.Items.Add("");
                listBox2.Items.Add("");
                listBox2.Items.Add("");
                listBox2.Items.Add("Pliki: ");

                foreach (string element in FilesTo)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(DirFrom!=null&&DirTo!=null&&FilesFrom!=null&&FilesTo!=null)
            {
                List<string> CopyListD = new List<string>();
                List<string> CopyListF = new List<string>();
                bool check = true;
                foreach (string element in DirFrom)
                {
                    check = true;
                    foreach (string element2 in DirTo)
                    {

                        if (element == element2)
                        {
                            check = false;
                        }


                    }

                    if (check)
                    {
                        CopyListD.Add(element);
                    }


                }

                foreach (string element in FilesFrom)
                {
                    check = true;
                    foreach (string element2 in FilesTo)
                    {

                        if (element == element2)
                        {
                            check = false;
                        }


                    }

                    if (check)
                    {
                        CopyListF.Add(element);
                    }
                    
                }
                ChangeListWindow = new ChangeList();
                ChangeListWindow.CopyListD=CopyListD;
                ChangeListWindow.CopyListF=CopyListF;
                ChangeListWindow.pathTo=pathTo;
                ChangeListWindow.pathFrom=pathFrom;
                ChangeListWindow.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("b³êdna œcie¿ka wejœciowa");

            }



        }
    }
}