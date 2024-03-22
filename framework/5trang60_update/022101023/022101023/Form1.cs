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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btTINH_Click(object sender, EventArgs e)
        {
            if (rdPHEPCONG.Checked == true)
                txtKETQUA.Text = (nuGT1.Value + nuGT2.Value).ToString();
            else if (rdPHEPTRU.Checked == true)
                txtKETQUA.Text = (nuGT1.Value - nuGT2.Value).ToString();
            else if (rdPHEPNHAN.Checked == true)
                txtKETQUA.Text = (nuGT1.Value * nuGT2.Value).ToString();
            else txtKETQUA.Text = Math.Round((nuGT1.Value / nuGT2.Value),2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btTINHCHUVI_Click(object sender, EventArgs e)
        {
            txtKQ.Text = ((int.Parse(txtCHIEUDAI.Text) + int.Parse(txtCHIEURONG.Text)) * 2).ToString();
            lbCHUVI.Text = ((int.Parse(txtCHIEUDAI.Text) + int.Parse(txtCHIEURONG.Text)) * 2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btTINHDIENTICH_Click(object sender, EventArgs e)
        {
            txtKQDT.Text = (Math.Sqrt(Math.Round(txtA.Text + txtB.Text + txtC.Text) + Math.Round(txtA.Text + txtB.Text - txtC.Text) + Math.Round(txtB.Text + txtC.Text - txtA.Text)));
        }

        private void txtKQDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
