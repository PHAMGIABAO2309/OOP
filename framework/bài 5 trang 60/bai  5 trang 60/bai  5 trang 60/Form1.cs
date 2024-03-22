namespace bai__5_trang_60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMONAN.Items.Add("Cơm sườn bì chả");
            lstMONAN.Items.Add("Phở");
            lstMONAN.Items.Add("Bún riêu");
            lstMONAN.Items.Add("Cháo cá");
            lstNUOCUONG.Items.Add("Sting");
            lstNUOCUONG.Items.Add("Trà đào");
            lstNUOCUONG.Items.Add("Trà chanh");
            lstNUOCUONG.Items.Add("Nước cam");
        }
        private void btTHEM_Click(object sender, EventArgs e)
        {
            if (rdMONAN.Checked == true)
            {
                lstMONAN.Items.Add(txtTENMON.Text);
            }
            if (rdNUOCUONG.Checked == true)
            {
                lstNUOCUONG.Items.Add(txtTENMON.Text);
            }
        }
        private void rdMONAN_CheckedChanged(object sender, EventArgs e)
        {
            if (lstMONAN.SelectedItem != null)
            {
                txtTENMON.Text = lstMONAN.SelectedItem.ToString();
            }
        }

        private void rdNUOCUONG_CheckedChanged(object sender, EventArgs e)
        {
            if (lstNUOCUONG.SelectedItem != null)
            {
                txtTENMON.Text = lstNUOCUONG.SelectedItem.ToString();
            }
        }

        private void btQUAPHAI_Click(object sender, EventArgs e)
        {
            lstNUOCUONG.Items.Add(lstMONAN.SelectedItem);
            lstMONAN.Items.RemoveAt(lstMONAN.SelectedIndex);
        }

        private void btQUATRAI_Click(object sender, EventArgs e)
        {
            lstMONAN.Items.Add(lstNUOCUONG.SelectedItem);
            lstNUOCUONG.Items.RemoveAt(lstNUOCUONG.SelectedIndex);
        }
    }
}