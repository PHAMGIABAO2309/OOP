namespace _022101023
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDS.Items.Add("Thịt kho trứng");
            lstDS.Items.Add("Tôm rang thịt");
            lstDS.Items.Add("Cá sốt cà");
            lstDS.Items.Add("Mực xào");
            lstDS.Items.Add("Canh cua");
        }

        private void btQuaPhai_Click(object sender, EventArgs e)
        {
            foreach (var item in lstDS.SelectedItems)
            {
                lstDaChon.Items.Add(item.ToString());
            }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            string s = "";
            int sodong = lstDaChon.Items.Count;
            s += "Họ tên: " + txtHoTen.Text + "\r\n" + "Ngày đặt: " + dtNgayDat.Text + "\r\n" + "Số món đã chọn: ";
            for (int i = 0; i < sodong; i++)
            {
                s += lstDaChon.Items[i].ToString();
                if (i < sodong - 1)
                {
                    s += ", ";
                }
            }
            lbTong.Text = sodong.ToString();
            txtThongTin.Text = s;
        }

        private void btBoChon_Click(object sender, EventArgs e)
        {
            txtThongTin.Clear();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

