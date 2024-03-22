namespace _022101023
{
    partial class Bai2
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
            label4 = new Label();
            label5 = new Label();
            clbDSHP = new CheckedListBox();
            lstDadky = new ListBox();
            btChon = new Button();
            label6 = new Label();
            lbTongTC = new Label();
            label8 = new Label();
            lbTongtien = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 27);
            label1.Name = "label1";
            label1.Size = new Size(396, 48);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ HỌC PHẦN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 75);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 1;
            label2.Text = "Đơn giá 1 tín chỉ là:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 75);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 2;
            label3.Text = "350.000 VNĐ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 132);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 3;
            label4.Text = "Danh sách học phần:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(511, 132);
            label5.Name = "label5";
            label5.Size = new Size(271, 25);
            label5.TabIndex = 4;
            label5.Text = "Danh sách học phần đã đăng ký:";
            // 
            // clbDSHP
            // 
            clbDSHP.FormattingEnabled = true;
            clbDSHP.Location = new Point(72, 172);
            clbDSHP.Name = "clbDSHP";
            clbDSHP.Size = new Size(261, 200);
            clbDSHP.TabIndex = 5;
            // 
            // lstDadky
            // 
            lstDadky.FormattingEnabled = true;
            lstDadky.ItemHeight = 25;
            lstDadky.Location = new Point(511, 176);
            lstDadky.Name = "lstDadky";
            lstDadky.Size = new Size(271, 204);
            lstDadky.TabIndex = 6;
            // 
            // btChon
            // 
            btChon.Location = new Point(374, 205);
            btChon.Name = "btChon";
            btChon.Size = new Size(92, 68);
            btChon.TabIndex = 7;
            btChon.Text = "Chọn";
            btChon.UseVisualStyleBackColor = true;
            btChon.Click += btChon_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(340, 436);
            label6.Name = "label6";
            label6.Size = new Size(227, 25);
            label6.TabIndex = 8;
            label6.Text = "Tổng số tín chỉ đã đăng ký:";
            // 
            // lbTongTC
            // 
            lbTongTC.AutoSize = true;
            lbTongTC.Location = new Point(573, 436);
            lbTongTC.Name = "lbTongTC";
            lbTongTC.Size = new Size(59, 25);
            lbTongTC.TabIndex = 9;
            lbTongTC.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 507);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 10;
            label8.Text = "Tổng tiền là:";
            // 
            // lbTongtien
            // 
            lbTongtien.AutoSize = true;
            lbTongtien.Location = new Point(477, 507);
            lbTongtien.Name = "lbTongtien";
            lbTongtien.Size = new Size(59, 25);
            lbTongtien.TabIndex = 11;
            lbTongtien.Text = "label9";
            // 
            // button2
            // 
            button2.Location = new Point(374, 304);
            button2.Name = "button2";
            button2.Size = new Size(92, 68);
            button2.TabIndex = 7;
            button2.Text = "Tính";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 680);
            Controls.Add(lbTongtien);
            Controls.Add(label8);
            Controls.Add(lbTongTC);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(btChon);
            Controls.Add(lstDadky);
            Controls.Add(clbDSHP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
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
        private Label label6;
        private Label lbTongTC;
        private Label label8;
        private Label lbTongtien;
        private Button button2;
    }
}