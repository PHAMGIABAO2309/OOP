namespace Timer
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dtNGAY = new DateTimePicker();
            button1 = new Button();
            txtNGAY = new TextBox();
            label2 = new Label();
            timer_thoigian = new System.Windows.Forms.Timer(components);
            nuGIO = new NumericUpDown();
            nuPHUT = new NumericUpDown();
            nuGIAY = new NumericUpDown();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            lbTHOIGIANCONLAI = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)nuGIO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuPHUT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuGIAY).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 55);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 0;
            label1.Text = "ngày:";
            // 
            // dtNGAY
            // 
            dtNGAY.CustomFormat = "MM/dd/yyyy";
            dtNGAY.Format = DateTimePickerFormat.Custom;
            dtNGAY.Location = new Point(191, 50);
            dtNGAY.Name = "dtNGAY";
            dtNGAY.Size = new Size(294, 31);
            dtNGAY.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(511, 50);
            button1.Name = "button1";
            button1.Size = new Size(80, 43);
            button1.TabIndex = 2;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNGAY
            // 
            txtNGAY.Location = new Point(630, 52);
            txtNGAY.Multiline = true;
            txtNGAY.Name = "txtNGAY";
            txtNGAY.Size = new Size(162, 52);
            txtNGAY.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 116);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 4;
            label2.Text = "Chọn thời gian:";
            label2.Click += label2_Click;
            // 
            // timer_thoigian
            // 
            timer_thoigian.Enabled = true;
            timer_thoigian.Tick += timer_thoigian_Tick;
            // 
            // nuGIO
            // 
            nuGIO.Location = new Point(165, 167);
            nuGIO.Name = "nuGIO";
            nuGIO.Size = new Size(86, 31);
            nuGIO.TabIndex = 5;
            // 
            // nuPHUT
            // 
            nuPHUT.Location = new Point(387, 167);
            nuPHUT.Name = "nuPHUT";
            nuPHUT.Size = new Size(86, 31);
            nuPHUT.TabIndex = 5;
            // 
            // nuGIAY
            // 
            nuGIAY.Location = new Point(630, 167);
            nuGIAY.Name = "nuGIAY";
            nuGIAY.Size = new Size(86, 31);
            nuGIAY.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 169);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 4;
            label3.Text = "giờ";
            label3.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(733, 173);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 4;
            label5.Text = "giây";
            label5.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 173);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 4;
            label4.Text = "phút ";
            label4.Click += label2_Click;
            // 
            // lbTHOIGIANCONLAI
            // 
            lbTHOIGIANCONLAI.AutoSize = true;
            lbTHOIGIANCONLAI.Location = new Point(30, 228);
            lbTHOIGIANCONLAI.Name = "lbTHOIGIANCONLAI";
            lbTHOIGIANCONLAI.Size = new Size(145, 25);
            lbTHOIGIANCONLAI.TabIndex = 6;
            lbTHOIGIANCONLAI.Text = "Thời gian còn lại:";
            // 
            // button2
            // 
            button2.Location = new Point(353, 219);
            button2.Name = "button2";
            button2.Size = new Size(132, 43);
            button2.TabIndex = 7;
            button2.Text = "Bắt đầu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(597, 219);
            button3.Name = "button3";
            button3.Size = new Size(132, 43);
            button3.TabIndex = 7;
            button3.Text = "Huỷ";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 681);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lbTHOIGIANCONLAI);
            Controls.Add(nuGIAY);
            Controls.Add(nuPHUT);
            Controls.Add(nuGIO);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNGAY);
            Controls.Add(button1);
            Controls.Add(dtNGAY);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nuGIO).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuPHUT).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuGIAY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtNGAY;
        private Button button1;
        private TextBox txtNGAY;
        private Label label2;
        private System.Windows.Forms.Timer timer_thoigian;
        private NumericUpDown nuGIO;
        private NumericUpDown nuPHUT;
        private NumericUpDown nuGIAY;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label lbTHOIGIANCONLAI;
        private Button button2;
        private Button button3;
    }
}