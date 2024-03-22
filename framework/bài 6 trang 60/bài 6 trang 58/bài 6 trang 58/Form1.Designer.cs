namespace bài_6_trang_58
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
            cbbLOAIXE = new ComboBox();
            groupBox1 = new GroupBox();
            nuSOLUONG = new NumericUpDown();
            txtDONGIA = new TextBox();
            txtMAUSAC = new TextBox();
            txtTENXE = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btTINHTIEN = new Button();
            lbTONGTIEN = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuSOLUONG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CÁC LOẠI XE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 47);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "loại xe:";
            // 
            // cbbLOAIXE
            // 
            cbbLOAIXE.FormattingEnabled = true;
            cbbLOAIXE.Location = new Point(262, 45);
            cbbLOAIXE.Margin = new Padding(2);
            cbbLOAIXE.Name = "cbbLOAIXE";
            cbbLOAIXE.Size = new Size(166, 23);
            cbbLOAIXE.TabIndex = 1;
            cbbLOAIXE.SelectedIndexChanged += cbbLOAIXE_SelectedIndexChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nuSOLUONG);
            groupBox1.Controls.Add(txtDONGIA);
            groupBox1.Controls.Add(txtMAUSAC);
            groupBox1.Controls.Add(txtTENXE);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(91, 85);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(571, 227);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // nuSOLUONG
            // 
            nuSOLUONG.Location = new Point(179, 151);
            nuSOLUONG.Margin = new Padding(2);
            nuSOLUONG.Name = "nuSOLUONG";
            nuSOLUONG.Size = new Size(176, 23);
            nuSOLUONG.TabIndex = 2;
            // 
            // txtDONGIA
            // 
            txtDONGIA.Location = new Point(178, 118);
            txtDONGIA.Margin = new Padding(2);
            txtDONGIA.Name = "txtDONGIA";
            txtDONGIA.Size = new Size(176, 23);
            txtDONGIA.TabIndex = 1;
            // 
            // txtMAUSAC
            // 
            txtMAUSAC.Location = new Point(178, 77);
            txtMAUSAC.Margin = new Padding(2);
            txtMAUSAC.Name = "txtMAUSAC";
            txtMAUSAC.Size = new Size(176, 23);
            txtMAUSAC.TabIndex = 1;
            // 
            // txtTENXE
            // 
            txtTENXE.Location = new Point(178, 37);
            txtTENXE.Margin = new Padding(2);
            txtTENXE.Name = "txtTENXE";
            txtTENXE.Size = new Size(176, 23);
            txtTENXE.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(91, 154);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 0;
            label8.Text = "Số lượng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 79);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 0;
            label7.Text = "Màu sắc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 122);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 0;
            label6.Text = "Đơn giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 39);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 0;
            label5.Text = "Tên xe:";
            // 
            // btTINHTIEN
            // 
            btTINHTIEN.Location = new Point(90, 334);
            btTINHTIEN.Margin = new Padding(2);
            btTINHTIEN.Name = "btTINHTIEN";
            btTINHTIEN.Size = new Size(137, 71);
            btTINHTIEN.TabIndex = 3;
            btTINHTIEN.Text = "Tính tiền";
            btTINHTIEN.UseVisualStyleBackColor = true;
            btTINHTIEN.Click += btTINHTIEN_Click;
            // 
            // lbTONGTIEN
            // 
            lbTONGTIEN.AutoSize = true;
            lbTONGTIEN.Location = new Point(413, 339);
            lbTONGTIEN.Margin = new Padding(2, 0, 2, 0);
            lbTONGTIEN.Name = "lbTONGTIEN";
            lbTONGTIEN.Size = new Size(38, 15);
            lbTONGTIEN.TabIndex = 4;
            lbTONGTIEN.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 339);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Thành tiền:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 414);
            Controls.Add(label4);
            Controls.Add(lbTONGTIEN);
            Controls.Add(btTINHTIEN);
            Controls.Add(groupBox1);
            Controls.Add(cbbLOAIXE);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuSOLUONG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbbLOAIXE;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btTINHTIEN;
        private Label lbTONGTIEN;
        private Label label4;
        private TextBox txtDONGIA;
        private TextBox txtMAUSAC;
        private TextBox txtTENXE;
        private Label label8;
        private NumericUpDown nuSOLUONG;
    }
}