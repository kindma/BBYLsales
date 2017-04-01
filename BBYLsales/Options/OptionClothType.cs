using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBYLsales
{
    public partial class OptionClothType : OptionModel
    {
        public OptionClothType()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionClothType_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_CLOTHTYPE”中。您可以根据需要移动或删除它。
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);
            this.RefreshTreeview();
            this.checkBox1.Enabled = staticLoinUser.isAdminUser();
        }

        /// <summary>
        /// 刷新节点树
        /// </summary>
        private void RefreshTreeview(){
            this.treeView1.Nodes.Clear();
            TreeNode root = new TreeNode("所有类别");
            root.Name = "1";
            //添加所有根下子节点
            foreach (TreeNode tn in this.getNodsByID(1)) root.Nodes.Add(tn);
            this.treeView1.Nodes.Add(root);
            this.treeView1.ExpandAll(); //全部展开

        }

        /// <summary>
        /// 递归显示求得所有子结点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private List<TreeNode> getNodsByID(int id)
        {
            //递归求出所有根节点下的子结点
            List<TreeNode> l = new List<TreeNode>();
            DataClassesSaleLinqDataContext DataContextLinq = new DataClassesSaleLinqDataContext();
            var a = DataContextLinq.F_S_CLOTHTYPE.Where(p => p.父类ID == id && p.ID != 1).Select(p => p);

            foreach (var q in a)
            {
                TreeNode tn = new TreeNode();
                tn.Name = q.ID.ToString();
                tn.Text = q.类别;
                var ll = this.getNodsByID(q.ID);
                foreach (TreeNode tnn in ll) tn.Nodes.Add(tnn);
                l.Add(tn);
            }
            return l;
        }


        /// <summary>
        /// 保存类别修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_S_CLOTHTYPEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.f_S_CLOTHTYPEBindingSource.EndEdit();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }

            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
           
            this.RefreshTreeview();//刷新TREEVIEW控件
            this.checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var ck = (CheckBox)sender;
            if (ck.Checked)
            {
                this.textBox类别名称.ReadOnly = false;
                this.comboBox父类ID.Enabled = true;
            }
            else
            {
                this.textBox类别名称.ReadOnly = true;
                this.comboBox父类ID.Enabled = false;
            }

        }

        private void f_S_CLOTHTYPEDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.checkBox1.CheckState = CheckState.Unchecked;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.checkBox1.CheckState = CheckState.Checked;
            this.textBox类别名称.Focus();

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                this.f_S_CLOTHTYPEBindingSource.CancelEdit();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            TreeNode tn = e.Node;
            this.f_S_CLOTHTYPEBindingSource.Filter = "ID=" + tn.Name;
            this.checkBox1.CheckState = CheckState.Unchecked;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.f_S_CLOTHTYPEBindingSource.RemoveCurrent();

        }
    }
}
