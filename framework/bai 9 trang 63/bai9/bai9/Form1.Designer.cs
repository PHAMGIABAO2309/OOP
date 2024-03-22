namespace bai9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            clbChiTietMonAn = new CheckedListBox();
            groupBox2 = new GroupBox();
            lvMonAnDaChon = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btChon = new Button();
            btBoChon = new Button();
            btTaoMoi = new Button();
            btThoat = new Button();
            cbbLoaiMonAn = new ComboBox();
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
            label1.Location = new Point(258, 9);
            label1.Name = "label1";
            label1.Size = new Size(507, 48);
            label1.TabIndex = 0;
            label1.Text = "CHỌN THỰC ĐƠN MÓN ĂN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 74);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 0;
            label2.Text = "Loại món ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 136);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 0;
            label3.Text = "Số lượng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clbChiTietMonAn);
            groupBox1.Location = new Point(90, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 303);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết món ăn:";
            // 
            // clbChiTietMonAn
            // 
            clbChiTietMonAn.FormattingEnabled = true;
            clbChiTietMonAn.Location = new Point(13, 37);
            clbChiTietMonAn.Name = "clbChiTietMonAn";
            clbChiTietMonAn.Size = new Size(262, 256);
            clbChiTietMonAn.TabIndex = 0;
            clbChiTietMonAn.SelectedIndexChanged += clbChiTietMonAn_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvMonAnDaChon);
            groupBox2.Location = new Point(519, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 300);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các món ăn đã chọn:";
            // 
            // lvMonAnDaChon
            // 
            lvMonAnDaChon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvMonAnDaChon.FullRowSelect = true;
            lvMonAnDaChon.GridLines = true;
            lvMonAnDaChon.Location = new Point(22, 29);
            lvMonAnDaChon.Name = "lvMonAnDaChon";
            lvMonAnDaChon.Size = new Size(224, 265);
            lvMonAnDaChon.TabIndex = 0;
            lvMonAnDaChon.UseCompatibleStateImageBehavior = false;
            lvMonAnDaChon.View = View.Details;
            lvMonAnDaChon.SelectedIndexChanged += lvMonAnDaChon_SelectedIndexChanged;
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
            // btChon
            // 
            btChon.Location = new Point(417, 243);
            btChon.Name = "btChon";
            btChon.Size = new Size(83, 41);
            btChon.TabIndex = 3;
            btChon.Text = "Chọn";
            btChon.UseVisualStyleBackColor = true;
            btChon.Click += btChon_Click;
            // 
            // btBoChon
            // 
            btBoChon.Location = new Point(417, 331);
            btBoChon.Name = "btBoChon";
            btBoChon.Size = new Size(86, 61);
            btBoChon.TabIndex = 4;
            btBoChon.Text = "Bỏ chọn";
            btBoChon.UseVisualStyleBackColor = true;
            btBoChon.Click += btBoChon_Click;
            // 
            // btTaoMoi
            // 
            btTaoMoi.Location = new Point(312, 473);
            btTaoMoi.Name = "btTaoMoi";
            btTaoMoi.Size = new Size(126, 62);
            btTaoMoi.TabIndex = 5;
            btTaoMoi.Text = "Tạo mới";
            btTaoMoi.UseVisualStyleBackColor = true;
            btTaoMoi.Click += btTaoMoi_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(525, 473);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(112, 58);
            btThoat.TabIndex = 6;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // cbbLoaiMonAn
            // 
            cbbLoaiMonAn.FormattingEnabled = true;
            cbbLoaiMonAn.Location = new Point(385, 71);
            cbbLoaiMonAn.Name = "cbbLoaiMonAn";
            cbbLoaiMonAn.Size = new Size(198, 33);
            cbbLoaiMonAn.TabIndex = 7;
            cbbLoaiMonAn.SelectedIndexChanged += cbbLoaiMonAn_SelectedIndexChanged;
            // 
            // nuSoLuong
            // 
            nuSoLuong.Location = new Point(408, 180);
            nuSoLuong.Name = "nuSoLuong";
            nuSoLuong.Size = new Size(101, 31);
            nuSoLuong.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 659);
            Controls.Add(nuSoLuong);
            Controls.Add(cbbLoaiMonAn);
            Controls.Add(btThoat);
            Controls.Add(btTaoMoi);
            Controls.Add(btBoChon);
            Controls.Add(btChon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nuSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btChon;
        private Button btBoChon;
        private Button btTaoMoi;
        private Button btThoat;
        private ComboBox cbbLoaiMonAn;
        private CheckedListBox clbChiTietMonAn;
        private ListView lvMonAnDaChon;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private NumericUpDown nuSoLuong;
    }
}
