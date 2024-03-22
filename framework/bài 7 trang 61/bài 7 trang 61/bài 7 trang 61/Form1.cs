namespace bài_7_trang_61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lvDANHSACHLOP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cbbLOP.Items.Add("Cao đẳng 17");
            cbbLOP.Items.Add("Cao đẳng 18");
            
        }

        private void lvDANHSACHLOP_Click(object sender, EventArgs e)
        {
            txtHOTEN.Text = lvDANHSACHLOP.SelectedItems[0].SubItems[0].Text;
            lbHOTEN.Text = lvDANHSACHLOP.SelectedItems[0].SubItems[0].Text;
            nuLAPTRINHGD.Value = decimal.Parse(lvDANHSACHLOP.SelectedItems[0].SubItems[1].Text);
            nuMANGMT.Value = decimal.Parse(lvDANHSACHLOP.SelectedItems[0].SubItems[2].Text);
            nuCSDL.Value = decimal.Parse(lvDANHSACHLOP.SelectedItems[0].SubItems[3].Text);
            double sum = int.Parse(nuLAPTRINHGD.Value.ToString()) +
              int.Parse(nuMANGMT.Value.ToString()) +
              int.Parse(nuCSDL.Value.ToString());

            lbDIEMTRUNGBINH.Text = (sum / 3.0).ToString();
        }
    

        private void cbbLOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDANHSACHLOP.Items.Clear();
            if (cbbLOP.SelectedItem.ToString() == "Cao đẳng 17")
            {
                lvDANHSACHLOP.Items.Add("Anh Tuấn");
                lvDANHSACHLOP.Items[0].SubItems.Add("9");
                lvDANHSACHLOP.Items[0].SubItems.Add("8");
                lvDANHSACHLOP.Items[0].SubItems.Add("9");

                lvDANHSACHLOP.Items.Add("Hoàng Giang");
                lvDANHSACHLOP.Items[1].SubItems.Add("10");
                lvDANHSACHLOP.Items[1].SubItems.Add("7");
                lvDANHSACHLOP.Items[1].SubItems.Add("9");

                lvDANHSACHLOP.Items.Add("Trâm Anh");
                lvDANHSACHLOP.Items[2].SubItems.Add("8");
                lvDANHSACHLOP.Items[2].SubItems.Add("7");
                lvDANHSACHLOP.Items[2].SubItems.Add("10");
            }
            if (cbbLOP.SelectedItem.ToString() == "Cao đẳng 18")
            {
                lvDANHSACHLOP.Items.Add("Hữu Tiến");
                lvDANHSACHLOP.Items[0].SubItems.Add("7");
                lvDANHSACHLOP.Items[0].SubItems.Add("8");
                lvDANHSACHLOP.Items[0].SubItems.Add("9");

                lvDANHSACHLOP.Items.Add("Thanh Lâm");
                lvDANHSACHLOP.Items[1].SubItems.Add("5");
                lvDANHSACHLOP.Items[1].SubItems.Add("4");
                lvDANHSACHLOP.Items[1].SubItems.Add("6");

                lvDANHSACHLOP.Items.Add("Yến Như");
                lvDANHSACHLOP.Items[2].SubItems.Add("4");
                lvDANHSACHLOP.Items[2].SubItems.Add("7");
                lvDANHSACHLOP.Items[2].SubItems.Add("7");
            }    
        }
    }
}