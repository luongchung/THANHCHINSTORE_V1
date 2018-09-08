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
    public partial class KhoiPhucPass : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public KhoiPhucPass()
        {
            InitializeComponent();
        }

        private void btnKhoiP_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text != txtPass2.Text)
            {
                Thongbao.Canhbao("Hai mật khẩu điền không giống nhau.");
                return;
            }
            if (gvMain.GetFocusedRowCellValue("ID") == null)
            {
                Thongbao.Hoi("Mời bạn chọn hàng có nhân viên cần khôi phục");
            }
            else
            {

                int id_tmp = (int)gvMain.GetFocusedRowCellValue("ID");
                DialogResult f = Thongbao._CauHoi("Bạn có chắc chắn khôi phục!");
                if (f == System.Windows.Forms.DialogResult.Yes)
                {
                    HeThong.Func.UserLogin lg = new HeThong.Func.UserLogin();
                    var delete = (from a in db.NhanViens where a.ID == (int)id_tmp select a).Single();
                    delete.Password = lg.HashPassword(txtPass1.Text);
                    try
                    {
                        db.SubmitChanges();
                        Thongbao.ThanhCong("Đã thay đổi mật khẩu thành công!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("LỖI DATABASE");
                    }
                    
                }
            }
        }

        private void KhoiPhucPass_Load(object sender, EventArgs e)
        {
            loadNV();
        }
        private void loadNV()
        {
            gcMain.DataSource = from a in db.NhanViens
                                select new
                                {
                                    a.ID,
                                    a.MaNV,
                                    a.TenNV,
                                    TrangThai = ((bool)a.IsLock) ? "Chưa kich hoạt" : "Kích hoạt"
                                };
        }
    }
}
