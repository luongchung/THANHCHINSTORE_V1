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
    public partial class frmThongTinTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private NhanVien obj;
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            obj = HeThong.Common.User;
            txtMaNV.Text = obj.MaNV;
            txtHVT.Text = obj.TenNV;
            txtTuoi.Text = obj.Tuoi.ToString();
            txtSDT.Text = obj.SDT;
            txtDiaChi.Text = obj.DiaChi;
            txtGT.Text = ((bool)obj.GioiTinh) ? "Nam" : "Nữ";
        }
    }
}
