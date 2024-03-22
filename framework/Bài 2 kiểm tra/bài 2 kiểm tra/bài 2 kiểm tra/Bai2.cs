namespace bài_2_kiểm_tra
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clbDSHP.Items.Add("30073_Công nghệ .NET");
            clbDSHP.Items.Add("30043_Tin học văn phòng");
            clbDSHP.Items.Add("32153_Lập trình cơ sở dữ liệu");
            clbDSHP.Items.Add("32304_Cơ sở dữ liệu");
            clbDSHP.Items.Add("31303_Toán rời rạc");
            clbDSHP.Items.Add("31323_Nhập môn lập trình");
            clbDSHP.Items.Add("31333_Kỹ thuật lập trình");
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            foreach (var item in clbDSHP.CheckedItems)
            {
                lstDadky.Items.Add(item.ToString());
            }

        }


        private void btTinh_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            int tongTC = 0;
            int sodong = clbDSHP.CheckedItems.Count;

            // Duyệt qua từng mục trong CheckedListBox để tính tổng tiền và tổng số tín chỉ
            for (int i = 0; i < sodong; i++)
            {
                // Lấy chuỗi mô tả môn học (ví dụ: "30073_Công nghệ .NET")
                string s = clbDSHP.CheckedItems[i].ToString();

                // Tách chuỗi để lấy số tín chỉ (có trong 5 ký tự đầu tiên)
                int soTC = Convert.ToInt32(s.Substring(4, 1));
 

                // Cộng dồn số tín chỉ
                tongTC += soTC;

                // Tính tổng tiền dựa trên số tín chỉ và giá tiền 350,000 VNĐ/tín chỉ
                tongtien += soTC * 350000;
            }

            // Hiển thị tổng tiền và tổng số tín chỉ lên các Label tương ứng
            lbTongtien.Text = tongtien.ToString("#,##0") + "VNĐ";
            lbTongTC.Text = tongTC.ToString();
        }



    }
}