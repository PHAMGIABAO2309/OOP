namespace bài_1_kiểm_tra
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
            label6 = new Label();
            lbTong = new Label();
            txtThongTin = new TextBox();
            lstDS = new ListBox();
            btQuaPhai = new Button();
            btChon = new Button();
            btBoChon = new Button();
            btThoat = new Button();
            txtHoTen = new TextBox();
            dtNgayDat = new DateTimePicker();
            lstDaChon = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 48);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH MÓN ĂN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 82);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 0;
            label2.Text = "Họ tên khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 132);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 0;
            label3.Text = "Ngày đặt hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 395);
            label4.Name = "label4";
            label4.Size = new Size(234, 25);
            label4.TabIndex = 0;
            label4.Text = "Tổng số món ăn đã chọn là:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 177);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 0;
            label5.Text = "Món ăn đã chọn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 177);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 0;
            label6.Text = "Danh sách món ăn:";
            label6.Click += label4_Click;
            // 
            // lbTong
            // 
            lbTong.AutoSize = true;
            lbTong.Location = new Point(355, 395);
            lbTong.Name = "lbTong";
            lbTong.Size = new Size(59, 25);
            lbTong.TabIndex = 0;
            lbTong.Text = "label1";
            lbTong.Click += label4_Click;
            // 
            // txtThongTin
            // 
            txtThongTin.Location = new Point(114, 446);
            txtThongTin.Multiline = true;
            txtThongTin.Name = "txtThongTin";
            txtThongTin.Size = new Size(496, 213);
            txtThongTin.TabIndex = 1;
            // 
            // lstDS
            // 
            lstDS.FormattingEnabled = true;
            lstDS.ItemHeight = 25;
            lstDS.Location = new Point(89, 216);
            lstDS.Name = "lstDS";
            lstDS.Size = new Size(159, 129);
            lstDS.TabIndex = 2;
            // 
            // btQuaPhai
            // 
            btQuaPhai.Location = new Point(287, 260);
            btQuaPhai.Name = "btQuaPhai";
            btQuaPhai.Size = new Size(97, 37);
            btQuaPhai.TabIndex = 4;
            btQuaPhai.Text = ">>";
            btQuaPhai.UseVisualStyleBackColor = true;
            btQuaPhai.Click += btQuaPhai_Click;
            // 
            // btChon
            // 
            btChon.Location = new Point(135, 355);
            btChon.Name = "btChon";
            btChon.Size = new Size(97, 37);
            btChon.TabIndex = 4;
            btChon.Text = "Chọn";
            btChon.UseVisualStyleBackColor = true;
            btChon.Click += btChon_Click;
            // 
            // btBoChon
            // 
            btBoChon.Location = new Point(287, 355);
            btBoChon.Name = "btBoChon";
            btBoChon.Size = new Size(97, 37);
            btBoChon.TabIndex = 4;
            btBoChon.Text = "Bỏ chọn";
            btBoChon.UseVisualStyleBackColor = true;
            btBoChon.Click += btBoChon_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(434, 355);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(97, 37);
            btThoat.TabIndex = 4;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(258, 79);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(240, 31);
            txtHoTen.TabIndex = 5;
            // 
            // dtNgayDat
            // 
            dtNgayDat.Location = new Point(258, 132);
            dtNgayDat.Name = "dtNgayDat";
            dtNgayDat.Size = new Size(240, 31);
            dtNgayDat.TabIndex = 6;
            // 
            // lstDaChon
            // 
            lstDaChon.FormattingEnabled = true;
            lstDaChon.ItemHeight = 25;
            lstDaChon.Location = new Point(434, 216);
            lstDaChon.Name = "lstDaChon";
            lstDaChon.Size = new Size(172, 129);
            lstDaChon.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 687);
            Controls.Add(lstDaChon);
            Controls.Add(dtNgayDat);
            Controls.Add(txtHoTen);
            Controls.Add(btThoat);
            Controls.Add(btBoChon);
            Controls.Add(btChon);
            Controls.Add(btQuaPhai);
            Controls.Add(lstDS);
            Controls.Add(txtThongTin);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(lbTong);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbTong;
        private TextBox txtThongTin;
        private ListBox lstDS;
        private Button btQuaPhai;
        private Button btChon;
        private Button btBoChon;
        private Button btThoat;
        private TextBox txtHoTen;
        private DateTimePicker dtNgayDat;
        private ListBox lstDaChon;
    }
}