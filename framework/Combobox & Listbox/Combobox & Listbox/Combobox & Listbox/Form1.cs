namespace Combobox___Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbCONTENT.Items.Add("Mango");
            cbbCONTENT.Items.Add("Coconut");
            cbbCONTENT.Items.Add("Mangosteen");
            cbbCONTENT.Items.Add("watermelon");
            cbbCONTENT.Items.Add("strawberry");
            cbbCONTENT.Items.Add("avocado");
            cbbCONTENT.Items.Add("lychee");
            cbbCONTENT.Items.Add("banana");
            cbbCONTENT.Items.Add("Dragonfruit");
            cbbCONTENT.Items.Add("Lemon / Lime ");
            lstMONHOC.Items.Add(" Công nghệ .NET");
            lstMONHOC.Items.Add(" Cơ sở dữ liệu ");
            lstMONHOC.Items.Add(" Cấu trúc dữ liệu ");
            lstMONHOC.Items.Add(" Mạng máy tính ");
            lstMONHOC.Items.Add(" Nhập môn lập trình ");
            lstMONHOC.Items.Add(" Tin học văn phòng ");
        }
        private void txtCONTENT_TextChanged(object sender, EventArgs e)
        {

        }
        private void cbbCONTENT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCONTENT.Text = cbbCONTENT.SelectedItem.ToString();
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            cbbCONTENT.Items.Add(txtCONTENT.Text);
        }

        private void btDELETE_Click(object sender, EventArgs e)
        {
            cbbCONTENT.Items.RemoveAt(cbbCONTENT.SelectedIndex);
        }

        private void btUPDATE_Click(object sender, EventArgs e)
        {
            cbbCONTENT.Items[cbbCONTENT.SelectedIndex] = txtCONTENT.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMONHOC.Text = lstMONHOC.SelectedItem.ToString();
        }

        private void txtMONHOC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstMONHOC.Items.Insert(Convert.ToInt32(nuVITRI.Value), txtMONHOC.Text);
            int sodongdachon = lstMONHOC.SelectedItems.Count;
            string s = "";
            string cs = "";
            for (int i = 0; i < sodongdachon; i++)
            {
                s += lstMONHOC.SelectedItems[i].ToString() + "\r\n";
                cs += lstMONHOC.SelectedIndices[i] + " ";
            }
            txtMONHOCDUOCCHON.Text = s;
            txtCHISODUOCCHON.Text = cs;
        }

        private void btEXITS_Click(object sender, EventArgs e)
        {

        }

        private void txtMONHOCDUOCCHON_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstMONHOCDUOCCHON_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void lstMONHOC_Click(object sender, EventArgs e)
        {

        }
    }
}