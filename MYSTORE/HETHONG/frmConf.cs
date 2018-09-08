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
    public partial class frmConf : DevExpress.XtraEditors.XtraForm
    {
        public frmConf()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HeThong.Properties.Settings.Default.chuoiketnoi =txtsv.Text.ToString();
            HeThong.Properties.Settings.Default.Save();
        }

        private void frmConf_Load(object sender, EventArgs e)
        {
            txtsv.Text = HeThong.Properties.Settings.Default.chuoiketnoi;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtsv.Text = "";
        }
    }
}
