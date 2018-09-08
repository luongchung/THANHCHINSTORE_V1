namespace banggia
{
    partial class frmAddHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHang));
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lueLoaiHang = new DevExpress.XtraEditors.LookUpEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.gcS = new DevExpress.XtraGrid.GridControl();
            this.gvS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(142, 74);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(325, 27);
            this.txtTenHang.TabIndex = 0;
            this.txtTenHang.TextChanged += new System.EventHandler(this.txtTenHang_TextChanged);
            this.txtTenHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddHang_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại hàng";
            // 
            // lueLoaiHang
            // 
            this.lueLoaiHang.Location = new System.Drawing.Point(142, 116);
            this.lueLoaiHang.Margin = new System.Windows.Forms.Padding(2);
            this.lueLoaiHang.Name = "lueLoaiHang";
            this.lueLoaiHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoaiHang.Properties.DisplayMember = "TenLoai";
            this.lueLoaiHang.Properties.NullText = "[Mời chọn loại hàng]";
            this.lueLoaiHang.Properties.ValueMember = "ID";
            this.lueLoaiHang.Size = new System.Drawing.Size(324, 26);
            this.lueLoaiHang.TabIndex = 7;
            this.lueLoaiHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddHang_KeyDown);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(142, 327);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(324, 53);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnLuu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddHang_KeyDown);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(143, 168);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(324, 27);
            this.txt1.TabIndex = 9;
            this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddHang_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "O1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "O2";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(143, 208);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(324, 27);
            this.txt2.TabIndex = 11;
            this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddHang_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "O3";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(142, 244);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(324, 27);
            this.txt3.TabIndex = 13;
            this.txt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddHang_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "O4";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(142, 282);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(324, 27);
            this.txt4.TabIndex = 15;
            this.txt4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddHang_KeyDown);
            // 
            // gcS
            // 
            this.gcS.Location = new System.Drawing.Point(580, 74);
            this.gcS.MainView = this.gvS;
            this.gcS.Name = "gcS";
            this.gcS.Size = new System.Drawing.Size(400, 306);
            this.gcS.TabIndex = 17;
            this.gcS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvS});
            // 
            // gvS
            // 
            this.gvS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gvS.GridControl = this.gcS;
            this.gvS.Name = "gvS";
            this.gvS.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên hàng trùng";
            this.gridColumn1.FieldName = "TenHang";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(705, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "KIỂN TRA TRÙNG";
            // 
            // frmAddHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 456);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gcS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lueLoaiHang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenHang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hàng";
            this.Load += new System.EventHandler(this.frmAddHang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddHang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiHang;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt4;
        private DevExpress.XtraGrid.GridControl gcS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label7;
    }
}