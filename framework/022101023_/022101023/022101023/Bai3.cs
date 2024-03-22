using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _022101023
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
            int soptu = lvDS.Items.Count;
            lvDS.Items.Add(txtMaHP.Text);

            lvDS.Items[soptu].SubItems.Add(txtTenHP.Text);
            lvDS.Items[soptu].SubItems.Add(nuSOTC.Value.ToString());
            if (rdTuChon.Checked == true)
            {
                lvDS.Items[soptu].SubItems.Add(rdTuChon.Text);
            }
            else
            {
                lvDS.Items[soptu].SubItems.Add(rdBatBuoc.Text);
            }
        }

        private void btQuaTrai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvDS.Items.Remove(lvDS.SelectedItems[0]);
                XoaThongTin();
            }
        }

        private void XoaThongTin()
        {
            MessageBox.Show("Thông tin đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            {
                int tongBB = 0;
                int tongTC = 0;
                foreach (ListViewItem lvDS in lvDS.Items)
                {
                    if (lvDS.SubItems[3].Text == "bắt buộc")
                        tongBB += int.Parse(lvDS.SubItems[2].Text);

                }
                foreach (ListViewItem lvDS in lvDS.Items)
                {
                    if (lvDS.SubItems[3].Text == "Tự chọn")
                        tongTC += int.Parse(lvDS.SubItems[2].Text);
                }
                lbBatBuoc.Text += tongBB.ToString();
                lbTuChon.Text += tongTC.ToString();
            }
        }
    }
}
