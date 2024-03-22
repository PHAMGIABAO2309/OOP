namespace CheckedListBox
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
            clbSUBJECT = new System.Windows.Forms.CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            btDELETE = new Button();
            btEXITS = new Button();
            btADD = new Button();
            txtSUBJECT = new TextBox();
            nuLOCATION = new NumericUpDown();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            txtSELECTEDLINES = new TextBox();
            txtSELECTEDSUBJECT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nuLOCATION).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // clbSUBJECT
            // 
            clbSUBJECT.FormattingEnabled = true;
            clbSUBJECT.Location = new Point(32, 18);
            clbSUBJECT.Name = "clbSUBJECT";
            clbSUBJECT.Size = new Size(258, 396);
            clbSUBJECT.TabIndex = 0;
            clbSUBJECT.SelectedIndexChanged += clbSUBJECT_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(404, 36);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 105);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "location:";
            // 
            // btDELETE
            // 
            btDELETE.Location = new Point(506, 180);
            btDELETE.Name = "btDELETE";
            btDELETE.Size = new Size(110, 53);
            btDELETE.TabIndex = 2;
            btDELETE.Text = "delete";
            btDELETE.UseVisualStyleBackColor = true;
            btDELETE.Click += btDELETE_Click;
            // 
            // btEXITS
            // 
            btEXITS.Location = new Point(699, 180);
            btEXITS.Name = "btEXITS";
            btEXITS.Size = new Size(110, 53);
            btEXITS.TabIndex = 2;
            btEXITS.Text = "exits";
            btEXITS.UseVisualStyleBackColor = true;
            btEXITS.Click += btEXITS_Click;
            // 
            // btADD
            // 
            btADD.Location = new Point(337, 163);
            btADD.Name = "btADD";
            btADD.Size = new Size(120, 69);
            btADD.TabIndex = 3;
            btADD.Text = "add";
            btADD.UseVisualStyleBackColor = true;
            btADD.Click += btADD_Click;
            // 
            // txtSUBJECT
            // 
            txtSUBJECT.Location = new Point(534, 29);
            txtSUBJECT.Name = "txtSUBJECT";
            txtSUBJECT.Size = new Size(304, 31);
            txtSUBJECT.TabIndex = 4;
            // 
            // nuLOCATION
            // 
            nuLOCATION.Location = new Point(536, 110);
            nuLOCATION.Name = "nuLOCATION";
            nuLOCATION.Size = new Size(295, 31);
            nuLOCATION.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSELECTEDLINES);
            groupBox1.Controls.Add(txtSELECTEDSUBJECT);
            groupBox1.Location = new Point(359, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 411);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "infomation details:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 255);
            label4.Name = "label4";
            label4.Size = new Size(186, 25);
            label4.TabIndex = 1;
            label4.Text = "Index of selected lines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 64);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 1;
            label3.Text = "Selected Subject:";
            // 
            // txtSELECTEDLINES
            // 
            txtSELECTEDLINES.Location = new Point(146, 305);
            txtSELECTEDLINES.Name = "txtSELECTEDLINES";
            txtSELECTEDLINES.Size = new Size(304, 31);
            txtSELECTEDLINES.TabIndex = 4;
            // 
            // txtSELECTEDSUBJECT
            // 
            txtSELECTEDSUBJECT.Location = new Point(196, 73);
            txtSELECTEDSUBJECT.Multiline = true;
            txtSELECTEDSUBJECT.Name = "txtSELECTEDSUBJECT";
            txtSELECTEDSUBJECT.Size = new Size(304, 165);
            txtSELECTEDSUBJECT.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 671);
            Controls.Add(groupBox1);
            Controls.Add(nuLOCATION);
            Controls.Add(txtSUBJECT);
            Controls.Add(btADD);
            Controls.Add(btEXITS);
            Controls.Add(btDELETE);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clbSUBJECT);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nuLOCATION).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbSUBJECT;
        private Label label1;
        private Label label2;
        private Button btDELETE;
        private Button btEXITS;
        private Button btADD;
        private TextBox txtSUBJECT;
        private NumericUpDown nuLOCATION;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox txtSELECTEDLINES;
        private TextBox txtSELECTEDSUBJECT;
    }
}