namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void btHIENTHI_Click(object sender, EventArgs e)
        {
            pic2.Load("D:\picture\nagumo.png");
        }

        private void btTHOAT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}