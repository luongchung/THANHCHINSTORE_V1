using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraWaitForm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;

namespace HeThong
{
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        List<TreeListNode> checkedNodes = new List<TreeListNode>();
        public List<int?> ListModuleAlreadyHasInAccess = new List<int?>();
        int SLChecked = 0; bool IsChecked = false;
        DatabaseDataContext db;
        pqModule md;
        int id_g;
        public frmPhanQuyen()
        {
            InitializeComponent();
            db = new DatabaseDataContext();
        }
        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            loadmain();
        }
        private void loadTreview() {
           tvModule.DataSource=(from a in db.pqModules                   
                        select new
                        {
                            a.ID,
                            a.IDCha,
                            a.Name,
                            a.DienGiai,
                            TICK=((from k in db.pqAccessRights where k.GroupID==id_g && a.ID==(int)k.ModuleID select k.IsAccessRight).Single()==null)?false:
                            (from k in db.pqAccessRights where k.GroupID == id_g && a.ID == (int)k.ModuleID select k.IsAccessRight).Single()
                        });
            tvModule.KeyFieldName= "ID";
            tvModule.ParentFieldName="IDCha";
            tvModule.ExpandAll();
        }
        private void loadNhomNV() {
            var data = (from a in db.GroupIDs select new { a.ID, a.GroupName,a.DienGiai });
            gcNhomNV.DataSource = data;
        }
        private void loadmain() {
            loadNhomNV();
            loadTreview();
        }
        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadmain();  
        }
        private void btnThemNutCha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            md = new pqModule();
            db.pqModules.InsertOnSubmit(md);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi" + ex);
            }
            loadTreview();
        }
        private void btnNhomSD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new frmGroup();
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK) { }
            loadmain();
        }
        private void gvNhomNV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                id_g = (int)gvNhomNV.GetFocusedRowCellValue("ID");
                if (id_g < 0) return;
                loadTreview();
            }
            catch (Exception){} 
        }
        private void btnLuuNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save_trangthaiNode();
        }
        private void SetCheckedParentNodes(TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                SetNodeCheckState(node.ParentNode, b ? CheckState.Checked : check);
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }
        private void SetNodeCheckState(TreeListNode node, CheckState state)
        {
            node.CheckState = state;
            if (node.Checked)
                checkedNodes.Add(node);
        }
        private void SetCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                SetNodeCheckState(node.Nodes[i], check);
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }

        private void tvModule_AfterCheckNode_1(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            checkedNodes.Clear();
            if (e.Node.Checked)
                checkedNodes.Add(e.Node);
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }

        private void CountCheckedNode(TreeListNode treenode)
        {
            checkedNodes.Add(treenode);
            foreach (TreeListNode tn in treenode.Nodes)
            {
                if (tn.Checked)
                    SLChecked++;
                CountCheckedNode(tn);
            }
            checkedNodes.Remove(treenode);
        }


        private void GetAllNode(TreeListNode treenode)
        {
            checkedNodes.Add(treenode);
            foreach (TreeListNode tn in treenode.Nodes)
            {
                if (tn.Checked == !IsChecked)
                    db.spUpdatePqAccess((int)gvNhomNV.GetFocusedRowCellValue("ID"), (int)tn.GetValue("ID"), !IsChecked);
                GetAllNode(tn);
            }
        }
        private void Save_trangthaiNode()
        {
            SLChecked = 0;
            var wait = new WaitDialogForm("Xin chờ ....");
            checkedNodes.Clear();
            foreach (TreeListNode node in tvModule.Nodes)
            {
                CountCheckedNode(node);
            }
            if (SLChecked >= (db.pqModules.Count() - SLChecked))
                IsChecked = true;
            else IsChecked = false;

            if (gvNhomNV.GetFocusedRowCellValue("ID") == null)
            {
                return;
            }
            // Thêm các node chưa có
            db.AccessRightInsert((int)gvNhomNV.GetFocusedRowCellValue("ID"));
            db.pqResetNode((int)gvNhomNV.GetFocusedRowCellValue("ID"), IsChecked);
            foreach (TreeListNode node in tvModule.Nodes)
            {
                GetAllNode(node);
                // Check node đầu tiên
                if (node.Checked == !IsChecked)
                    db.spUpdatePqAccess((int)gvNhomNV.GetFocusedRowCellValue("ID"), (int)node.GetValue("ID"), !IsChecked);
            }
            if (checkedNodes == null)
            {
                wait.Close();
                wait.Dispose();
                return;
            }
            try{ db.SubmitChanges();}
            catch{}
            finally
            {
                wait.Close();
                wait.Dispose();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModule frm = new frmModule();
            frm.ShowDialog();
        }
    }
}
