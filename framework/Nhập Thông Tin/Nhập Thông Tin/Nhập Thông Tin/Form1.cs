namespace Nhập_Thông_Tin
{
    public partial class Form1 : Form
    {
        List<string> listGIOITINH = new List<string>() { "Nam", "Nữ", "Không xác định!" };
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbGIOITINH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbGIOITINH.DataSource = listGIOITINH;
        }

        private void btEXITS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btINPUT_Click(object sender, EventArgs e)
        {
            string fullname = txtFULLNAME.Text;
            string address = txtADDRESS.Text;

            if(KIEMTRAINPUT())
            {
                XuLy.suachuoi(ref fullname);
                XuLy.suachuoi(ref address);
                txtKETQUA.Text = " Full name: " + fullname + Environment.NewLine
                                + " Date of birth: " + dtpNGAYSINH.Value.ToShortDateString() + Environment.NewLine
                                + " Giới tính: " + cbbGIOITINH.SelectedItem  + Environment.NewLine 
                                + " Address: " + address + Environment.NewLine
                                + " MSSV: " + txtMSSV.Text;
            }
            //foreach(var item in groupBox1.Controls )
            //{
            //    TextBox item1 = item as TextBox;
            //    if( item1 != null)
            //    {
            //        item1.Clear();
            //    }
            //}
            //dtpNGAYSINH.Value = DateTime.Now;
        }
        bool KIEMTRAINPUT()
        {
            if (txtFULLNAME.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ Họ tên ! ", " Thông báo!");
                //Focus() : tự động trỏ vào ô textbox còn thiếu
                txtFULLNAME.Focus();
                return false;
            }
            if (txtADDRESS.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ địa chỉ !", " Thông báo!");
                txtADDRESS.Focus();
                return false;
            }
            if (txtMSSV.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ mssv !", "Thông báo !");
                txtMSSV.Focus();
                return false;
            }
            //chỉ nhập số KHÔNG hiện chữ
            long ketqua;
            string MSSV = txtMSSV.Text;
            if( !(long.TryParse( MSSV, out ketqua)))
            {
                MessageBox.Show(" Hãy nhập đúng định dạng số MSSV", "Thông báo!");
                txtMSSV.Focus();
                return false;
            }
            //chỉ nhập số dương không hiện số âm
            if( ketqua < 0 )
            {
                MessageBox.Show("MSSV không được âm !", " Thông báo!");
                txtMSSV.Focus();
                return false;
            }
            //chỉ nhập đủ số cần thiết, không được dư hay thiếu
            char[] mangMSSV = MSSV.ToCharArray();
            if ( mangMSSV.Length != 9 )
            {
                MessageBox.Show("MSSV phải đủ 9 con số !", "Thông báo!");
                txtMSSV.Focus();
                return false;
            }
            return true;
        }
    }
}