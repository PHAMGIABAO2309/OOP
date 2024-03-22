namespace bài_8_trang_62
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
            lbTongTien = new Label();
            cbbLoaiThucUong = new ComboBox();
            lvMenu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lvHoaDon = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btQuaTrai = new Button();
            btQuaPhai = new Button();
            btTinh = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 49);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 0;
            label1.Text = "MENU THỨC UỐNG";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(397, 475);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(59, 25);
            lbTongTien.TabIndex = 0;
            lbTongTien.Text = "label1";
            // 
            // cbbLoaiThucUong
            // 
            cbbLoaiThucUong.FormattingEnabled = true;
            cbbLoaiThucUong.Location = new Point(241, 100);
            cbbLoaiThucUong.Name = "cbbLoaiThucUong";
            cbbLoaiThucUong.Size = new Size(182, 33);
            cbbLoaiThucUong.TabIndex = 1;
            cbbLoaiThucUong.SelectedIndexChanged += cbbLoaiThucUong_SelectedIndexChanged;
            // 
            // lvMenu
            // 
            lvMenu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvMenu.FullRowSelect = true;
            lvMenu.GridLines = true;
            lvMenu.Location = new Point(74, 171);
            lvMenu.Name = "lvMenu";
            lvMenu.Size = new Size(279, 254);
            lvMenu.TabIndex = 2;
            lvMenu.UseCompatibleStateImageBehavior = false;
            lvMenu.View = View.Details;
            lvMenu.SelectedIndexChanged += lvMenu_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Thức uống";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn Giá";
            // 
            // lvHoaDon
            // 
            lvHoaDon.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lvHoaDon.FullRowSelect = true;
            lvHoaDon.GridLines = true;
            lvHoaDon.Location = new Point(499, 171);
            lvHoaDon.Name = "lvHoaDon";
            lvHoaDon.Size = new Size(279, 254);
            lvHoaDon.TabIndex = 2;
            lvHoaDon.UseCompatibleStateImageBehavior = false;
            lvHoaDon.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thức uống";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số lượng";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Thành tiền";
            // 
            // btQuaTrai
            // 
            btQuaTrai.Location = new Point(405, 272);
            btQuaTrai.Name = "btQuaTrai";
            btQuaTrai.Size = new Size(51, 45);
            btQuaTrai.TabIndex = 3;
            btQuaTrai.Text = "<";
            btQuaTrai.UseVisualStyleBackColor = true;
            btQuaTrai.Click += btQuaTrai_Click;
            // 
            // btQuaPhai
            // 
            btQuaPhai.Location = new Point(405, 210);
            btQuaPhai.Name = "btQuaPhai";
            btQuaPhai.Size = new Size(51, 45);
            btQuaPhai.TabIndex = 3;
            btQuaPhai.Text = ">";
            btQuaPhai.UseVisualStyleBackColor = true;
            btQuaPhai.Click += btQuaPhai_Click;
            // 
            // btTinh
            // 
            btTinh.Location = new Point(290, 465);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(84, 45);
            btTinh.TabIndex = 3;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 108);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 0;
            label3.Text = "Loại thức uống:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 671);
            Controls.Add(btTinh);
            Controls.Add(btQuaPhai);
            Controls.Add(btQuaTrai);
            Controls.Add(lvHoaDon);
            Controls.Add(lvMenu);
            Controls.Add(cbbLoaiThucUong);
            Controls.Add(label3);
            Controls.Add(lbTongTien);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbTongTien;
        private ComboBox cbbLoaiThucUong;
        private ListView lvMenu;
        private ListView lvHoaDon;
        private Button btQuaTrai;
        private Button btQuaPhai;
        private Button btTinh;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}