namespace bài_8_trang_62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbLoaiThucUong.Items.Add("Nước uống");
            cbbLoaiThucUong.Items.Add("Nước ép");
            cbbLoaiThucUong.Items.Add("Sinh tố");
        }

        int kiemtra(string tenthucuong, ListView lv)
        {
            int vitri = -1;
            int sodong = lv.Items.Count;
            for (int i = 0; i < sodong; i++)

                if (tenthucuong == lv.Items[i].SubItems[0].Text)
                {
                    vitri = i;
                    break;
                }
            return vitri;
        }

        private void cbbLoaiThucUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiThucUong.SelectedIndex == 0)
            {
                lvMenu.Items.Clear();
                lvMenu.Items.Add("1");
                lvMenu.Items[0].SubItems.Add("Cà phê");
                lvMenu.Items[0].SubItems.Add("10000");
                lvMenu.Items.Add("2");
                lvMenu.Items[1].SubItems.Add("Cà phê sữa");
                lvMenu.Items[1].SubItems.Add("12000");
                lvMenu.Items.Add("3");
                lvMenu.Items[2].SubItems.Add("Sting");
                lvMenu.Items[2].SubItems.Add("9000");
            }
            if (cbbLoaiThucUong.SelectedIndex == 1)
            {
                lvMenu.Items.Clear();
                lvMenu.Items.Add("1");
                lvMenu.Items[0].SubItems.Add("Ép dâu");
                lvMenu.Items[0].SubItems.Add("15000");
                lvMenu.Items.Add("2");
                lvMenu.Items[1].SubItems.Add("Ép thơm");
                lvMenu.Items[1].SubItems.Add("17000");
                lvMenu.Items.Add("3");
                lvMenu.Items[2].SubItems.Add("Ép bưởi");
                lvMenu.Items[2].SubItems.Add("19000");
            }
            if (cbbLoaiThucUong.SelectedIndex == 2)
            {
                lvMenu.Items.Clear();
                lvMenu.Items.Add("1");
                lvMenu.Items[0].SubItems.Add("Sinh tố bơ");
                lvMenu.Items[0].SubItems.Add("21000");
                lvMenu.Items.Add("2");
                lvMenu.Items[1].SubItems.Add("Sinh tố dưa hấu");
                lvMenu.Items[1].SubItems.Add("33000");
                lvMenu.Items.Add("3");
                lvMenu.Items[2].SubItems.Add("Sinh tố thập cẩm");
                lvMenu.Items[2].SubItems.Add("49000");
            }
        }

        private void btQuaPhai_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn một item trong ListView lvMenu chưa
            int vitri = kiemtra(lvMenu.SelectedItems[0].SubItems[1].Text, lvHoaDon);
            if (vitri == -1)
            {
                // Nếu chưa tồn tại trong danh sách hóa đơn, thêm mới vào
                int sodong = lvHoaDon.Items.Count;
                // Thêm tên món vào danh sách hóa đơn
                lvHoaDon.Items.Add(lvMenu.SelectedItems[0].SubItems[1].Text);
                // Thêm số lượng (ban đầu là 1) vào danh sách hóa đơn
                lvHoaDon.Items[sodong].SubItems.Add("1");
                // Thêm giá tiền của món vào danh sách hóa đơn
                lvHoaDon.Items[sodong].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
            }
            else
            {
                // Nếu đã tồn tại trong danh sách hóa đơn, tăng số lượng lên 1
                int soluong = int.Parse(lvHoaDon.Items[vitri].SubItems[1].Text);
                // Tính giá của một đơn vị sản phẩm
                decimal dongia = decimal.Parse(lvHoaDon.Items[vitri].SubItems[2].Text) / soluong;
                // Tăng số lượng lên 1
                lvHoaDon.Items[vitri].SubItems[1].Text = (soluong + 1).ToString();
                // Cập nhật giá tiền theo số lượng mới
                lvHoaDon.Items[vitri].SubItems[2].Text = (dongia * (soluong + 1)).ToString();
            }
        }

        private void btQuaTrai_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(lvHoaDon.Items[lvHoaDon.SelectedIndices[0]].SubItems[1].Text);
            decimal thanhtien = decimal.Parse(lvHoaDon.Items[lvHoaDon.SelectedIndices[0]].SubItems[2].Text);
            if (soluong > 1)
            {
                lvHoaDon.Items[lvHoaDon.SelectedIndices[0]].SubItems[1].Text = (soluong - 1).ToString();
                lvHoaDon.Items[lvHoaDon.SelectedIndices[0]].SubItems[2].Text = (thanhtien - thanhtien / soluong).ToString();
            }
            else
            {
                lvHoaDon.Items.RemoveAt(lvHoaDon.SelectedIndices[0]);
            }
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            int soluong = lvHoaDon.Items.Count;
            // Duyệt qua từng mục trong ListView lvHoaDon
            for (int i = 0; i < soluong; i++)
            {
                tongtien += Convert.ToInt32(lvHoaDon.Items[i].SubItems[2].Text) ;
            }
            lbTongTien.Text = tongtien.ToString();
        }

    }
}