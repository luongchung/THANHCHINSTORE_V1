namespace HeThong
{
    partial class frmChagePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChagePass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.txtPassNew1 = new System.Windows.Forms.TextBox();
            this.txtPassNew2 = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(282, 43);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.PasswordChar = '*';
            this.txtPassOld.Size = new System.Drawing.Size(293, 33);
            this.txtPassOld.TabIndex = 3;
            // 
            // txtPassNew1
            // 
            this.txtPassNew1.Location = new System.Drawing.Point(282, 94);
            this.txtPassNew1.Name = "txtPassNew1";
            this.txtPassNew1.PasswordChar = '*';
            this.txtPassNew1.Size = new System.Drawing.Size(293, 33);
            this.txtPassNew1.TabIndex = 4;
            // 
            // txtPassNew2
            // 
            this.txtPassNew2.Location = new System.Drawing.Point(282, 142);
            this.txtPassNew2.Name = "txtPassNew2";
            this.txtPassNew2.PasswordChar = '*';
            this.txtPassNew2.Size = new System.Drawing.Size(293, 33);
            this.txtPassNew2.TabIndex = 5;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(282, 194);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(293, 57);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmChagePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 280);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtPassNew2);
            this.Controls.Add(this.txtPassNew1);
            this.Controls.Add(this.txtPassOld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChagePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.TextBox txtPassNew1;
        private System.Windows.Forms.TextBox txtPassNew2;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
    }
}