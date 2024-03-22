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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clbDSHP.Items.Add("30073_Công nghệ .NET");
            clbDSHP.Items.Add("30043_Tin học văn phòng");
            clbDSHP.Items.Add("32153_Lập trình cơ sở dữ liệu");
            clbDSHP.Items.Add("32304_Cơ sở dữ liệu");
            clbDSHP.Items.Add("31303_Toán rời rạc");
            clbDSHP.Items.Add("31323_Nhập môn lập trình");
            clbDSHP.Items.Add("31333_Kỹ thuật lập trình");
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            foreach (var item in clbDSHP.CheckedItems)
            {
                lstDadky.Items.Add(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            int tongTC = 0;
            int sodong = clbDSHP.CheckedItems.Count;

            
            for (int i = 0; i < sodong; i++)
            {
                
                string s = clbDSHP.CheckedItems[i].ToString();
                int soTC = Convert.ToInt32(s.Substring(4, 1));
                tongTC += soTC;
                tongtien += soTC * 350000;
            }
            lbTongtien.Text = tongtien.ToString("#,##0") + " VNĐ";
            lbTongTC.Text = tongTC.ToString();
        }
    }
}
