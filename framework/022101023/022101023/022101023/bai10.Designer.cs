namespace bai_10_trang_64
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
            TreeNode treeNode1 = new TreeNode("Lập trình giao diện");
            TreeNode treeNode2 = new TreeNode("Mạng máy tính");
            TreeNode treeNode3 = new TreeNode("Cơ sở dữ liệu");
            TreeNode treeNode4 = new TreeNode("Tin học", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Tấm cám");
            TreeNode treeNode6 = new TreeNode("Thánh gióng");
            TreeNode treeNode7 = new TreeNode("Thiếu nhi", new TreeNode[] { treeNode5, treeNode6 });
            tvTheLoai = new TreeView();
            lbTongTien = new Label();
            lvDanhSach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // tvTheLoai
            // 
            tvTheLoai.Location = new Point(74, 81);
            tvTheLoai.Name = "tvTheLoai";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Lập trình giao diện";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Mạng máy tính";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Cơ sở dữ liệu";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Tin học";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Tấm cám";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Thánh gióng";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Thiếu nhi";
            tvTheLoai.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode7 });
            tvTheLoai.Size = new Size(317, 390);
            tvTheLoai.TabIndex = 0;
            tvTheLoai.AfterSelect += tvTheLoai_AfterSelect;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(408, 509);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(59, 25);
            lbTongTien.TabIndex = 2;
            lbTongTien.Text = "label1";
            // 
            // lvDanhSach
            // 
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvDanhSach.FullRowSelect = true;
            lvDanhSach.GridLines = true;
            lvDanhSach.Location = new Point(456, 81);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(431, 383);
            lvDanhSach.TabIndex = 3;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            lvDanhSach.SelectedIndexChanged += lvDanhSach_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Học phần";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tác giả";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 648);
            Controls.Add(lvDanhSach);
            Controls.Add(lbTongTien);
            Controls.Add(tvTheLoai);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tvTheLoai;
        private Label lbTongTien;
        private ListView lvDanhSach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
