using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThong;

namespace MYSTOREMAIN
{
    public partial class frmBaoCao : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            loadView();
        }
        private void loadView()
        {
            //txtDoanThuThang.Text = String.Format("{0:###.000}", (decimal)db.doansothang());
            ////txtMucTangThang.Text = String.Format("{0:dd/MM/yyyy  HH:mm:ss}", db.doansothangnamtruoc());


            //txtDoanThuNam.Text = String.Format("{0:###.000}",(decimal) db.doansothangnam());
        }

      

       
    }
}
