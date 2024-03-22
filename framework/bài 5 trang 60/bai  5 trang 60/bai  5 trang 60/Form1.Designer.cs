namespace bai__5_trang_60
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
            txtTENMON = new TextBox();
            rdMONAN = new RadioButton();
            rdNUOCUONG = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            lstMONAN = new ListBox();
            lstNUOCUONG = new ListBox();
            btQUAPHAI = new Button();
            btQUATRAI = new Button();
            btTHEM = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 34);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 0;
            label1.Text = "CÀ PHÊ PHẠM GIA BẢO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 82);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên món:";
            // 
            // txtTENMON
            // 
            txtTENMON.Location = new Point(276, 76);
            txtTENMON.Name = "txtTENMON";
            txtTENMON.Size = new Size(212, 31);
            txtTENMON.TabIndex = 1;
            // 
            // rdMONAN
            // 
            rdMONAN.AutoSize = true;
            rdMONAN.Location = new Point(219, 146);
            rdMONAN.Name = "rdMONAN";
            rdMONAN.Size = new Size(98, 29);
            rdMONAN.TabIndex = 2;
            rdMONAN.TabStop = true;
            rdMONAN.Text = "Món ăn";
            rdMONAN.UseVisualStyleBackColor = true;
            rdMONAN.CheckedChanged += rdMONAN_CheckedChanged;
            // 
            // rdNUOCUONG
            // 
            rdNUOCUONG.AutoSize = true;
            rdNUOCUONG.Location = new Point(379, 146);
            rdNUOCUONG.Name = "rdNUOCUONG";
            rdNUOCUONG.Size = new Size(127, 29);
            rdNUOCUONG.TabIndex = 2;
            rdNUOCUONG.TabStop = true;
            rdNUOCUONG.Text = "Nước uống";
            rdNUOCUONG.UseVisualStyleBackColor = true;
            rdNUOCUONG.CheckedChanged += rdNUOCUONG_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 211);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 0;
            label3.Text = "Nước uống:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 211);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 0;
            label4.Text = "Món ăn:";
            // 
            // lstMONAN
            // 
            lstMONAN.FormattingEnabled = true;
            lstMONAN.ItemHeight = 25;
            lstMONAN.Location = new Point(94, 261);
            lstMONAN.Name = "lstMONAN";
            lstMONAN.Size = new Size(192, 279);
            lstMONAN.TabIndex = 3;
            // 
            // lstNUOCUONG
            // 
            lstNUOCUONG.FormattingEnabled = true;
            lstNUOCUONG.ItemHeight = 25;
            lstNUOCUONG.Location = new Point(429, 261);
            lstNUOCUONG.Name = "lstNUOCUONG";
            lstNUOCUONG.Size = new Size(192, 279);
            lstNUOCUONG.TabIndex = 3;
            // 
            // btQUAPHAI
            // 
            btQUAPHAI.Location = new Point(309, 354);
            btQUAPHAI.Name = "btQUAPHAI";
            btQUAPHAI.Size = new Size(97, 50);
            btQUAPHAI.TabIndex = 4;
            btQUAPHAI.Text = ">>";
            btQUAPHAI.UseVisualStyleBackColor = true;
            btQUAPHAI.Click += btQUAPHAI_Click;
            // 
            // btQUATRAI
            // 
            btQUATRAI.Location = new Point(309, 429);
            btQUATRAI.Name = "btQUATRAI";
            btQUATRAI.Size = new Size(97, 50);
            btQUATRAI.TabIndex = 4;
            btQUATRAI.Text = "<<";
            btQUATRAI.UseVisualStyleBackColor = true;
            btQUATRAI.Click += btQUATRAI_Click;
            // 
            // btTHEM
            // 
            btTHEM.Location = new Point(309, 261);
            btTHEM.Name = "btTHEM";
            btTHEM.Size = new Size(97, 50);
            btTHEM.TabIndex = 4;
            btTHEM.Text = "Thêm";
            btTHEM.UseVisualStyleBackColor = true;
            btTHEM.Click += btTHEM_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 668);
            Controls.Add(btTHEM);
            Controls.Add(btQUATRAI);
            Controls.Add(btQUAPHAI);
            Controls.Add(lstNUOCUONG);
            Controls.Add(lstMONAN);
            Controls.Add(rdNUOCUONG);
            Controls.Add(rdMONAN);
            Controls.Add(txtTENMON);
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
        private TextBox txtTENMON;
        private RadioButton rdMONAN;
        private RadioButton rdNUOCUONG;
        private Label label3;
        private Label label4;
        private ListBox lstMONAN;
        private ListBox lstNUOCUONG;
        private Button btQUAPHAI;
        private Button btQUATRAI;
        private Button btTHEM;
    }
}