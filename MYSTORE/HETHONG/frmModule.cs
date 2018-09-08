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
    public partial class frmModule : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db;
        public frmModule()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
        }
        private void frmModule_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void btnXoaControl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvControl.DeleteSelectedRows();
        }
        private void btnNap_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                treeModules.DataSource = from a in db.pqModules select new { a.IDCha, a.ID, a.Name, a.DienGiai };
                lookForm.DataSource = db.pqForms.OrderBy(p => p.FormName);
            }
            catch { }
            treeModules.ExpandAll();
        }
        private void treeModules_FocusedNodeChanged_1(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try {
                if (gcControl.DataSource != null) gcControl.DataSource = null;

                var val = (pqModule)treeModules.GetDataRecordByNode(treeModules.FocusedNode);
                gcControl.DataSource = val.pqModule_FormControls; }
            catch (Exception) { }
        }
        private void grvControl_InitNewRow_1(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvControl.SetFocusedRowCellValue("IsAccess", false);
        }
        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (treeModules.FocusedNode != null)
            {
                if (QuestionDelete() == DialogResult.No) return;
                try
                {
                    treeModules.DeleteNode(treeModules.FocusedNode);
                }
                catch { }
            }
        }
        private void btnThemCap_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (treeModules.FocusedNode != null)
            {
                treeModules.FocusedNode = treeModules.AppendNode(null, treeModules.FocusedNode);
            }
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                treeModules.RefreshNode(treeModules.FocusedNode);
                db.SubmitChanges();
                XtraMessageBox.Show("Dữ liệu đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            treeModules.FocusedNode = treeModules.AppendNode("",null);
        }
        private void LoadData()
        {
            try
            {
                treeModules.DataSource = db.pqModules;
                lookForm.DataSource = db.pqForms.OrderBy(p => p.FormName);
                
            }
            catch { }
            treeModules.ExpandAll();

        }
        public static DialogResult QuestionDelete()
        {
            return XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        private void btnQLform_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmForm frm = new frmForm();
            frm.ShowDialog();
            LoadData();
        }
    }
}
