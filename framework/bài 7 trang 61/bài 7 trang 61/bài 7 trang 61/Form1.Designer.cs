namespace bài_7_trang_61
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
            cbbLOP = new ComboBox();
            label2 = new Label();
            lvDANHSACHLOP = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btTHEM = new Button();
            btCAPNHAT = new Button();
            btTHOAT = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtHOTEN = new TextBox();
            nuLAPTRINHGD = new NumericUpDown();
            nuMANGMT = new NumericUpDown();
            nuCSDL = new NumericUpDown();
            label7 = new Label();
            lbHOTEN = new Label();
            label9 = new Label();
            lbDIEMTRUNGBINH = new Label();
            ((System.ComponentModel.ISupportInitialize)nuLAPTRINHGD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuMANGMT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuCSDL).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Lớp";
            // 
            // cbbLOP
            // 
            cbbLOP.FormattingEnabled = true;
            cbbLOP.Location = new Point(88, 31);
            cbbLOP.Margin = new Padding(2);
            cbbLOP.Name = "cbbLOP";
            cbbLOP.Size = new Size(127, 23);
            cbbLOP.TabIndex = 1;
            cbbLOP.SelectedIndexChanged += cbbLOP_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 82);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 2;
            label2.Text = "Danh sách lớp:";
            // 
            // lvDANHSACHLOP
            // 
            lvDANHSACHLOP.AccessibleRole = AccessibleRole.None;
            lvDANHSACHLOP.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvDANHSACHLOP.FullRowSelect = true;
            lvDANHSACHLOP.GridLines = true;
            lvDANHSACHLOP.Location = new Point(8, 109);
            lvDANHSACHLOP.Margin = new Padding(2);
            lvDANHSACHLOP.Name = "lvDANHSACHLOP";
            lvDANHSACHLOP.Size = new Size(330, 170);
            lvDANHSACHLOP.TabIndex = 3;
            lvDANHSACHLOP.UseCompatibleStateImageBehavior = false;
            lvDANHSACHLOP.View = View.Details;
            lvDANHSACHLOP.SelectedIndexChanged += lvDANHSACHLOP_SelectedIndexChanged;
            lvDANHSACHLOP.Click += lvDANHSACHLOP_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Họ tên";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Lập trình GD";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mạng MT";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "CSDL SQL";
            columnHeader4.Width = 100;
            // 
            // btTHEM
            // 
            btTHEM.Location = new Point(391, 109);
            btTHEM.Margin = new Padding(2);
            btTHEM.Name = "btTHEM";
            btTHEM.Size = new Size(75, 23);
            btTHEM.TabIndex = 4;
            btTHEM.Text = "Thêm";
            btTHEM.UseVisualStyleBackColor = true;
            // 
            // btCAPNHAT
            // 
            btCAPNHAT.Location = new Point(391, 176);
            btCAPNHAT.Margin = new Padding(2);
            btCAPNHAT.Name = "btCAPNHAT";
            btCAPNHAT.Size = new Size(75, 23);
            btCAPNHAT.TabIndex = 4;
            btCAPNHAT.Text = "Cập nhật";
            btCAPNHAT.UseVisualStyleBackColor = true;
            btCAPNHAT.Click += button2_Click;
            // 
            // btTHOAT
            // 
            btTHOAT.Location = new Point(391, 235);
            btTHOAT.Margin = new Padding(2);
            btTHOAT.Name = "btTHOAT";
            btTHOAT.Size = new Size(75, 23);
            btTHOAT.TabIndex = 4;
            btTHOAT.Text = "Thoát";
            btTHOAT.UseVisualStyleBackColor = true;
            btTHOAT.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 113);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Họ tên:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 154);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 2;
            label4.Text = "Lập trình GD:";
            label4.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 193);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 2;
            label5.Text = "Mạng MT:";
            label5.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 235);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 2;
            label6.Text = "CSDL SQL:";
            label6.Click += label3_Click;
            // 
            // txtHOTEN
            // 
            txtHOTEN.Location = new Point(554, 113);
            txtHOTEN.Margin = new Padding(2);
            txtHOTEN.Name = "txtHOTEN";
            txtHOTEN.Size = new Size(122, 23);
            txtHOTEN.TabIndex = 5;
            // 
            // nuLAPTRINHGD
            // 
            nuLAPTRINHGD.Location = new Point(569, 154);
            nuLAPTRINHGD.Margin = new Padding(2);
            nuLAPTRINHGD.Name = "nuLAPTRINHGD";
            nuLAPTRINHGD.Size = new Size(130, 23);
            nuLAPTRINHGD.TabIndex = 6;
            // 
            // nuMANGMT
            // 
            nuMANGMT.Location = new Point(569, 193);
            nuMANGMT.Margin = new Padding(2);
            nuMANGMT.Name = "nuMANGMT";
            nuMANGMT.Size = new Size(130, 23);
            nuMANGMT.TabIndex = 6;
            // 
            // nuCSDL
            // 
            nuCSDL.Location = new Point(569, 233);
            nuCSDL.Margin = new Padding(2);
            nuCSDL.Name = "nuCSDL";
            nuCSDL.Size = new Size(130, 23);
            nuCSDL.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 286);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 0;
            label7.Text = "Điểm trung bình của SV:";
            // 
            // lbHOTEN
            // 
            lbHOTEN.AutoSize = true;
            lbHOTEN.Location = new Point(173, 286);
            lbHOTEN.Margin = new Padding(2, 0, 2, 0);
            lbHOTEN.Name = "lbHOTEN";
            lbHOTEN.Size = new Size(38, 15);
            lbHOTEN.TabIndex = 0;
            lbHOTEN.Text = "label1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(266, 286);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 0;
            label9.Text = "là:";
            // 
            // lbDIEMTRUNGBINH
            // 
            lbDIEMTRUNGBINH.AutoSize = true;
            lbDIEMTRUNGBINH.Location = new Point(300, 286);
            lbDIEMTRUNGBINH.Margin = new Padding(2, 0, 2, 0);
            lbDIEMTRUNGBINH.Name = "lbDIEMTRUNGBINH";
            lbDIEMTRUNGBINH.Size = new Size(38, 15);
            lbDIEMTRUNGBINH.TabIndex = 0;
            lbDIEMTRUNGBINH.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 404);
            Controls.Add(nuCSDL);
            Controls.Add(nuMANGMT);
            Controls.Add(nuLAPTRINHGD);
            Controls.Add(txtHOTEN);
            Controls.Add(btTHOAT);
            Controls.Add(btCAPNHAT);
            Controls.Add(btTHEM);
            Controls.Add(lvDANHSACHLOP);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbbLOP);
            Controls.Add(lbDIEMTRUNGBINH);
            Controls.Add(label9);
            Controls.Add(lbHOTEN);
            Controls.Add(label7);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nuLAPTRINHGD).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuMANGMT).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuCSDL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbLOP;
        private Label label2;
        private ListView lvDANHSACHLOP;
        private Button btTHEM;
        private Button btCAPNHAT;
        private Button btTHOAT;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtHOTEN;
        private NumericUpDown nuLAPTRINHGD;
        private NumericUpDown nuMANGMT;
        private NumericUpDown nuCSDL;
        private Label label7;
        private Label lbHOTEN;
        private Label label9;
        private Label lbDIEMTRUNGBINH;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}