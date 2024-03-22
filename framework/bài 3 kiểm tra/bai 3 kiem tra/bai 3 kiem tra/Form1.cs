namespace bai_3_kiem_tra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (lvDS.SelectedItems.Count > 0)
            {
                DialogResult kq = MessageBox.Show("Bạn có chắc muốn xoá ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    lvDS.Items.RemoveAt(lvDS.SelectedIndices[0]);
                    Clear();
                }
            }

        }
        private void Clear()
        {
            txtMaHP.Clear();
            txtTenHP.Clear();
            nuSOTC.Value = 0;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
            {
                txtMaHP.Text = lvDS.SelectedItems[0].SubItems[0].Text;
                txtTenHP.Text = lvDS.SelectedItems[0].SubItems[1].Text;
                nuSOTC.Value = Convert.ToInt32(lvDS.SelectedItems[0].SubItems[2].Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvDS.Items.Add("30073");
            lvDS.Items[0].SubItems.Add("Công nghệ.Net");
            lvDS.Items[0].SubItems.Add("3");
            lvDS.Items[0].SubItems.Add("bắt buộc");

            lvDS.Items.Add("32304");
            lvDS.Items[1].SubItems.Add("Cơ sở dữ liệu");
            lvDS.Items[1].SubItems.Add("4");
            lvDS.Items[1].SubItems.Add("bắt buộc");

            lvDS.Items.Add("30043");
            lvDS.Items[2].SubItems.Add("Tin học văn phòng");
            lvDS.Items[2].SubItems.Add("3");
            lvDS.Items[2].SubItems.Add("Tự chọn");

            lvDS.Items.Add("30102");
            lvDS.Items[3].SubItems.Add("Lắp đặt và MMT");
            lvDS.Items[3].SubItems.Add("3");
            lvDS.Items[3].SubItems.Add("Tự chọn");

            lvDS.Items.Add("31003");
            lvDS.Items[4].SubItems.Add("Toán rời rạc");
            lvDS.Items[4].SubItems.Add("3");
            lvDS.Items[4].SubItems.Add("bắt buộc");
        }

        private void btQuaPhai_Click(object sender, EventArgs e)
        {
            int sophantu = lvDS.Items.Count;
            if (rdBatBuoc.Checked)
            {
                lvDS.Items.Add(txtMaHP.Text);
                lvDS.Items[sophantu].SubItems.Add(txtMaHP.Text);
                lvDS.Items[sophantu].SubItems.Add(txtTenHP.Text);
                lvDS.Items[sophantu].SubItems.Add("bắt buộc");
            }
            if (rdTuChon.Checked)
            {
                lvDS.Items.Add(txtMaHP.Text);
                lvDS.Items[sophantu].SubItems.Add(txtMaHP.Text);
                lvDS.Items[sophantu].SubItems.Add(txtTenHP.Text);
                lvDS.Items[sophantu].SubItems.Add("Tự chọn");
            }


        }


        private void btTinh_Click(object sender, EventArgs e)
        {
            int tongBB = 0;
            int tongTC = 0;
            //duyệt qua từng mục trong listview để tính tổng số tín chỉ
            foreach (ListViewItem lvDS in lvDS.Items)
            {
                //kiểm tra nếu môn học là bắt buộc(được đánh dấu "bắt buộc" trong cột thứ 4)
                if (lvDS.SubItems[3].Text == "bắt buộc")
                    tongBB += int.Parse(lvDS.SubItems[2].Text);
                
            }
            foreach (ListViewItem lvDS in lvDS.Items)
            {
                if (lvDS.SubItems[3].Text == "Tự chọn")
                    tongTC += int.Parse(lvDS.SubItems[2].Text);
            }
            lbBatBuoc.Text = tongBB.ToString();
            lbTUCHON.Text = tongTC.ToString();
        }




    }
}
