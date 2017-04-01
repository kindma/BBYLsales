using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBYLsales.Options
{
    public partial class OptionStockAdjustReason : BBYLsales.OptionModel
    {
        public OptionStockAdjustReason()
        {
            InitializeComponent();
        }

        

        private void OptionStockAdjustReason_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_KCTZTYPE”中。您可以根据需要移动或删除它。
            this.f_S_KCTZTYPETableAdapter.Fill(this.saleDataSetAll.F_S_KCTZTYPE);
           

            //设置属性
            this.f_S_KCTZTYPEDataGridView.AllowUserToAddRows = false;
            this.f_S_KCTZTYPEDataGridView.AllowUserToDeleteRows = false;
            this.f_S_KCTZTYPEDataGridView.AllowUserToOrderColumns = true;
            this.f_S_KCTZTYPEDataGridView.AllowUserToResizeColumns = false;
            this.f_S_KCTZTYPEDataGridView.AllowUserToResizeRows = false;
            this.f_S_KCTZTYPEDataGridView.AutoGenerateColumns = false; 
            this.f_S_KCTZTYPEDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.f_S_KCTZTYPEDataGridView.MultiSelect = false;
            this.f_S_KCTZTYPEDataGridView.ReadOnly = true;
            this.f_S_KCTZTYPEDataGridView.RowHeadersVisible = false;
            this.f_S_KCTZTYPEDataGridView.RowTemplate.Height = 23;
            this.f_S_KCTZTYPEDataGridView.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
        }

        private void CheckBoxAllowModify_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = this.CheckBoxAllowModify.Checked;
        }

        private void f_S_KCTZTYPEBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.CheckBoxAllowModify.Checked = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.CheckBoxAllowModify.Checked = true;
        }

        private void f_S_KCTZTYPEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.f_S_KCTZTYPEBindingSource.EndEdit();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            this.CheckBoxAllowModify.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
