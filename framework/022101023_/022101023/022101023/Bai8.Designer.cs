namespace _022101023
{
    partial class Bai8
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
            label2 = new Label();
            label3 = new Label();
            lvMenu = new ListView();
            btQuaPhai = new Button();
            btQuaTrai = new Button();
            lvHoaDon = new ListView();
            btTinh = new Button();
            lbTongTien = new Label();
            cbbLoaiThucUong = new ComboBox();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 25);
            label1.Name = "label1";
            label1.Size = new Size(367, 48);
            label1.TabIndex = 0;
            label1.Text = "MENU THỨC UỐNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 98);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 1;
            label2.Text = "Loại thức uống:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 152);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "Menu";
            // 
            // lvMenu
            // 
            lvMenu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvMenu.FullRowSelect = true;
            lvMenu.GridLines = true;
            lvMenu.Location = new Point(61, 193);
            lvMenu.Name = "lvMenu";
            lvMenu.Size = new Size(294, 186);
            lvMenu.TabIndex = 3;
            lvMenu.UseCompatibleStateImageBehavior = false;
            lvMenu.View = View.Details;
            // 
            // btQuaPhai
            // 
            btQuaPhai.Location = new Point(444, 199);
            btQuaPhai.Name = "btQuaPhai";
            btQuaPhai.Size = new Size(81, 43);
            btQuaPhai.TabIndex = 4;
            btQuaPhai.Text = ">";
            btQuaPhai.UseVisualStyleBackColor = true;
            btQuaPhai.Click += btQuaPhai_Click;
            // 
            // btQuaTrai
            // 
            btQuaTrai.Location = new Point(444, 303);
            btQuaTrai.Name = "btQuaTrai";
            btQuaTrai.Size = new Size(89, 51);
            btQuaTrai.TabIndex = 5;
            btQuaTrai.Text = "<";
            btQuaTrai.UseVisualStyleBackColor = true;
            btQuaTrai.Click += btQuaTrai_Click;
            // 
            // lvHoaDon
            // 
            lvHoaDon.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lvHoaDon.FullRowSelect = true;
            lvHoaDon.GridLines = true;
            lvHoaDon.Location = new Point(579, 193);
            lvHoaDon.Name = "lvHoaDon";
            lvHoaDon.Size = new Size(301, 183);
            lvHoaDon.TabIndex = 6;
            lvHoaDon.UseCompatibleStateImageBehavior = false;
            lvHoaDon.View = View.Details;
            // 
            // btTinh
            // 
            btTinh.Location = new Point(256, 431);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(91, 68);
            btTinh.TabIndex = 7;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(470, 437);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(0, 25);
            lbTongTien.TabIndex = 8;
            // 
            // cbbLoaiThucUong
            // 
            cbbLoaiThucUong.FormattingEnabled = true;
            cbbLoaiThucUong.Location = new Point(299, 95);
            cbbLoaiThucUong.Name = "cbbLoaiThucUong";
            cbbLoaiThucUong.Size = new Size(200, 33);
            cbbLoaiThucUong.TabIndex = 9;
            cbbLoaiThucUong.SelectedIndexChanged += cbbLoaiThucUong_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Thức uống";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thức uống";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số lượng";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Thành tiền";
            columnHeader6.Width = 100;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 660);
            Controls.Add(cbbLoaiThucUong);
            Controls.Add(lbTongTien);
            Controls.Add(btTinh);
            Controls.Add(lvHoaDon);
            Controls.Add(btQuaTrai);
            Controls.Add(btQuaPhai);
            Controls.Add(lvMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lvMenu;
        private Button btQuaPhai;
        private Button btQuaTrai;
        private ListView lvHoaDon;
        private Button btTinh;
        private Label lbTongTien;
        private ComboBox cbbLoaiThucUong;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}