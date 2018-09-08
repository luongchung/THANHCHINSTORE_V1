using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThong;

namespace MYSTOREMAIN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //show banner 
            frmBanner frmb = new frmBanner();
            frmb.Show();

            ////show form login
            fromLogin frm = new fromLogin();
            frmb.Close();
            frm.ShowDialog();
            if (frm.DialogResult != DialogResult.OK) { return; }

            HeThong.Common.User = frm.UsersLogin;
            frmMain frmmain = new frmMain()
            {
                IsAdmin = frm.IsAdmin,
                User = frm.UsersLogin
            };

            
            Application.Run(frmmain);
        }
    }
}
