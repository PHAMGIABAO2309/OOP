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
    public partial class listview : Form
    {
        public listview()
        {
            InitializeComponent();
        }

        private void listview_Load(object sender, EventArgs e)
        {

        }

        private void lv_monan_Click(object sender, EventArgs e)
        {
           nu_sothutu.Value = Convert.ToInt32(lv_monan.SelectedItems[0].SubItems[0].Text);
           txt_tenmon.Text = lv_monan.SelectedItems[0].SubItems[1].Text;
           nu_gia.Value = Convert.ToInt32(lv_monan.SelectedItems[0].SubItems[2].Text);
        }

        private void lv_nuocuong_Click(object sender, EventArgs e)
        {
            nu_sothutu.Value = Convert.ToInt32(lv_nuocuong.SelectedItems[0].SubItems[0].Text);
            txt_tenmon.Text = lv_nuocuong.SelectedItems[0].SubItems[1].Text;
            nu_gia.Value = Convert.ToInt32(lv_nuocuong.SelectedItems[0].SubItems[2].Text);
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            int so_monan = lv_monan.Items.Count;
            int so_nuocuong = lv_nuocuong.Items.Count;
            if( rd_monan.Checked == true)
            {
                lv_monan.Items.Add(nu_sothutu.Value.ToString());
                lv_monan.Items[so_monan].SubItems.Add(txt_tenmon.Text);
                lv_monan.Items[so_monan].SubItems.Add(nu_gia.Value.ToString());
            }    
            else
            {
                lv_nuocuong.Items.Add(nu_sothutu.Value.ToString());
                lv_nuocuong.Items[so_nuocuong].SubItems.Add(txt_tenmon.Text);
                lv_nuocuong.Items[so_nuocuong].SubItems.Add(nu_gia.Value.ToString());
            }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (rd_monan.Checked == true)
            {
                lv_monan.SelectedItems[0].SubItems[0].Text = nu_sothutu.Value.ToString();
                lv_monan.SelectedItems[0].SubItems[1].Text = txt_tenmon.Text;
                lv_monan.SelectedItems[0].SubItems[2].Text = nu_gia.Value.ToString();
            }
            else
            {
                lv_nuocuong.SelectedItems[0].SubItems[0].Text = nu_sothutu.Value.ToString();
                lv_nuocuong.SelectedItems[0].SubItems[1].Text = txt_tenmon.Text;
                lv_nuocuong.SelectedItems[0].SubItems[2].Text = nu_gia.Value.ToString();

            }
        }

        private void lv_nuocuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_traiquaphai_Click(object sender, EventArgs e)
        {
            
            int so_nuocuong = lv_nuocuong.Items.Count;
            lv_nuocuong.Items.Add(lv_monan.SelectedItems[0].SubItems[0].Text);
            lv_nuocuong.Items[so_nuocuong].SubItems.Add(lv_monan.SelectedItems[0].SubItems[1].Text);
            lv_nuocuong.Items[so_nuocuong].SubItems.Add(lv_monan.SelectedItems[0].SubItems[2].Text);
            lv_monan.Items.RemoveAt(lv_monan.SelectedIndices[0]);
        }

        private void bt_phaiquatrai_Click(object sender, EventArgs e)
        {
            int so_monan = lv_monan.Items.Count;
            lv_monan.Items.Add(lv_nuocuong.SelectedItems[0].SubItems[0].Text);
            lv_monan.Items[so_monan].SubItems.Add(lv_nuocuong.SelectedItems[0].SubItems[1].Text);
            lv_monan.Items[so_monan].SubItems.Add(lv_nuocuong.SelectedItems[0].SubItems[2].Text);
            lv_nuocuong.Items.RemoveAt(lv_nuocuong.SelectedIndices[0]);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (rd_monan.Checked == true)
            {
                lv_monan.Items.RemoveAt(lv_monan.SelectedIndices[0]);
            }
            else
            {
                lv_nuocuong.Items.RemoveAt(lv_nuocuong.SelectedIndices[0]);
            }
        }
    }
    
}
