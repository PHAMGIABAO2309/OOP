using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022101023
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
            int vitri = kiemtra(lvMenu.SelectedItems[0].SubItems[1].Text, lvHoaDon);
            if (vitri == -1)
            {
                int sodong = lvHoaDon.Items.Count;
                lvHoaDon.Items.Add(lvMenu.SelectedItems[0].SubItems[1].Text);
                lvHoaDon.Items[sodong].SubItems.Add("1");
                lvHoaDon.Items[sodong].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
            }
            else
            {
                int soluong = int.Parse(lvHoaDon.Items[vitri].SubItems[1].Text);
                decimal dongia = decimal.Parse(lvHoaDon.Items[vitri].SubItems[2].Text) / soluong;
                lvHoaDon.Items[vitri].SubItems[1].Text = (soluong + 1).ToString();
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
            for (int i = 0; i < soluong; i++)
            {
                tongtien += Convert.ToInt32(lvHoaDon.Items[i].SubItems[2].Text);
            }
            lbTongTien.Text = tongtien.ToString();
        }
    }
}
