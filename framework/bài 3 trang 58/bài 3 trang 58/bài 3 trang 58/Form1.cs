using System;
using System.Windows.Forms;

namespace bài_3_trang_58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int motanh = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = true;
        }

        private void rdlaptop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdlaptop.Checked == true)
            {
                lstlaptop.Items.Add("HP");
                lstlaptop.Items.Add("Vaio");
                lstlaptop.Items.Add("DELL");
                lstlaptop.Items.Add("Lenovo");
                pic1.Image = Properties.Resources.dell;
                pic2.Image = Properties.Resources.hp;
                pic3.Image = Properties.Resources.lenovo;
                pic4.Image = Properties.Resources.vaio;
            }
            else
                lstlaptop.Items.Clear();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            // Code for pic1 click event goes here if needed
        }

        private void lstUSB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdusb_CheckedChanged(object sender, EventArgs e)
        {
            if (rdusb.Checked == true)
            {
                lstlaptop.Items.Add("Kington");
                lstlaptop.Items.Add("Trancer");
                lstlaptop.Items.Add("KingMax");
                lstlaptop.Items.Add("Adapt");
                pic1.Image = Properties.Resources.trancer;
                pic2.Image = Properties.Resources.kingmax;
                pic3.Image = Properties.Resources.kington;
                pic4.Image = Properties.Resources.adapt;
            }
            else
                lstlaptop.Items.Clear();

        }

        private void lstlaptop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( motanh == 1  )
            {
                pic1.Visible = true;
                pic2.Visible = true;
                pic3.Visible = true;
                pic4.Visible = true;
                pic5.Visible = false;
                motanh = 0;
            }
            else
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = true;
                motanh = 1;
            }
            pic1.Image = null;
            pic2.Image = null;
            pic3.Image = null;
            pic4.Image = null;
            pic5.Image = null;
            if (lstlaptop.SelectedItem != null)
            {
                string selectedProduct = lstlaptop.SelectedItem.ToString();

                switch (selectedProduct)
                {
                    case "HP":
                        pic5.Image = Properties.Resources.hp;
                        break;
                    case "Vaio":
                        pic5.Image = Properties.Resources.vaio;
                        break;
                    case "DELL":
                        pic5.Image = Properties.Resources.dell;
                        break;
                    case "Lenovo":
                        pic5.Image = Properties.Resources.lenovo;
                        break;
                    case "Kington":
                        pic5.Image = Properties.Resources.kington;
                        break;
                    case "Trancer":
                        pic5.Image = Properties.Resources.trancer;
                        break;
                    case "KingMax":
                        pic5.Image = Properties.Resources.kingmax;
                        break;
                    case "Adapt":
                        pic5.Image = Properties.Resources.adapt;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
