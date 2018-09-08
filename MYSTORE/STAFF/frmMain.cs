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
namespace STAFF
{
    public partial class frmMain : Form
    {
        DatabaseDataContext db;
        public frmMain()
        {
            InitializeComponent();
            db = new DatabaseDataContext();

        }
        private void loadNV()
        {
            gcMain.DataSource =( from a in db.NhanViens
                                select new
                                {
                                    a.ID,
                                    a.MaNV,
                                    a.TenNV,
                                    a.Tuoi,
                                    GioiTinh=((bool)a.GioiTinh)?"Nam":"Nữ",
                                    a.DiaChi,
                                    a.SDT
                                }).ToList();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadNV();
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadNV();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new frmAddNhanVien();
            f.ID = null;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadNV();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (int?)gvMain.GetFocusedRowCellValue("ID");
            if (id == null)
            {
                MessageBox.Show("Bạn chưa chọn vào hàng cần sửa, vui lòng chọn.");
                return;
            }
            var f = new frmAddNhanVien();
            f.ID = id;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadNV();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvMain.GetFocusedRowCellValue("ID") == null)
            {
                Thongbao.Hoi("Mời bạn chọn hàng cần xóa.");
            }
            else
            {
                int id_tmp = (int)gvMain.GetFocusedRowCellValue("ID");
                DialogResult f = Thongbao._CauHoi();
                if (f == System.Windows.Forms.DialogResult.Yes)
                {
                    var delete = (from a in db.NhanViens where a.ID == (int)id_tmp select a).Single();
                    db.NhanViens.DeleteOnSubmit(delete);
                    try { db.SubmitChanges(); }
                    catch (Exception) { MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại."); }
                    loadNV();
                }
            }
        }

        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gcMain.ExportToXlsx(@"C:\Users\LUONG CHUNG\Downloads");
            }
            catch
            {

            }
            
        }
    }
}
