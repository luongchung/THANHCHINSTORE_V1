using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThong.Func
{
    public class PhanQuyen
    {
        public static void Authorize(System.Windows.Forms.Form frm, NhanVien objnhanvien, DevExpress.XtraBars.Ribbon.RibbonControl ribbon, DevExpress.XtraNavBar.NavBarControl control)
        {
            if (objnhanvien.IsLock.Value) return;
            else
            {
                using (DatabaseDataContext db = new DatabaseDataContext())
                {
                    var objNhomNhanVien = db.pqNhomNhanViens.Where(p => p.MaNV == objnhanvien.ID).Select(p => p.GroupID);

                    var ModuleHasPermisson = db.pqAccessRights.Where(p => objNhomNhanVien.Contains(p.GroupID) & p.IsAccessRight == true).Select(p => p.pqModule);

                    var permissionOnModule = db.pqModule_FormControls.Where(p => p.pqModule == ModuleHasPermisson).Select(p => p.ControlName);

                    if (permissionOnModule.Count() <= 0 & frm.Name != "frmMain")
                        frm.Close();
                    else
                    {
                        var lstModuleHasPermisson = ModuleHasPermisson.ToList();
                        var ControlHasPermisson = db.pqModule_FormControls.Where(p => lstModuleHasPermisson.Contains(p.pqModule)).Select(p => p.ControlName).ToList();

                        var nlstRibbobPage = getAllRibbonPage(ribbon).Where(p => ControlHasPermisson.Contains(p.Name)).ToList();
                        var nlstRibbobPageGroup = getAllRibbonPageGroup(ribbon).Where(p => ControlHasPermisson.Contains(p.Name)).ToList();
                        var nlstBarButtonItem = getAllBarButtonItem(ribbon).Where(p => ControlHasPermisson.Contains(p.Name)).ToList();
                        var nlstNavGroup = getAllNavGroup(control).Where(p => ControlHasPermisson.Contains(p.Name)).ToList();
                        var nlstNavItem = getAllNavItem(control).Where(p => ControlHasPermisson.Contains(p.Name)).ToList();

                        #region Invisble All
                        getAllRibbonPage(ribbon).ForEach(item =>
                        {
                            item.Visible = false;
                        });

                        getAllRibbonPageGroup(ribbon).ForEach(item =>
                        {
                            item.Visible = false;
                        });

                        getAllBarButtonItem(ribbon).ForEach(item =>
                        {
                            item.Enabled = false;
                        });

                        getAllNavGroup(control).ForEach(item =>
                        {
                            item.Visible = false;
                        });

                        getAllNavItem(control).ForEach(item =>
                        {
                            item.Visible = false;
                        });
                        #endregion

                        foreach (DevExpress.XtraBars.BarButtonItem item in nlstBarButtonItem)
                        {
                            item.Enabled = true;
                        }
                        foreach (DevExpress.XtraNavBar.NavBarGroup item in nlstNavGroup)
                        {
                            item.Visible = true;
                        }
                        foreach (DevExpress.XtraNavBar.NavBarItem item in nlstNavItem)
                        {
                            item.Visible = true;
                        }
                        foreach (DevExpress.XtraBars.Ribbon.RibbonPage item in nlstRibbobPage)
                        {
                            item.Visible = true;
                        }
                        foreach (DevExpress.XtraBars.Ribbon.RibbonPageGroup item in nlstRibbobPageGroup)
                        {
                            item.Visible = true;
                        }
                    }
                }
            }
        }
        public static void PhanQuyenRibon(System.Windows.Forms.Form frm, NhanVien objnhanvien, DevExpress.XtraBars.Ribbon.RibbonControl ribbon)
        {
            if (objnhanvien.IsLock.Value) return;
            else
            {
                using (DatabaseDataContext db = new DatabaseDataContext())
                {
                    var objNhomNhanVien = db.pqNhomNhanViens.Where(p => p.MaNV == objnhanvien.ID).Select(p => p.GroupID);

                    var ModuleHasPermisson = db.pqAccessRights.Where(p => objNhomNhanVien.Contains(p.GroupID) & p.IsAccessRight == true).Select(p => p.pqModule);

                    var permissionOnModule = db.pqModule_FormControls.Where(p => p.pqModule == ModuleHasPermisson).Select(p => p.ControlName);

                    if (permissionOnModule.Count() <= 0 & frm.Name != "frmMain")
                        frm.Close();
                    else
                    {
                        var lstModuleHasPermisson = ModuleHasPermisson.ToList();
                        var ControlHasPermisson = db.pqModule_FormControls.Where(p => lstModuleHasPermisson.Contains(p.pqModule)).Select(p => p.ControlName).ToList();

                        var nlstRibbobPage = getAllRibbonPage(ribbon).Where(p => ControlHasPermisson.Contains(p.Name)).ToList();
                        var nlstRibbobPageGroup = getAllRibbonPageGroup(ribbon).Where(p => ControlHasPermisson.Contains(p.Name)).ToList();
                        var nlstBarButtonItem = getAllBarButtonItem(ribbon).Where(p => ControlHasPermisson.Contains(p.Name)).ToList();

                        #region Invisble All
                        getAllRibbonPage(ribbon).ForEach(item =>
                        {
                            item.Visible = false;
                        });

                        getAllRibbonPageGroup(ribbon).ForEach(item =>
                        {
                            item.Visible = false;
                        });

                        getAllBarButtonItem(ribbon).ForEach(item =>
                        {
                            item.Enabled = false;
                        });

                        #endregion

                        foreach (DevExpress.XtraBars.BarButtonItem item in nlstBarButtonItem)
                        {
                            item.Enabled = true;
                        }
                        foreach (DevExpress.XtraBars.Ribbon.RibbonPage item in nlstRibbobPage)
                        {
                            item.Visible = true;
                        }
                        foreach (DevExpress.XtraBars.Ribbon.RibbonPageGroup item in nlstRibbobPageGroup)
                        {
                            item.Visible = true;
                        }
                    }
                }
            }
        }

        public static void Authorize(System.Windows.Forms.Form frm, NhanVien objnhanvien, DevExpress.XtraBars.BarManager BarManagerName)
        {
            if (objnhanvien.IsLock.Value) return;
            else
            {
                using (DatabaseDataContext db = new DatabaseDataContext())
                {
                    var objNhomNhanVien = db.pqNhomNhanViens.Where(p => p.MaNV == objnhanvien.ID).Select(p => p.GroupID).ToList();
                    var ModuleHasPermisson = db.pqAccessRights.Where(p => objNhomNhanVien.Contains(p.GroupID.Value) & p.IsAccessRight == true).Select(p => p.pqModule).ToList();
                    var ControlHasPermisson = db.pqModule_FormControls.Where(p => ModuleHasPermisson.Contains(p.pqModule) & p.pqForm.FormName == frm.GetType().FullName).Select(p => p.ControlName).ToList();

                    getAllBarButtonItem(BarManagerName).ForEach(item =>
                    {
                        item.Enabled = false;
                        foreach (var per in ControlHasPermisson)
                        {
                            if (per == item.Name) item.Enabled = true;
                        }
                    });

                    getAllBarSubItem(BarManagerName).ForEach(item =>
                    {
                        item.Enabled = false;
                        foreach (var per in ControlHasPermisson)
                        {
                            if (per == item.Name) item.Enabled = true;
                        }
                    });
                }
            }
        }

        public static void EnumerateControls(System.Windows.Forms.Control ctrl)
        {
            if (ctrl.Controls.Count > 0)
            {
                foreach (System.Windows.Forms.Control control in ctrl.Controls)
                    EnumerateControls(control);
            }
        }
        public static List<DevExpress.XtraBars.BarButtonItem> getAllBarButtonItem(DevExpress.XtraBars.BarManager BarManagerName)
        {
            List<DevExpress.XtraBars.BarButtonItem> lstBarbuttonItem = new List<DevExpress.XtraBars.BarButtonItem>();
            foreach (var item in BarManagerName.Items)
            {
                if (item is DevExpress.XtraBars.BarButtonItem)
                {
                    lstBarbuttonItem.Add(item as DevExpress.XtraBars.BarButtonItem);
                }
            }

            return lstBarbuttonItem;
        }
        public static List<DevExpress.XtraBars.BarSubItem> getAllBarSubItem(DevExpress.XtraBars.BarManager BarManagerName)
        {
            List<DevExpress.XtraBars.BarSubItem> lstBarbuttonItem = new List<DevExpress.XtraBars.BarSubItem>();
            foreach (var item in BarManagerName.Items)
            {

                if (item is DevExpress.XtraBars.BarSubItem)
                {
                    lstBarbuttonItem.Add(item as DevExpress.XtraBars.BarSubItem);
                }
            }

            return lstBarbuttonItem;
        }
        public static List<DevExpress.XtraBars.BarButtonItem> getAllBarButtonItem(DevExpress.XtraBars.Ribbon.RibbonControl ribbon)
        {
            List<DevExpress.XtraBars.BarButtonItem> lstBarbuttonItem = new List<DevExpress.XtraBars.BarButtonItem>();
            foreach (var item in (ribbon as DevExpress.XtraBars.Ribbon.RibbonControl).Items)
            {
                if (item is DevExpress.XtraBars.BarButtonItem)
                {
                    lstBarbuttonItem.Add(item as DevExpress.XtraBars.BarButtonItem);
                }
            }

            return lstBarbuttonItem;
        }
        public static List<DevExpress.XtraBars.Ribbon.RibbonPage> getAllRibbonPage(DevExpress.XtraBars.Ribbon.RibbonControl ribbon)
        {
            List<DevExpress.XtraBars.Ribbon.RibbonPage> lstRibbonPage = new List<DevExpress.XtraBars.Ribbon.RibbonPage>();
            foreach (var page in ribbon.Pages)
            {
                if (page is DevExpress.XtraBars.Ribbon.RibbonPage)
                {
                    lstRibbonPage.Add(page as DevExpress.XtraBars.Ribbon.RibbonPage);
                }
            }

            return lstRibbonPage;
        }
        public static List<DevExpress.XtraBars.Ribbon.RibbonPageGroup> getAllRibbonPageGroup(DevExpress.XtraBars.Ribbon.RibbonControl ribbon)
        {
            List<DevExpress.XtraBars.Ribbon.RibbonPageGroup> lstRibbonPageGroup = new List<DevExpress.XtraBars.Ribbon.RibbonPageGroup>();
            foreach (DevExpress.XtraBars.Ribbon.RibbonPage page in ribbon.Pages)
            {
                foreach (var pageGroup in page.Groups)
                {
                    if (pageGroup is DevExpress.XtraBars.Ribbon.RibbonPageGroup)
                    {
                        lstRibbonPageGroup.Add(pageGroup as DevExpress.XtraBars.Ribbon.RibbonPageGroup);
                    }
                }
            }

            return lstRibbonPageGroup;
        }
        public static List<DevExpress.XtraNavBar.NavBarGroup> getAllNavGroup(DevExpress.XtraNavBar.NavBarControl control)
        {
            List<DevExpress.XtraNavBar.NavBarGroup> lstnavGroup = new List<DevExpress.XtraNavBar.NavBarGroup>();
            foreach (var item in control.Groups)
            {
                if (item is DevExpress.XtraNavBar.NavBarGroup)
                {
                    lstnavGroup.Add(item as DevExpress.XtraNavBar.NavBarGroup);
                }
            }
            return lstnavGroup;
        }
        public static List<DevExpress.XtraNavBar.NavBarItem> getAllNavItem(DevExpress.XtraNavBar.NavBarControl control)
        {
            List<DevExpress.XtraNavBar.NavBarItem> lstnavItem = new List<DevExpress.XtraNavBar.NavBarItem>();
            foreach (var item in control.Items)
            {
                if (item is DevExpress.XtraNavBar.NavBarItem)
                {
                    lstnavItem.Add(item as DevExpress.XtraNavBar.NavBarItem);
                }
            }
            return lstnavItem;
        }

    }
}
