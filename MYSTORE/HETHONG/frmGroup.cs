using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThong
{
    public partial class frmGroup : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db;
        public frmGroup()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
        }
        private void addGroup_Load(object sender, EventArgs e)
        {
            loadNhomNV();
            barManagerMenu.SetPopupContextMenu(gcNV, popupMenuThemGroup);
        }
        private void loadNhomNV()
        {
            var data = (from a in db.GroupIDs select new { a.ID, a.GroupName, a.DienGiai }).ToList();
            gcNhomNV.DataSource = data;
        }
        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadNhomNV();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvNhomNV.GetFocusedRowCellValue("ID") == null)
            {
                MessageBox.Show("Bạn chưa chọn vào hàng cần xóa, vui lòng chọn.");
            }
            else
            {
                int id_tmp = (int)gvNhomNV.GetFocusedRowCellValue("ID");
                DialogResult f = XtraMessageBox.Show("Bạn có chắc chắn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;
                if (f == System.Windows.Forms.DialogResult.Yes)
                {
                    var delete = (from a in db.GroupIDs where a.ID == (int)id_tmp select a).Single();
                    db.GroupIDs.DeleteOnSubmit(delete);
                    try { db.SubmitChanges(); }
                    catch (Exception) {
                        XtraMessageBox.Show("Xóa không thành công vui lòng kiểm tra lại...", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    loadNhomNV();
                }
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new frmAddGroup();
            f.ID = null;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadNhomNV();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (int?)gvNhomNV.GetFocusedRowCellValue("ID");
            if (id == null){
                XtraMessageBox.Show("Bạn chưa chọn hàng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var f = new frmAddGroup();
            f.ID = id;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadNhomNV();
        }

        private void gvNhomNV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var id = (int?)gvNhomNV.GetFocusedRowCellValue("ID");
            if (id == null)
            {
                return;
            }
            loadNVTrongNhom(id);
        }
        private void loadNVTrongNhom(int? id)
        {
            gcNV.DataSource = (from a in db.NhanViens
                   select new
                   {
                       a.ID,
                       Thuoc = (from b in db.pqNhomNhanViens where b.GroupID == id && b.MaNV == a.ID select new { b.MaNV }).Count() > 0,
                       a.MaNV,
                       a.TenNV
                   }).ToList();
        }

        private void btnThemVaoNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvNhomNV.GetFocusedRowCellValue("ID") == null)
            {
                Thongbao.Hoi("Mời bạn chọn hàng nhóm nhân viên");
                return;
            }
            if (gvNV.GetFocusedRowCellValue("ID") == null)
            {
                Thongbao.Hoi("Mời bạn chọn hàng nhân viên");
                return;
            }
            int ID_Nhom = (int)gvNhomNV.GetFocusedRowCellValue("ID");
            int ID_NV = (int)gvNV.GetFocusedRowCellValue("ID");
            if ((from a in db.pqNhomNhanViens where a.GroupID == ID_Nhom && a.MaNV == ID_NV select a).Count()==0)
            {
                pqNhomNhanVien nv = new pqNhomNhanVien();
                nv.GroupID = ID_Nhom;
                nv.MaNV = ID_NV;
                db.pqNhomNhanViens.InsertOnSubmit(nv);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("LỖI DATABASE");
                }
                loadNVTrongNhom(ID_Nhom);
            }
        }
        private void btnRoiKhoiNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xóa khoi db
            if (gvNhomNV.GetFocusedRowCellValue("ID") == null)
            {
                Thongbao.Hoi("Mời bạn chọn hàng nhóm nhân viên");
            }
            else
            {
                if (gvNV.GetFocusedRowCellValue("ID") == null)
                {
                    Thongbao.Hoi("Mời bạn chọn hàng nhân viên");
                    return;
                }
                int ID_Nhom = (int)gvNhomNV.GetFocusedRowCellValue("ID");
                int ID_NV = (int)gvNV.GetFocusedRowCellValue("ID");

                var delete = (from a in db.pqNhomNhanViens where a.GroupID == ID_Nhom && a.MaNV == ID_NV select a).Single();
                db.pqNhomNhanViens.DeleteOnSubmit(delete);
                try { db.SubmitChanges(); }
                catch (Exception)
                {
                    MessageBox.Show("Rời khỏi nhóm không thành công, vui lòng kiểm tra lại.");
                }
                loadNVTrongNhom(ID_Nhom);
            }
        }
    }
}
