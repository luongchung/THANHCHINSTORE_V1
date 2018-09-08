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
    public partial class frmAddHang : DevExpress.XtraEditors.XtraForm
    {
        public int? ID { get; set; }
        private Hang obj;
        private DatabaseDataContext db;
        public frmAddHang()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
            obj = new Hang();
        }
        private bool kiemtra()
        {
            if (String.IsNullOrEmpty(txtTenHang.Text))
            {
                Thongbao.Canhbao("Bạn chưa nhập tên hàng. xin mời nhập !");
                return true;
            }
         
            if (lueLoaiHang.EditValue==null)
            {
                Thongbao.Canhbao("Bạn chưa chọn loại hàng. xin mời nhập !");
                return true;
            }
            return false;
  
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            luu();
        }

        private void frmAddHang_Load(object sender, EventArgs e)
        {
            lueLoaiHang.Properties.DataSource= (from a in db.LoaiHangs
                                                orderby a.TenLoai
                                                select new
                                                {
                                                    a.ID,
                                                    a.TenLoai
                                                }).ToList();

            if (ID != null)
            {
                obj = db.Hangs.Single(p => p.ID == ID);
                txtTenHang.Text = obj.TenHang;
                lueLoaiHang.EditValue = obj.IDLoaiHang;
                txt1.Text =(String.IsNullOrEmpty(obj.Cot1))?"":obj.Cot1;
                txt2.Text = (String.IsNullOrEmpty(obj.Cot2)) ? "" : obj.Cot2;
                txt3.Text = (String.IsNullOrEmpty(obj.Cot3)) ? "" : obj.Cot3;
                txt4.Text = (String.IsNullOrEmpty(obj.Cot4)) ? "" : obj.Cot4;
            }
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            gcS.DataSource=(from a in db.Hangs
                            where SqlMethods.Like(a.TenHang, "%"+txtTenHang.Text+"%")
                            orderby a.TenHang
            select new
            {
                a.TenHang
            }).ToList();
        }

        private void frmAddHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                luu();

            }
        }


        private void luu()
        {
            if (ID == null)
            {
                if (kiemtra()) return;
                obj.IDLoaiHang = (int)lueLoaiHang.EditValue;
                obj.TenHang = txtTenHang.Text;
                obj.Cot1 = String.IsNullOrEmpty(txt1.Text) ? "" : txt1.Text;
                obj.Cot2 = String.IsNullOrEmpty(txt1.Text) ? "" : txt2.Text;
                obj.Cot3 = String.IsNullOrEmpty(txt1.Text) ? "" : txt3.Text;
                obj.Cot4 = String.IsNullOrEmpty(txt1.Text) ? "" : txt4.Text;
                db.Hangs.InsertOnSubmit(obj);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm loại hàng lỗi !");
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            else
            {
                obj.TenHang = txtTenHang.Text;
                obj.IDLoaiHang = (int)lueLoaiHang.EditValue;
                obj.Cot1 = String.IsNullOrEmpty(txt1.Text) ? "" : txt1.Text;
                obj.Cot2 = String.IsNullOrEmpty(txt1.Text) ? "" : txt2.Text;
                obj.Cot3 = String.IsNullOrEmpty(txt1.Text) ? "" : txt3.Text;
                obj.Cot4 = String.IsNullOrEmpty(txt1.Text) ? "" : txt4.Text;
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
    }
}
