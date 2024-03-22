namespace _5trang60_update
{
    partial class listview
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
            this.bt_phaiquatrai = new System.Windows.Forms.Button();
            this.bt_traiquaphai = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.txt_tenmon = new System.Windows.Forms.TextBox();
            this.rd_nuocuong = new System.Windows.Forms.RadioButton();
            this.rd_monan = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_monan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_nuocuong = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nu_sothutu = new System.Windows.Forms.NumericUpDown();
            this.nu_gia = new System.Windows.Forms.NumericUpDown();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nu_sothutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_gia)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_phaiquatrai
            // 
            this.bt_phaiquatrai.Location = new System.Drawing.Point(369, 392);
            this.bt_phaiquatrai.Name = "bt_phaiquatrai";
            this.bt_phaiquatrai.Size = new System.Drawing.Size(75, 37);
            this.bt_phaiquatrai.TabIndex = 12;
            this.bt_phaiquatrai.Text = "<<";
            this.bt_phaiquatrai.UseVisualStyleBackColor = true;
            this.bt_phaiquatrai.Click += new System.EventHandler(this.bt_phaiquatrai_Click);
            // 
            // bt_traiquaphai
            // 
            this.bt_traiquaphai.Location = new System.Drawing.Point(369, 349);
            this.bt_traiquaphai.Name = "bt_traiquaphai";
            this.bt_traiquaphai.Size = new System.Drawing.Size(75, 37);
            this.bt_traiquaphai.TabIndex = 13;
            this.bt_traiquaphai.Text = ">>";
            this.bt_traiquaphai.UseVisualStyleBackColor = true;
            this.bt_traiquaphai.Click += new System.EventHandler(this.bt_traiquaphai_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(369, 220);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 37);
            this.bt_them.TabIndex = 14;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // txt_tenmon
            // 
            this.txt_tenmon.Location = new System.Drawing.Point(281, 85);
            this.txt_tenmon.Name = "txt_tenmon";
            this.txt_tenmon.Size = new System.Drawing.Size(259, 22);
            this.txt_tenmon.TabIndex = 11;
            // 
            // rd_nuocuong
            // 
            this.rd_nuocuong.AutoSize = true;
            this.rd_nuocuong.Location = new System.Drawing.Point(429, 152);
            this.rd_nuocuong.Name = "rd_nuocuong";
            this.rd_nuocuong.Size = new System.Drawing.Size(93, 20);
            this.rd_nuocuong.TabIndex = 7;
            this.rd_nuocuong.TabStop = true;
            this.rd_nuocuong.Text = "Nước uống";
            this.rd_nuocuong.UseVisualStyleBackColor = true;
            // 
            // rd_monan
            // 
            this.rd_monan.AutoSize = true;
            this.rd_monan.Location = new System.Drawing.Point(281, 152);
            this.rd_monan.Name = "rd_monan";
            this.rd_monan.Size = new System.Drawing.Size(72, 20);
            this.rd_monan.TabIndex = 8;
            this.rd_monan.TabStop = true;
            this.rd_monan.Text = "Món ăn";
            this.rd_monan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(216, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "CÀ PHÊ HOA HƯỚNG DƯƠNG";
            // 
            // lv_monan
            // 
            this.lv_monan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_monan.FullRowSelect = true;
            this.lv_monan.GridLines = true;
            this.lv_monan.HideSelection = false;
            this.lv_monan.Location = new System.Drawing.Point(27, 220);
            this.lv_monan.Name = "lv_monan";
            this.lv_monan.Size = new System.Drawing.Size(326, 209);
            this.lv_monan.TabIndex = 15;
            this.lv_monan.UseCompatibleStateImageBehavior = false;
            this.lv_monan.View = System.Windows.Forms.View.Details;
            this.lv_monan.Click += new System.EventHandler(this.lv_monan_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Món ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nước uống";
            // 
            // lv_nuocuong
            // 
            this.lv_nuocuong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_nuocuong.FullRowSelect = true;
            this.lv_nuocuong.GridLines = true;
            this.lv_nuocuong.HideSelection = false;
            this.lv_nuocuong.Location = new System.Drawing.Point(459, 220);
            this.lv_nuocuong.Name = "lv_nuocuong";
            this.lv_nuocuong.Size = new System.Drawing.Size(329, 209);
            this.lv_nuocuong.TabIndex = 15;
            this.lv_nuocuong.UseCompatibleStateImageBehavior = false;
            this.lv_nuocuong.View = System.Windows.Forms.View.Details;
            this.lv_nuocuong.SelectedIndexChanged += new System.EventHandler(this.lv_nuocuong_SelectedIndexChanged);
            this.lv_nuocuong.Click += new System.EventHandler(this.lv_nuocuong_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STT";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên món";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên món";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số thứ tự";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giá";
            // 
            // nu_sothutu
            // 
            this.nu_sothutu.Location = new System.Drawing.Point(281, 54);
            this.nu_sothutu.Name = "nu_sothutu";
            this.nu_sothutu.Size = new System.Drawing.Size(259, 22);
            this.nu_sothutu.TabIndex = 17;
            // 
            // nu_gia
            // 
            this.nu_gia.Location = new System.Drawing.Point(281, 120);
            this.nu_gia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nu_gia.Name = "nu_gia";
            this.nu_gia.Size = new System.Drawing.Size(259, 22);
            this.nu_gia.TabIndex = 17;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(369, 263);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 37);
            this.bt_xoa.TabIndex = 14;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Location = new System.Drawing.Point(369, 306);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(75, 37);
            this.bt_capnhat.TabIndex = 14;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // listview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nu_gia);
            this.Controls.Add(this.nu_sothutu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lv_nuocuong);
            this.Controls.Add(this.lv_monan);
            this.Controls.Add(this.bt_phaiquatrai);
            this.Controls.Add(this.bt_traiquaphai);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.txt_tenmon);
            this.Controls.Add(this.rd_nuocuong);
            this.Controls.Add(this.rd_monan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "listview";
            this.Text = "listview";
            this.Load += new System.EventHandler(this.listview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nu_sothutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_gia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_phaiquatrai;
        private System.Windows.Forms.Button bt_traiquaphai;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txt_tenmon;
        private System.Windows.Forms.RadioButton rd_nuocuong;
        private System.Windows.Forms.RadioButton rd_monan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_monan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_nuocuong;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nu_sothutu;
        private System.Windows.Forms.NumericUpDown nu_gia;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_capnhat;
    }
}