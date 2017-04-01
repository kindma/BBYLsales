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
    public partial class FormPends : Form
    {
        public FormPends()
        {
            InitializeComponent();
        }

        private bool hasChangeVar;
      
        public bool hasChang
        {
            get
            {
                return this.hasChangeVar;
            }
            set
            {
                this.hasChangeVar = value;
                this.groupBox1.Visible = value;
                this.f_PENDDataGridView.Enabled =!value;
            }
        }
        private void FormPends_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_USER”中。您可以根据需要移动或删除它。
            this.f_S_USERTableAdapter.Fill(this.saleDataSetAll.F_S_USER);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_PENDTYPE”中。您可以根据需要移动或删除它。
            this.f_S_PENDTYPETableAdapter.Fill(this.saleDataSetAll.F_S_PENDTYPE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_PEND”中。您可以根据需要移动或删除它。
            this.f_PENDTableAdapter.Fill(this.saleDataSetAll.F_PEND);
            this.hasChang = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.hasChang = true;
            this.dateTimePicker时间.Value = DateTime.Now;
            this.comboBox收支类型.SelectedIndex = 0;
            this.comboBox录入人员.SelectedValue = staticLoinUser.loginID;
            this.textBox录入时间.Text = DateTime.Now.ToShortDateString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.f_PENDBindingSource.CancelEdit();
            this.hasChang = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.f_PENDBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            }
            catch (Exception exp) {
                MessageBox.Show(exp.Message);
                return;
            }
            MessageBox.Show("保存成功");
            this.hasChang = false;
        }

        private void f_PENDDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.hasChang = true;
        }

        private void 焦点离开(object sender, EventArgs e)
        {
            this.label1.Focus();
        }

        private void f_PENDDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            decimal all = 0;
            foreach (DataGridViewRow dr in this.f_PENDDataGridView.Rows)
            {
                try
                {
                    all += (decimal)dr.Cells["金额"].Value;
                }
                catch { }
            }
            this.label6.Text = "总额:"+all.ToString();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除这行吗?此删除不可恢复!", "确认删除", MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                this.f_PENDBindingSource.RemoveCurrent();
                this.button保存.PerformClick();
            }
        }
    }
}
