using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThong;
using DevExpress.XtraReports.UI;

namespace MYSTOREMAIN
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db;
        public bool IsAdmin { get; set; }
        public NhanVien  User;
        public frmMain()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
            LoadForm(new ghino.frmMain());
            LoadForm(new banggia.FrmMain());
           
        }
       
        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm(new HeThong.frmPhanQuyen());
        }
        public void LoadForm(Form frm)
        {
            for (int i = 0; i < pageMain.Pages.Count; i++)
            {
                if (String.Compare(pageMain.Pages[i].Text, frm.Text.ToUpper(), false) != 0)
                    continue;

                pageMain.SelectedPage = pageMain.Pages[i];
                return;
            }
            frm.Text = frm.Text.ToUpper();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnQLCanHo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm(new banggia.FrmMain());
        }
        private void btnQLNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm(new STAFF.frmMain());
        }
        private void btnLoaiDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        private void btnThemDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var f = new QL_DichVu.frmaddDV();
            //f.ID = null;
            //f.ShowDialog();
            //if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
            //    load();
        }
        private void btnDSDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //LoadForm(new QL_DichVu.frmDV_Main());
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            //Phân quyền
          //  HeThong.Func.PhanQuyen.PhanQuyenRibon(this, Common.User, ribbon);
            //set không cho đóng tab
            HeThong.Common.IsClose = false;
            //LoadForm(new HoaDon.frmTaoHoaDon());
         
         
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {


            //var h = Thongbao._CauHoi("Bạn có muốn đóng phần mềm không?");
            //if (h == DialogResult.OK)
            //{
            //    this.Close();
            //}
            
        }

        private void btnDangXuat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.Common.User = null;
            Application.Restart();
        }

        private void btnKichHoatTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new HeThong.frmKichHoatTK();
            f.ShowDialog();
            //if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
            //    load();
        }

        private void btnTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new HeThong.frmThongTinTaiKhoan();
            f.ShowDialog();
        }

        private void btn_DoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new HeThong.frmChagePass();
            f.ShowDialog();
        }

        private void btnKhoiPhucPass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new HeThong.KhoiPhucPass();
            f.ShowDialog();
        }

        private void btnToaHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //LoadForm(new HoaDon.frmTaoHoaDon());
        }

        private void btnQLHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //LoadForm(new HoaDon.frmQLHoaDon());
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

         
        }

        private void btnTaoBC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }

        private void btnQLNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm(new STAFF.frmMain());
        }
    }
}
