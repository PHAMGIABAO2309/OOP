namespace bai_10_trang_64
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            lvMonAnDaChon = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label2 = new Label();
            cbbLoaiMonAn = new ComboBox();
            groupBox1 = new GroupBox();
            clbChiTietMonAn = new CheckedListBox();
            groupBox2 = new GroupBox();
            btChon = new Button();
            btBoChon = new Button();
            btTaoMoi = new Button();
            btThoat = new Button();
            nuSoLuong = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuSoLuong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(507, 48);
            label1.TabIndex = 0;
            label1.Text = "CHỌN THỰC ĐƠN MÓN ĂN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 59);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 2;
            label3.Text = "Loại món ăn:";
            // 
            // lvMonAnDaChon
            // 
            lvMonAnDaChon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvMonAnDaChon.FullRowSelect = true;
            lvMonAnDaChon.GridLines = true;
            lvMonAnDaChon.Location = new Point(16, 30);
            lvMonAnDaChon.Name = "lvMonAnDaChon";
            lvMonAnDaChon.Size = new Size(224, 295);
            lvMonAnDaChon.TabIndex = 7;
            lvMonAnDaChon.UseCompatibleStateImageBehavior = false;
            lvMonAnDaChon.View = View.Details;
            lvMonAnDaChon.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món ăn";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 149);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 2;
            label2.Text = "Số lượng:";
            // 
            // cbbLoaiMonAn
            // 
            cbbLoaiMonAn.FormattingEnabled = true;
            cbbLoaiMonAn.Location = new Point(45, 104);
            cbbLoaiMonAn.Name = "cbbLoaiMonAn";
            cbbLoaiMonAn.Size = new Size(162, 33);
            cbbLoaiMonAn.TabIndex = 8;
            cbbLoaiMonAn.SelectedIndexChanged += cbbLoaiMonAn_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clbChiTietMonAn);
            groupBox1.Location = new Point(32, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 335);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết món ăn:";
            // 
            // clbChiTietMonAn
            // 
            clbChiTietMonAn.FormattingEnabled = true;
            clbChiTietMonAn.Location = new Point(13, 45);
            clbChiTietMonAn.Name = "clbChiTietMonAn";
            clbChiTietMonAn.Size = new Size(255, 284);
            clbChiTietMonAn.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvMonAnDaChon);
            groupBox2.Location = new Point(462, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 356);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các món ăn đã chọn:";
            // 
            // btChon
            // 
            btChon.Location = new Point(348, 258);
            btChon.Name = "btChon";
            btChon.Size = new Size(108, 40);
            btChon.TabIndex = 11;
            btChon.Text = "Chọn";
            btChon.UseVisualStyleBackColor = true;
            btChon.Click += btChon_Click;
            // 
            // btBoChon
            // 
            btBoChon.Location = new Point(348, 332);
            btBoChon.Name = "btBoChon";
            btBoChon.Size = new Size(108, 66);
            btBoChon.TabIndex = 12;
            btBoChon.Text = "Bỏ chọn";
            btBoChon.UseVisualStyleBackColor = true;
            btBoChon.Click += btBoChon_Click;
            // 
            // btTaoMoi
            // 
            btTaoMoi.Location = new Point(257, 534);
            btTaoMoi.Name = "btTaoMoi";
            btTaoMoi.Size = new Size(105, 53);
            btTaoMoi.TabIndex = 13;
            btTaoMoi.Text = "Tạo mới";
            btTaoMoi.UseVisualStyleBackColor = true;
            btTaoMoi.Click += btTaoMoi_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(436, 531);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(131, 56);
            btThoat.TabIndex = 14;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // nuSoLuong
            // 
            nuSoLuong.Location = new Point(335, 194);
            nuSoLuong.Name = "nuSoLuong";
            nuSoLuong.Size = new Size(121, 31);
            nuSoLuong.TabIndex = 15;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 659);
            Controls.Add(nuSoLuong);
            Controls.Add(btThoat);
            Controls.Add(btTaoMoi);
            Controls.Add(btBoChon);
            Controls.Add(btChon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cbbLoaiMonAn);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nuSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ListView lvMonAnDaChon;
        private Label label2;
        private ComboBox cbbLoaiMonAn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btChon;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private CheckedListBox clbChiTietMonAn;
        private Button btBoChon;
        private Button btTaoMoi;
        private Button btThoat;
        private NumericUpDown nuSoLuong;
    }
}