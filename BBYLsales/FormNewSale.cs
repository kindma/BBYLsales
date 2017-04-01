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
    public partial class FormNewSale : Form
    {
        private bool errFlag { get; set; }
        public FormNewSale()
        {
            InitializeComponent();
        }
        private void FormNewSale_Load(object sender, EventArgs e)
        {
            ///重统计库存，在保存销售时会检查库存是否可以做销售
            staticFunc.refreshStock();

            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_CLOTHTYPE”中。您可以根据需要移动或删除它。
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_USER”中。您可以根据需要移动或删除它。
            this.f_S_USERTableAdapter.Fill(this.saleDataSetAll.F_S_USER);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_VIP”中。您可以根据需要移动或删除它。
            this.f_VIPTableAdapter.Fill(this.saleDataSetAll.F_VIP);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SIZE”中。您可以根据需要移动或删除它。
            this.f_S_SIZETableAdapter.Fill(this.saleDataSetAll.F_S_SIZE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_COLOR”中。您可以根据需要移动或删除它。
            this.f_S_COLORTableAdapter.Fill(this.saleDataSetAll.F_S_COLOR);


            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_SALE”中。您可以根据需要移动或删除它。
            this.f_SALETableAdapter.Fill(this.saleDataSetAll.F_SALE);

            //注意,下面这一行必须放在this.f_STOCKSTableAdapter.Fill前面,因为本软件中,库存表填充后会引发SELETEDCHANGE事件,并连锁影响到
            //f_SALEBindingSource的当前行数值,所以必须选建立新行后再添充库存数据源
            this.f_SALEBindingSource.AddNew();            
            this.f_STOCKSTableAdapter.Fill(this.saleDataSetAll.F_STOCKS);

            if (this.StockDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("库存为零,无法销售");
                this.Close();
            }
            this.fSUSERBindingSource.Filter = "名称 <>'admin'";
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker1.Value = DateTime.Now.Date;
            this.numericTextBox开票价.Text = "0";
            this.numericTextBox数量.Text = "1";
            this.listBox销售员.SelectedIndex = 0;
            this.listBox优惠.SelectedIndex = 0;
            this.textBox录入人员.Text = staticLoinUser.loginID.ToString();
            this.textBox录入时间.Text = DateTime.Now.ToString();
            this.textBox货号.Focus();
        }

        /// <summary>
        /// 保存新的销售记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            ///错误验证部分开始=======================================================
            if (this.StockDataGridView.CurrentRow == null)
            {
                MessageBox.Show("请检查输入！不存在此货号");
                return;
            }


            this.Validate();
            this.errFlag = false;

            //货号检查
            this.errorProvider1.Clear();
            if (this.textBox货号.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.textBox货号, "不得为空！");
                this.errFlag = true;
            }


            //销量检查
            try
            {
                if (int.Parse(this.numericTextBox数量.Text) <= 0)
                {
                    this.errorProvider1.SetError(this.numericTextBox数量, "数字不正确！");
                    this.errFlag = true;
                }

            }
            catch
            {
                this.errorProvider1.SetError(this.numericTextBox数量, "数字不正确！");
                this.errFlag = true;
            }

            if (this.errFlag) return;

            ///先查库存是否足够此次销售
            int allInstock = staticFunc.getMountOfCloth(this.textBox货号.Text, (int)this.comboBox尺码.SelectedValue, (int)this.comboBox颜色.SelectedValue);

            if (allInstock - int.Parse(this.numericTextBox数量.Text) < 0)
            {
                MessageBox.Show("这款衣服的库存量不足这次销售，请检查库存量与销售量！");
                return;
            }


            try
            {

                this.f_SALEBindingSource.EndEdit();
            }
            catch (NoNullAllowedException exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }

            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            this.DialogResult = DialogResult.OK;
        }

        private void fmainProductStockDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.StockDataGridView.CurrentRow == null)
            {
                this.buttonSave.Enabled = false;
                return;
            }
            DataGridViewRow dr = this.StockDataGridView.CurrentRow;

            //焦点不在货号框内时，对表格行的选择变化才引起货号变化，这是防止货号手动修改时引发表格选择变化又反馈回货号框
            if (!this.textBox货号.Focused) this.textBox货号.Text = dr.Cells["货号"].Value.ToString();

            this.comboBox颜色.SelectedValue = dr.Cells["颜色"].Value;
            this.comboBox尺码.SelectedValue = dr.Cells["尺码"].Value;
            this.buttonSave.Enabled = true;

        }

        private void textBox货号_Leave(object sender, EventArgs e)
        {
            //大写转换并去空格
            this.textBox货号.Text = this.textBox货号.Text.ToUpper().Trim();  //转为大写去掉空格
            if (this.StockDataGridView.CurrentRow == null) return;
            this.textBox货号.Text = this.StockDataGridView.CurrentRow.Cells["货号"].Value.ToString();

        }

        private void textBox货号_TextChanged(object sender, EventArgs e)
        {
            ///只有当焦点在货号框内，文本变化才引起表格过滤。以否点击表格产生文本变化时引起表格的反馈过滤
            if (this.textBox货号.Focused) this.fSTOCKSBindingSource.Filter = string.Format("货号 like '*{0}*'", this.textBox货号.Text.Trim().ToUpper());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox颜色_Enter(object sender, EventArgs e)
        {
            this.label3.Focus();

        }
    }
}
