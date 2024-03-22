using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chức_năng_đăng_nhập__đăng_xuất
{
    public partial class FormChuongTrinh : Form
    {
        public FormChuongTrinh()
        {
            InitializeComponent();
        }
        public bool isthoat = true;
        public event EventHandler DangXuat;
        private void button1_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void FormChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isthoat)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isthoat)
                Application.Exit();
        }
    }
}
