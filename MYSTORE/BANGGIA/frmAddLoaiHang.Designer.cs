namespace banggia
{
    partial class frmAddLoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLoaiHang));
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.gcS = new DevExpress.XtraGrid.GridControl();
            this.gvS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(97, 137);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(257, 27);
            this.txtTenLoai.TabIndex = 0;
            this.txtTenLoai.TextChanged += new System.EventHandler(this.txtTenLoai_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên loại";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(97, 184);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(256, 43);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "KIỂN TRA TRÙNG";
            // 
            // gcS
            // 
            this.gcS.Location = new System.Drawing.Point(421, 55);
            this.gcS.MainView = this.gvS;
            this.gcS.Name = "gcS";
            this.gcS.Size = new System.Drawing.Size(400, 306);
            this.gcS.TabIndex = 19;
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
            this.gridColumn1.Caption = "Tên loại trùng";
            this.gridColumn1.FieldName = "TenLoai";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // frmAddLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 397);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gcS);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLoai);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại hàng";
            this.Load += new System.EventHandler(this.frmAddLoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl gcS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}