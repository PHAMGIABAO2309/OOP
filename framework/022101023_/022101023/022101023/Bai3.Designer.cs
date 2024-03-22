namespace _022101023
{
    partial class Bai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rdTuChon = new RadioButton();
            rdBatBuoc = new RadioButton();
            txtMaHP = new TextBox();
            txtTenHP = new TextBox();
            nuSOTC = new NumericUpDown();
            btQuaPhai = new Button();
            btQuaTrai = new Button();
            btTinh = new Button();
            lvDS = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lbTuChon = new Label();
            lbBatBuoc = new Label();
            ((System.ComponentModel.ISupportInitialize)nuSOTC).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(322, 24);
            label1.Name = "label1";
            label1.Size = new Size(392, 48);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HỌC PHẦN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 107);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã học phần:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 184);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên học phần:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 244);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 3;
            label4.Text = "Số tín chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 319);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 4;
            label5.Text = "Loại học phần:";
            // 
            // rdTuChon
            // 
            rdTuChon.AutoSize = true;
            rdTuChon.Location = new Point(180, 317);
            rdTuChon.Name = "rdTuChon";
            rdTuChon.Size = new Size(101, 29);
            rdTuChon.TabIndex = 5;
            rdTuChon.TabStop = true;
            rdTuChon.Text = "Tự chọn";
            rdTuChon.UseVisualStyleBackColor = true;
            // 
            // rdBatBuoc
            // 
            rdBatBuoc.AutoSize = true;
            rdBatBuoc.Location = new Point(297, 317);
            rdBatBuoc.Name = "rdBatBuoc";
            rdBatBuoc.Size = new Size(107, 29);
            rdBatBuoc.TabIndex = 6;
            rdBatBuoc.TabStop = true;
            rdBatBuoc.Text = "Bắt buộc";
            rdBatBuoc.UseVisualStyleBackColor = true;
            // 
            // txtMaHP
            // 
            txtMaHP.Location = new Point(198, 107);
            txtMaHP.Name = "txtMaHP";
            txtMaHP.Size = new Size(196, 31);
            txtMaHP.TabIndex = 7;
            // 
            // txtTenHP
            // 
            txtTenHP.Location = new Point(198, 178);
            txtTenHP.Name = "txtTenHP";
            txtTenHP.Size = new Size(191, 31);
            txtTenHP.TabIndex = 8;
            // 
            // nuSOTC
            // 
            nuSOTC.Location = new Point(198, 251);
            nuSOTC.Name = "nuSOTC";
            nuSOTC.Size = new Size(196, 31);
            nuSOTC.TabIndex = 9;
            // 
            // btQuaPhai
            // 
            btQuaPhai.Location = new Point(409, 100);
            btQuaPhai.Name = "btQuaPhai";
            btQuaPhai.Size = new Size(91, 44);
            btQuaPhai.TabIndex = 10;
            btQuaPhai.Text = ">";
            btQuaPhai.UseVisualStyleBackColor = true;
            btQuaPhai.Click += btQuaPhai_Click;
            // 
            // btQuaTrai
            // 
            btQuaTrai.Location = new Point(409, 184);
            btQuaTrai.Name = "btQuaTrai";
            btQuaTrai.Size = new Size(91, 39);
            btQuaTrai.TabIndex = 11;
            btQuaTrai.Text = "<";
            btQuaTrai.UseVisualStyleBackColor = true;
            btQuaTrai.Click += btQuaTrai_Click;
            // 
            // btTinh
            // 
            btTinh.Location = new Point(409, 251);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(95, 39);
            btTinh.TabIndex = 12;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // lvDS
            // 
            lvDS.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvDS.FullRowSelect = true;
            lvDS.GridLines = true;
            lvDS.Location = new Point(510, 100);
            lvDS.Name = "lvDS";
            lvDS.Size = new Size(585, 197);
            lvDS.TabIndex = 13;
            lvDS.UseCompatibleStateImageBehavior = false;
            lvDS.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã học phần";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên học phần";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số tín chỉ";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Loại học phần";
            columnHeader4.Width = 100;
            // 
            // lbTuChon
            // 
            lbTuChon.AutoSize = true;
            lbTuChon.Location = new Point(568, 321);
            lbTuChon.Name = "lbTuChon";
            lbTuChon.Size = new Size(217, 25);
            lbTuChon.TabIndex = 14;
            lbTuChon.Text = "Tổng số tín chỉ tự chọn là:";
            // 
            // lbBatBuoc
            // 
            lbBatBuoc.AutoSize = true;
            lbBatBuoc.Location = new Point(568, 366);
            lbBatBuoc.Name = "lbBatBuoc";
            lbBatBuoc.Size = new Size(227, 25);
            lbBatBuoc.TabIndex = 15;
            lbBatBuoc.Text = "Tổng số tín chỉ bắt buộc là:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 666);
            Controls.Add(lbBatBuoc);
            Controls.Add(lbTuChon);
            Controls.Add(lvDS);
            Controls.Add(btTinh);
            Controls.Add(btQuaTrai);
            Controls.Add(btQuaPhai);
            Controls.Add(nuSOTC);
            Controls.Add(txtTenHP);
            Controls.Add(txtMaHP);
            Controls.Add(rdBatBuoc);
            Controls.Add(rdTuChon);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)nuSOTC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rdTuChon;
        private RadioButton rdBatBuoc;
        private TextBox txtMaHP;
        private TextBox txtTenHP;
        private NumericUpDown nuSOTC;
        private Button btQuaPhai;
        private Button btQuaTrai;
        private Button btTinh;
        private ListView lvDS;
        private Label lbTuChon;
        private Label lbBatBuoc;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}