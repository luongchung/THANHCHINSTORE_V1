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
    public partial class frmChagePass : DevExpress.XtraEditors.XtraForm
    {
        public frmChagePass()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            HeThong.Func.UserLogin dtb = new HeThong.Func.UserLogin(); 
            if (checkPass())
            {
                NhanVien ob = HeThong.Common.User;
                ob.Password = dtb.HashPassword(txtPassNew1.Text);
                if (dtb.ChangePassword(ob)){Thongbao.ThanhCong("Đổi mật khẩu thành công!");}
                else{Thongbao.Canhbao("Đổi mật khẩu thất bại");}
            }
        }
        private bool checkPass()
        {
            if (kiemtragiong()&&kiemtraMKcu())
            {
                return true;
            }
            return false;
        }
        private bool kiemtragiong()
        {
            if (txtPassNew1.Text == txtPassNew2.Text)
            {
                return true;
            }
            Thongbao.Hoi("Mật khẩu mới không giống nhau.");
            return false;
        }
        private bool kiemtraMKcu()
        {
            HeThong.Func.UserLogin dt = new HeThong.Func.UserLogin();
            NhanVien ob = HeThong.Common.User;
            if (ob.Password==dt.HashPassword(txtPassOld.Text))
            {
                return true;
            }
            Thongbao.Hoi("Mật khẩu cũ không chính xác.");
            return false;
        }
    }
}
