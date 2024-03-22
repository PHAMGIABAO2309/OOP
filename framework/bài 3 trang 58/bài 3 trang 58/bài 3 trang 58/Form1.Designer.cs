namespace bài_3_trang_58
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
            groupBox1 = new GroupBox();
            rdmouse = new RadioButton();
            rdusb = new RadioButton();
            rdlaptop = new RadioButton();
            groupBox2 = new GroupBox();
            pic5 = new PictureBox();
            pic3 = new PictureBox();
            pic2 = new PictureBox();
            pic4 = new PictureBox();
            pic1 = new PictureBox();
            lstlaptop = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 41);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 0;
            label1.Text = "CỬA HÀNG VI TÍNH GIA BẢO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdmouse);
            groupBox1.Controls.Add(rdusb);
            groupBox1.Controls.Add(rdlaptop);
            groupBox1.Location = new Point(63, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 269);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các loại hàng hoá";
            //groupBox1.Enter += groupBox1_Enter;
            // 
            // rdmouse
            // 
            rdmouse.AutoSize = true;
            rdmouse.Location = new Point(55, 161);
            rdmouse.Name = "rdmouse";
            rdmouse.Size = new Size(91, 29);
            rdmouse.TabIndex = 0;
            rdmouse.TabStop = true;
            rdmouse.Text = "Mouse";
            rdmouse.UseVisualStyleBackColor = true;
            // 
            // rdusb
            // 
            rdusb.AutoSize = true;
            rdusb.Location = new Point(55, 112);
            rdusb.Name = "rdusb";
            rdusb.Size = new Size(69, 29);
            rdusb.TabIndex = 0;
            rdusb.TabStop = true;
            rdusb.Text = "USB";
            rdusb.UseVisualStyleBackColor = true;
            rdusb.CheckedChanged += rdusb_CheckedChanged;
            // 
            // rdlaptop
            // 
            rdlaptop.AutoSize = true;
            rdlaptop.Location = new Point(55, 56);
            rdlaptop.Name = "rdlaptop";
            rdlaptop.Size = new Size(93, 29);
            rdlaptop.TabIndex = 0;
            rdlaptop.TabStop = true;
            rdlaptop.Text = "Laptop";
            rdlaptop.UseVisualStyleBackColor = true;
            rdlaptop.CheckedChanged += rdlaptop_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pic5);
            groupBox2.Controls.Add(pic3);
            groupBox2.Controls.Add(pic2);
            groupBox2.Controls.Add(pic4);
            groupBox2.Controls.Add(pic1);
            groupBox2.Controls.Add(lstlaptop);
            groupBox2.Location = new Point(414, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(595, 416);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các dòng sản phẩm và hình minh hoạ";
            // 
            // pic5
            // 
            pic5.BackColor = Color.Transparent;
            pic5.BackgroundImageLayout = ImageLayout.None;
            pic5.Enabled = false;
            pic5.Location = new Point(253, 71);
            pic5.Name = "pic5";
            pic5.Size = new Size(321, 239);
            pic5.SizeMode = PictureBoxSizeMode.StretchImage;
            pic5.TabIndex = 3;
            pic5.TabStop = false;
            // 
            // pic3
            // 
            pic3.BackgroundImage = Properties.Resources.kingmax;
            pic3.Location = new Point(253, 219);
            pic3.Name = "pic3";
            pic3.Size = new Size(133, 91);
            pic3.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3.TabIndex = 2;
            pic3.TabStop = false;
            // 
            // pic2
            // 
            pic2.BackgroundImage = Properties.Resources.kington;
            pic2.Location = new Point(408, 71);
            pic2.Name = "pic2";
            pic2.Size = new Size(166, 91);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabIndex = 2;
            pic2.TabStop = false;
            // 
            // pic4
            // 
            pic4.BackgroundImage = Properties.Resources.adapt;
            pic4.Location = new Point(408, 219);
            pic4.Name = "pic4";
            pic4.Size = new Size(166, 91);
            pic4.SizeMode = PictureBoxSizeMode.StretchImage;
            pic4.TabIndex = 2;
            pic4.TabStop = false;
            // 
            // pic1
            // 
            pic1.BackgroundImage = Properties.Resources.trancer;
            pic1.Location = new Point(253, 71);
            pic1.Name = "pic1";
            pic1.Size = new Size(133, 93);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 1;
            pic1.TabStop = false;
            //pic1.Click += pic1_Click;
            // 
            // lstlaptop
            // 
            lstlaptop.FormattingEnabled = true;
            lstlaptop.ItemHeight = 25;
            lstlaptop.Location = new Point(27, 69);
            lstlaptop.Name = "lstlaptop";
            lstlaptop.Size = new Size(193, 329);
            lstlaptop.TabIndex = 0;
            lstlaptop.SelectedIndexChanged += lstlaptop_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 666);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rdmouse;
        private RadioButton rdusb;
        private RadioButton rdlaptop;
        private GroupBox groupBox2;
        private ListBox lstlaptop;
        private PictureBox pic1;
        private PictureBox pic3;
        private PictureBox pic2;
        private PictureBox pic4;
        private PictureBox pic5;
    }
}