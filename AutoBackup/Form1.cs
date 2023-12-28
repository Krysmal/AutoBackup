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
            System.Windows.Forms.MessageBox.Show(path);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}