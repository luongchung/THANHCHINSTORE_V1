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
    public partial class frmAddGroup : DevExpress.XtraEditors.XtraForm
    {
        private DatabaseDataContext db;
        private GroupID obj;
        public int? ID { get; set; }
        public frmAddGroup()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
            obj = new GroupID();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ID == null)
            {
                if (checkvali_null()) return;
                obj.GroupName = txtNameGroup.Text;
                obj.DienGiai = txtDienGiai.Text;
                db.GroupIDs.InsertOnSubmit(obj);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception )
                {
                    MessageBox.Show("LỖI DATABASE");
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else 
            {
                obj.GroupName = txtNameGroup.Text;
                obj.DienGiai = txtDienGiai.Text;
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception )
                {
                    MessageBox.Show("LỖI DATABASE");
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private bool checkvali_null() {
            if (String.IsNullOrEmpty(txtNameGroup.Text)) {
                MessageBox.Show("Tên nhóm trống. xin mời nhập !","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                return true;
            }
            return false;
        
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddGroup_Load(object sender, EventArgs e)
        {
            if (ID != null) {
                obj = db.GroupIDs.Single(p => p.ID == ID);
                txtNameGroup.Text = obj.GroupName;
                txtDienGiai.Text = obj.DienGiai;
            }
        }
    }
}
