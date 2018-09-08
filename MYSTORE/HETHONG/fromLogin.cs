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
    public partial class fromLogin : DevExpress.XtraEditors.XtraForm
    {
        public NhanVien UsersLogin = new NhanVien();
        public bool IsAdmin { get; set; }
        public fromLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            IsAdmin = false;
            if (!CheckDataInput())
                return;
            var wait = Thongbao.Loading();
            try
            {
                NhanVien objnhanvien = new NhanVien();
                Func.UserLogin ul = new HeThong.Func.UserLogin();
                objnhanvien = ul.GetUserByMaNV(txtUser.Text.Trim(),txtPass.Text.Trim());
                if (objnhanvien != null)
                {
                    //Kiểm tra tài khoản khóa/kích hoạt
                    if ((bool)objnhanvien.IsLock){
                        Thongbao.Canhbao("Tài khoản đang bị khóa hoặc chưa kích hoạt, liên hệ quản trị viên...");
                        return;
                    }


                    UsersLogin = objnhanvien;
                    if (ckNho.Checked)
                    {
                        //lưu lại pass and user
                        HeThong.Properties.Settings.Default.Username = txtUser.Text.Trim();
                        HeThong.Properties.Settings.Default.Password = txtPass.Text.Trim();
                    }
                    else
                    {
                        HeThong.Properties.Settings.Default.Username = string.Empty;
                        HeThong.Properties.Settings.Default.Password = string.Empty;
                    }
                    HeThong.Properties.Settings.Default.RememberCheck = ckNho.Checked;
                    HeThong.Properties.Settings.Default.Save();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    wait.Close();
                    wait.Dispose();
                    Thongbao.Loi("Người dùng hoặc mật khẩu không đúng");
                    return;
                }


            }
            catch{
                wait.Close();
                wait.Dispose();
                Thongbao.Loi("Lỗi kết nối mạng. Vui lòng thử lại sau");
                return;
            }
            finally
            {
                if (!wait.IsDisposed)
                {
                    wait.Close();
                    wait.Dispose();
                }
            }

        }

        private bool CheckDataInput()
        {
            if (txtUser.Text.Trim().Length != 0 && txtPass.Text.Trim().Length != 0)
                return true;
            Thongbao.Loi("Điền tên đăng nhập và mật khẩu!");
            return false;
        }

        private void fromLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = HeThong.Properties.Settings.Default.Username;
            txtPass.Text = HeThong.Properties.Settings.Default.Password;
            ckNho.Checked = HeThong.Properties.Settings.Default.RememberCheck;
        }

        private void ckNho_CheckedChanged(object sender, EventArgs e)
        {
            HeThong.Properties.Settings.Default.RememberCheck = ckNho.Checked;
            HeThong.Properties.Settings.Default.Save();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new frmConf();
           
            f.ShowDialog();
           
        }
    }
}
