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
    public partial class FormSales : Form
    {
        private bool hasmodifyVar;
        private bool hasmodify
        {
            get
            {
                return hasmodifyVar;

            }
            set
            {
                hasmodifyVar = value;
                this.f_SALEBindingNavigatorSaveItem.Enabled = value;
                this.toolStripLabel放充保存.Enabled = value;
            }

        }
        private DateTime returnDate; //退货日期变量，将被强出窗口中的日期控件所改变
        public FormSales()
        {
            InitializeComponent();
        }
        private void FormSales_Load(object sender, EventArgs e)
        {
            this.filldate();
            this.hasmodify = false;
            if (staticLoinUser.isAdminUser()) this.f_SALEDataGridView.ReadOnly = false;
        }
        private void FormSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            if (this.hasmodify)
            {
                if (MessageBox.Show("销售表还有未保存的入库数据，退出后这些数据将丢失，确定退出？", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                }
                else
                {
                    e.Cancel = true;
                    this.Activate();
                }
            }
        }

        #region 工具栏按钮行为=======================================

        /// <summary>
        /// 添加新销售
        /// </summary>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


            if ((new FormNewSale()).ShowDialog() == DialogResult.OK)
            {
                // TODO: 这行代码将数据加载到表“saleDataSetAll.F_SALE”中。您可以根据需要移动或删除它。
                this.f_SALETableAdapter.Fill(this.saleDataSetAll.F_SALE);
            }
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_SALEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.f_SALEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            MessageBox.Show("已保存!");
            this.hasmodify = false;
        }

        /// <summary>
        /// 删除按钮行为,可以删除或置红
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.f_SALEDataGridView.CurrentRow == null) return;


            DataGridViewRow dr = this.f_SALEDataGridView.CurrentRow;
            int mount = (int)dr.Cells["销量"].Value;

            //如果数量是负值,表示是退货,它的清零相当于出库,就要检查是否引起负库存
            if (mount < 0)
            {
                int count = staticFunc.getMountOfCloth(dr.Cells["货号"].Value.ToString(),
                    (int)dr.Cells["尺码"].Value,
                    (int)dr.Cells["颜色"].Value);

                if (count + mount < 0)
                {
                    MessageBox.Show("这次变动会引起此款产品的库存小于零，操作无效");
                    return;
                }

            }

            if (staticLoinUser.isCommonUser())
            {
                if (this.ask("确定要取消选中的这行记录吗？\n这个操作不会删除记录，只是将数量置为零，同时在备注中标明"))
                    this.setRowToZero();
                this.f_SALEBindingNavigatorSaveItem.PerformClick();
                return;
            }
            var rs = MessageBox.Show("确认删除？点YES删除，点NO只归零，点取消关闭", "", MessageBoxButtons.YesNoCancel);
            switch (rs)
            {
                case DialogResult.Yes:
                    try
                    {
                        this.f_SALEDataGridView.Rows.Remove(this.f_SALEDataGridView.CurrentRow);
                        this.hasmodify = true;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    break;
                case DialogResult.No:
                    this.setRowToZero();
                    break;
                case DialogResult.Cancel:
                    return;

            }
            this.f_SALEBindingNavigatorSaveItem.PerformClick();
        }

        /// <summary>
        /// 按货号搜索
        /// </summary>
        private void toolStripTextBox搜索框_TextChanged(object sender, EventArgs e)
        {
            this.f_SALEBindingSource.Filter = string.Format("货号 like '*{0}*'", this.toolStripTextBox搜索框.Text.Trim().ToUpper());
        }




        /// <summary>
        /// 退货
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.f_SALEDataGridView.CurrentRow == null)
            {
                MessageBox.Show("请先选择要退的货！");
                return;
            }

            try
            {
                DataGridViewRow s = this.f_SALEDataGridView.CurrentRow;

                if ((int)s.Cells["销量"].Value < 1)
                {
                    MessageBox.Show("销量不大于零,无法退货");
                    return;  //如果销量或负则退出
                }
                //此处预留位置检测某ID的行进行过退货没有，可以用查找备注中【ID】的方式


                ///////////////////////

                string askstr = string.Format("确定要将{0}销售的{1}退一件吗？",
                    ((DateTime)s.Cells["销售日期"].Value).ToShortDateString(),
                    s.Cells["货号"].Value.ToString());

                ReturnProductTimePicker n = new ReturnProductTimePicker();
                n.datePicked += this.dealDatetimeResult;
                n.AskString = askstr;
                if (n.ShowDialog() != DialogResult.OK) return;



                this.f_SALEBindingSource.AddNew();
                DataGridViewRow t = this.f_SALEDataGridView.CurrentRow;
                staticFunc.copyDataGridViewRow(s, t);

                t.Cells["销量"].Value = -1;
                t.Cells["销售日期"].Value = this.returnDate.Date; //退货日期
                t.Cells["录入人员"].Value = staticLoinUser.loginID;
                t.Cells["录入时间"].Value = DateTime.Now.Date;

                t.Cells["备注"].Value = string.Format("退货ID:[{0}],售货日为:{1}原备注:{2}",
                    s.Cells["ID"].Value.ToString(),
                    ((DateTime)s.Cells["销售日期"].Value).ToShortDateString(),
                    s.Cells["备注"].Value.ToString()
                    );

                t.DefaultCellStyle.BackColor = Color.Cyan;
                this.hasmodify = true;
                this.f_SALEBindingNavigatorSaveItem.PerformClick();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        /// <summary>
        /// 放弃保存重填数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLabel放充保存_Click(object sender, EventArgs e)
        {
            if (ask("确定要放弃未保存的操作吗？"))
            {
                this.filldate();
                this.hasmodify = false;
            }
        }

        #endregion=========================================================

        /// <summary>
        /// 替代性提示框
        /// </summary>
        /// <param name="askstr"></param>
        /// <returns></returns>
        private bool ask(string askstr)
        {
            return MessageBox.Show(askstr, "确认", MessageBoxButtons.OKCancel) == DialogResult.OK;
        }


        /// <summary>
        /// 退货日期选择的日期进行处理
        /// </summary>
        /// <param name="r"></param>
        private void dealDatetimeResult(DateTime r)
        {
            this.returnDate = r;
        }

        /// <summary>
        /// 数据绑定后进行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_SALEDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.setRedRows();
            this.FormSales_Activated(new object(), new EventArgs());
        }


        /// <summary>
        /// 数量置零，背影改为异色
        /// </summary>
        private void setRowToZero()
        {
            DataGridViewRow s = this.f_SALEDataGridView.CurrentRow;
            if ((int)s.Cells["销量"].Value == 0) return;
            string orignal = s.Cells["销量"].Value.ToString();

            s.Cells["销量"].Value = 0;
            s.Cells["备注"].Value = string.Format("清除于{0}by{1},原数量【{2}】，原备注【{3}】",
                DateTime.Now.ToShortDateString(),
                staticLoinUser.loginName, orignal,
                s.Cells["备注"].Value.ToString()
                );

            s.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.hasmodify = true;
        }


        /// <summary>
        /// 设置所有的背景
        /// </summary>
        private void setRedRows()
        {

            foreach (DataGridViewRow row in this.f_SALEDataGridView.Rows)
            {
                try
                {
                    if ((int)row.Cells["销量"].Value == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        continue;
                    }
                    if (row.Cells["销量"].Value.ToString() == "-1")
                    {
                        row.DefaultCellStyle.BackColor = Color.Cyan;
                        row.Cells["类型"].Value = "退货";
                    }
                    else
                    {
                        row.Cells["类型"].Value = "销售";
                    }
                }
                catch { }


            }

        }


        /// <summary>
        /// 重新填充数据
        /// </summary>
        private void filldate()
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_VIP”中。您可以根据需要移动或删除它。
            this.f_VIPTableAdapter.Fill(this.saleDataSetAll.F_VIP);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_USER”中。您可以根据需要移动或删除它。
            this.f_S_USERTableAdapter.Fill(this.saleDataSetAll.F_S_USER);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SIZE”中。您可以根据需要移动或删除它。
            this.f_S_SIZETableAdapter.Fill(this.saleDataSetAll.F_S_SIZE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_COLOR”中。您可以根据需要移动或删除它。
            this.f_S_COLORTableAdapter.Fill(this.saleDataSetAll.F_S_COLOR);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_SALE”中。您可以根据需要移动或删除它。
            this.f_SALETableAdapter.Fill(this.saleDataSetAll.F_SALE);

        }

        /// <summary>
        /// 双击单元格弹出描述
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_SALEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.f_SALEDataGridView.Columns[e.ColumnIndex].Name != "备注") return;

            string k = this.f_SALEDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string msg = "";
            int lineWord = 50; //每行的字数

            while (k.Length > lineWord)
            {
                msg += k.Substring(0, lineWord);
                msg += "\n\r";
                k = k.Substring(lineWord);
            }
            msg += k;
            MessageBox.Show(msg);
        }

        private void toolStripButton显示全部_Click(object sender, EventArgs e)
        {
            this.toolStripTextBox搜索框.Text = "";
        }

        private void FormSales_Activated(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)this.MdiParent;
            try
            {
                mf.toolStrip状态栏.Text = "表中数量:" + staticFunc.CountMainTable(this.f_SALEDataGridView, "销量").ToString();
            }
            catch { }
        }
    }
}
