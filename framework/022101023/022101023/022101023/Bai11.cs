using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_10_trang_64
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvXE.SelectedNode.Text == "SH")
            {
                lvDANHSACH.Items.Clear();
                lvDANHSACH.Items.Add("Ducati");
                lvDANHSACH.Items[0].SubItems.Add("2012");
                lvDANHSACH.Items[0].SubItems.Add("125");
                lvDANHSACH.Items[0].SubItems.Add("40000000");

                lvDANHSACH.Items.Add("Ducati");
                lvDANHSACH.Items[1].SubItems.Add("2013");
                lvDANHSACH.Items[1].SubItems.Add("125");
                lvDANHSACH.Items[1].SubItems.Add("42000000");
            }
            if (tvXE.SelectedNode.Text == "Spacy")
            {
                lvDANHSACH.Items.Clear();
                lvDANHSACH.Items.Add("Yamaha");
                lvDANHSACH.Items[0].SubItems.Add("2014");
                lvDANHSACH.Items[0].SubItems.Add("150");
                lvDANHSACH.Items[0].SubItems.Add("52000000");
            }
            if (tvXE.SelectedNode.Text == "Innova")
            {
                lvDANHSACH.Items.Clear();
                lvDANHSACH.Items.Add("Toyo");
                lvDANHSACH.Items[0].SubItems.Add("2013");
                lvDANHSACH.Items[0].SubItems.Add("100");
                lvDANHSACH.Items[0].SubItems.Add("150000000");
            }
            if (tvXE.SelectedNode.Text == "Camry")
            {
                lvDANHSACH.Items.Clear();
                lvDANHSACH.Items.Add("Huyndai");
                lvDANHSACH.Items[0].SubItems.Add("2012");
                lvDANHSACH.Items[0].SubItems.Add("300");
                lvDANHSACH.Items[0].SubItems.Add("200000000");

                lvDANHSACH.Items.Add("Huynhdai");
                lvDANHSACH.Items[1].SubItems.Add("2015");
                lvDANHSACH.Items[1].SubItems.Add("400");
                lvDANHSACH.Items[1].SubItems.Add("500000000");
            }


            decimal tong = 0;
            for (int i = 0; i < lvDANHSACH.Items.Count; i++)
            {
                tong += Convert.ToDecimal(lvDANHSACH.Items[i].SubItems[3].Text) * nuSoluong.Value;
            }

            lbTongTien.Text = string.Format("{0:#,##0}", tong) + "VNĐ";




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbbPhuongthucthanhtoan.Items.Add("Trả góp");
            cbbPhuongthucthanhtoan.Items.Add("Thẻ tín dụng");
            cbbPhuongthucthanhtoan.Items.Add("Tiền mặt");
        }

        private void btDatHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông tin xe gồm: \n" + "Hãng: " + lvDANHSACH.Items[0].Text + "\n"
                                                   + "Năm sản xuất: " + lvDANHSACH.Items[0].SubItems[1].Text + "\n"
                                                   + "Động cơ: " + lvDANHSACH.Items[0].SubItems[2].Text + "\n"
                                                   + "Giá: " + lvDANHSACH.Items[0].SubItems[3].Text + "\n"
                                                   + "Số lượng: " + nuSoluong.Value.ToString() + "\n"
                                                   + "Phương thức thanh toán: " + cbbPhuongthucthanhtoan.Text + "\n"
                                                   + "Tổng tiền: " + lbTongTien.Text
                                                   , "Thông báo");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lvDANHSACH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
