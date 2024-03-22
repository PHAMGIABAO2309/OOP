namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clbSUBJECT.Items.Add("Công nghệ .NET");
            clbSUBJECT.Items.Add("Quản Trị Mạng");
            clbSUBJECT.Items.Add("Lý thuyết đồ thị");
            clbSUBJECT.Items.Add("Nhập môn CNTT");
            clbSUBJECT.Items.Add("Nhập môn lập trình");
        }

        private void clbSUBJECT_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtSUBJECT.Text = clbSUBJECT.SelectedItem.ToString();
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            clbSUBJECT.Items.Insert(Convert.ToInt32(nuLOCATION.Value), txtSUBJECT.Text);
            int sodongdachon = clbSUBJECT.CheckedItems.Count;
            string s = "";
            string cs = "";
            for (int i = 0; i < sodongdachon; i++)
            {
                s += clbSUBJECT.CheckedItems[i].ToString() + "\r\n";
                cs += clbSUBJECT.CheckedIndices[i] + " ";
            }
            txtSELECTEDSUBJECT.Text = s;
            txtSELECTEDLINES.Text = cs;
        }

        private void btDELETE_Click(object sender, EventArgs e)
        {
            int sodongdachon = clbSUBJECT.CheckedItems.Count;
            for (int i = sodongdachon - 1; i >= 0; i--)
            {
                clbSUBJECT.Items.RemoveAt(clbSUBJECT.CheckedIndices[i]);
            }
        }

        private void btEXITS_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát chương trình ? ", " Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }
    }
}