namespace MYSTOREMAIN
{
    partial class frmMain
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
            DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHeThong;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonPageGroup_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup_BaoMat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnKhoiPhucPass = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnKichHoatTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnRobonQLTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnQLNV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLLoaiHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLGiaHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemDV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiDV = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.txtTongCH = new DevExpress.XtraBars.BarHeaderItem();
            this.btnToaHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoBC = new DevExpress.XtraBars.BarButtonItem();
            this.btBaoCaoNam = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBangGia = new DevExpress.XtraBars.BarButtonItem();
            this.txtTongDanCu = new DevExpress.XtraBars.BarHeaderItem();
            this.txtTongNhanVien = new DevExpress.XtraBars.BarHeaderItem();
            this.btnInThang = new DevExpress.XtraBars.BarButtonItem();
            this.btInBaoCaoNam = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupQL = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHoaDon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHoaDon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageDichVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupQLDichVu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupLoaiDV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupExportBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.applicationmenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.image = new DevExpress.Utils.ImageCollection(this.components);
            this.pageMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.theme = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPageGroupThongKe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageHeThong
            // 
            ribbonPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_HeThong,
            this.ribbonPageGroup_BaoMat,
            this.btnRobonQLTK});
            ribbonPageHeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageHeThong.ImageOptions.Image")));
            ribbonPageHeThong.Name = "ribbonPageHeThong";
            ribbonPageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup_HeThong
            // 
            this.ribbonPageGroup_HeThong.ItemLinks.Add(this.btnDX);
            this.ribbonPageGroup_HeThong.ItemLinks.Add(this.btnThongTin);
            this.ribbonPageGroup_HeThong.ItemLinks.Add(this.btn_DoiMatKhau);
            this.ribbonPageGroup_HeThong.Name = "ribbonPageGroup_HeThong";
            this.ribbonPageGroup_HeThong.Text = "Hệ thống";
            // 
            // btnDX
            // 
            this.btnDX.Caption = "Đăng xuất hệ thống";
            this.btnDX.Id = 4;
            this.btnDX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDX.ImageOptions.SvgImage")));
            this.btnDX.Name = "btnDX";
            this.btnDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick_1);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Caption = "Thông tin tài khoản";
            this.btnThongTin.Id = 1;
            this.btnThongTin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongTin.ImageOptions.SvgImage")));
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTT_ItemClick);
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.Caption = "Đổi mật khẩu";
            this.btn_DoiMatKhau.Id = 3;
            this.btn_DoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DoiMatKhau.ImageOptions.LargeImage")));
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DoiMatKhau_ItemClick);
            // 
            // ribbonPageGroup_BaoMat
            // 
            this.ribbonPageGroup_BaoMat.ItemLinks.Add(this.btnKhoiPhucPass);
            this.ribbonPageGroup_BaoMat.ItemLinks.Add(this.btnPhanQuyen);
            this.ribbonPageGroup_BaoMat.ItemLinks.Add(this.btnKichHoatTK);
            this.ribbonPageGroup_BaoMat.Name = "ribbonPageGroup_BaoMat";
            this.ribbonPageGroup_BaoMat.Text = "Bảo mật";
            // 
            // btnKhoiPhucPass
            // 
            this.btnKhoiPhucPass.Caption = "Khôi phục mật khẩu";
            this.btnKhoiPhucPass.Id = 4;
            this.btnKhoiPhucPass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhoiPhucPass.ImageOptions.SvgImage")));
            this.btnKhoiPhucPass.Name = "btnKhoiPhucPass";
            this.btnKhoiPhucPass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoiPhucPass_ItemClick);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân quyền chức năng";
            this.btnPhanQuyen.Id = 2;
            this.btnPhanQuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.ImageOptions.LargeImage")));
            this.btnPhanQuyen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhanQuyen.ImageOptions.SvgImage")));
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanQuyen_ItemClick);
            // 
            // btnKichHoatTK
            // 
            this.btnKichHoatTK.Caption = "Kích hoạt tài khoản";
            this.btnKichHoatTK.Id = 3;
            this.btnKichHoatTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKichHoatTK.ImageOptions.SvgImage")));
            this.btnKichHoatTK.Name = "btnKichHoatTK";
            this.btnKichHoatTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKichHoatTK_ItemClick);
            // 
            // btnRobonQLTK
            // 
            this.btnRobonQLTK.ItemLinks.Add(this.btnQLNV);
            this.btnRobonQLTK.Name = "btnRobonQLTK";
            this.btnRobonQLTK.Text = "Quản lý tài khoản";
            // 
            // btnQLNV
            // 
            this.btnQLNV.Caption = "Quản lý nhân viên";
            this.btnQLNV.Id = 20;
            this.btnQLNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLNV.ImageOptions.SvgImage")));
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNV_ItemClick);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnThongTin,
            this.btnPhanQuyen,
            this.btn_DoiMatKhau,
            this.btnKhoiPhucPass,
            this.btnLogout,
            this.btnQLLoaiHang,
            this.btnQLGiaHang,
            this.btnQLNhanVien,
            this.btnThemDV,
            this.btnDSDV,
            this.btnLoaiDV,
            this.barListItem1,
            this.barStaticItem1,
            this.txtTongCH,
            this.btnToaHD,
            this.btnQLHoaDon,
            this.btnTaoBC,
            this.btBaoCaoNam,
            this.barButtonItem6,
            this.barButtonItem7,
            this.btnTT,
            this.btnDangXuat,
            this.btnKichHoatTK,
            this.btnDX,
            this.btnInBangGia,
            this.txtTongDanCu,
            this.txtTongNhanVien,
            this.btnInThang,
            this.btInBaoCaoNam,
            this.btnQLNV});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btnTT);
            this.ribbon.PageHeaderItemLinks.Add(this.btnDangXuat);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            ribbonPageHeThong,
            this.ribbonPageQuanLy,
            this.ribbonPageHoaDon,
            this.ribbonPageDichVu,
            this.ribbonPageBaoCao});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbon.Size = new System.Drawing.Size(1415, 232);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 5;
            this.btnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogout.ImageOptions.SvgImage")));
            this.btnLogout.Name = "btnLogout";
            // 
            // btnQLLoaiHang
            // 
            this.btnQLLoaiHang.Caption = "Quản lý loại hàng";
            this.btnQLLoaiHang.Id = 6;
            this.btnQLLoaiHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLLoaiHang.ImageOptions.Image")));
            this.btnQLLoaiHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLLoaiHang.ImageOptions.LargeImage")));
            this.btnQLLoaiHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLLoaiHang.ImageOptions.SvgImage")));
            this.btnQLLoaiHang.Name = "btnQLLoaiHang";
            this.btnQLLoaiHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLCanHo_ItemClick);
            // 
            // btnQLGiaHang
            // 
            this.btnQLGiaHang.Caption = "Quản lý quản lý giá hàng";
            this.btnQLGiaHang.Id = 7;
            this.btnQLGiaHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLGiaHang.ImageOptions.Image")));
            this.btnQLGiaHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLGiaHang.ImageOptions.LargeImage")));
            this.btnQLGiaHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLGiaHang.ImageOptions.SvgImage")));
            this.btnQLGiaHang.Name = "btnQLGiaHang";
            this.btnQLGiaHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Caption = "Quản lý nhân viên";
            this.btnQLNhanVien.Id = 8;
            this.btnQLNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.ImageOptions.Image")));
            this.btnQLNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.ImageOptions.LargeImage")));
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNhanVien_ItemClick);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Caption = "Thêm dịch vụ";
            this.btnThemDV.Id = 9;
            this.btnThemDV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemDV.ImageOptions.SvgImage")));
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemDV_ItemClick);
            // 
            // btnDSDV
            // 
            this.btnDSDV.Caption = "Danh sách dịch vụ";
            this.btnDSDV.Id = 10;
            this.btnDSDV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDSDV.ImageOptions.SvgImage")));
            this.btnDSDV.Name = "btnDSDV";
            this.btnDSDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDV_ItemClick);
            // 
            // btnLoaiDV
            // 
            this.btnLoaiDV.Caption = "Loại dịch vụ kinh doanh";
            this.btnLoaiDV.Id = 11;
            this.btnLoaiDV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiDV.ImageOptions.SvgImage")));
            this.btnLoaiDV.Name = "btnLoaiDV";
            this.btnLoaiDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiDV_ItemClick);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 12;
            this.barListItem1.Name = "barListItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 13;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // txtTongCH
            // 
            this.txtTongCH.Caption = "Tổng số căn hộ: 1067";
            this.txtTongCH.Id = 14;
            this.txtTongCH.Name = "txtTongCH";
            // 
            // btnToaHD
            // 
            this.btnToaHD.Caption = "Thêm nợ";
            this.btnToaHD.Id = 16;
            this.btnToaHD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnToaHD.ImageOptions.SvgImage")));
            this.btnToaHD.Name = "btnToaHD";
            this.btnToaHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnToaHD_ItemClick);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.Caption = "Quản lý quản lý nợ";
            this.btnQLHoaDon.Id = 17;
            this.btnQLHoaDon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLHoaDon.ImageOptions.SvgImage")));
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLHoaDon_ItemClick);
            // 
            // btnTaoBC
            // 
            this.btnTaoBC.Caption = "Báo cáo";
            this.btnTaoBC.Id = 18;
            this.btnTaoBC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoBC.ImageOptions.SvgImage")));
            this.btnTaoBC.Name = "btnTaoBC";
            this.btnTaoBC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoBC_ItemClick);
            // 
            // btBaoCaoNam
            // 
            this.btBaoCaoNam.Caption = "Báo cáo theo năm";
            this.btBaoCaoNam.Id = 19;
            this.btBaoCaoNam.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btBaoCaoNam.ImageOptions.SvgImage")));
            this.btBaoCaoNam.Name = "btBaoCaoNam";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 20;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 21;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnTT
            // 
            this.btnTT.Caption = "Thông tin tài khoản";
            this.btnTT.Id = 1;
            this.btnTT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTT.ImageOptions.SvgImage")));
            this.btnTT.Name = "btnTT";
            this.btnTT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTT_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick_1);
            // 
            // btnInBangGia
            // 
            this.btnInBangGia.Caption = "In báo cáo bảng giá dịch vụ";
            this.btnInBangGia.Id = 6;
            this.btnInBangGia.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInBangGia.ImageOptions.SvgImage")));
            this.btnInBangGia.Name = "btnInBangGia";
            this.btnInBangGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // txtTongDanCu
            // 
            this.txtTongDanCu.Caption = "Tổng số dân cư: 50";
            this.txtTongDanCu.Id = 7;
            this.txtTongDanCu.Name = "txtTongDanCu";
            // 
            // txtTongNhanVien
            // 
            this.txtTongNhanVien.Caption = "Tổng số nhân viên : 5";
            this.txtTongNhanVien.Id = 8;
            this.txtTongNhanVien.Name = "txtTongNhanVien";
            // 
            // btnInThang
            // 
            this.btnInThang.Caption = "In báo cáo";
            this.btnInThang.Id = 18;
            this.btnInThang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInThang.ImageOptions.SvgImage")));
            this.btnInThang.Name = "btnInThang";
            // 
            // btInBaoCaoNam
            // 
            this.btInBaoCaoNam.Caption = "Báo cáo năm";
            this.btInBaoCaoNam.Id = 19;
            this.btInBaoCaoNam.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btInBaoCaoNam.ImageOptions.SvgImage")));
            this.btInBaoCaoNam.Name = "btInBaoCaoNam";
            // 
            // ribbonPageQuanLy
            // 
            this.ribbonPageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupQL});
            this.ribbonPageQuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageQuanLy.ImageOptions.Image")));
            this.ribbonPageQuanLy.Name = "ribbonPageQuanLy";
            this.ribbonPageQuanLy.Text = "Bảng giá";
            // 
            // ribbonPageGroupQL
            // 
            this.ribbonPageGroupQL.ItemLinks.Add(this.btnQLGiaHang);
            this.ribbonPageGroupQL.Name = "ribbonPageGroupQL";
            this.ribbonPageGroupQL.Text = "Quản lý";
            // 
            // ribbonPageHoaDon
            // 
            this.ribbonPageHoaDon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHoaDon});
            this.ribbonPageHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageHoaDon.ImageOptions.Image")));
            this.ribbonPageHoaDon.Name = "ribbonPageHoaDon";
            this.ribbonPageHoaDon.Text = "Ghi nợ";
            // 
            // ribbonPageGroupHoaDon
            // 
            this.ribbonPageGroupHoaDon.ItemLinks.Add(this.btnToaHD);
            this.ribbonPageGroupHoaDon.ItemLinks.Add(this.btnQLHoaDon);
            this.ribbonPageGroupHoaDon.Name = "ribbonPageGroupHoaDon";
            this.ribbonPageGroupHoaDon.Text = "Hóa đơn";
            // 
            // ribbonPageDichVu
            // 
            this.ribbonPageDichVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupQLDichVu,
            this.ribbonPageGroupLoaiDV,
            this.ribbonPageGroupExport});
            this.ribbonPageDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageDichVu.ImageOptions.Image")));
            this.ribbonPageDichVu.Name = "ribbonPageDichVu";
            this.ribbonPageDichVu.Text = "Dịch vụ";
            // 
            // ribbonPageGroupQLDichVu
            // 
            this.ribbonPageGroupQLDichVu.ItemLinks.Add(this.btnThemDV);
            this.ribbonPageGroupQLDichVu.ItemLinks.Add(this.btnDSDV);
            this.ribbonPageGroupQLDichVu.Name = "ribbonPageGroupQLDichVu";
            this.ribbonPageGroupQLDichVu.Text = "Quản lý dịch vụ";
            // 
            // ribbonPageGroupLoaiDV
            // 
            this.ribbonPageGroupLoaiDV.ItemLinks.Add(this.btnLoaiDV);
            this.ribbonPageGroupLoaiDV.Name = "ribbonPageGroupLoaiDV";
            this.ribbonPageGroupLoaiDV.Text = "Loại dịch vụ";
            // 
            // ribbonPageGroupExport
            // 
            this.ribbonPageGroupExport.ItemLinks.Add(this.btnInBangGia);
            this.ribbonPageGroupExport.Name = "ribbonPageGroupExport";
            this.ribbonPageGroupExport.Text = "Export";
            // 
            // ribbonPageBaoCao
            // 
            this.ribbonPageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupBaoCao,
            this.ribbonPageGroupExportBaoCao});
            this.ribbonPageBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageBaoCao.ImageOptions.Image")));
            this.ribbonPageBaoCao.Name = "ribbonPageBaoCao";
            this.ribbonPageBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroupBaoCao
            // 
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.btnTaoBC);
            this.ribbonPageGroupBaoCao.Name = "ribbonPageGroupBaoCao";
            this.ribbonPageGroupBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroupExportBaoCao
            // 
            this.ribbonPageGroupExportBaoCao.ItemLinks.Add(this.btnInThang);
            this.ribbonPageGroupExportBaoCao.Name = "ribbonPageGroupExportBaoCao";
            this.ribbonPageGroupExportBaoCao.Text = "Export";
            // 
            // applicationmenu
            // 
            this.applicationmenu.Name = "applicationmenu";
            this.applicationmenu.Ribbon = this.ribbon;
            // 
            // image
            // 
            this.image.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("image.ImageStream")));
            this.image.Images.SetKeyName(0, "1788-42738.png");
            this.image.Images.SetKeyName(1, "1808-60678.png");
            this.image.Images.SetKeyName(2, "1813-91951.png");
            this.image.Images.SetKeyName(3, "1836-88781.png");
            this.image.Images.SetKeyName(4, "1841-3834.png");
            this.image.Images.SetKeyName(5, "1842-31829.png");
            this.image.Images.SetKeyName(6, "1845-45617.png");
            this.image.Images.SetKeyName(7, "1847-15213.png");
            this.image.Images.SetKeyName(8, "1857-24779.png");
            this.image.Images.SetKeyName(9, "1858-57055.png");
            this.image.Images.SetKeyName(10, "1861-30112.png");
            this.image.Images.SetKeyName(11, "1871-64607.png");
            this.image.Images.SetKeyName(12, "1876-52248.png");
            this.image.Images.SetKeyName(13, "1877-8011.png");
            this.image.Images.SetKeyName(14, "1878-40332.png");
            this.image.Images.SetKeyName(15, "1910-27816.png");
            this.image.Images.SetKeyName(16, "1911-56757.png");
            this.image.Images.SetKeyName(17, "1928-78708.png");
            this.image.Images.SetKeyName(18, "1933-44340.png");
            this.image.Images.SetKeyName(19, "1936-34539.png");
            this.image.Images.SetKeyName(20, "1939-89860.png");
            this.image.Images.SetKeyName(21, "1946-4795.png");
            this.image.Images.SetKeyName(22, "1949-11953.png");
            this.image.Images.SetKeyName(23, "1950-15207.png");
            this.image.Images.SetKeyName(24, "1951-50234.png");
            this.image.Images.SetKeyName(25, "1954-86817.png");
            this.image.Images.SetKeyName(26, "1960-91647.png");
            this.image.Images.SetKeyName(27, "1961-34168.png");
            this.image.Images.SetKeyName(28, "1962-7744.png");
            this.image.Images.SetKeyName(29, "1974-70366.png");
            this.image.Images.SetKeyName(30, "1975-50731.png");
            this.image.Images.SetKeyName(31, "1977-10164.png");
            this.image.Images.SetKeyName(32, "1981-52758.png");
            this.image.Images.SetKeyName(33, "1982-96763.png");
            this.image.Images.SetKeyName(34, "1984-6923.png");
            this.image.Images.SetKeyName(35, "1991-80680.png");
            this.image.Images.SetKeyName(36, "1998-49916.png");
            this.image.Images.SetKeyName(37, "2000-8832.png");
            this.image.Images.SetKeyName(38, "2018-69254.png");
            this.image.Images.SetKeyName(39, "2032-96879.png");
            this.image.Images.SetKeyName(40, "2035-76365.png");
            this.image.Images.SetKeyName(41, "2036-42622.png");
            this.image.Images.SetKeyName(42, "2087-32464.png");
            this.image.Images.SetKeyName(43, "2113-66537.png");
            this.image.Images.SetKeyName(44, "2120-19084.png");
            this.image.Images.SetKeyName(45, "2124-28742.png");
            this.image.Images.SetKeyName(46, "2127-77560.png");
            this.image.Images.SetKeyName(47, "2142-46099.png");
            this.image.Images.SetKeyName(48, "2184-36177.png");
            this.image.Images.SetKeyName(49, "2187-93826.png");
            this.image.Images.SetKeyName(50, "2190-4556.png");
            this.image.Images.SetKeyName(51, "2192-7615.png");
            this.image.Images.SetKeyName(52, "2211-87292.png");
            this.image.Images.SetKeyName(53, "2228-84189.png");
            this.image.Images.SetKeyName(54, "2240-40779.png");
            this.image.Images.SetKeyName(55, "2280-38229.png");
            this.image.Images.SetKeyName(56, "2284-85686.png");
            this.image.Images.SetKeyName(57, "2290-81213.png");
            this.image.Images.SetKeyName(58, "2304-21179.png");
            this.image.Images.SetKeyName(59, "2364-89491.png");
            this.image.Images.SetKeyName(60, "2369-35278.png");
            this.image.Images.SetKeyName(61, "2370-75477.png");
            this.image.Images.SetKeyName(62, "2373-71556.png");
            this.image.Images.SetKeyName(63, "2393-9069.png");
            this.image.Images.SetKeyName(64, "2411-96066.png");
            this.image.Images.SetKeyName(65, "2423-89004.png");
            this.image.Images.SetKeyName(66, "2430-1111.png");
            this.image.Images.SetKeyName(67, "2447-1150.png");
            this.image.Images.SetKeyName(68, "2475-63841.png");
            this.image.Images.SetKeyName(69, "2493-83580.png");
            this.image.Images.SetKeyName(70, "2497-97618.png");
            this.image.Images.SetKeyName(71, "2500-13288.png");
            this.image.Images.SetKeyName(72, "2508-40510.png");
            this.image.Images.SetKeyName(73, "2509-70891.png");
            this.image.Images.SetKeyName(74, "2510-78528.png");
            this.image.Images.SetKeyName(75, "2511-79331.png");
            this.image.Images.SetKeyName(76, "2512-98370.png");
            this.image.Images.SetKeyName(77, "2513-21599.png");
            this.image.Images.SetKeyName(78, "2516-7967.png");
            this.image.Images.SetKeyName(79, "2518-11470.png");
            this.image.Images.SetKeyName(80, "2527-95401.png");
            this.image.Images.SetKeyName(81, "2528-71050.png");
            this.image.Images.SetKeyName(82, "2529-62121.png");
            this.image.Images.SetKeyName(83, "2530-62528.png");
            this.image.Images.SetKeyName(84, "2531-17008.png");
            this.image.Images.SetKeyName(85, "2536-7515.png");
            this.image.Images.SetKeyName(86, "2537-80203.png");
            this.image.Images.SetKeyName(87, "2574-21395.png");
            this.image.Images.SetKeyName(88, "2601-32558.png");
            this.image.Images.SetKeyName(89, "2604-79952.png");
            this.image.Images.SetKeyName(90, "2615-64454.png");
            this.image.Images.SetKeyName(91, "2628-39411.png");
            this.image.Images.SetKeyName(92, "2631-57529.png");
            this.image.Images.SetKeyName(93, "2665-15275.png");
            this.image.Images.SetKeyName(94, "2666-76449.png");
            this.image.Images.SetKeyName(95, "2667-3499.png");
            this.image.Images.SetKeyName(96, "2735-61252.png");
            this.image.Images.SetKeyName(97, "2736-43423.png");
            this.image.Images.SetKeyName(98, "2737-56066.png");
            this.image.Images.SetKeyName(99, "2770-13289.png");
            this.image.Images.SetKeyName(100, "2774-39325.png");
            this.image.Images.SetKeyName(101, "2776-6178.png");
            this.image.Images.SetKeyName(102, "2786-21016.png");
            this.image.Images.SetKeyName(103, "2795-90579.png");
            this.image.Images.SetKeyName(104, "2797-83620.png");
            this.image.Images.SetKeyName(105, "2809-65308.png");
            this.image.Images.SetKeyName(106, "2815-37878.png");
            this.image.Images.SetKeyName(107, "2945-8504.png");
            this.image.Images.SetKeyName(108, "2953-21366.png");
            this.image.Images.SetKeyName(109, "3033-80263.png");
            this.image.Images.SetKeyName(110, "3075-48649.png");
            this.image.Images.SetKeyName(111, "3082-78427.png");
            this.image.Images.SetKeyName(112, "3084-9691.png");
            this.image.Images.SetKeyName(113, "3086-32077.png");
            this.image.Images.SetKeyName(114, "3089-9980.png");
            this.image.Images.SetKeyName(115, "3090-89056.png");
            this.image.Images.SetKeyName(116, "3109-45323.png");
            this.image.Images.SetKeyName(117, "3110-3911.png");
            this.image.Images.SetKeyName(118, "3115-59854.png");
            this.image.Images.SetKeyName(119, "3116-66630.png");
            this.image.Images.SetKeyName(120, "3121-97433.png");
            this.image.Images.SetKeyName(121, "3125-39042.png");
            this.image.Images.SetKeyName(122, "3135-6268.png");
            this.image.Images.SetKeyName(123, "3136-73903.png");
            this.image.Images.SetKeyName(124, "3137-84642.png");
            this.image.Images.SetKeyName(125, "3138-18118.png");
            this.image.Images.SetKeyName(126, "3142-69827.png");
            this.image.Images.SetKeyName(127, "3143-63842.png");
            this.image.Images.SetKeyName(128, "3145-55599.png");
            this.image.Images.SetKeyName(129, "3210-39444.png");
            this.image.Images.SetKeyName(130, "3220-70326.png");
            this.image.Images.SetKeyName(131, "3251-33512.png");
            this.image.Images.SetKeyName(132, "3269-7460.png");
            this.image.Images.SetKeyName(133, "3270-83270.png");
            this.image.Images.SetKeyName(134, "3271-96561.png");
            this.image.Images.SetKeyName(135, "3272-65658.png");
            this.image.Images.SetKeyName(136, "3273-50298.png");
            this.image.Images.SetKeyName(137, "3274-9270.png");
            this.image.Images.SetKeyName(138, "3286-31806.png");
            this.image.Images.SetKeyName(139, "3307-38524.png");
            this.image.Images.SetKeyName(140, "3316-58186.png");
            this.image.Images.SetKeyName(141, "3358-45946.png");
            this.image.Images.SetKeyName(142, "3410-72605.png");
            this.image.Images.SetKeyName(143, "3422-90713.png");
            this.image.Images.SetKeyName(144, "3424-85991.png");
            this.image.Images.SetKeyName(145, "3426-60526.png");
            this.image.Images.SetKeyName(146, "3430-88138.png");
            this.image.Images.SetKeyName(147, "3432-7848.png");
            this.image.Images.SetKeyName(148, "3608-98722.png");
            this.image.Images.SetKeyName(149, "3616-28881.png");
            this.image.Images.SetKeyName(150, "3617-5784.png");
            this.image.Images.SetKeyName(151, "3673-4098.png");
            this.image.Images.SetKeyName(152, "3674-91302.png");
            this.image.Images.SetKeyName(153, "3675-32561.png");
            this.image.Images.SetKeyName(154, "3702-14857.png");
            this.image.Images.SetKeyName(155, "3707-67098.png");
            this.image.Images.SetKeyName(156, "3708-74222.png");
            this.image.Images.SetKeyName(157, "3728-53944.png");
            this.image.Images.SetKeyName(158, "3729-21215.png");
            this.image.Images.SetKeyName(159, "3745-9393.png");
            this.image.Images.SetKeyName(160, "3777-33207.png");
            this.image.Images.SetKeyName(161, "3779-77823.png");
            this.image.Images.SetKeyName(162, "3782-38555.png");
            this.image.Images.SetKeyName(163, "3791-71367.png");
            this.image.Images.SetKeyName(164, "3793-61947.png");
            this.image.Images.SetKeyName(165, "3794-29666.png");
            this.image.Images.SetKeyName(166, "3811-8814.png");
            this.image.Images.SetKeyName(167, "3814-57733.png");
            this.image.Images.SetKeyName(168, "3817-81469.png");
            this.image.Images.SetKeyName(169, "3830-12566.png");
            this.image.Images.SetKeyName(170, "3832-23422.png");
            this.image.Images.SetKeyName(171, "3839-27692.png");
            this.image.Images.SetKeyName(172, "3840-99919.png");
            this.image.Images.SetKeyName(173, "3863-90517.png");
            this.image.Images.SetKeyName(174, "3864-43348.png");
            this.image.Images.SetKeyName(175, "3898-29074.png");
            this.image.Images.SetKeyName(176, "3902-39581.png");
            this.image.Images.SetKeyName(177, "3905-39773.png");
            this.image.Images.SetKeyName(178, "3956-67726.png");
            this.image.Images.SetKeyName(179, "3960-79397.png");
            this.image.Images.SetKeyName(180, "3975-6326.png");
            this.image.Images.SetKeyName(181, "3981-49830.png");
            this.image.Images.SetKeyName(182, "3983-80092.png");
            this.image.Images.SetKeyName(183, "3984-44134.png");
            this.image.Images.SetKeyName(184, "3993-77116.png");
            this.image.Images.SetKeyName(185, "4033-90776.png");
            this.image.Images.SetKeyName(186, "4035-55425.png");
            this.image.Images.SetKeyName(187, "4037-40492.png");
            this.image.Images.SetKeyName(188, "4043-78792.png");
            this.image.Images.SetKeyName(189, "4044-13894.png");
            this.image.Images.SetKeyName(190, "4049-33766.png");
            this.image.Images.SetKeyName(191, "4084-41286.png");
            this.image.Images.SetKeyName(192, "4087-71927.png");
            this.image.Images.SetKeyName(193, "4088-63512.png");
            this.image.Images.SetKeyName(194, "4099-69624.png");
            this.image.Images.SetKeyName(195, "4103-19622.png");
            this.image.Images.SetKeyName(196, "4106-82447.png");
            this.image.Images.SetKeyName(197, "4112-95778.png");
            this.image.Images.SetKeyName(198, "4113-55782.png");
            this.image.Images.SetKeyName(199, "4115-75579.png");
            this.image.Images.SetKeyName(200, "4116-68505.png");
            this.image.Images.SetKeyName(201, "4118-66404.png");
            this.image.Images.SetKeyName(202, "4119-96540.png");
            this.image.Images.SetKeyName(203, "4120-37334.png");
            this.image.Images.SetKeyName(204, "4122-39859.png");
            this.image.Images.SetKeyName(205, "4124-23099.png");
            this.image.Images.SetKeyName(206, "4128-66738.png");
            this.image.Images.SetKeyName(207, "4129-71653.png");
            this.image.Images.SetKeyName(208, "4130-58058.png");
            this.image.Images.SetKeyName(209, "4131-57712.png");
            this.image.Images.SetKeyName(210, "4132-86098.png");
            this.image.Images.SetKeyName(211, "4146-3422.png");
            this.image.Images.SetKeyName(212, "4147-95384.png");
            this.image.Images.SetKeyName(213, "4148-58485.png");
            this.image.Images.SetKeyName(214, "4149-48036.png");
            this.image.Images.SetKeyName(215, "4150-5805.png");
            this.image.Images.SetKeyName(216, "4151-55236.png");
            this.image.Images.SetKeyName(217, "4174-51265.png");
            this.image.Images.SetKeyName(218, "4175-15386.png");
            this.image.Images.SetKeyName(219, "4192-18404.png");
            this.image.Images.SetKeyName(220, "4196-11359.png");
            this.image.Images.SetKeyName(221, "4201-54211.png");
            this.image.Images.SetKeyName(222, "4208-21624.png");
            this.image.Images.SetKeyName(223, "4210-48352.png");
            this.image.Images.SetKeyName(224, "4218-10186.png");
            this.image.Images.SetKeyName(225, "4226-59539.png");
            this.image.Images.SetKeyName(226, "4227-51054.png");
            this.image.Images.SetKeyName(227, "4230-85205.png");
            this.image.Images.SetKeyName(228, "4244-37080.png");
            this.image.Images.SetKeyName(229, "4280-77948.png");
            this.image.Images.SetKeyName(230, "4281-96802.png");
            this.image.Images.SetKeyName(231, "4282-91971.png");
            this.image.Images.SetKeyName(232, "4288-83943.png");
            this.image.Images.SetKeyName(233, "4361-31506.png");
            this.image.Images.SetKeyName(234, "4362-14351.png");
            this.image.Images.SetKeyName(235, "4363-76451.png");
            this.image.Images.SetKeyName(236, "4364-94788.png");
            this.image.Images.SetKeyName(237, "4365-8843.png");
            this.image.Images.SetKeyName(238, "4366-88435.png");
            this.image.Images.SetKeyName(239, "4368-25528.png");
            this.image.Images.SetKeyName(240, "4371-18329.png");
            this.image.Images.SetKeyName(241, "4372-2595.png");
            this.image.Images.SetKeyName(242, "4373-71660.png");
            this.image.Images.SetKeyName(243, "4378-50224.png");
            this.image.Images.SetKeyName(244, "4379-38573.png");
            this.image.Images.SetKeyName(245, "4382-26901.png");
            this.image.Images.SetKeyName(246, "4387-59265.png");
            this.image.Images.SetKeyName(247, "4393-50040.png");
            this.image.Images.SetKeyName(248, "4395-55659.png");
            this.image.Images.SetKeyName(249, "4408-7292.png");
            this.image.Images.SetKeyName(250, "4414-80663.png");
            this.image.Images.SetKeyName(251, "4415-19341.png");
            this.image.Images.SetKeyName(252, "4431-21605.png");
            this.image.Images.SetKeyName(253, "4432-33560.png");
            this.image.Images.SetKeyName(254, "4437-88835.png");
            this.image.Images.SetKeyName(255, "4440-72213.png");
            this.image.Images.SetKeyName(256, "4446-74673.png");
            this.image.Images.SetKeyName(257, "4447-21514.png");
            this.image.Images.SetKeyName(258, "4448-43305.png");
            this.image.Images.SetKeyName(259, "4449-453.png");
            this.image.Images.SetKeyName(260, "4450-5415.png");
            this.image.Images.SetKeyName(261, "4451-20300.png");
            this.image.Images.SetKeyName(262, "4468-60921.png");
            this.image.Images.SetKeyName(263, "4505-56040.png");
            this.image.Images.SetKeyName(264, "4512-72173.png");
            this.image.Images.SetKeyName(265, "4513-89452.png");
            this.image.Images.SetKeyName(266, "4516-13718.png");
            this.image.Images.SetKeyName(267, "4531-38619.png");
            this.image.Images.SetKeyName(268, "4532-79247.png");
            this.image.Images.SetKeyName(269, "4536-37632.png");
            this.image.Images.SetKeyName(270, "4540-20668.png");
            this.image.Images.SetKeyName(271, "4542-76035.png");
            this.image.Images.SetKeyName(272, "4543-87384.png");
            this.image.Images.SetKeyName(273, "4552-63309.png");
            this.image.Images.SetKeyName(274, "4553-26978.png");
            this.image.Images.SetKeyName(275, "4554-9858.png");
            this.image.Images.SetKeyName(276, "4555-34644.png");
            this.image.Images.SetKeyName(277, "4558-32199.png");
            this.image.Images.SetKeyName(278, "4564-61038.png");
            this.image.Images.SetKeyName(279, "4565-98998.png");
            this.image.Images.SetKeyName(280, "4566-94026.png");
            this.image.Images.SetKeyName(281, "4567-6742.png");
            this.image.Images.SetKeyName(282, "4569-67600.png");
            this.image.Images.SetKeyName(283, "4573-20201.png");
            this.image.Images.SetKeyName(284, "4575-40855.png");
            this.image.Images.SetKeyName(285, "4576-9091.png");
            this.image.Images.SetKeyName(286, "4577-67758.png");
            this.image.Images.SetKeyName(287, "4585-74041.png");
            this.image.Images.SetKeyName(288, "4586-75809.png");
            this.image.Images.SetKeyName(289, "4587-33521.png");
            this.image.Images.SetKeyName(290, "4588-35000.png");
            this.image.Images.SetKeyName(291, "4589-19158.png");
            this.image.Images.SetKeyName(292, "4590-92832.png");
            this.image.Images.SetKeyName(293, "4591-28729.png");
            this.image.Images.SetKeyName(294, "4595-6109.png");
            this.image.Images.SetKeyName(295, "4596-15897.png");
            this.image.Images.SetKeyName(296, "4598-95864.png");
            this.image.Images.SetKeyName(297, "4602-35020.png");
            this.image.Images.SetKeyName(298, "4603-74312.png");
            this.image.Images.SetKeyName(299, "4605-22622.png");
            this.image.Images.SetKeyName(300, "4607-64666.png");
            this.image.Images.SetKeyName(301, "4608-92618.png");
            this.image.Images.SetKeyName(302, "4609-60858.png");
            this.image.Images.SetKeyName(303, "4610-94653.png");
            this.image.Images.SetKeyName(304, "4611-38950.png");
            this.image.Images.SetKeyName(305, "4612-334.png");
            this.image.Images.SetKeyName(306, "4616-59687.png");
            this.image.Images.SetKeyName(307, "4618-55353.png");
            this.image.Images.SetKeyName(308, "4620-52530.png");
            this.image.Images.SetKeyName(309, "4635-60843.png");
            this.image.Images.SetKeyName(310, "4639-62709.png");
            this.image.Images.SetKeyName(311, "4640-70843.png");
            this.image.Images.SetKeyName(312, "4650-98160.png");
            this.image.Images.SetKeyName(313, "4666-8582.png");
            this.image.Images.SetKeyName(314, "4672-36454.png");
            this.image.Images.SetKeyName(315, "4677-87675.png");
            this.image.Images.SetKeyName(316, "4684-40355.png");
            this.image.Images.SetKeyName(317, "4690-23819.png");
            this.image.Images.SetKeyName(318, "4691-73450.png");
            this.image.Images.SetKeyName(319, "4707-72172.png");
            this.image.Images.SetKeyName(320, "4708-20304.png");
            this.image.Images.SetKeyName(321, "4723-61649.png");
            this.image.Images.SetKeyName(322, "4730-548.png");
            this.image.Images.SetKeyName(323, "4735-6048.png");
            this.image.Images.SetKeyName(324, "4757-1426.png");
            this.image.Images.SetKeyName(325, "4760-62458.png");
            this.image.Images.SetKeyName(326, "4765-58167.png");
            this.image.Images.SetKeyName(327, "4771-46406.png");
            this.image.Images.SetKeyName(328, "4778-59653.png");
            this.image.Images.SetKeyName(329, "4779-93344.png");
            this.image.Images.SetKeyName(330, "4781-37289.png");
            this.image.Images.SetKeyName(331, "4782-77796.png");
            this.image.Images.SetKeyName(332, "4783-54644.png");
            this.image.Images.SetKeyName(333, "4784-19375.png");
            this.image.Images.SetKeyName(334, "4812-mimipunk-WorldCup.png");
            this.image.Images.SetKeyName(335, "4816-pittux-Ipod.png");
            this.image.Images.SetKeyName(336, "4821-babasse-avedesk.png");
            this.image.Images.SetKeyName(337, "4824-babasse-objectdocktecflo.png");
            this.image.Images.SetKeyName(338, "4825-babasse-shutdowntecflo.png");
            this.image.Images.SetKeyName(339, "4826-babasse-CXPtecflo.png");
            this.image.Images.SetKeyName(340, "4827-babasse-WindowsTecflo.png");
            this.image.Images.SetKeyName(341, "4832-bananaboy-ThexXx.png");
            this.image.Images.SetKeyName(342, "4837-LloydBanks-Areternnselec.png");
            this.image.Images.SetKeyName(343, "4840-Tardio-Opera.png");
            this.image.Images.SetKeyName(344, "4842-LloydBanks-Arreter2.png");
            this.image.Images.SetKeyName(345, "4846-LloydBanks-BudyBleu.png");
            this.image.Images.SetKeyName(346, "4847-LloydBanks-Budyvert.png");
            this.image.Images.SetKeyName(347, "4848-LloydBanks-Fermersession.png");
            this.image.Images.SetKeyName(348, "4849-LloydBanks-Fermersession2.png");
            this.image.Images.SetKeyName(349, "4851-LloydBanks-Office.png");
            this.image.Images.SetKeyName(350, "4853-LloydBanks-Boutonplay.png");
            this.image.Images.SetKeyName(351, "4856-LloydBanks-Rss.png");
            this.image.Images.SetKeyName(352, "4859-LloydBanks-Reboot.png");
            this.image.Images.SetKeyName(353, "4861-LloydBanks-Reboot2.png");
            this.image.Images.SetKeyName(354, "4889-Designaxl-HardDrive.png");
            this.image.Images.SetKeyName(355, "4892-Designaxl-Clavier.png");
            this.image.Images.SetKeyName(356, "4897-Cacahuete-Balloncoupedumonde.png");
            this.image.Images.SetKeyName(357, "4901-raklo-ReGetDeluxe.png");
            this.image.Images.SetKeyName(358, "4907-babasse-postedetravail.png");
            this.image.Images.SetKeyName(359, "4922-dclick-SonyDSCV3DcK.png");
            this.image.Images.SetKeyName(360, "4931-dclick-NFSUnderground2DcK.png");
            this.image.Images.SetKeyName(361, "4952-ShuYaHacK-WindowsV3.png");
            this.image.Images.SetKeyName(362, "4953-dclick-DJConsoleMK2DcK.png");
            this.image.Images.SetKeyName(363, "4954-dclick-PlatineDJDcK.png");
            this.image.Images.SetKeyName(364, "4960-darklight-encyclopedia.png");
            this.image.Images.SetKeyName(365, "4961-Tardio-Sizer.png");
            this.image.Images.SetKeyName(366, "4964-tatice-Parchemin.png");
            this.image.Images.SetKeyName(367, "4965-tatice-Vieuxparchemin.png");
            this.image.Images.SetKeyName(368, "4973-babasse-appareilphoto.png");
            this.image.Images.SetKeyName(369, "4974-tatice-Ballondefoot.png");
            this.image.Images.SetKeyName(370, "4975-tatice-Pinceauvert.png");
            this.image.Images.SetKeyName(371, "4976-rd909-GuitarPro5.png");
            this.image.Images.SetKeyName(372, "4980-dclick-LesSims2DcK.png");
            this.image.Images.SetKeyName(373, "4981-Silmasoron-adobereader.png");
            this.image.Images.SetKeyName(374, "4983-babasse-apareilphotov2.png");
            this.image.Images.SetKeyName(375, "4991-babasse-mesimages.png");
            this.image.Images.SetKeyName(376, "4997-Dusboy-Starwarsbf2.png");
            this.image.Images.SetKeyName(377, "4998-efdur-Photo.png");
            this.image.Images.SetKeyName(378, "5009-pittux-iPodU2.png");
            this.image.Images.SetKeyName(379, "5010-pittux-iPodshuffle.png");
            this.image.Images.SetKeyName(380, "5011-pittux-macbook.png");
            this.image.Images.SetKeyName(381, "5014-pittux-AppleCinema.png");
            this.image.Images.SetKeyName(382, "5015-babasse-MiniDV.png");
            this.image.Images.SetKeyName(383, "5031-tOo-CreativeZenTouch.png");
            this.image.Images.SetKeyName(384, "5032-tOo-PaddePlaystation.png");
            this.image.Images.SetKeyName(385, "5034-tOo-Alcohol120.png");
            this.image.Images.SetKeyName(386, "5035-tOo-Quake4.png");
            this.image.Images.SetKeyName(387, "5036-tOo-GoogleSketchup.png");
            this.image.Images.SetKeyName(388, "5060-vIcO-SonicReelDVD.png");
            this.image.Images.SetKeyName(389, "5064-babasse-lecteurmp3v2.png");
            this.image.Images.SetKeyName(390, "5069-tOo-PaddePlaystation2.png");
            this.image.Images.SetKeyName(391, "5072-babasse-disquedurexterne.png");
            this.image.Images.SetKeyName(392, "5073-ToWMarine-DisqueDur.png");
            this.image.Images.SetKeyName(393, "5074-Silmasoron-apple.png");
            this.image.Images.SetKeyName(394, "5081-babasse-disquedurv2.png");
            this.image.Images.SetKeyName(395, "5082-Livan-Think.png");
            this.image.Images.SetKeyName(396, "5083-Livan-Stop.png");
            this.image.Images.SetKeyName(397, "5084-Livan-Execut.png");
            this.image.Images.SetKeyName(398, "5085-Livan-Star.png");
            this.image.Images.SetKeyName(399, "5086-Livan-GoodNight.png");
            this.image.Images.SetKeyName(400, "5087-Livan-Zen.png");
            this.image.Images.SetKeyName(401, "5088-Livan-Love.png");
            this.image.Images.SetKeyName(402, "5092-TazBurner-AmericaArmyHitman.png");
            this.image.Images.SetKeyName(403, "5097-cameleonhelp-Alcohol.png");
            this.image.Images.SetKeyName(404, "5098-cameleonhelp-Alcohol52.png");
            this.image.Images.SetKeyName(405, "5099-cameleonhelp-Alcohol120btn.png");
            this.image.Images.SetKeyName(406, "5100-cameleonhelp-MSStickyNotes.png");
            this.image.Images.SetKeyName(407, "5104-vIcO-Cadenasnoir.png");
            this.image.Images.SetKeyName(408, "5105-vIcO-Cadenasjaune.png");
            this.image.Images.SetKeyName(409, "5107-cameleonhelp-Alcohol25btn.png");
            this.image.Images.SetKeyName(410, "5110-Livan-Yes.png");
            this.image.Images.SetKeyName(411, "5143-JoGnEt-ShutdownAero.png");
            this.image.Images.SetKeyName(412, "5144-bananaboy-Winamp6.png");
            this.image.Images.SetKeyName(413, "5145-JoGnEt-WMP11v1.png");
            this.image.Images.SetKeyName(414, "5146-JoGnEt-ShutdownAero2.png");
            this.image.Images.SetKeyName(415, "5147-JoGnEt-VeilleAero.png");
            this.image.Images.SetKeyName(416, "5148-JoGnEt-Reboot.png");
            this.image.Images.SetKeyName(417, "5152-mimipunk-Snow.png");
            this.image.Images.SetKeyName(418, "5153-LloydBanks-Apple.png");
            this.image.Images.SetKeyName(419, "5154-Silmasoron-yinyang.png");
            this.image.Images.SetKeyName(420, "5179-pittux-Stylo.png");
            this.image.Images.SetKeyName(421, "5180-Frearnaud-Kasperskyv2.png");
            this.image.Images.SetKeyName(422, "5182-tOo-SNES.png");
            this.image.Images.SetKeyName(423, "5189-canariveto-dvdregionfree.png");
            this.image.Images.SetKeyName(424, "5192-canariveto-skypelol.png");
            this.image.Images.SetKeyName(425, "5193-canariveto-treesize.png");
            this.image.Images.SetKeyName(426, "5217-vIcO-OneCare.png");
            this.image.Images.SetKeyName(427, "5218-vIcO-AntiSpyware.png");
            this.image.Images.SetKeyName(428, "5221-vIcO-Applecolors.png");
            this.image.Images.SetKeyName(429, "5225-vIcO-Devcplusplus.png");
            this.image.Images.SetKeyName(430, "5228-JoGnEt-CS2Aero.png");
            this.image.Images.SetKeyName(431, "5246-Silmasoron-QuickTime.png");
            this.image.Images.SetKeyName(432, "5292-Hugo98-Windows.png");
            this.image.Images.SetKeyName(433, "5299-Stargate89-Kaspersky.png");
            this.image.Images.SetKeyName(434, "5300-Stargate89-Dossier.png");
            this.image.Images.SetKeyName(435, "5301-Stargate89-Windows.png");
            this.image.Images.SetKeyName(436, "5302-Stargate89-Stargate.png");
            this.image.Images.SetKeyName(437, "5307-vIcO-FootballManager.png");
            this.image.Images.SetKeyName(438, "5308-vIcO-ObjectDock.png");
            this.image.Images.SetKeyName(439, "5312-vIcO-Biohazard.png");
            this.image.Images.SetKeyName(440, "5321-JoGnEt-WMP11v2.png");
            this.image.Images.SetKeyName(441, "5341-Designaxl-Salamandre.png");
            this.image.Images.SetKeyName(442, "5342-pittux-statistiques.png");
            this.image.Images.SetKeyName(443, "5343-babasse-tour.png");
            this.image.Images.SetKeyName(444, "acrobat_casimir_software.png");
            this.image.Images.SetKeyName(445, "actualiser_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(446, "andorre_kavel_divers.png");
            this.image.Images.SetKeyName(447, "antispyware_micka_software.png");
            this.image.Images.SetKeyName(448, "archos_silver4_hardware.png");
            this.image.Images.SetKeyName(449, "audio_kavel_divers.png");
            this.image.Images.SetKeyName(450, "autriche_kavel_divers.png");
            this.image.Images.SetKeyName(451, "avast_south-park_software.png");
            this.image.Images.SetKeyName(452, "azureus_frost_software.png");
            this.image.Images.SetKeyName(453, "banque_hiroshi_divers.png");
            this.image.Images.SetKeyName(454, "belgique_kavel_divers.png");
            this.image.Images.SetKeyName(455, "bloc-note_la-fouine_divers.png");
            this.image.Images.SetKeyName(456, "cancel-bouclier_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(457, "canon-s30_overlord_hardware.png");
            this.image.Images.SetKeyName(458, "cd_jer_suite.png");
            this.image.Images.SetKeyName(459, "cd1_la-fouine_suite.png");
            this.image.Images.SetKeyName(460, "cd2_la-fouine_suite.png");
            this.image.Images.SetKeyName(461, "cd3_la-fouine_suite.png");
            this.image.Images.SetKeyName(462, "cd4_la-fouine_suite.png");
            this.image.Images.SetKeyName(463, "cerisegimp_mickaylfreefr_divers.png");
            this.image.Images.SetKeyName(464, "chariot_kavel_divers.png");
            this.image.Images.SetKeyName(465, "chat_pitbull13_divers.png");
            this.image.Images.SetKeyName(466, "clavier_la-fouine-du-net_divers.png");
            this.image.Images.SetKeyName(467, "cle-usb-mp3_tpdk-casimir_hardware.png");
            this.image.Images.SetKeyName(468, "coche_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(469, "compactflash-insert_tpdk-casimir_hardware.png");
            this.image.Images.SetKeyName(470, "conection-reso-inter_la-fouine_divers.png");
            this.image.Images.SetKeyName(471, "cpp-borland_ulluss_software.png");
            this.image.Images.SetKeyName(472, "creative_vico_software.png");
            this.image.Images.SetKeyName(473, "creditcard_tpdk-casimir_divers.png");
            this.image.Images.SetKeyName(474, "danger_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(475, "delphi6_cacabuda_software.png");
            this.image.Images.SetKeyName(476, "desactive_silver4_divers.png");
            this.image.Images.SetKeyName(477, "divx-player_overlord_software.png");
            this.image.Images.SetKeyName(478, "doc-vierge-parch_hiroshi_suite.png");
            this.image.Images.SetKeyName(479, "dosier-1_la-fouine_divers.png");
            this.image.Images.SetKeyName(480, "dosier-simple_la-fouine_divers.png");
            this.image.Images.SetKeyName(481, "dossier-adobe_la-fouine_divers.png");
            this.image.Images.SetKeyName(482, "dossier-aol_la-fouine_divers.png");
            this.image.Images.SetKeyName(483, "dossier-cd_la-fouine_divers.png");
            this.image.Images.SetKeyName(484, "dossier-cherche_la-fouine_divers.png");
            this.image.Images.SetKeyName(485, "dossier-clock_la-fouine_divers.png");
            this.image.Images.SetKeyName(486, "dossier-conection_la-fouine_divers.png");
            this.image.Images.SetKeyName(487, "dossier-corse_la-fouine_divers.png");
            this.image.Images.SetKeyName(488, "dossier-document-2_la-fouine_divers.png");
            this.image.Images.SetKeyName(489, "dossier-favoris_la-fouine_divers.png");
            this.image.Images.SetKeyName(490, "dossier-favoris-2_la-fouine_divers.png");
            this.image.Images.SetKeyName(491, "dossier-fleche-rouge_la-fouine_divers.png");
            this.image.Images.SetKeyName(492, "dossier-fleche-verte_la-fouine_divers.png");
            this.image.Images.SetKeyName(493, "dossier-image_la-fouine_divers.png");
            this.image.Images.SetKeyName(494, "dossier-internet_la-fouine_divers.png");
            this.image.Images.SetKeyName(495, "dossier-jeux_la-fouine_divers.png");
            this.image.Images.SetKeyName(496, "dossier-jeux-2_la-fouine_divers.png");
            this.image.Images.SetKeyName(497, "dossier-kaspersky_la-fouine_divers.png");
            this.image.Images.SetKeyName(498, "dossier-kaza_la-fouine_divers.png");
            this.image.Images.SetKeyName(499, "dossier-mac_la-fouine_divers.png");
            this.image.Images.SetKeyName(500, "dossier-media-player_la-fouine_divers.png");
            this.image.Images.SetKeyName(501, "dossier-metalique_yannthebigboss_divers.png");
            this.image.Images.SetKeyName(502, "dossier-metal-music_yannthebigboss_divers.png");
            this.image.Images.SetKeyName(503, "dossier-nouveau_la-fouine_divers.png");
            this.image.Images.SetKeyName(504, "dossier-outil_la-fouine_divers.png");
            this.image.Images.SetKeyName(505, "dossier-paint_la-fouine_divers.png");
            this.image.Images.SetKeyName(506, "dossier-papillon-msn_la-fouine_divers.png");
            this.image.Images.SetKeyName(507, "dossier-partage-fich_la-fouine_divers.png");
            this.image.Images.SetKeyName(508, "dossier-quicktime_la-fouine_divers.png");
            this.image.Images.SetKeyName(509, "dossier-skype_la-fouine_divers.png");
            this.image.Images.SetKeyName(510, "dossier-smaley_la-fouine_divers.png");
            this.image.Images.SetKeyName(511, "dossier-soleil_la-fouine_divers.png");
            this.image.Images.SetKeyName(512, "dossier-son_la-fouine_divers.png");
            this.image.Images.SetKeyName(513, "dossier-stop_la-fouine_divers.png");
            this.image.Images.SetKeyName(514, "dossier-toshop_la-fouine_divers.png");
            this.image.Images.SetKeyName(515, "dossier-toshop-2_la-fouine_divers.png");
            this.image.Images.SetKeyName(516, "dossier-virus_la-fouine_divers.png");
            this.image.Images.SetKeyName(517, "dossier-windows_la-fouine_divers.png");
            this.image.Images.SetKeyName(518, "dossier-windows-2_la-fouine_divers.png");
            this.image.Images.SetKeyName(519, "dossier-word_la-fouine_divers.png");
            this.image.Images.SetKeyName(520, "dossier-yahou_la-fouine_divers.png");
            this.image.Images.SetKeyName(521, "dossier-zip_la-fouine_divers.png");
            this.image.Images.SetKeyName(522, "download1_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(523, "dreamweaver_wolftom_software.png");
            this.image.Images.SetKeyName(524, "emule-aqua_overlord_software.png");
            this.image.Images.SetKeyName(525, "enemy-territory_acidtux_jeux-video.png");
            this.image.Images.SetKeyName(526, "erreur_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(527, "farcry_olryn_jeux-video.png");
            this.image.Images.SetKeyName(528, "feu_mickaylfreefr_suite.png");
            this.image.Images.SetKeyName(529, "feuille-de-chaine_la-fouine_divers.png");
            this.image.Images.SetKeyName(530, "feurouge_mickaylfreefr_suite.png");
            this.image.Images.SetKeyName(531, "firewall_kavel_divers.png");
            this.image.Images.SetKeyName(532, "flash_wolftom_software.png");
            this.image.Images.SetKeyName(533, "ftp-expert_hiroshi_software.png");
            this.image.Images.SetKeyName(534, "gibraltar_kavel_divers.png");
            this.image.Images.SetKeyName(535, "googleearth_tthhiibb_software.png");
            this.image.Images.SetKeyName(536, "hardware-ram_tpdk-casimir_hardware.png");
            this.image.Images.SetKeyName(537, "home_kavel_divers.png");
            this.image.Images.SetKeyName(538, "hp-mute_cyber-mdee_hardware.png");
            this.image.Images.SetKeyName(539, "identity_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(540, "image-compressor_kenzo_software.png");
            this.image.Images.SetKeyName(541, "info-bouclier_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(542, "information_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(543, "instantget_overlord_software.png");
            this.image.Images.SetKeyName(544, "ipod2_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(545, "ipod3_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(546, "ipod4_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(547, "ipod6_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(548, "ipod7_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(549, "ipod8_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(550, "ipod9_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(551, "ipod10_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(552, "ipod13_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(553, "irlande_kavel_divers.png");
            this.image.Images.SetKeyName(554, "lavasoft_south-park_software.png");
            this.image.Images.SetKeyName(555, "linksys_la-fouine-du-net_divers.png");
            this.image.Images.SetKeyName(556, "logo-playstation_la-fouine_jeux-video.png");
            this.image.Images.SetKeyName(557, "logo-windows_la-fouine_divers.png");
            this.image.Images.SetKeyName(558, "maya-6_silver4_software.png");
            this.image.Images.SetKeyName(559, "medalofhonor_vico_jeux-video.png");
            this.image.Images.SetKeyName(560, "mediaplayerclassicv1_tpdk-casimir_software.png");
            this.image.Images.SetKeyName(561, "mediaplayerclassicv2_tpdk-casimir_software.png");
            this.image.Images.SetKeyName(562, "memory-stick_tpdk-casimir_hardware.png");
            this.image.Images.SetKeyName(563, "memory-stick-2_tpdk-casimir_hardware.png");
            this.image.Images.SetKeyName(564, "mes-images_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(565, "mesnews_overlord_software.png");
            this.image.Images.SetKeyName(566, "microscope_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(567, "modem_shikamaru-mj_hardware.png");
            this.image.Images.SetKeyName(568, "money-2005_splat_software.png");
            this.image.Images.SetKeyName(569, "mp3_cyber-mdee_divers.png");
            this.image.Images.SetKeyName(570, "msexcel1_cameleonhelp_software.png");
            this.image.Images.SetKeyName(571, "msnmessengerda_dacust_software.png");
            this.image.Images.SetKeyName(572, "msword1_cameleonhelp_software.png");
            this.image.Images.SetKeyName(573, "nanopod1_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(574, "nanopod2_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(575, "nanopod3_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(576, "nanopod5_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(577, "nanopod6_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(578, "nanopod7_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(579, "nanopod8_cameleonhelp_suite.png");
            this.image.Images.SetKeyName(580, "nero_vico_software.png");
            this.image.Images.SetKeyName(581, "nero-flame_la-fouine_divers.png");
            this.image.Images.SetKeyName(582, "neufbox_silver4_hardware.png");
            this.image.Images.SetKeyName(583, "nfsu2_atome77_jeux-video.png");
            this.image.Images.SetKeyName(584, "nhl-2005_fcys14_jeux-video.png");
            this.image.Images.SetKeyName(585, "nintendo-64_hiroshi_jeux-video.png");
            this.image.Images.SetKeyName(586, "norton_silver4_software.png");
            this.image.Images.SetKeyName(587, "norton_vico_software.png");
            this.image.Images.SetKeyName(588, "o-et-o-defrag-pro_overlord_software.png");
            this.image.Images.SetKeyName(589, "olitec-usb-adsl-v3_overlord_hardware.png");
            this.image.Images.SetKeyName(590, "palone_la-fouine-du-net_divers.png");
            this.image.Images.SetKeyName(591, "panda-antivirus_epona_hardware.png");
            this.image.Images.SetKeyName(592, "photoshopcs2-noir_lord-of-sodom_suite.png");
            this.image.Images.SetKeyName(593, "pile_kavel_divers.png");
            this.image.Images.SetKeyName(594, "pinceau_shikamaru-mj_divers.png");
            this.image.Images.SetKeyName(595, "pocketdivxconverter_micka_software.png");
            this.image.Images.SetKeyName(596, "poste-de-travail_la-fouine-du-net_divers.png");
            this.image.Images.SetKeyName(597, "poste-travail_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(598, "progo_la-fouine-du-net_divers.png");
            this.image.Images.SetKeyName(599, "qt_citron_divers.png");
            this.image.Images.SetKeyName(600, "question-bouclier_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(601, "quille-travaux_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(602, "reader_hunabkuc_suite.png");
            this.image.Images.SetKeyName(603, "refresh.png");
            this.image.Images.SetKeyName(604, "registre_kavel_divers.png");
            this.image.Images.SetKeyName(605, "rep-images_silver4_divers.png");
            this.image.Images.SetKeyName(606, "republiquetcheque_kavel_divers.png");
            this.image.Images.SetKeyName(607, "restart_overlord_divers.png");
            this.image.Images.SetKeyName(608, "ringemule_micka_suite.png");
            this.image.Images.SetKeyName(609, "roumanie_kavel_divers.png");
            this.image.Images.SetKeyName(610, "royaumeuni_kavel_divers.png");
            this.image.Images.SetKeyName(611, "russie_kavel_divers.png");
            this.image.Images.SetKeyName(612, "saintmarin_kavel_divers.png");
            this.image.Images.SetKeyName(613, "scan_la-fouine-du-net_divers.png");
            this.image.Images.SetKeyName(614, "securedigital-insert_tpdk-casimir_hardware.png");
            this.image.Images.SetKeyName(615, "security-reader2_tpdk-casimir_software.png");
            this.image.Images.SetKeyName(616, "senegal_kavel_divers.png");
            this.image.Images.SetKeyName(617, "serbiemontenegro_kavel_divers.png");
            this.image.Images.SetKeyName(618, "skype_cameleonhelp_software.png");
            this.image.Images.SetKeyName(619, "slovaquie_kavel_divers.png");
            this.image.Images.SetKeyName(620, "slovenie_kavel_divers.png");
            this.image.Images.SetKeyName(621, "smartmedia-insert_tpdk-casimir_hardware.png");
            this.image.Images.SetKeyName(622, "sony-ericson01_djmdee_divers.png");
            this.image.Images.SetKeyName(623, "souris_shikamaru-mj_hardware.png");
            this.image.Images.SetKeyName(624, "speetouch_silver4_hardware.png");
            this.image.Images.SetKeyName(625, "stats-bleue_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(626, "statutaway_south-park_divers.png");
            this.image.Images.SetKeyName(627, "statutlunch_south-park_divers.png");
            this.image.Images.SetKeyName(628, "statutoff_south-park_divers.png");
            this.image.Images.SetKeyName(629, "statuton_south-park_divers.png");
            this.image.Images.SetKeyName(630, "stop_designaxl_suite.png");
            this.image.Images.SetKeyName(631, "suede_kavel_divers.png");
            this.image.Images.SetKeyName(632, "suisse_kavel_divers.png");
            this.image.Images.SetKeyName(633, "suse_la-fouine-du-net_divers.png");
            this.image.Images.SetKeyName(634, "system-a-parch_madness_suite.png");
            this.image.Images.SetKeyName(635, "tetris-3_tpdk-casimir_jeux-video.png");
            this.image.Images.SetKeyName(636, "totalcommander_cameleonhelp_software.png");
            this.image.Images.SetKeyName(637, "uc_shikamaru-mj_hardware.png");
            this.image.Images.SetKeyName(638, "ukraine_kavel_divers.png");
            this.image.Images.SetKeyName(639, "valid-bouclier_cameleonhelp_divers.png");
            this.image.Images.SetKeyName(640, "vlc_la-fouine_suite.png");
            this.image.Images.SetKeyName(641, "volant_la-fouine_jeux-video.png");
            this.image.Images.SetKeyName(642, "wi-fi_lord-of-sodom_divers.png");
            this.image.Images.SetKeyName(643, "winwashed_jer_divers.png");
            this.image.Images.SetKeyName(644, "wmp-classic_overlord_software.png");
            this.image.Images.SetKeyName(645, "wmplayer_karabe_software.png");
            this.image.Images.SetKeyName(646, "word_la-fouine_hardware.png");
            this.image.Images.SetKeyName(647, "xbox-button_cameleonhelp_hardware.png");
            this.image.Images.SetKeyName(648, "xbox-restart_cameleonhelp_hardware.png");
            // 
            // pageMain
            // 
            this.pageMain.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pageMain.AppearancePage.HeaderActive.Options.UseFont = true;
            this.pageMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.pageMain.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next) 
            | DevExpress.XtraTab.TabButtons.Close) 
            | DevExpress.XtraTab.TabButtons.Default)));
            this.pageMain.MdiParent = this;
            this.pageMain.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.TabControl;
            // 
            // ribbonPageGroupThongKe
            // 
            this.ribbonPageGroupThongKe.ItemLinks.Add(this.txtTongCH);
            this.ribbonPageGroupThongKe.ItemLinks.Add(this.txtTongDanCu);
            this.ribbonPageGroupThongKe.ItemLinks.Add(this.txtTongNhanVien);
            this.ribbonPageGroupThongKe.ItemLinks.Add(this.txtTongCH);
            this.ribbonPageGroupThongKe.ItemLinks.Add(this.txtTongDanCu);
            this.ribbonPageGroupThongKe.ItemLinks.Add(this.txtTongNhanVien);
            this.ribbonPageGroupThongKe.Name = "ribbonPageGroupThongKe";
            this.ribbonPageGroupThongKe.Text = "Thông tin";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 1013);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "STORE - MAKE BY LUONGCHUNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_HeThong;
        private DevExpress.XtraBars.BarButtonItem btnThongTin;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_BaoMat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuanLy;
        private DevExpress.XtraBars.BarButtonItem btn_DoiMatKhau;
        private DevExpress.Utils.ImageCollection image;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager pageMain;
        private DevExpress.XtraBars.BarButtonItem btnKhoiPhucPass;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnQLLoaiHang;
        private DevExpress.XtraBars.BarButtonItem btnQLGiaHang;
        private DevExpress.XtraBars.BarButtonItem btnQLNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQL;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDichVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQLDichVu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupHoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBaoCao;
        private DevExpress.XtraBars.BarButtonItem btnThemDV;
        private DevExpress.XtraBars.BarButtonItem btnDSDV;
        private DevExpress.XtraBars.BarButtonItem btnLoaiDV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupLoaiDV;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem txtTongCH;
        private DevExpress.XtraBars.BarButtonItem btnToaHD;
        private DevExpress.XtraBars.BarButtonItem btnQLHoaDon;
        private DevExpress.XtraBars.BarButtonItem btnTaoBC;
        private DevExpress.XtraBars.BarButtonItem btBaoCaoNam;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationmenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.LookAndFeel.DefaultLookAndFeel theme;
        private DevExpress.XtraBars.BarButtonItem btnTT;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnKichHoatTK;
        private DevExpress.XtraBars.BarButtonItem btnDX;
        private DevExpress.XtraBars.BarButtonItem btnInBangGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupExport;
        private DevExpress.XtraBars.BarHeaderItem txtTongDanCu;
        private DevExpress.XtraBars.BarHeaderItem txtTongNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnInThang;
        private DevExpress.XtraBars.BarButtonItem btInBaoCaoNam;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupExportBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnRobonQLTK;
        private DevExpress.XtraBars.BarButtonItem btnQLNV;
    }
}

