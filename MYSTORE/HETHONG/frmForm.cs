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
    public partial class frmForm : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db;
        public frmForm()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
        }
        private void addGroup_Load(object sender, EventArgs e)
        {
            loadNhomNV();
        }
        private void loadNhomNV()
        {
            var data = (from a in db.pqForms select new { a.ID, a.FormName, a.DienGiai }).ToList();
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
                Thongbao.Hoi("Mời bạn chọn hàng cần xóa.");
            }
            else
            {
                int id_tmp = (int)gvNhomNV.GetFocusedRowCellValue("ID");
                DialogResult f = Thongbao._CauHoi();
                if (f == System.Windows.Forms.DialogResult.Yes)
                {
                    var delete = (from a in db.pqForms where a.ID == (int)id_tmp select a).Single();
                    db.pqForms.DeleteOnSubmit(delete);
                    try { db.SubmitChanges(); }
                    catch (Exception) { MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại."); }
                    loadNhomNV();
                }
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new frmAddForm();
            f.ID = null;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadNhomNV();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (int?)gvNhomNV.GetFocusedRowCellValue("ID");
            if (id == null) {
                MessageBox.Show("Bạn chưa chọn vào hàng cần sửa, vui lòng chọn.");
                return; }
            var f = new frmAddForm();
            f.ID = id;
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                loadNhomNV();
        }
    }
}
