namespace QuanLyBanHang
{
    partial class FormMain
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(113, 57);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(265, 27);
            this.txtSoA.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(113, 211);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(94, 29);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(113, 103);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(265, 27);
            this.txtSoB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "B";
            // 
            // txtSoC
            // 
            this.txtSoC.Location = new System.Drawing.Point(113, 157);
            this.txtSoC.Name = "txtSoC";
            this.txtSoC.Size = new System.Drawing.Size(265, 27);
            this.txtSoC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "C";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(247, 211);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(94, 29);
            this.btnLamLai.TabIndex = 2;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(113, 270);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(265, 124);
            this.txtKetQua.TabIndex = 1;
            this.txtKetQua.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết Quả";
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoC);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKetQua);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoC;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}