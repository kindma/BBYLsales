using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBYLsales.Options
{
    public partial class OptionCharge : BBYLsales.OptionModel
    {
        public OptionCharge()
        {
            InitializeComponent();
        }

        private void f_S_PENDTYPEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            try
            {
                this.f_S_PENDTYPEBindingSource.EndEdit();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            this.CheckBoxAllowModify.Checked = false;

        }

        private void OptionCharge_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_PENDTYPE”中。您可以根据需要移动或删除它。
            this.f_S_PENDTYPETableAdapter.Fill(this.saleDataSetAll.F_S_PENDTYPE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_PENDTYPE”中。您可以根据需要移动或删除它。
            this.f_S_PENDTYPETableAdapter.Fill(this.saleDataSetAll.F_S_PENDTYPE);

            //设置属性

            this.f_S_PENDTYPEDataGridView.AllowUserToAddRows = false;
            this.f_S_PENDTYPEDataGridView.AllowUserToDeleteRows = false;
            this.f_S_PENDTYPEDataGridView.AllowUserToOrderColumns = true;
            this.f_S_PENDTYPEDataGridView.AllowUserToResizeColumns = false;
            this.f_S_PENDTYPEDataGridView.AllowUserToResizeRows = false;
            this.f_S_PENDTYPEDataGridView.AutoGenerateColumns = false;
            this.f_S_PENDTYPEDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.f_S_PENDTYPEDataGridView.MultiSelect = false;
            this.f_S_PENDTYPEDataGridView.ReadOnly = true;
            this.f_S_PENDTYPEDataGridView.RowHeadersVisible = false;
            this.f_S_PENDTYPEDataGridView.RowTemplate.Height = 23;
            this.f_S_PENDTYPEDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CheckBoxAllowModify_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = this.CheckBoxAllowModify.Checked;
        }

        private void f_S_PENDTYPEBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.CheckBoxAllowModify.Checked = false;
        }

        

        private void f_S_PENDTYPEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            
            this.Validate();
            try
            {
                this.f_S_PENDTYPEBindingSource.EndEdit();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            this.CheckBoxAllowModify.Checked = false;
            MessageBox.Show("已保存");
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            this.CheckBoxAllowModify.Checked = true;
        }

        private void f_S_PENDTYPEDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }
    }
}
