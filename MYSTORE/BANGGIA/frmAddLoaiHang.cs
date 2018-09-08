using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThong;
namespace banggia
{
    public partial class frmAddLoaiHang : DevExpress.XtraEditors.XtraForm
    {
        public int? ID { get; set; }
        private LoaiHang obj;
        private DatabaseDataContext db;
        public frmAddLoaiHang()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
            obj = new LoaiHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ID == null)
            {
                if (checkvali_null()) return;
                obj.TenLoai = txtTenLoai.Text;
                db.LoaiHangs.InsertOnSubmit(obj);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception )
                {
                    MessageBox.Show("Thêm loại hàng lỗi !");
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
   
            }
            else
            {
                obj.TenLoai = txtTenLoai.Text;
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("LỖI DATABASE");
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
        private void frmAddLoaiHang_Load(object sender, EventArgs e)
        {
            if (ID != null)
            {
                obj = db.LoaiHangs.Single(p => p.ID == ID);
                txtTenLoai.Text = obj.TenLoai;
            }
        } 
        private bool checkvali_null()
        {
            if (String.IsNullOrEmpty(txtTenLoai.Text))
            {
                Thongbao.Canhbao("Bạn chưa nhập tên loại hàng. xin mời nhập !");
                return true;
            }
            return false;
        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {
            gcS.DataSource = (from a in db.LoaiHangs
                              where SqlMethods.Like(a.TenLoai, "%" + txtTenLoai.Text + "%")
                              orderby a.TenLoai
                              select new
                              {
                                  a.TenLoai
                              }).ToList();
        }
    }
}
