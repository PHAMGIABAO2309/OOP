namespace chức_năng_đăng_nhập__đăng_xuất
{
    public partial class FormDangNhap : Form
    {
        string tentaikhoan = "admin";
        string matkhau = "admin";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( kiemtradangnhap(textBox1.Text, textBox2.Text))
            {
                FormChuongTrinh f = new FormChuongTrinh();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                textBox1.Focus();
            }
        }

        private void F_DangXuat(object? sender, EventArgs e)
        {
            (sender as FormChuongTrinh).isthoat = false;
            (sender as FormChuongTrinh).Close();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool kiemtradangnhap(string tentaikhoan, string matkhau)
        {
            if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }
    }
}