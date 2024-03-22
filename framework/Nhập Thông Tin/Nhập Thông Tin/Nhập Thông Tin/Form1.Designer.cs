namespace Nhập_Thông_Tin
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
            groupBox1 = new GroupBox();
            dtpNGAYSINH = new DateTimePicker();
            cbbGIOITINH = new ComboBox();
            txtMSSV = new TextBox();
            txtFULLNAME = new TextBox();
            txtADDRESS = new TextBox();
            txtKETQUA = new TextBox();
            btEXITS = new Button();
            btINPUT = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNGAYSINH);
            groupBox1.Controls.Add(cbbGIOITINH);
            groupBox1.Controls.Add(txtMSSV);
            groupBox1.Controls.Add(txtFULLNAME);
            groupBox1.Controls.Add(txtADDRESS);
            groupBox1.Controls.Add(txtKETQUA);
            groupBox1.Controls.Add(btEXITS);
            groupBox1.Controls.Add(btINPUT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(50, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1037, 603);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dtpNGAYSINH
            // 
            dtpNGAYSINH.Location = new Point(194, 127);
            dtpNGAYSINH.Name = "dtpNGAYSINH";
            dtpNGAYSINH.Size = new Size(409, 31);
            dtpNGAYSINH.TabIndex = 5;
            // 
            // cbbGIOITINH
            // 
            cbbGIOITINH.FormattingEnabled = true;
            cbbGIOITINH.Location = new Point(737, 238);
            cbbGIOITINH.Name = "cbbGIOITINH";
            cbbGIOITINH.Size = new Size(166, 33);
            cbbGIOITINH.TabIndex = 4;
            cbbGIOITINH.SelectedIndexChanged += cbbGIOITINH_SelectedIndexChanged;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(192, 241);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(411, 31);
            txtMSSV.TabIndex = 3;
            // 
            // txtFULLNAME
            // 
            txtFULLNAME.Location = new Point(194, 54);
            txtFULLNAME.Name = "txtFULLNAME";
            txtFULLNAME.Size = new Size(411, 31);
            txtFULLNAME.TabIndex = 3;
            // 
            // txtADDRESS
            // 
            txtADDRESS.Location = new Point(194, 186);
            txtADDRESS.Name = "txtADDRESS";
            txtADDRESS.Size = new Size(411, 31);
            txtADDRESS.TabIndex = 3;
            // 
            // txtKETQUA
            // 
            txtKETQUA.Location = new Point(96, 340);
            txtKETQUA.Multiline = true;
            txtKETQUA.Name = "txtKETQUA";
            txtKETQUA.Size = new Size(568, 257);
            txtKETQUA.TabIndex = 2;
            // 
            // btEXITS
            // 
            btEXITS.Location = new Point(434, 293);
            btEXITS.Name = "btEXITS";
            btEXITS.Size = new Size(100, 42);
            btEXITS.TabIndex = 1;
            btEXITS.Text = "Exits";
            btEXITS.UseVisualStyleBackColor = true;
            btEXITS.Click += btEXITS_Click;
            // 
            // btINPUT
            // 
            btINPUT.Location = new Point(137, 293);
            btINPUT.Name = "btINPUT";
            btINPUT.Size = new Size(100, 42);
            btINPUT.TabIndex = 1;
            btINPUT.Text = "Input";
            btINPUT.UseVisualStyleBackColor = true;
            btINPUT.Click += btINPUT_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(649, 241);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 0;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 247);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 0;
            label4.Text = "MSSV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 189);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 0;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 133);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Text = "Date of birth:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 60);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 647);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpNGAYSINH;
        private ComboBox cbbGIOITINH;
        private TextBox txtMSSV;
        private TextBox txtFULLNAME;
        private TextBox txtADDRESS;
        private TextBox txtKETQUA;
        private Button btEXITS;
        private Button btINPUT;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}