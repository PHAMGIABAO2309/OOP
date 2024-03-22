namespace _022101023
{
    partial class Bai1
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
            dtNgayDat = new DateTimePicker();
            txtHoTen = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lstDS = new ListBox();
            btQuaPhai = new Button();
            lbTong = new Label();
            label7 = new Label();
            txtThongTin = new TextBox();
            lstDaChon = new ListBox();
            btChon = new Button();
            btBoChon = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 48);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH MÓN ĂN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 67);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 1;
            label2.Text = "Họ tên khách hàng:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 127);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày đặt hàng:";
            label3.Click += label3_Click;
            // 
            // dtNgayDat
            // 
            dtNgayDat.Location = new Point(280, 127);
            dtNgayDat.Name = "dtNgayDat";
            dtNgayDat.Size = new Size(234, 31);
            dtNgayDat.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(280, 64);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(234, 31);
            txtHoTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 206);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 2;
            label4.Text = "Danh sách món ăn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 206);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 2;
            label5.Text = "Món ăn đã chọn:";
            label5.Click += label3_Click;
            // 
            // lstDS
            // 
            lstDS.FormattingEnabled = true;
            lstDS.ItemHeight = 25;
            lstDS.Location = new Point(81, 245);
            lstDS.Name = "lstDS";
            lstDS.Size = new Size(178, 154);
            lstDS.TabIndex = 5;
            // 
            // btQuaPhai
            // 
            btQuaPhai.Location = new Point(330, 245);
            btQuaPhai.Name = "btQuaPhai";
            btQuaPhai.Size = new Size(107, 63);
            btQuaPhai.TabIndex = 7;
            btQuaPhai.Text = ">";
            btQuaPhai.UseVisualStyleBackColor = true;
            btQuaPhai.Click += btQuaPhai_Click;
            // 
            // lbTong
            // 
            lbTong.AutoSize = true;
            lbTong.Location = new Point(427, 477);
            lbTong.Name = "lbTong";
            lbTong.Size = new Size(59, 25);
            lbTong.TabIndex = 8;
            lbTong.Text = "label6";
            lbTong.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 477);
            label7.Name = "label7";
            label7.Size = new Size(216, 25);
            label7.TabIndex = 8;
            label7.Text = "Tổng số món ăn đã chọn:";
            // 
            // txtThongTin
            // 
            txtThongTin.Location = new Point(141, 532);
            txtThongTin.Multiline = true;
            txtThongTin.Name = "txtThongTin";
            txtThongTin.Size = new Size(490, 145);
            txtThongTin.TabIndex = 9;
            // 
            // lstDaChon
            // 
            lstDaChon.FormattingEnabled = true;
            lstDaChon.ItemHeight = 25;
            lstDaChon.Location = new Point(493, 245);
            lstDaChon.Name = "lstDaChon";
            lstDaChon.Size = new Size(193, 154);
            lstDaChon.TabIndex = 10;
            // 
            // btChon
            // 
            btChon.Location = new Point(178, 418);
            btChon.Name = "btChon";
            btChon.Size = new Size(87, 49);
            btChon.TabIndex = 11;
            btChon.Text = "Chọn";
            btChon.UseVisualStyleBackColor = true;
            btChon.Click += btChon_Click;
            // 
            // btBoChon
            // 
            btBoChon.Location = new Point(330, 418);
            btBoChon.Name = "btBoChon";
            btBoChon.Size = new Size(87, 49);
            btBoChon.TabIndex = 11;
            btBoChon.Text = "Bỏ chọn";
            btBoChon.UseVisualStyleBackColor = true;
            btBoChon.Click += btBoChon_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(493, 418);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(87, 49);
            btThoat.TabIndex = 11;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 689);
            Controls.Add(btThoat);
            Controls.Add(btBoChon);
            Controls.Add(btChon);
            Controls.Add(lstDaChon);
            Controls.Add(txtThongTin);
            Controls.Add(label7);
            Controls.Add(lbTong);
            Controls.Add(btQuaPhai);
            Controls.Add(lstDS);
            Controls.Add(txtHoTen);
            Controls.Add(dtNgayDat);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
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
        private DateTimePicker dtNgayDat;
        private TextBox txtHoTen;
        private Label label4;
        private Label label5;
        private ListBox lstDS;
        private Button btQuaPhai;
        private Label lbTong;
        private Label label7;
        private TextBox txtThongTin;
        private ListBox lstDaChon;
        private Button btChon;
        private Button btBoChon;
        private Button btThoat;
    }
}
