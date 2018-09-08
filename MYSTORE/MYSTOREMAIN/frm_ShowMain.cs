using HeThong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYSTOREMAIN
{
    public partial class frm_ShowMain : Form
    {
        private int? ID_tmp=null;
        DatabaseDataContext db;
        public frm_ShowMain()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
        }

        private void frm_ShowMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void loadData()
        {
            gcLoai.DataSource = (from a in db.LoaiHangs
                                 select new
                                 {
                                    a.ID,
                                    a.TenLoai
                                 }).ToList();
            gcHang.DataSource = (from a in db.Hangs
                                 select new
                                 {
                                     a.ID,
                                     a.TenHang,
                                     a.Cot1,
                                     a.Cot2,
                                     a.Cot3,
                                     a.Cot4,
                                     TenLoai = (from b in db.LoaiHangs
                                                where b.ID == a.IDLoaiHang
                                                select  b.TenLoai ).Single()
                                 }).ToList();
        }

        private void frm_ShowMain_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gvLoai_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ID_tmp = (int)gvLoai.GetFocusedRowCellValue("ID");
            }
            catch (Exception) { }
            if (ID_tmp != null) {
                gcHang.DataSource = (from a in db.Hangs
                                     where a.IDLoaiHang ==ID_tmp
                                     select new
                                 {
                                     a.ID,
                                     a.TenHang,
                                         a.Cot1,
                                         a.Cot2,
                                         a.Cot3,
                                         a.Cot4,
                                         TenLoai = (from b in db.LoaiHangs
                                                where b.ID == a.IDLoaiHang
                                                select b.TenLoai).Single()
                                 }).ToList();
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
