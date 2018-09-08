using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThong
{
    public class Thongbao
    {
      
        public static void ThanhCong(string text)
        {
            XtraMessageBox.Show(text,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Canhbao(string text)
        {
            XtraMessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Hoi(string text)
        {
            XtraMessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public static void Loi(string text)
        {
            XtraMessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult _CauHoi(string text)
        {
            return XtraMessageBox.Show(text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult _CauHoi()
        {
            string text = "Bạn có muốn xóa không?";
            return XtraMessageBox.Show(text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static WaitDialogForm Loading()
        {
            return new WaitDialogForm("Ðang xử lý.Vui lòng chờ...", "QUẢN LÝ CHUNG CƯ");
        }

        public static WaitDialogForm Loading(string caption)
        {
            return new WaitDialogForm(caption, "QUẢN LÝ CHUNG CƯ");
        }
    }
}
