namespace vd3._3_tr_72
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
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.btHienThi = new System.Windows.Forms.Button();
            this.btLUU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(114, 31);
            this.txtThongTin.Multiline = true;
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(580, 132);
            this.txtThongTin.TabIndex = 0;
            // 
            // btHienThi
            // 
            this.btHienThi.Location = new System.Drawing.Point(134, 193);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(94, 38);
            this.btHienThi.TabIndex = 1;
            this.btHienThi.Text = "Hiển thị";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // btLUU
            // 
            this.btLUU.Location = new System.Drawing.Point(514, 207);
            this.btLUU.Name = "btLUU";
            this.btLUU.Size = new System.Drawing.Size(94, 38);
            this.btLUU.TabIndex = 1;
            this.btLUU.Text = "Lưu";
            this.btLUU.UseVisualStyleBackColor = true;
            this.btLUU.Click += new System.EventHandler(this.btLUU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 604);
            this.Controls.Add(this.btLUU);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.txtThongTin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.Button btLUU;
    }
}

