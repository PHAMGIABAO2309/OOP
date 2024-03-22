namespace bài_1_trang_58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Họ tên: " + textBox1.Text + " \r\n"
                + "Ngày sinh: " + textBox2.Text + " \r\n" 
                + " Sở thích: " + textBox3.Text, "Thông báo");
        }
    }
}