namespace _5trang60_update
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_monan = new System.Windows.Forms.RadioButton();
            this.rd_nuocuong = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ls_monan = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ls_nuocuong = new System.Windows.Forms.ListBox();
            this.txt_tenmon = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_traiquaphai = new System.Windows.Forms.Button();
            this.bt_phaiquatrai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÀ PHÊ HOA HƯỚNG DƯƠNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // rd_monan
            // 
            this.rd_monan.AutoSize = true;
            this.rd_monan.Location = new System.Drawing.Point(159, 144);
            this.rd_monan.Name = "rd_monan";
            this.rd_monan.Size = new System.Drawing.Size(72, 20);
            this.rd_monan.TabIndex = 1;
            this.rd_monan.TabStop = true;
            this.rd_monan.Text = "Món ăn";
            this.rd_monan.UseVisualStyleBackColor = true;
            // 
            // rd_nuocuong
            // 
            this.rd_nuocuong.AutoSize = true;
            this.rd_nuocuong.Location = new System.Drawing.Point(307, 144);
            this.rd_nuocuong.Name = "rd_nuocuong";
            this.rd_nuocuong.Size = new System.Drawing.Size(93, 20);
            this.rd_nuocuong.TabIndex = 1;
            this.rd_nuocuong.TabStop = true;
            this.rd_nuocuong.Text = "Nước uống";
            this.rd_nuocuong.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ls_monan);
            this.groupBox1.Location = new System.Drawing.Point(45, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Món ăn";
            // 
            // ls_monan
            // 
            this.ls_monan.FormattingEnabled = true;
            this.ls_monan.ItemHeight = 16;
            this.ls_monan.Location = new System.Drawing.Point(0, 21);
            this.ls_monan.Name = "ls_monan";
            this.ls_monan.Size = new System.Drawing.Size(174, 212);
            this.ls_monan.TabIndex = 0;
            this.ls_monan.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ls_nuocuong);
            this.groupBox2.Location = new System.Drawing.Point(338, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 223);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nước uống";
            // 
            // ls_nuocuong
            // 
            this.ls_nuocuong.FormattingEnabled = true;
            this.ls_nuocuong.ItemHeight = 16;
            this.ls_nuocuong.Location = new System.Drawing.Point(0, 21);
            this.ls_nuocuong.Name = "ls_nuocuong";
            this.ls_nuocuong.Size = new System.Drawing.Size(174, 212);
            this.ls_nuocuong.TabIndex = 0;
            this.ls_nuocuong.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txt_tenmon
            // 
            this.txt_tenmon.Location = new System.Drawing.Point(159, 90);
            this.txt_tenmon.Name = "txt_tenmon";
            this.txt_tenmon.Size = new System.Drawing.Size(259, 22);
            this.txt_tenmon.TabIndex = 3;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(237, 223);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 37);
            this.bt_them.TabIndex = 4;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_traiquaphai
            // 
            this.bt_traiquaphai.Location = new System.Drawing.Point(237, 266);
            this.bt_traiquaphai.Name = "bt_traiquaphai";
            this.bt_traiquaphai.Size = new System.Drawing.Size(75, 37);
            this.bt_traiquaphai.TabIndex = 4;
            this.bt_traiquaphai.Text = ">>";
            this.bt_traiquaphai.UseVisualStyleBackColor = true;
            this.bt_traiquaphai.Click += new System.EventHandler(this.bt_traiquaphai_Click);
            // 
            // bt_phaiquatrai
            // 
            this.bt_phaiquatrai.Location = new System.Drawing.Point(237, 309);
            this.bt_phaiquatrai.Name = "bt_phaiquatrai";
            this.bt_phaiquatrai.Size = new System.Drawing.Size(75, 37);
            this.bt_phaiquatrai.TabIndex = 4;
            this.bt_phaiquatrai.Text = "<<";
            this.bt_phaiquatrai.UseVisualStyleBackColor = true;
            this.bt_phaiquatrai.Click += new System.EventHandler(this.bt_phaiquatrai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 440);
            this.Controls.Add(this.bt_phaiquatrai);
            this.Controls.Add(this.bt_traiquaphai);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.txt_tenmon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rd_nuocuong);
            this.Controls.Add(this.rd_monan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Dùng listbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd_monan;
        private System.Windows.Forms.RadioButton rd_nuocuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ls_monan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ls_nuocuong;
        private System.Windows.Forms.TextBox txt_tenmon;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_traiquaphai;
        private System.Windows.Forms.Button bt_phaiquatrai;
    }
}

