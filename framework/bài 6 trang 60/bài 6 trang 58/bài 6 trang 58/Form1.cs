namespace bài_6_trang_58
{
    public partial class Form1 : Form
    {
        // Khai báo một từ điển riêng tư để lưu trữ loại xe và màu sắc tương ứng
        private Dictionary<string, string> mausac = new Dictionary<string, string>();
        private Dictionary<string, int> dongia = new Dictionary<string, int>();
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cbbLOAIXE.Items.Add("Vision");
            cbbLOAIXE.Items.Add("Click");
            cbbLOAIXE.Items.Add("SH mode");

            // Liên kết màu sắc với các loại xe trong từ điển
            mausac["Vision"] = "Xanh";
            mausac["Click"] = "Trắng";
            mausac["SH mode"] = "Đỏ";

            dongia["Vision"] = 35000000;
            dongia["Click"] = 42000000;
            dongia["SH mode"] = 50000000;
        }
        
        private void cbbLOAIXE_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTENXE.Text = cbbLOAIXE.SelectedItem.ToString();
            // Lấy loại xe được chọn từ ComboBox
            string hienthi = cbbLOAIXE.SelectedItem.ToString();

            // Kiểm tra xem loại xe được chọn có tồn tại trong từ điển không
            if (mausac.ContainsKey(hienthi))
            {
                // Lấy màu sắc tương ứng và hiển thị nó trong TextBox
                string color = mausac[hienthi];
                txtMAUSAC.Text = color;

                if (dongia.ContainsKey(hienthi))
                {
                    int gia = dongia[hienthi];
                    txtDONGIA.Text = gia.ToString();
                }
            }
        }
        private void btTINHTIEN_Click(object sender, EventArgs e)
        {
            // Lấy số lượng từ TextBox
            if (int.TryParse(nuSOLUONG.Value.ToString(), out int soLuong))
            {
                // Lấy loại xe được chọn từ ComboBox
                string hienthi = cbbLOAIXE.SelectedItem.ToString();

                // Kiểm tra xem loại xe được chọn có tồn tại trong từ điển không
                if (mausac.ContainsKey(hienthi) && dongia.ContainsKey(hienthi))
                {
                    // Lấy màu sắc và giá tiền tương ứng
                    string color = mausac[hienthi];
                    int gia = dongia[hienthi];

                    // Tính toán thành tiền và hiển thị kết quả trong Label
                    int thanhTien = soLuong * gia;
                    lbTONGTIEN.Text = thanhTien.ToString("C0"); // Hiển thị thành tiền có dạng tiền tệ
                }
            }
        }
    }
}
