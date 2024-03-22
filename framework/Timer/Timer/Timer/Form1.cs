namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNGAY.Text = Convert.ToString(dtNGAY.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_thoigian.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int thoigian;
        private void timer_thoigian_Tick(object sender, EventArgs e)
        {

            if (thoigian > 0)
            {
                thoigian--;
                lbTHOIGIANCONLAI.Text = " Còn lại " + thoigian.ToString() + " giây ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            thoigian = ((int)nuGIO.Value) * 3600 + ((int)nuPHUT.Value) * 60 + ((int)nuGIAY.Value);
            lbTHOIGIANCONLAI.Text = " Còn lại: " + thoigian.ToString() + " giây ";
        }
    }
}