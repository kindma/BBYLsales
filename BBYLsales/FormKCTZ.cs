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
    public partial class FormKCTZ : Form
    {
        private bool hasChangeVar;
        private Point mouse_offset;
        public bool hasChang
        {
            get
            {
                return this.hasChangeVar;
            }
            set
            {
                this.hasChangeVar = value;
                this.f_KCTZBindingNavigatorSaveItem.Enabled = value;
                this.toolStripButton放弃修改.Enabled = value;
            }
        }

        #region 窗体
        public FormKCTZ()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormKCTZ_Load(object sender, EventArgs e)
        {
            staticFunc.refreshStock();

           

            this.dataFill();
            this.setRedRows();
            this.hasChang = false;
        }
        /// <summary>
        /// 窗体关闭前提示保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormKCTZ_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hasChang)
            {
                if (MessageBox.Show("库存调整表中有未保存的修改！退出后将丢失这些修改，是否继续？") != DialogResult.OK)
                {
                    e.Cancel = true;
                    this.Activate();
                }
            }
        }


        #endregion

        #region 导航按钮============================

        /// <summary>
        /// 导航的保存按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_KCTZBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.f_KCTZBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);

            this.hasChang = false;
            MessageBox.Show("已保存");
        }


        /// <summary>
        /// 导航的新添调整按扭按下,初始化新添记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            if (this.hasChang)
            {
                if (MessageBox.Show("在新添记录前会自动保存当前的修改，是否继续？") == DialogResult.OK)
                {
                    this.f_KCTZBindingNavigatorSaveItem.PerformClick();
                }
                else
                {
                    return;

                }
            }

            //重计库存并添充库存表
            staticFunc.refreshStock();
           

            //添加新记录（会清空货号，引发表格的FILTER清空
            this.f_KCTZBindingSource.AddNew();

            //这一行必须在上面ADDNEW之后,以防发生的联动响到之前的行
            this.f_STOCKSTableAdapter.Fill(this.saleDataSetAll.F_STOCKS);

            //如果库存为零则提示并退出
            if (this.f_STOCKSDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("无库存!");
                this.f_KCTZBindingSource.CancelEdit();
                return;
            }
            else
            {
                this.panel1.Visible = true;

                this.f_KCTZBindingNavigator.Enabled = false;
                this.f_KCTZDataGridView.Enabled = false;

                //选择第一行
                this.f_STOCKSDataGridView.Rows[0].Selected = true;


                this.radioButton出库一件.Checked = true;
                this.textBox数量.Text = "-1";
                this.listBox1.SelectedIndex = 0;

                this.dateTimePicker1.Value = new DateTime(2000, 1, 1);
                this.dateTimePicker1.Value = DateTime.Now.Date;

                this.textBox调整责任人.Text = staticLoinUser.loginID.ToString();
                this.textBox录入人员.Text = staticLoinUser.loginID.ToString();
                this.textBox录入时间.Text = DateTime.Now.ToString();

                //需要再次清空货号
                this.textBox货号.Text = "";
                this.textBox货号.Focus();
            }

        }

        /// <summary>
        /// 导航的删除按钮按下.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            DataGridViewRow dr = this.f_KCTZDataGridView.CurrentRow;
            int mount = (int)dr.Cells["数量"].Value;

            //如果数量是正值,表示是进库纪录,它的清零相当于出库,就要检查是否引起负库存
            if (mount > 0)
            {
                int count = staticFunc.getMountOfCloth(dr.Cells["货号S"].Value.ToString(),
                    (int)dr.Cells["尺码S"].Value,
                    (int)dr.Cells["颜色S"].Value);

                if (count - mount < 0)
                {
                    MessageBox.Show("这次变动会引起此款产品的库存小于零，操作无效");
                    return;
                }

            }


            if (this.f_KCTZDataGridView.CurrentRow == null) return;
            //普通用户为置红
            if (staticLoinUser.isCommonUser())
            {
                string askstr = "确定要取消选中的这行出入库记录吗？\n这个操作不会删除记录，只是将数量置为零，同时在备注中标明";
                if (MessageBox.Show(askstr) == DialogResult.OK)
                {
                    this.setRedArow();
                    this.f_KCTZBindingNavigatorSaveItem.PerformClick();
                }
                return;
            }

            //管理员用户可以选择是彻底删除还是置红
            var rst = MessageBox.Show("确定要删除吗？点YES删除，点NO进行归零而不删除，点取消关闭窗口", "确认", MessageBoxButtons.YesNoCancel);
            if (rst == DialogResult.Yes)
            {
                try
                {
                    this.f_KCTZBindingSource.RemoveCurrent();
                   
                    this.hasChang = true; 
                    this.f_KCTZBindingNavigatorSaveItem.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (rst == DialogResult.No)
            {
                this.setRedArow();
                this.f_KCTZBindingNavigatorSaveItem.PerformClick();
            }
            if (rst == DialogResult.Cancel) return;


        }



        /// <summary>
        /// 放度保存重加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("这将放充未保存的修改，继续？") == DialogResult.OK) this.FormKCTZ_Load(new object(), new EventArgs());
        }


        #endregion

        #region 新建窗体控件反应========================
        /// <summary>
        /// 新的库存调整的【保存】按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button保存_Click(object sender, EventArgs e)
        {
            //为防止货号输入不全,颜色尺码的乱改，直接调用表格选择函数，将当前选择行自动匹配货号，颜色尺码什么的
            this.f_STOCKSDataGridView_SelectionChanged(new object(), new EventArgs());

            this.Validate();
            ///如果是出库，就要查库存是否请允许出库
            if (this.radioButton出库一件.Checked)
            {
                ///先查库存是否足够此次销售
                int allInstock = staticFunc.getMountOfCloth(this.textBox货号.Text, (int)this.comboBox尺码.SelectedValue, (int)this.comboBox颜色.SelectedValue);
                if (allInstock < 1)
                {
                    MessageBox.Show("这款衣服的库存量小于1，无法进行出库操作，请检查此款衣服的进销存情况！");
                    return;
                }

            }

            try
            {
                this.f_KCTZBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("确保所有的项目正确添写！特别是数量，必须为-1或1\n\r错误信息：" + ex.Message);
                return;
            }



            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            this.panel1.Visible = false;
            this.hasChang = false;
            this.f_KCTZBindingNavigator.Enabled = true;
            this.f_KCTZDataGridView.Enabled = true;
            this.setRedRows();

            MessageBox.Show("已保存！");
        }

        /// <summary>
        /// 取消按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button取消_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.f_KCTZBindingSource.CancelEdit();
            this.f_KCTZBindingNavigator.Enabled = true;
            this.f_KCTZDataGridView.Enabled = true;
        }

        /// <summary>
        /// 填 完货号以后查找相关资 料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox货号_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.f_STOCKSDataGridView.CurrentRow == null) return;
                this.textBox货号.Text = this.f_STOCKSDataGridView.CurrentRow.Cells["货号"].Value.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void f_STOCKSDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = (this.f_STOCKSDataGridView.CurrentRow != null);
            if (this.f_STOCKSDataGridView.CurrentRow == null) return;

            DataGridViewRow dr = this.f_STOCKSDataGridView.CurrentRow;
            this.comboBox尺码.SelectedValue = dr.Cells["尺码"].Value;
            this.comboBox颜色.SelectedValue = dr.Cells["颜色"].Value;

            //焦点不在货号框内时，对表格行的选择变化才引起货号变化，这是防止货号手动修改时引发表格选择变化又反馈回货号框
            if (!this.textBox货号.Focused) this.textBox货号.Text = dr.Cells["货号"].Value.ToString();


        }

        private void radioButton出库一件_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox数量.Text = "-1";

        }

        private void radioButton入库一件_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox数量.Text = "1";
        }

        private void textBox货号_TextChanged(object sender, EventArgs e)
        {
            //只有在输入框有焦点时变化才引发联动
            if (((TextBox)sender).Focused) this.f_STOCKSBindingSource.Filter = string.Format("货号 like '*{0}*'", ((TextBox)sender).Text.Trim().ToUpper());

        }

        #endregion


        /// <summary>
        /// 数据加载
        /// </summary>
        private void dataFill()
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_CLASS”中。您可以根据需要移动或删除它。
            this.f_CLASSTableAdapter.Fill(this.saleDataSetAll.F_CLASS);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_CLOTHTYPE”中。您可以根据需要移动或删除它。
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);             
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_USER”中。您可以根据需要移动或删除它。
            this.f_S_USERTableAdapter.Fill(this.saleDataSetAll.F_S_USER);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_KCTZTYPE”中。您可以根据需要移动或删除它。
            this.f_S_KCTZTYPETableAdapter.Fill(this.saleDataSetAll.F_S_KCTZTYPE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SIZE”中。您可以根据需要移动或删除它。
            this.f_S_SIZETableAdapter.Fill(this.saleDataSetAll.F_S_SIZE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_COLOR”中。您可以根据需要移动或删除它。
            this.f_S_COLORTableAdapter.Fill(this.saleDataSetAll.F_S_COLOR);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_KCTZ”中。您可以根据需要移动或删除它。
            this.f_KCTZTableAdapter.Fill(this.saleDataSetAll.F_KCTZ);

        }

        /// <summary>
        /// 设置红色行
        /// </summary>
        private void setRedRows()
        {
            foreach (DataGridViewRow dr in this.f_KCTZDataGridView.Rows)
            {
                if ((int)dr.Cells["数量"].Value == 0)
                {
                    dr.DefaultCellStyle.BackColor = Color.MistyRose;
                    continue;
                }
                if ((int)dr.Cells["数量"].Value < 0)
                {
                    dr.DefaultCellStyle.BackColor = Color.Cyan;
                    dr.Cells["类别"].Value = "出库";
                }
                else
                {
                    dr.Cells["类别"].Value = "入库";
                }

            }
        }

        /// <summary>
        /// 设置一行为红色
        /// </summary>
        private void setRedArow()
        {
            DataGridViewRow drow = this.f_KCTZDataGridView.CurrentRow;
            int orignal = (int)drow.Cells["数量"].Value;
            if (orignal == 0) return;
            drow.Cells["数量"].Value = 0;
            drow.Cells["备注"].Value = string.Format("清除于{0}by{1},原数量【{2:d}】，原备注【{3}】",
                DateTime.Now.ToShortDateString(),
                staticLoinUser.loginName,
                orignal,
                drow.Cells["备注"].Value.ToString()
                );

            drow.DefaultCellStyle.BackColor = Color.MistyRose;
            this.hasChang = true;
        }

        private void Control移动_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Control移动_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.panel1.Location = this.panel1.Parent.PointToClient(mousePos);
            }
        }

        /// <summary>
        /// 用于禁止颜色与尺码的手动修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 焦点脱离(object sender, EventArgs e)
        {
            this.label1.Focus();
        }

        private void FormKCTZ_Activated(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)this.MdiParent;
            try
            {
                mf.toolStrip状态栏.Text = "表中数量:" + staticFunc.CountMainTable(this.f_KCTZDataGridView, "数量").ToString();
            }
            catch { }
        }

        private void f_KCTZDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setRedRows();
            this.FormKCTZ_Activated(new object(), new EventArgs());
        }




    }
}
