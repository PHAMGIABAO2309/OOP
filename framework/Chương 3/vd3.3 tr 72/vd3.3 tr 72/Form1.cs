using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vd3._3_tr_72
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("taptin.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            int L = (int)fs.Length;
            var buffer = new byte[L];
            fs.Read(buffer, 0, L);
            string str = Encoding.UTF8.GetString(buffer);
            fs.Close();
            txtThongTin.Text = str;
        }

        private void btLUU_Click(object sender, EventArgs e)
        {
            FileStream  fs = new FileStream("noidung.txt", FileMode.Create,FileAccess.Write,FileShare.Write);
            string s = txtThongTin.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(s);
            fs.Write(buffer, 0, buffer.Length);
        }
    }
}
