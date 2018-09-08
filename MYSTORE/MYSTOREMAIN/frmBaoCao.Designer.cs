namespace MYSTOREMAIN
{
    partial class frmBaoCao
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMucTangThang = new System.Windows.Forms.Label();
            this.txtDoanThuThang = new System.Windows.Forms.Label();
            this.txtMucTangNam = new System.Windows.Forms.Label();
            this.txtDoanThuNam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng doan thu tháng này:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mức tăng so với tháng trước:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mức tăng so với năm trước:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(814, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng doanh thu cả năm này:";
            // 
            // txtMucTangThang
            // 
            this.txtMucTangThang.AutoSize = true;
            this.txtMucTangThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucTangThang.Location = new System.Drawing.Point(318, 97);
            this.txtMucTangThang.Name = "txtMucTangThang";
            this.txtMucTangThang.Size = new System.Drawing.Size(0, 25);
            this.txtMucTangThang.TabIndex = 5;
            // 
            // txtDoanThuThang
            // 
            this.txtDoanThuThang.AutoSize = true;
            this.txtDoanThuThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanThuThang.Location = new System.Drawing.Point(318, 49);
            this.txtDoanThuThang.Name = "txtDoanThuThang";
            this.txtDoanThuThang.Size = new System.Drawing.Size(0, 25);
            this.txtDoanThuThang.TabIndex = 4;
            // 
            // txtMucTangNam
            // 
            this.txtMucTangNam.AutoSize = true;
            this.txtMucTangNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucTangNam.Location = new System.Drawing.Point(1126, 97);
            this.txtMucTangNam.Name = "txtMucTangNam";
            this.txtMucTangNam.Size = new System.Drawing.Size(0, 25);
            this.txtMucTangNam.TabIndex = 7;
            // 
            // txtDoanThuNam
            // 
            this.txtDoanThuNam.AutoSize = true;
            this.txtDoanThuNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanThuNam.Location = new System.Drawing.Point(1126, 49);
            this.txtDoanThuNam.Name = "txtDoanThuNam";
            this.txtDoanThuNam.Size = new System.Drawing.Size(0, 25);
            this.txtDoanThuNam.TabIndex = 6;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 971);
            this.Controls.Add(this.txtMucTangNam);
            this.Controls.Add(this.txtDoanThuNam);
            this.Controls.Add(this.txtMucTangThang);
            this.Controls.Add(this.txtDoanThuThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCao";
            this.Text = "Báo cáo tháng";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtMucTangThang;
        private System.Windows.Forms.Label txtDoanThuThang;
        private System.Windows.Forms.Label txtMucTangNam;
        private System.Windows.Forms.Label txtDoanThuNam;
    }
}