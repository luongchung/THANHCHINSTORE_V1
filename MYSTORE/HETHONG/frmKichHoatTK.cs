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
    public partial class frmKichHoatTK : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public frmKichHoatTK()
        {
            InitializeComponent();
        }

        private void frmKichHoatTK_Load(object sender, EventArgs e)
        {
            loadNV();
            barManager.SetPopupContextMenu(gcMain, popupMenu);
        }
        private void loadNV()
        {
            gcMain.DataSource = from a in db.NhanViens
                                select new {
                                    a.ID,
                                    a.MaNV,
                                    a.TenNV,
                                    TrangThai = ((bool)a.IsLock) ? "Chưa kich hoạt":"Kích hoạt"
                                    };
        }

        private void btnKichHoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvMain.GetFocusedRowCellValue("ID") == null)
            {
                Thongbao.Hoi("Mời bạn chọn hàng cần kích hoạt.");
            }
            else
            {
                int id_tmp = (int)gvMain.GetFocusedRowCellValue("ID");
                DialogResult f = Thongbao._CauHoi("Có chắc chắn kích hoạt tài khoản");
                if (f == System.Windows.Forms.DialogResult.Yes)
                {
                    var delete = (from a in db.NhanViens where a.ID == (int)id_tmp select a).Single();
                    delete.IsLock = false;
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("LỖI DATABASE");
                    }
                    loadNV();
                }
            }
        }

        private void btnHuyKichHoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvMain.GetFocusedRowCellValue("ID") == null)
            {
                Thongbao.Hoi("Mời bạn chọn hàng cần hủy kích hoạt.");
            }
            else
            {
                int id_tmp = (int)gvMain.GetFocusedRowCellValue("ID");
                DialogResult f = Thongbao._CauHoi("Có chắc chắn hủy kích hoạt tài khoản");
                if (f == System.Windows.Forms.DialogResult.Yes)
                {
                    var delete = (from a in db.NhanViens where a.ID == (int)id_tmp select a).Single();
                    delete.IsLock = true;
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("LỖI DATABASE");
                    }
                    loadNV();
                }
            }
        }
    }
}
