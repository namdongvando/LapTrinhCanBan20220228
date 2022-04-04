namespace QuanLyBanHangDB
{
    partial class FormDonHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(2, 35);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(224, 20);
            this.txtTuKhoa.TabIndex = 1;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(232, 35);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpTuNgay.TabIndex = 3;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(484, 35);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpDenNgay.TabIndex = 4;
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 393);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDonHang";
            this.Text = "FormDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
    }
}