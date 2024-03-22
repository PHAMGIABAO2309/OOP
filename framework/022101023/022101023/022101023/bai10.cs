namespace bai_10_trang_64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tvTheLoai_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvTheLoai.SelectedNode.Text == "Tin học")
            {
                lvDanhSach.Items.Clear();
                lvDanhSach.Items.Add("Lập trình giao diện");
                lvDanhSach.Items[0].SubItems.Add("Phương Linh");
                lvDanhSach.Items[0].SubItems.Add("35000");


                lvDanhSach.Items.Add("Mạng máy tính");
                lvDanhSach.Items[1].SubItems.Add("Minh Khánh");
                lvDanhSach.Items[1].SubItems.Add("45000");


                lvDanhSach.Items.Add("Cơ sở dữ liệu");
                lvDanhSach.Items[2].SubItems.Add("Thiên Trang");
                lvDanhSach.Items[2].SubItems.Add("30000");

            }
            if (tvTheLoai.SelectedNode.Text == "Thiếu nhi")
            {
                lvDanhSach.Items.Clear();
                lvDanhSach.Items.Add("Tấm Cám");
                lvDanhSach.Items[0].SubItems.Add("Chuyện cổ tích");
                lvDanhSach.Items[0].SubItems.Add("25000");


                lvDanhSach.Items.Add("Thánh Gióng");
                lvDanhSach.Items[1].SubItems.Add("Chuyện cổ tích");
                lvDanhSach.Items[1].SubItems.Add("40000");

            }
            int s = 0;
            int sodong = lvDanhSach.Items.Count;
            for (int i = 0; i < sodong; i++)
            {
                s += Convert.ToInt32(lvDanhSach.Items[i].SubItems[2].Text);
            }
            lbTongTien.Text = s.ToString();
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
