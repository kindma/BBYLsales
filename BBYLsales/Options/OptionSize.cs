using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBYLsales.Options
{
    public partial class OptionSize : BBYLsales.OptionModel
    {
        public OptionSize()
        {
            InitializeComponent();
        }

        private void f_S_SIZEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.f_S_SIZEBindingSource.EndEdit();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            this.CheckBoxAllowModify.Checked = false;
            

        }

        private void OptionSize_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SIZE”中。您可以根据需要移动或删除它。
            this.f_S_SIZETableAdapter.Fill(this.saleDataSetAll.F_S_SIZE);

        }

        private void CheckBoxAllowModify_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = this.CheckBoxAllowModify.Checked;
            this.textBox2.Enabled = this.CheckBoxAllowModify.Checked;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.CheckBoxAllowModify.Checked = true;
        }

         

        private void f_S_SIZEDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            MessageBox.Show("数据错误");
            return;
        }

        private void f_S_SIZEBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            this.CheckBoxAllowModify.Checked = false;
        }

       
    }
}
