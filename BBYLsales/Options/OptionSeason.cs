using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBYLsales.Options
{
    public partial class OptionSeason : BBYLsales.OptionModel
    {
        public OptionSeason()
        {
            InitializeComponent();
        }

        private void f_S_SEASONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            this.Validate();
            try
            {
                this.f_S_SEASONBindingSource.EndEdit();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            this.CheckBoxAllowModify.Checked = false;
        }

        private void OptionSeason_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SEASON”中。您可以根据需要移动或删除它。
            this.f_S_SEASONTableAdapter.Fill(this.saleDataSetAll.F_S_SEASON);

            //设置属性

            this.f_S_SEASONDataGridView.AllowUserToAddRows = false;
            this.f_S_SEASONDataGridView.AllowUserToDeleteRows = false;
            this.f_S_SEASONDataGridView.AllowUserToOrderColumns = true;
            this.f_S_SEASONDataGridView.AllowUserToResizeColumns = false;
            this.f_S_SEASONDataGridView.AllowUserToResizeRows = false;
            this.f_S_SEASONDataGridView.AutoGenerateColumns = false;
            this.f_S_SEASONDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.f_S_SEASONDataGridView.MultiSelect = false;
            this.f_S_SEASONDataGridView.ReadOnly = true;
            this.f_S_SEASONDataGridView.RowHeadersVisible = false;
            this.f_S_SEASONDataGridView.RowTemplate.Height = 23;
            this.f_S_SEASONDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void f_S_SEASONDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void CheckBoxAllowModify_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = this.CheckBoxAllowModify.Checked;
            this.textBox2.Enabled = this.CheckBoxAllowModify.Checked;
        }

        private void DisableModify(object sender, EventArgs e)
        {
            this.CheckBoxAllowModify.Checked = false;
        }

        private void EnableModify(object sender, EventArgs e)
        {
            this.CheckBoxAllowModify.Checked = true;
        }

    }
}
