using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5trang60_update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if(rd_monan.Checked == true)
            {
                ls_monan.Items.Add(txt_tenmon.Text);
            }
            else if (rd_nuocuong.Checked == true)
            {
                ls_nuocuong.Items.Add(txt_tenmon.Text);
            }
        }

        private void bt_traiquaphai_Click(object sender, EventArgs e)
        {

                ls_nuocuong.Items.Add(ls_monan.SelectedItem);
                ls_monan.Items.RemoveAt(ls_monan.SelectedIndex);
        }

        private void bt_phaiquatrai_Click(object sender, EventArgs e)
        { 
                ls_monan.Items.Add(ls_nuocuong.SelectedItem);
                ls_nuocuong.Items.RemoveAt(ls_nuocuong.SelectedIndex);
        }
    }
}
