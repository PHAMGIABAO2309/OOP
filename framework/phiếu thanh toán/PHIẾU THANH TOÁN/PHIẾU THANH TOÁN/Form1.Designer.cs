namespace PHIẾU_THANH_TOÁN
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
            txtTENKHACHHANG = new TextBox();
            cbCAOVOI = new CheckBox();
            cbTAYTRANG = new CheckBox();
            cbCHUPHINHRANG = new CheckBox();
            txtTRAMRANG = new Label();
            nuTRAMRANG = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbTONGTIEN = new Label();
            btTINH = new Button();
            btTHOAT = new Button();
            ((System.ComponentModel.ISupportInitialize)nuTRAMRANG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 29);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU THANH TOÁN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 72);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng:";
            label2.Click += label1_Click;
            // 
            // txtTENKHACHHANG
            // 
            txtTENKHACHHANG.Location = new Point(356, 72);
            txtTENKHACHHANG.Name = "txtTENKHACHHANG";
            txtTENKHACHHANG.Size = new Size(285, 31);
            txtTENKHACHHANG.TabIndex = 1;
            // 
            // cbCAOVOI
            // 
            cbCAOVOI.AutoSize = true;
            cbCAOVOI.Location = new Point(110, 107);
            cbCAOVOI.Name = "cbCAOVOI";
            cbCAOVOI.Size = new Size(98, 29);
            cbCAOVOI.TabIndex = 2;
            cbCAOVOI.Text = "Cạo vôi";
            cbCAOVOI.UseVisualStyleBackColor = true;
            // 
            // cbTAYTRANG
            // 
            cbTAYTRANG.AutoSize = true;
            cbTAYTRANG.Location = new Point(110, 167);
            cbTAYTRANG.Name = "cbTAYTRANG";
            cbTAYTRANG.Size = new Size(112, 29);
            cbTAYTRANG.TabIndex = 2;
            cbTAYTRANG.Text = "Tẩy trắng";
            cbTAYTRANG.UseVisualStyleBackColor = true;
            // 
            // cbCHUPHINHRANG
            // 
            cbCHUPHINHRANG.AutoSize = true;
            cbCHUPHINHRANG.Location = new Point(110, 226);
            cbCHUPHINHRANG.Name = "cbCHUPHINHRANG";
            cbCHUPHINHRANG.Size = new Size(160, 29);
            cbCHUPHINHRANG.TabIndex = 2;
            cbCHUPHINHRANG.Text = "Chụp hình răng";
            cbCHUPHINHRANG.UseVisualStyleBackColor = true;
            // 
            // txtTRAMRANG
            // 
            txtTRAMRANG.AutoSize = true;
            txtTRAMRANG.Location = new Point(110, 286);
            txtTRAMRANG.Name = "txtTRAMRANG";
            txtTRAMRANG.Size = new Size(95, 25);
            txtTRAMRANG.TabIndex = 0;
            txtTRAMRANG.Text = "Trám răng:";
            txtTRAMRANG.Click += label1_Click;
            // 
            // nuTRAMRANG
            // 
            nuTRAMRANG.DecimalPlaces = 2;
            nuTRAMRANG.Location = new Point(219, 282);
            nuTRAMRANG.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nuTRAMRANG.Name = "nuTRAMRANG";
            nuTRAMRANG.Size = new Size(173, 31);
            nuTRAMRANG.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 168);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 0;
            label4.Text = "1.200.000 VNĐ";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(582, 114);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 0;
            label5.Text = "100.000 VNĐ";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 227);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 0;
            label6.Text = "200.000 VNĐ";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(582, 288);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 0;
            label7.Text = "80.000 VNĐ";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(262, 359);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 0;
            label8.Text = "Tổng tiền:";
            label8.Click += label1_Click;
            // 
            // lbTONGTIEN
            // 
            lbTONGTIEN.AutoSize = true;
            lbTONGTIEN.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTONGTIEN.ForeColor = Color.Red;
            lbTONGTIEN.Location = new Point(403, 359);
            lbTONGTIEN.Name = "lbTONGTIEN";
            lbTONGTIEN.Size = new Size(65, 25);
            lbTONGTIEN.TabIndex = 0;
            lbTONGTIEN.Text = "label1";
            lbTONGTIEN.Click += label1_Click;
            // 
            // btTINH
            // 
            btTINH.Location = new Point(179, 413);
            btTINH.Name = "btTINH";
            btTINH.Size = new Size(138, 73);
            btTINH.TabIndex = 4;
            btTINH.Text = "TÍNH";
            btTINH.UseVisualStyleBackColor = true;
            btTINH.Click += btTINH_Click;
            // 
            // btTHOAT
            // 
            btTHOAT.Location = new Point(503, 413);
            btTHOAT.Name = "btTHOAT";
            btTHOAT.Size = new Size(138, 73);
            btTHOAT.TabIndex = 4;
            btTHOAT.Text = "THOÁT";
            btTHOAT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 603);
            Controls.Add(btTHOAT);
            Controls.Add(btTINH);
            Controls.Add(nuTRAMRANG);
            Controls.Add(cbCHUPHINHRANG);
            Controls.Add(cbTAYTRANG);
            Controls.Add(cbCAOVOI);
            Controls.Add(txtTENKHACHHANG);
            Controls.Add(txtTRAMRANG);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(lbTONGTIEN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nuTRAMRANG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTENKHACHHANG;
        private CheckBox cbCAOVOI;
        private CheckBox cbTAYTRANG;
        private CheckBox cbCHUPHINHRANG;
        private Label txtTRAMRANG;
        private NumericUpDown nuTRAMRANG;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbTONGTIEN;
        private Button btTINH;
        private Button btTHOAT;
    }
}