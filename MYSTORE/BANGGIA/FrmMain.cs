using HeThong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banggia
{
    public partial class FrmMain : Form
    {
        DatabaseDataContext db;
        public FrmMain()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
            //set menu sub
            barManagerHang.SetPopupContextMenu(gcHang, popupMenuHang);
            barManagerLoaiHang.SetPopupContextMenu(gcLoaiHang, popupMenuLoaiHang);
        }

        private void frmBangGiaMain_Load(object sender, EventArgs e)
        {
            loadData();
            
        }

        private void loadData()
        {
            gcLoaiHang.DataSource = (from a in db.LoaiHangs
                                     orderby a.TenLoai ascending
                                     select new
                                 {
                                     a.ID,
                                     a.TenLoai
                                 }).ToList();
            gcHang.DataSource = (from a in db.Hangs
                                 orderby a.TenHang ascending
                                 select new
                                 {
                                     a.ID,
                                     a.TenHang,
                                     a.Cot1,
                                     a.Cot2,
                                     a.Cot3,
                                     a.Cot4,
                                     TenLoai = (from b in db.LoaiHangs
                                                where b.ID == a.IDLoaiHang
                                                select b.TenLoai).Single()
                                 }).ToList();
        }
        //Loại hàng
        private void btnThemLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new frmAddLoaiHang();
            f.ID = null;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadData();
        }
        private void btnSuaLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (int?)gvLoaiHang.GetFocusedRowCellValue("ID");
            if (id == null)
            {
                MessageBox.Show("Bạn chưa chọn vào hàng cần sửa, vui lòng chọn.");
                return;
            }
            var f = new frmAddLoaiHang();
            f.ID = id;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadData();
        }
        private void btnXoaLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvLoaiHang.GetFocusedRowCellValue("ID") == null)
            {
                Thongbao.Hoi("Mời bạn chọn hàng cần xóa.");
            }
            else
            {
                int id_tmp = (int)gvLoaiHang.GetFocusedRowCellValue("ID");  
                DialogResult f = Thongbao._CauHoi();
                if (f == System.Windows.Forms.DialogResult.Yes)
                {          
                    var delete = (from a in db.LoaiHangs where a.ID == (int)id_tmp select a).Single();
                    db.LoaiHangs.DeleteOnSubmit(delete);
                    try { db.SubmitChanges(); }
                    catch (Exception) { MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại."); }
                    loadData();
                }
            }
        }
        //Hàng
        private void btnThemHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new frmAddHang();
            f.ID = null;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void btnSuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (int?)gvHang.GetFocusedRowCellValue("ID");
            if (id == null)
            {
                MessageBox.Show("Bạn chưa chọn vào hàng cần sửa, vui lòng chọn.");
                return;
            }
            var f = new frmAddHang();
            f.ID = id;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void btnXoaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvHang.GetFocusedRowCellValue("ID") == null)
            {
                Thongbao.Hoi("Mời bạn chọn hàng cần xóa.");
            }
            else
            {
                int id_tmp = (int)gvHang.GetFocusedRowCellValue("ID");
                DialogResult f = Thongbao._CauHoi();
                if (f == System.Windows.Forms.DialogResult.Yes)
                {
                    var delete = (from a in db.Hangs where a.ID == (int)id_tmp select a).Single();
                    db.Hangs.DeleteOnSubmit(delete);
                    try { db.SubmitChanges(); }
                    catch (Exception) { MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại."); }
                    loadData();
                }
            }
        }

        private void gvLoaiHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int? ID_tmp = null;
            try
            {
                ID_tmp = (int)gvLoaiHang.GetFocusedRowCellValue("ID");
            }
            catch (Exception) { }
            if (ID_tmp != null)
            {
                gcHang.DataSource = (from a in db.Hangs
                                     where a.IDLoaiHang == ID_tmp
                                     orderby a.TenHang ascending
                                     select new
                                     {
                                         a.ID,
                                         a.TenHang,
                                         a.Cot1,
                                         a.Cot2,
                                         a.Cot3,
                                         a.Cot4,
                                         TenLoai = (from b in db.LoaiHangs
                                                    where b.ID == a.IDLoaiHang
                                                    select b.TenLoai).Single()
                                     }).ToList();
            }
        }

        private void btnNapall_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}
