namespace bai_3_kiem_tra
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
            txtTenHP = new TextBox();
            txtMaHP = new TextBox();
            nuSOTC = new NumericUpDown();
            rdTuChon = new RadioButton();
            rdBatBuoc = new RadioButton();
            btQuaPhai = new Button();
            btQuaTrai = new Button();
            btTinh = new Button();
            lvDS = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label4 = new Label();
            lbTUCHON = new Label();
            label6 = new Label();
            lbBatBuoc = new Label();
            ((System.ComponentModel.ISupportInitialize)nuSOTC).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 144);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã học phần:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 213);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên học phần:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 263);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 0;
            label3.Text = "Số tín chỉ:";
            // 
            // txtTenHP
            // 
            txtTenHP.Location = new Point(203, 199);
            txtTenHP.Name = "txtTenHP";
            txtTenHP.Size = new Size(125, 31);
            txtTenHP.TabIndex = 1;
            // 
            // txtMaHP
            // 
            txtMaHP.Location = new Point(203, 138);
            txtMaHP.Name = "txtMaHP";
            txtMaHP.Size = new Size(125, 31);
            txtMaHP.TabIndex = 1;
            // 
            // nuSOTC
            // 
            nuSOTC.Location = new Point(205, 257);
            nuSOTC.Name = "nuSOTC";
            nuSOTC.Size = new Size(154, 31);
            nuSOTC.TabIndex = 2;
            // 
            // rdTuChon
            // 
            rdTuChon.AutoSize = true;
            rdTuChon.Location = new Point(130, 361);
            rdTuChon.Name = "rdTuChon";
            rdTuChon.Size = new Size(98, 29);
            rdTuChon.TabIndex = 3;
            rdTuChon.TabStop = true;
            rdTuChon.Text = "tự chọn";
            rdTuChon.UseVisualStyleBackColor = true;
            // 
            // rdBatBuoc
            // 
            rdBatBuoc.AutoSize = true;
            rdBatBuoc.Location = new Point(310, 370);
            rdBatBuoc.Name = "rdBatBuoc";
            rdBatBuoc.Size = new Size(108, 29);
            rdBatBuoc.TabIndex = 3;
            rdBatBuoc.TabStop = true;
            rdBatBuoc.Text = "bắt buộc";
            rdBatBuoc.UseVisualStyleBackColor = true;
            // 
            // btQuaPhai
            // 
            btQuaPhai.Location = new Point(447, 153);
            btQuaPhai.Name = "btQuaPhai";
            btQuaPhai.Size = new Size(112, 34);
            btQuaPhai.TabIndex = 4;
            btQuaPhai.Text = ">";
            btQuaPhai.UseVisualStyleBackColor = true;
            btQuaPhai.Click += btQuaPhai_Click;
            // 
            // btQuaTrai
            // 
            btQuaTrai.Location = new Point(476, 213);
            btQuaTrai.Name = "btQuaTrai";
            btQuaTrai.Size = new Size(112, 34);
            btQuaTrai.TabIndex = 5;
            btQuaTrai.Text = "<";
            btQuaTrai.UseVisualStyleBackColor = true;
            btQuaTrai.Click += button2_Click;
            // 
            // btTinh
            // 
            btTinh.Location = new Point(498, 301);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(112, 34);
            btTinh.TabIndex = 6;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // lvDS
            // 
            lvDS.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvDS.FullRowSelect = true;
            lvDS.GridLines = true;
            lvDS.Location = new Point(713, 122);
            lvDS.Name = "lvDS";
            lvDS.Size = new Size(328, 294);
            lvDS.TabIndex = 7;
            lvDS.UseCompatibleStateImageBehavior = false;
            lvDS.View = View.Details;
            lvDS.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã học phần";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "tên học phần";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số tín chỉ";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "loại học phần";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 588);
            label4.Name = "label4";
            label4.Size = new Size(182, 25);
            label4.TabIndex = 0;
            label4.Text = "tổng tín chỉ bắt buộc:";
            // 
            // lbTUCHON
            // 
            lbTUCHON.AutoSize = true;
            lbTUCHON.Location = new Point(551, 513);
            lbTUCHON.Name = "lbTUCHON";
            lbTUCHON.Size = new Size(59, 25);
            lbTUCHON.TabIndex = 0;
            lbTUCHON.Text = "label1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 513);
            label6.Name = "label6";
            label6.Size = new Size(172, 25);
            label6.TabIndex = 0;
            label6.Text = "tổng tín chỉ tự chon:";
            // 
            // lbBatBuoc
            // 
            lbBatBuoc.AutoSize = true;
            lbBatBuoc.Location = new Point(590, 588);
            lbBatBuoc.Name = "lbBatBuoc";
            lbBatBuoc.Size = new Size(59, 25);
            lbBatBuoc.TabIndex = 0;
            lbBatBuoc.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 673);
            Controls.Add(lvDS);
            Controls.Add(btTinh);
            Controls.Add(btQuaTrai);
            Controls.Add(btQuaPhai);
            Controls.Add(rdBatBuoc);
            Controls.Add(rdTuChon);
            Controls.Add(nuSOTC);
            Controls.Add(txtMaHP);
            Controls.Add(txtTenHP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbTUCHON);
            Controls.Add(lbBatBuoc);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nuSOTC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenHP;
        private TextBox txtMaHP;
        private NumericUpDown nuSOTC;
        private RadioButton rdTuChon;
        private RadioButton rdBatBuoc;
        private Button btQuaPhai;
        private Button btQuaTrai;
        private Button btTinh;
        private ListView lvDS;
        private Label label4;
        private Label lbTUCHON;
        private Label label6;
        private Label lbBatBuoc;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
