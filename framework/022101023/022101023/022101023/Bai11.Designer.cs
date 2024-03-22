namespace bai_10_trang_64
{
    partial class Form2
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
            TreeNode treeNode1 = new TreeNode("SH");
            TreeNode treeNode2 = new TreeNode("Spacy");
            TreeNode treeNode3 = new TreeNode("Xe máy", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Innova");
            TreeNode treeNode5 = new TreeNode("Camry");
            TreeNode treeNode6 = new TreeNode("Ô tô", new TreeNode[] { treeNode4, treeNode5 });
            TreeNode treeNode7 = new TreeNode("Xe", new TreeNode[] { treeNode3, treeNode6 });
            tvXE = new TreeView();
            lvDANHSACH = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            nuSoluong = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            lbTongTien = new Label();
            label4 = new Label();
            cbbPhuongthucthanhtoan = new ComboBox();
            btDatHang = new Button();
            btThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)nuSoluong).BeginInit();
            SuspendLayout();
            // 
            // tvXE
            // 
            tvXE.Location = new Point(35, 136);
            tvXE.Name = "tvXE";
            treeNode1.Name = "Node3";
            treeNode1.Text = "SH";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Spacy";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Xe máy";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Innova";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Camry";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Ô tô";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Xe";
            tvXE.Nodes.AddRange(new TreeNode[] { treeNode7 });
            tvXE.Size = new Size(241, 283);
            tvXE.TabIndex = 0;
            tvXE.AfterSelect += treeView1_AfterSelect;
            // 
            // lvDANHSACH
            // 
            lvDANHSACH.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvDANHSACH.FullRowSelect = true;
            lvDANHSACH.GridLines = true;
            lvDANHSACH.Location = new Point(408, 84);
            lvDANHSACH.Name = "lvDANHSACH";
            lvDANHSACH.Size = new Size(613, 335);
            lvDANHSACH.TabIndex = 1;
            lvDANHSACH.UseCompatibleStateImageBehavior = false;
            lvDANHSACH.View = View.Details;
            lvDANHSACH.SelectedIndexChanged += lvDANHSACH_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hãng";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Năm SX";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Động cơ";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá";
            columnHeader4.Width = 200;
            // 
            // nuSoluong
            // 
            nuSoluong.Location = new Point(138, 463);
            nuSoluong.Name = "nuSoluong";
            nuSoluong.Size = new Size(110, 31);
            nuSoluong.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 469);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 3;
            label1.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 551);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Tổng tiền:";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(183, 552);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(59, 25);
            lbTongTien.TabIndex = 5;
            lbTongTien.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 437);
            label4.Name = "label4";
            label4.Size = new Size(210, 25);
            label4.TabIndex = 6;
            label4.Text = "Phương thức thanh toán:";
            // 
            // cbbPhuongthucthanhtoan
            // 
            cbbPhuongthucthanhtoan.FormattingEnabled = true;
            cbbPhuongthucthanhtoan.Location = new Point(551, 469);
            cbbPhuongthucthanhtoan.Name = "cbbPhuongthucthanhtoan";
            cbbPhuongthucthanhtoan.Size = new Size(252, 33);
            cbbPhuongthucthanhtoan.TabIndex = 7;
            cbbPhuongthucthanhtoan.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btDatHang
            // 
            btDatHang.Location = new Point(532, 533);
            btDatHang.Name = "btDatHang";
            btDatHang.Size = new Size(103, 63);
            btDatHang.TabIndex = 8;
            btDatHang.Text = "Đặt hàng";
            btDatHang.UseVisualStyleBackColor = true;
            btDatHang.Click += btDatHang_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(700, 533);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(124, 63);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 682);
            Controls.Add(btThoat);
            Controls.Add(btDatHang);
            Controls.Add(cbbPhuongthucthanhtoan);
            Controls.Add(label4);
            Controls.Add(lbTongTien);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nuSoluong);
            Controls.Add(lvDANHSACH);
            Controls.Add(tvXE);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nuSoluong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tvXE;
        private ListView lvDANHSACH;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private NumericUpDown nuSoluong;
        private Label label1;
        private Label label2;
        private Label lbTongTien;
        private Label label4;
        private ComboBox cbbPhuongthucthanhtoan;
        private Button btDatHang;
        private Button btThoat;
    }
}