namespace PictureBox
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
            pic1 = new System.Windows.Forms.PictureBox();
            pic2 = new System.Windows.Forms.PictureBox();
            btHIENTHI = new Button();
            btTHOAT = new Button();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            SuspendLayout();
            // 
            // pic1
            // 
            pic1.Image = Properties.Resources.nagumo;
            pic1.Location = new Point(84, 61);
            pic1.Name = "pic1";
            pic1.Size = new Size(522, 392);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 0;
            pic1.TabStop = false;
            pic1.Click += pic1_Click;
            // 
            // pic2
            // 
            pic2.Location = new Point(634, 59);
            pic2.Name = "pic2";
            pic2.Size = new Size(405, 418);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabIndex = 1;
            pic2.TabStop = false;
            // 
            // btHIENTHI
            // 
            btHIENTHI.Location = new Point(513, 530);
            btHIENTHI.Name = "btHIENTHI";
            btHIENTHI.Size = new Size(185, 87);
            btHIENTHI.TabIndex = 2;
            btHIENTHI.Text = "HIỂN THỊ";
            btHIENTHI.UseVisualStyleBackColor = true;
            btHIENTHI.Click += btHIENTHI_Click;
            // 
            // btTHOAT
            // 
            btTHOAT.Location = new Point(780, 537);
            btTHOAT.Name = "btTHOAT";
            btTHOAT.Size = new Size(215, 90);
            btTHOAT.TabIndex = 3;
            btTHOAT.Text = "THOAT";
            btTHOAT.UseVisualStyleBackColor = true;
            btTHOAT.Click += btTHOAT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 659);
            Controls.Add(btTHOAT);
            Controls.Add(btHIENTHI);
            Controls.Add(pic2);
            Controls.Add(pic1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private Button btHIENTHI;
        private Button btTHOAT;
    }
}