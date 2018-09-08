namespace banggia
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gcHang = new DevExpress.XtraGrid.GridControl();
            this.gvHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcLoaiHang = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManagerALL = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNapall = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaHang = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuLoaiHang = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuHang = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerHang = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barManagerLoaiHang = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gcHang
            // 
            this.gcHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcHang.Location = new System.Drawing.Point(0, 0);
            this.gcHang.MainView = this.gvHang;
            this.gcHang.Margin = new System.Windows.Forms.Padding(2);
            this.gcHang.Name = "gcHang";
            this.gcHang.Size = new System.Drawing.Size(837, 699);
            this.gcHang.TabIndex = 4;
            this.gcHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHang});
            // 
            // gvHang
            // 
            this.gvHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn4});
            this.gvHang.GridControl = this.gcHang;
            this.gvHang.Name = "gvHang";
            this.gvHang.OptionsView.ShowAutoFilterRow = true;
            this.gvHang.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Hàng";
            this.gridColumn2.FieldName = "TenHang";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cột1";
            this.gridColumn3.FieldName = "Cot1";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cột2";
            this.gridColumn5.FieldName = "Cot2";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Cột 3";
            this.gridColumn8.FieldName = "Cot3";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Cột 4";
            this.gridColumn9.FieldName = "Cot4";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Loại Hàng";
            this.gridColumn4.FieldName = "TenLoai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 60);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcLoaiHang);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcHang);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1246, 699);
            this.splitContainerControl1.SplitterPosition = 401;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcLoaiHang
            // 
            this.gcLoaiHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoaiHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcLoaiHang.Location = new System.Drawing.Point(0, 0);
            this.gcLoaiHang.MainView = this.gvLoaiHang;
            this.gcLoaiHang.Margin = new System.Windows.Forms.Padding(2);
            this.gcLoaiHang.Name = "gcLoaiHang";
            this.gcLoaiHang.Size = new System.Drawing.Size(401, 699);
            this.gcLoaiHang.TabIndex = 0;
            this.gcLoaiHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiHang});
            // 
            // gvLoaiHang
            // 
            this.gvLoaiHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7});
            this.gvLoaiHang.GridControl = this.gcLoaiHang;
            this.gvLoaiHang.Name = "gvLoaiHang";
            this.gvLoaiHang.OptionsView.ShowAutoFilterRow = true;
            this.gvLoaiHang.OptionsView.ShowGroupPanel = false;
            this.gvLoaiHang.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvLoaiHang_FocusedRowChanged);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ID";
            this.gridColumn6.FieldName = "ID";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên Loại Hàng";
            this.gridColumn7.FieldName = "TenLoai";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // barManagerALL
            // 
            this.barManagerALL.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManagerALL.DockControls.Add(this.barDockControlTop);
            this.barManagerALL.DockControls.Add(this.barDockControlBottom);
            this.barManagerALL.DockControls.Add(this.barDockControlLeft);
            this.barManagerALL.DockControls.Add(this.barDockControlRight);
            this.barManagerALL.Form = this;
            this.barManagerALL.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnNapall,
            this.btnThemLoai,
            this.btnSuaLoai,
            this.btnXoaLoai,
            this.btnThemHang,
            this.btnSuaHang,
            this.btnXoaHang});
            this.barManagerALL.MainMenu = this.bar2;
            this.barManagerALL.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNapall, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnNapall
            // 
            this.btnNapall.Caption = "Nạp tất cả";
            this.btnNapall.Id = 1;
            this.btnNapall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNapall.ImageOptions.Image")));
            this.btnNapall.Name = "btnNapall";
            this.btnNapall.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNapall_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerALL;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1246, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 759);
            this.barDockControlBottom.Manager = this.barManagerALL;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1246, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Manager = this.barManagerALL;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 699);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1246, 60);
            this.barDockControlRight.Manager = this.barManagerALL;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 699);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nạp lại tất cả";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Caption = "Thêm Loại";
            this.btnThemLoai.Id = 2;
            this.btnThemLoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoai.ImageOptions.Image")));
            this.btnThemLoai.ImageOptions.SvgImage = global::banggia.Properties.Resources.add;
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemLoai_ItemClick);
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.Caption = "Sửa";
            this.btnSuaLoai.Id = 3;
            this.btnSuaLoai.ImageOptions.SvgImage = global::banggia.Properties.Resources.edit;
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaLoai_ItemClick);
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.Caption = "Xóa";
            this.btnXoaLoai.Id = 4;
            this.btnXoaLoai.ImageOptions.SvgImage = global::banggia.Properties.Resources.trash;
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaLoai_ItemClick);
            // 
            // btnThemHang
            // 
            this.btnThemHang.Caption = "Thêm hàng";
            this.btnThemHang.Id = 5;
            this.btnThemHang.ImageOptions.SvgImage = global::banggia.Properties.Resources.add1;
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemHang_ItemClick);
            // 
            // btnSuaHang
            // 
            this.btnSuaHang.Caption = "Sửa";
            this.btnSuaHang.Id = 6;
            this.btnSuaHang.ImageOptions.SvgImage = global::banggia.Properties.Resources.edit1;
            this.btnSuaHang.Name = "btnSuaHang";
            this.btnSuaHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaHang_ItemClick);
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.Caption = "Xóa";
            this.btnXoaHang.Id = 7;
            this.btnXoaHang.ImageOptions.SvgImage = global::banggia.Properties.Resources.trash1;
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaHang_ItemClick);
            // 
            // popupMenuLoaiHang
            // 
            this.popupMenuLoaiHang.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemLoai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSuaLoai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaLoai)});
            this.popupMenuLoaiHang.Manager = this.barManagerALL;
            this.popupMenuLoaiHang.Name = "popupMenuLoaiHang";
            // 
            // popupMenuHang
            // 
            this.popupMenuHang.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSuaHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaHang)});
            this.popupMenuHang.Manager = this.barManagerALL;
            this.popupMenuHang.Name = "popupMenuHang";
            // 
            // barManagerHang
            // 
            this.barManagerHang.DockControls.Add(this.barDockControl1);
            this.barManagerHang.DockControls.Add(this.barDockControl2);
            this.barManagerHang.DockControls.Add(this.barDockControl3);
            this.barManagerHang.DockControls.Add(this.barDockControl4);
            this.barManagerHang.Form = this;
            this.barManagerHang.MaxItemId = 0;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManagerHang;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControl1.Size = new System.Drawing.Size(1246, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 759);
            this.barDockControl2.Manager = this.barManagerHang;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControl2.Size = new System.Drawing.Size(1246, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManagerHang;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 759);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1246, 0);
            this.barDockControl4.Manager = this.barManagerHang;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 759);
            // 
            // barManagerLoaiHang
            // 
            this.barManagerLoaiHang.DockControls.Add(this.barDockControl5);
            this.barManagerLoaiHang.DockControls.Add(this.barDockControl6);
            this.barManagerLoaiHang.DockControls.Add(this.barDockControl7);
            this.barManagerLoaiHang.DockControls.Add(this.barDockControl8);
            this.barManagerLoaiHang.Form = this;
            this.barManagerLoaiHang.MaxItemId = 0;
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManagerLoaiHang;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControl5.Size = new System.Drawing.Size(1246, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 759);
            this.barDockControl6.Manager = this.barManagerLoaiHang;
            this.barDockControl6.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControl6.Size = new System.Drawing.Size(1246, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 0);
            this.barDockControl7.Manager = this.barManagerLoaiHang;
            this.barDockControl7.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControl7.Size = new System.Drawing.Size(0, 759);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1246, 0);
            this.barDockControl8.Manager = this.barManagerLoaiHang;
            this.barDockControl8.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControl8.Size = new System.Drawing.Size(0, 759);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 759);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "QUẢN LÝ GIÁ";
            this.Load += new System.EventHandler(this.frmBangGiaMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLoaiHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcLoaiHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraBars.BarManager barManagerALL;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnNapall;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManagerHang;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManagerLoaiHang;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarButtonItem btnThemLoai;
        private DevExpress.XtraBars.BarButtonItem btnSuaLoai;
        private DevExpress.XtraBars.BarButtonItem btnXoaLoai;
        private DevExpress.XtraBars.PopupMenu popupMenuLoaiHang;
        private DevExpress.XtraBars.PopupMenu popupMenuHang;
        private DevExpress.XtraBars.BarButtonItem btnThemHang;
        private DevExpress.XtraBars.BarButtonItem btnSuaHang;
        private DevExpress.XtraBars.BarButtonItem btnXoaHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}

