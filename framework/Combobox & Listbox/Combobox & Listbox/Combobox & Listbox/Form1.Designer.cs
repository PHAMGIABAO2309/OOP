namespace Combobox___Listbox
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
            cbbCONTENT = new ComboBox();
            label1 = new Label();
            txtCONTENT = new TextBox();
            btADD = new Button();
            btDELETE = new Button();
            btUPDATE = new Button();
            btEXITS = new Button();
            lstMONHOC = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtMONHOC = new TextBox();
            nuVITRI = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            txtMONHOCDUOCCHON = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtCHISODUOCCHON = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nuVITRI).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbbCONTENT
            // 
            cbbCONTENT.FormattingEnabled = true;
            cbbCONTENT.Location = new Point(34, 18);
            cbbCONTENT.Name = "cbbCONTENT";
            cbbCONTENT.Size = new Size(231, 56);
            cbbCONTENT.TabIndex = 0;
            cbbCONTENT.SelectedIndexChanged += cbbCONTENT_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 25);
            label1.Name = "label1";
            label1.Size = new Size(158, 48);
            label1.TabIndex = 1;
            label1.Text = "Content:";
            // 
            // txtCONTENT
            // 
            txtCONTENT.Location = new Point(532, 25);
            txtCONTENT.Name = "txtCONTENT";
            txtCONTENT.Size = new Size(312, 56);
            txtCONTENT.TabIndex = 2;
            // 
            // btADD
            // 
            btADD.Location = new Point(63, 109);
            btADD.Name = "btADD";
            btADD.Size = new Size(146, 65);
            btADD.TabIndex = 3;
            btADD.Text = "Add";
            btADD.UseVisualStyleBackColor = true;
            btADD.Click += btADD_Click;
            // 
            // btDELETE
            // 
            btDELETE.Location = new Point(268, 109);
            btDELETE.Name = "btDELETE";
            btDELETE.Size = new Size(146, 65);
            btDELETE.TabIndex = 3;
            btDELETE.Text = "Delete";
            btDELETE.UseVisualStyleBackColor = true;
            btDELETE.Click += btDELETE_Click;
            // 
            // btUPDATE
            // 
            btUPDATE.Location = new Point(488, 109);
            btUPDATE.Name = "btUPDATE";
            btUPDATE.Size = new Size(146, 65);
            btUPDATE.TabIndex = 3;
            btUPDATE.Text = "Update";
            btUPDATE.UseVisualStyleBackColor = true;
            btUPDATE.Click += btUPDATE_Click;
            // 
            // btEXITS
            // 
            btEXITS.Location = new Point(698, 109);
            btEXITS.Name = "btEXITS";
            btEXITS.Size = new Size(146, 65);
            btEXITS.TabIndex = 3;
            btEXITS.Text = "Exits";
            btEXITS.UseVisualStyleBackColor = true;
            btEXITS.Click += btEXITS_Click;
            // 
            // lstMONHOC
            // 
            lstMONHOC.FormattingEnabled = true;
            lstMONHOC.ItemHeight = 48;
            lstMONHOC.Location = new Point(12, 238);
            lstMONHOC.Name = "lstMONHOC";
            lstMONHOC.SelectionMode = SelectionMode.MultiSimple;
            lstMONHOC.Size = new Size(353, 388);
            lstMONHOC.TabIndex = 4;
            lstMONHOC.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 177);
            label2.Name = "label2";
            label2.Size = new Size(145, 48);
            label2.TabIndex = 5;
            label2.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 256);
            label3.Name = "label3";
            label3.Size = new Size(167, 48);
            label3.TabIndex = 5;
            label3.Text = "Location:";
            // 
            // txtMONHOC
            // 
            txtMONHOC.Location = new Point(555, 177);
            txtMONHOC.Name = "txtMONHOC";
            txtMONHOC.Size = new Size(409, 56);
            txtMONHOC.TabIndex = 6;
            txtMONHOC.TextChanged += txtMONHOC_TextChanged;
            // 
            // nuVITRI
            // 
            nuVITRI.Location = new Point(555, 254);
            nuVITRI.Name = "nuVITRI";
            nuVITRI.Size = new Size(414, 56);
            nuVITRI.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(378, 328);
            button1.Name = "button1";
            button1.Size = new Size(140, 53);
            button1.TabIndex = 8;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(555, 328);
            button2.Name = "button2";
            button2.Size = new Size(179, 53);
            button2.TabIndex = 8;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(761, 328);
            button3.Name = "button3";
            button3.Size = new Size(169, 53);
            button3.TabIndex = 8;
            button3.Text = "EXITS";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMONHOCDUOCCHON);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCHISODUOCCHON);
            groupBox1.Location = new Point(378, 387);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 338);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Infomation Details:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtMONHOCDUOCCHON
            // 
            txtMONHOCDUOCCHON.Location = new Point(286, 50);
            txtMONHOCDUOCCHON.Multiline = true;
            txtMONHOCDUOCCHON.Name = "txtMONHOCDUOCCHON";
            txtMONHOCDUOCCHON.Size = new Size(358, 147);
            txtMONHOCDUOCCHON.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-7, 200);
            label5.Name = "label5";
            label5.Size = new Size(380, 48);
            label5.TabIndex = 5;
            label5.Text = "Index of selected lines:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-7, 52);
            label4.Name = "label4";
            label4.Size = new Size(287, 48);
            label4.TabIndex = 5;
            label4.Text = "Selected Subject:";
            label4.Click += label4_Click;
            // 
            // txtCHISODUOCCHON
            // 
            txtCHISODUOCCHON.Location = new Point(228, 264);
            txtCHISODUOCCHON.Name = "txtCHISODUOCCHON";
            txtCHISODUOCCHON.Size = new Size(442, 56);
            txtCHISODUOCCHON.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 701);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(nuVITRI);
            Controls.Add(txtMONHOC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstMONHOC);
            Controls.Add(btEXITS);
            Controls.Add(btUPDATE);
            Controls.Add(btDELETE);
            Controls.Add(btADD);
            Controls.Add(txtCONTENT);
            Controls.Add(label1);
            Controls.Add(cbbCONTENT);
            Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Combobox & ListBox";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nuVITRI).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbCONTENT;
        private Label label1;
        private TextBox txtCONTENT;
        private Button btADD;
        private Button btDELETE;
        private Button btUPDATE;
        private Button btEXITS;
        private ListBox lstMONHOC;
        private Label label2;
        private Label label3;
        private TextBox txtMONHOC;
        private NumericUpDown nuVITRI;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox txtCHISODUOCCHON;
        private TextBox txtMONHOCDUOCCHON;
    }
}