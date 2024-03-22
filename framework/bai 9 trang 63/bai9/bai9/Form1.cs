namespace bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbLoaiMonAn.Items.Add("Việt Nam");
            cbbLoaiMonAn.Items.Add("Hàn Quốc");
            cbbLoaiMonAn.Items.Add("Trung Quốc");


        }

        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiMonAn.SelectedIndex == 0)
            {
                clbChiTietMonAn.Items.Clear();
                clbChiTietMonAn.Items.Add("Gỏi cuốn");
                clbChiTietMonAn.Items.Add("Bánh Flan");
                clbChiTietMonAn.Items.Add("Bún thịt nướng");
                clbChiTietMonAn.Items.Add("Gà hấp chao");
            }
            if (cbbLoaiMonAn.SelectedIndex == 1)
            {
                clbChiTietMonAn.Items.Clear();
                clbChiTietMonAn.Items.Add("Su shi");
                clbChiTietMonAn.Items.Add("Canh rong biển");
                clbChiTietMonAn.Items.Add("Kim chi");
                clbChiTietMonAn.Items.Add("Cơm trộn");
            }
            if (cbbLoaiMonAn.SelectedIndex == 2)
            {
                clbChiTietMonAn.Items.Clear();
                clbChiTietMonAn.Items.Add("Mì vịt tiềm");
                clbChiTietMonAn.Items.Add("Mì xào giòn");
                clbChiTietMonAn.Items.Add("Bánh canh vịt");
                clbChiTietMonAn.Items.Add("Hột vịt lộn");
            }
        }
        int kiemtra(string tenmonan, ListView lv)
        {
            int vitri = -1; //khai bao khong thuoc trong vi tri checklistbox
            int sodong = lv.Items.Count;
            for (int i = 0; i < sodong; i++)

                if (tenmonan == lv.Items[i].SubItems[0].Text)
                {
                    vitri = i;
                    break;
                }
            return vitri;
        }
        private void clbChiTietMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvMonAnDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btChon_Click(object sender, EventArgs e)
        {
            int sodong = clbChiTietMonAn.CheckedItems.Count;
            for (int i = 0; i < sodong; i++)
            {
                string tenmonan = clbChiTietMonAn.CheckedItems[i].ToString();
                int vitri = kiemtra(tenmonan, lvMonAnDaChon);

                if (vitri == -1)
                {
                    //thêm 1 dòng mới vào listview lvmonandachon
                    ListViewItem lv = new ListViewItem(tenmonan);
                    lv.SubItems.Add(nuSoLuong.Value.ToString());
                    lvMonAnDaChon.Items.Add(lv);
                }
                else
                {
                    //cập nhật số lượng món ăn ngay dòng vị trí
                    int soluong_hientai = int.Parse(lvMonAnDaChon.Items[vitri].SubItems[1].Text);
                    int soluong_moi = soluong_hientai + (int)nuSoLuong.Value;
                    lvMonAnDaChon.Items[vitri].SubItems[1].Text = soluong_moi.ToString();
                }
            }
        }
        private void btBoChon_Click(object sender, EventArgs e)
        {
            int soluongdongchon = lvMonAnDaChon.SelectedItems.Count;
            for (int  i = soluongdongchon -1; i >= 0;i--)
            {
                int soluong = int.Parse(lvMonAnDaChon.SelectedItems[i].SubItems[1].Text);
                if (soluong > 1)
                {
                    lvMonAnDaChon.SelectedItems[i].SubItems[1].Text = (soluong - 1).ToString();
                }
                else
                {
                    lvMonAnDaChon.Items.RemoveAt(lvMonAnDaChon.SelectedIndices[i]);
                }
            }
        }
        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn tạo mới ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                lvMonAnDaChon.Items.Clear();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xoá mới ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
