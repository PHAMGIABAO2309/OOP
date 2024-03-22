namespace PHIẾU_THANH_TOÁN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btTINH_Click(object sender, EventArgs e)
        {
            decimal tong = 0;
            if (cbCAOVOI.Checked == true)
                tong += 100000;
            if (cbTAYTRANG.Checked == true)
                tong += 1200000;
            if (cbCHUPHINHRANG.Checked == true)
                tong += 200000;
            tong += nuTRAMRANG.Value * 80000;
            lbTONGTIEN.Text = tong.ToString("#,##0") + " VNĐ";
        }
    }
}