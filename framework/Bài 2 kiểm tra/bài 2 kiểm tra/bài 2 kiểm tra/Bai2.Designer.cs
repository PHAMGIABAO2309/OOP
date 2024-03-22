namespace bài_2_kiểm_tra
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
            label4 = new Label();
            label5 = new Label();
            clbDSHP = new CheckedListBox();
            lstDadky = new ListBox();
            btChon = new Button();
            btTinh = new Button();
            label6 = new Label();
            lbTongTC = new Label();
            label8 = new Label();
            lbTongtien = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(441, 42);
            label1.Name = "label1";
            label1.Size = new Size(308, 38);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ HỌC PHẦN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 97);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 1;
            label2.Text = "Đơn giá 1 tín chỉ là:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 97);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 1;
            label3.Text = "350.000 VNĐ";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 146);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 1;
            label4.Text = "Danh sách học phần:";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(575, 146);
            label5.Name = "label5";
            label5.Size = new Size(271, 25);
            label5.TabIndex = 1;
            label5.Text = "Danh sách học phần đã đăng ký:";
            label5.Click += label2_Click;
            // 
            // clbDSHP
            // 
            clbDSHP.FormattingEnabled = true;
            clbDSHP.Location = new Point(182, 196);
            clbDSHP.Name = "clbDSHP";
            clbDSHP.Size = new Size(239, 200);
            clbDSHP.TabIndex = 2;
            // 
            // lstDadky
            // 
            lstDadky.FormattingEnabled = true;
            lstDadky.ItemHeight = 25;
            lstDadky.Location = new Point(575, 196);
            lstDadky.Name = "lstDadky";
            lstDadky.Size = new Size(271, 204);
            lstDadky.TabIndex = 3;
            // 
            // btChon
            // 
            btChon.Location = new Point(441, 222);
            btChon.Name = "btChon";
            btChon.Size = new Size(109, 62);
            btChon.TabIndex = 4;
            btChon.Text = "Chọn";
            btChon.UseVisualStyleBackColor = true;
            btChon.Click += btChon_Click;
            // 
            // btTinh
            // 
            btTinh.Location = new Point(441, 317);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(109, 62);
            btTinh.TabIndex = 4;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 449);
            label6.Name = "label6";
            label6.Size = new Size(227, 25);
            label6.TabIndex = 5;
            label6.Text = "Tổng số tín chỉ đã đăng ký:";
            // 
            // lbTongTC
            // 
            lbTongTC.AutoSize = true;
            lbTongTC.Location = new Point(700, 449);
            lbTongTC.Name = "lbTongTC";
            lbTongTC.Size = new Size(59, 25);
            lbTongTC.TabIndex = 5;
            lbTongTC.Text = "label6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(475, 496);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 5;
            label8.Text = "Tổng tiền là:";
            // 
            // lbTongtien
            // 
            lbTongtien.AutoSize = true;
            lbTongtien.Location = new Point(601, 496);
            lbTongtien.Name = "lbTongtien";
            lbTongtien.Size = new Size(59, 25);
            lbTongtien.TabIndex = 5;
            lbTongtien.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 682);
            Controls.Add(lbTongTC);
            Controls.Add(lbTongtien);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(btTinh);
            Controls.Add(btChon);
            Controls.Add(lstDadky);
            Controls.Add(clbDSHP);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckedListBox clbDSHP;
        private ListBox lstDadky;
        private Button btChon;
        private Button btTinh;
        private Label label6;
        private Label lbTongTC;
        private Label label8;
        private Label lbTongtien;
    }
}