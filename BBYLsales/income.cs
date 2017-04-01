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
    public partial class income : Form
    {
        private Point mouse_offset;
        private bool isDisplayHistoryVar;
        /// <summary>
        /// 是否是显示的历史入库记录
        /// 此将决定是根据权限显示删除按钮及本《显示历史》按钮的显示与否
        /// </summary>
        private bool isDisplayHistory
        {
            get
            {
                return isDisplayHistoryVar;

            }
            set
            {
                isDisplayHistoryVar = value;
                this.toolStripLabel放充保存.Enabled = !value;
                if (value)
                {
                    //this.hasmodify = !value;
                    //this.bindingNavigatorDeleteItem.Visible = !value;
                    //if (staticLoinUser.loginPower == "admin") this.bindingNavigatorDeleteItem.Enabled = value;

                }
                else
                {
                    //this.toolStripLabel历史.Visible = true;
                    //this.bindingNavigatorDeleteItem.Visible = true;
                }
            }


        }

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
                this.f_INCOMEBindingNavigatorSaveItem.Enabled = value;
                this.toolStripLabel放充保存.Enabled = value;
            }

        }

        public income()
        {
            InitializeComponent();
        }
        private void income_Load(object sender, EventArgs e)
        {
            if (staticLoinUser.loginPower == "admin") this.f_INCOMEDataGridView.ReadOnly = false;

             
            this.dataFill(true);

            this.hasmodify = false;
            this.isDisplayHistory = true;

            staticFunc.bindClothTypeToTreeView(this.treeView服装类型);

        }

        private void income_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            if (this.hasmodify)
            {
                if (MessageBox.Show("入库表有未保存的数据，退出后这些数据将丢失，确定退出？", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                }
                else
                {
                    e.Cancel = true;
                    this.Activate();
                }
            }
        }
        private void income_Activated(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)this.MdiParent;
            try
            {
                mf.toolStrip状态栏.Text = "表中数量:" + staticFunc.CountMainTable(this.f_INCOMEDataGridView, "进货数量").ToString();
            }
            catch { }
        }

        #region 导航栏按钮按下///////////////////////////////////////////////////
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_INCOMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.f_INCOMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            this.hasmodify = false;
            MessageBox.Show("保存完毕");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //如果显示的是历史记录，就清除后准备添加新入库记录
            //(new incomeHistory()).ShowDialog();
            if (this.hasmodify)
            {
                if (!this.ask("此操作将丢充未保存的修改，是否继续?"))
                {
                    return;
                }
            }

            //if (this.isDisplayHistory)
            //{
            //    this.saleDataSetAll.Clear();
            //    this.dataFill(false);

            //}
            //关掉导航与表格
            this.f_INCOMEBindingNavigator.Enabled = false;
            this.f_INCOMEDataGridView.Enabled = false;

            //this.isDisplayHistory = false;


            this.panel1.Visible = true;
            this.groupBoxaddmod.Enabled = true;
            this.button添加.Visible = true;
            this.groupBoxadd.Visible = true;
            this.groupBoxmod.Visible = false;
            this.f_INCOMEBindingSource.AddNew();
            this.f_INCOMEDataGridView.Enabled = false;
            this.comboBox品牌.Enabled = true;
            this.comboBox颜色.Enabled = true;
            this.comboBox类型.Enabled = true;
            this.comboBox季节.Enabled = true;
            this.treeView服装类型.Size = new Size(180, 280);

            this.checkBoxS.Checked = false;
            this.checkBoxM.Checked = false; ;
            this.checkBoxL.Checked = false;
            this.checkBoxXL.Checked = false;
            this.checkBoxXXL.Checked = false;


            //读取上次记录的参数
            this.textBox进货批次.Text = Properties.Settings.Default.批次;
            this.comboBox季节.SelectedValue = Properties.Settings.Default.季节;
            this.comboBox类型.SelectedValue = Properties.Settings.Default.服装类型;
            this.comboBox品牌.SelectedValue = Properties.Settings.Default.品牌;
            this.textBox货号.Focus();
        }
        /// <summary>
        /// 导航删除按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.f_INCOMEDataGridView.CurrentRow == null) return;


            DataGridViewRow dr = this.f_INCOMEDataGridView.CurrentRow;
            int mount = (int)dr.Cells["进货数量"].Value;

            int count = staticFunc.getMountOfCloth(dr.Cells["货号"].Value.ToString(),
                (int)dr.Cells["尺码"].Value,
                (int)dr.Cells["颜色"].Value);

            if (count - mount < 0)
            {
                MessageBox.Show("这次变动会引起此款产品的库存小于零，操作无效");

                return;
            }

            //如果是普通用户
            if (staticLoinUser.isCommonUser())
            {
                if (staticFunc.allowModRecord(this.f_INCOMEDataGridView))
                {
                    if (this.ask("确定要取消选中的这行入库记录吗？\n这个操作不会删除记录，只是将数量置为零，同时在备注中标明"))
                        this.setRedArow();
                    this.f_INCOMEBindingNavigatorSaveItem.PerformClick();
                }
                else
                {
                    MessageBox.Show("你不是当前记录的录入者，不得改动！");
                }
                return;
            }

            //如果是管理员
            var rs = MessageBox.Show("确认删除？点YES删除，点NO只归零，点取消关闭", "", MessageBoxButtons.YesNoCancel);
            switch (rs)
            {
                case DialogResult.Yes:
                    try
                    {
                        this.f_INCOMEBindingSource.RemoveCurrent();
                        this.hasmodify = true;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    break;
                case DialogResult.No:
                    this.setRedArow();
                    break;
                case DialogResult.Cancel:
                    return;
            }
            this.f_INCOMEBindingNavigatorSaveItem.PerformClick();

        }

        /// <summary>
        /// 不保存按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLabel历史_Click(object sender, EventArgs e)
        {
            //(new incomeHistory()).ShowDialog();
            if (this.hasmodify)
            {
                if (!this.ask("此操作将丢充未保存的入库记录，是否丢弃这些数据?"))
                {
                    return;
                }
            }
            this.saleDataSetAll.Clear();
            this.dataFill(true);
            this.toolStripTextBox查找.Text = "";
            this.hasmodify = false;

            //this.toolStripDropDownButton显示红行.Text = "显示红行";
            //this.isDisplayHistory = true;

            //this.bindingNavigatorDeleteItem.Visible = false; //不许删除
        }

        private void toolStripButton修改产品_Click(object sender, EventArgs e)
        {
            if (this.f_INCOMEDataGridView.CurrentRow == null) return;
            FormAllMod m = new FormAllMod();
            m.dr = this.f_INCOMEDataGridView.CurrentRow;
            m.ShowDialog();
            this.f_INCOMETableAdapter.Fill(this.saleDataSetAll.F_INCOME);
        }

        private void toolStripTextBox查找_Leave(object sender, EventArgs e)
        {
            this.f_INCOMEBindingSource.Filter = string.Format("(进货批次 like '*{0}*' or 货号 like '*{0}*')", this.toolStripTextBox查找.Text.Trim().ToUpper());


        }



        private void toolStripTextBox查找_DoubleClick(object sender, EventArgs e)
        {
            ((ToolStripTextBox)sender).Text = "";
        }



        #endregion //////////////////////////////////////////////

        #region PANAL1上的控件响应=========================

        /// <summary>
        /// 校验表单，保存默认值
        /// </summary>
        /// <returns></returns>
        private bool checkeFormOk()
        {
            //校验货号与批次
            this.errorProvider1.Clear();
            this.textBox进货批次.Text = this.textBox进货批次.Text.Trim();
            this.textBox货号.Text = this.textBox货号.Text.Trim();
            if (this.textBox进货批次.Text == "")
            {
                this.errorProvider1.SetError(this.textBox进货批次, "不得为空");
                this.textBox进货批次.Focus();
                return false; ;
            }


            if (this.textBox货号.Text == "")
            {
                this.errorProvider1.SetError(this.textBox货号, "不得为空");
                this.textBox进货批次.Focus();
                return false;
            }


            //记录此次的相关参数以备下次使用


            Properties.Settings.Default.批次 = this.textBox进货批次.Text;
            Properties.Settings.Default.季节 = (int)this.comboBox季节.SelectedValue;
            Properties.Settings.Default.服装类型 = (int)this.comboBox类型.SelectedValue;
            Properties.Settings.Default.品牌 = (int)this.comboBox品牌.SelectedValue;
            return true;
        }
        /// <summary>
        /// 保存添加或修改的记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1保存_Click(object sender, EventArgs e)
        {
            //检查表单位
            if (!this.checkeFormOk()) return;

            //之所以用DataView 和DataRowView进行对行的复制是因为如果用表格行,会因为排序问题
            //导致当前行发生变化,不好定位到最后修改的行上去.
            BindingSource bs = this.f_INCOMEBindingSource;
            DataView view = (DataView)bs.List;
            DataRowView crow = (DataRowView)bs.Current;

            if (this.groupBoxadd.Visible)
            {
                //如果是添加记录：

                bool isfirstLine = true; //用于检测是不是第一行

                //建立尺寸表的对应
                DataClassesSaleLinqDataContext dataclass = new DataClassesSaleLinqDataContext();
                var sizeList = dataclass.F_S_SIZE.Select(p => p).ToList();
                var sizeNameList = new List<string> { "S", "M", "L", "XL", "XXL" };

                //循环检查尺寸添加新行
                foreach (Control obj in this.groupBoxadd.Controls)
                {
                    //如果不是尺寸控件，跑过下面代码进入下一循环
                    if (sizeNameList.Where(q => q == obj.Name).Count() == 0) continue;
                    //控制值为零了跳过
                    if (((NumericUpDown)obj).Value == 0) continue;

                    if (isfirstLine)
                    {
                        //第一行进行基本设置
                        DataGridViewRow copyTargetRow = this.f_INCOMEDataGridView.CurrentRow;
                        copyTargetRow.Cells["尺码"].Value = sizeList.Where(pp => pp.尺寸 == obj.Name).Select(ppp => ppp.id).First();
                        copyTargetRow.Cells["进货数量"].Value = (int)((NumericUpDown)obj).Value;
                        copyTargetRow.Cells["录入人员"].Value = staticLoinUser.loginID;
                        copyTargetRow.Cells["录入时间"].Value = DateTime.Now;
                        this.f_INCOMEBindingSource.EndEdit();
                        isfirstLine = false;
                    }
                    else
                    {
                        DataRowView newrow = view.AddNew();//每执行一次ADDNEW会自动将上次的ADDNEW的修改状态END。但CURRENT不变
                        for (int i = 1; i < this.f_INCOMEDataGridView.CurrentRow.Cells.Count; i++) newrow[i] = crow[i];
                        newrow["尺码"] = sizeList.Where(pp => pp.尺寸 == obj.Name).Select(ppp => ppp.id).First();
                        newrow["进货数量"] = (int)((NumericUpDown)obj).Value;
                    }
                }
                this.f_INCOMEBindingSource.MoveLast(); //将当前行移动到最后的添加行上,要不然下面的ENDEDIT无效
                this.f_INCOMEBindingSource.EndEdit();


                this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
                this.hasmodify = false;



                if (this.toolStripTextBox查找.Text != Properties.Settings.Default.批次)
                {
                    this.toolStripTextBox查找.Text = Properties.Settings.Default.批次;
                    MessageBox.Show("将自动显示同一批次进库信息！如果想查看其它批次，请清空上方查找框的内容");
                }

            }
            else
            {
                //仅是修改记录
                this.Validate();
                DataGridViewRow ddr = this.f_INCOMEDataGridView.CurrentRow;
                ddr.Cells["备注"].Value = string.Format("修改于{0},by{1},原数量:{2}原尺寸:{3}原备注:【{4}】",
                                                        DateTime.Now.ToShortDateString(),
                                                        staticLoinUser.loginName,
                                                        this.label原数量.Text,
                                                        this.comboBox原尺码.Text,
                                                        this.label原备注.Text);
                this.f_INCOMEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
                this.hasmodify = false;

            }
          
            //关才添加/修改的窗体
            this.panel1.Visible = false;
            this.f_INCOMEDataGridView.Enabled = true;
           
            this.f_INCOMEBindingNavigator.Enabled = true;
            this.f_INCOMEDataGridView.Enabled = true;

        }

        /// <summary>
        /// cancel edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.f_INCOMEBindingSource.CancelEdit();
            this.f_INCOMEBindingNavigator.Enabled = true;
            this.f_INCOMEDataGridView.Enabled = true;

        }

        private void button3添加类型_Click(object sender, EventArgs e)
        {
            (new OptionClothType()).ShowDialog();
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);
            staticFunc.bindClothTypeToTreeView(this.treeView服装类型);

        }

        private void button移动_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void button移动_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.panel1.Location = this.panel1.Parent.PointToClient(mousePos);
            }
        }


        private void button折扣_Click(object sender, EventArgs e)
        {
            (new FormZheKou()).ShowDialog();
        }

        private void numericTextBox吊牌价_Leave(object sender, EventArgs e)
        {
            try
            {
                double zhekou = double.Parse(Properties.Settings.Default.进货折扣);
                double diaopai = double.Parse(this.numericTextBox吊牌价.Text);
                if (this.numericTextBox进货价.Text.Trim() == "" || this.numericTextBox进货价.Text.Trim() == "0")
                    this.numericTextBox进货价.Text = Math.Round(zhekou * diaopai).ToString();
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }

        private void textBox货号_Leave(object sender, EventArgs e)
        {

            ///根据货号查询入库记录，得到一个列表，联合查询，得出对应品牌是否是颜色锁定
            ///根据找到的资料，设置品牌，季节，服装类型 ，如果颜色锁定，也设置颜色。并锁定以上三种。
            ///如果找不到记录，解锁其它设置
            ///
            this.textBox货号.Text = this.textBox货号.Text.ToUpper().Trim();  //转为大写去掉空格
            if (this.textBox货号.Text == "") return;

            var l = staticFunc.getProductByHuohao(this.textBox货号.Text);
            if (l.Count > 0)
            {
                var k = l.First();

                this.comboBox品牌.SelectedValue = k.品牌;
                this.comboBox类型.SelectedValue = k.类型;
                this.comboBox季节.SelectedValue = k.季节;
                this.numericTextBox吊牌价.Text = k.吊牌价.ToString();
                this.numericTextBox进货价.Text = k.进货价.ToString();

                this.comboBox品牌.Enabled = false;
                this.comboBox类型.Enabled = false;
                this.comboBox季节.Enabled = false;
                this.numericTextBox吊牌价.Enabled = false;

                if ((bool)k.颜色货号锁定)
                {
                    this.comboBox颜色.SelectedValue = k.颜色;
                    this.comboBox颜色.Enabled = false;
                }
            }
            else
            {
                this.comboBox品牌.Enabled = true;
                this.comboBox颜色.Enabled = true;
                this.comboBox类型.Enabled = true;
                this.comboBox季节.Enabled = true;
                this.numericTextBox吊牌价.Enabled = true;
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var k = new OptionColor();
            k.WindowState = FormWindowState.Normal;
            k.ShowDialog();
            this.f_S_COLORTableAdapter.Fill(this.saleDataSetAll.F_S_COLOR);
        }
        private void treeView服装类型_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level < 2) return;
            this.comboBox类型.SelectedValue = e.Node.Name;
            this.treeView服装类型.Visible = false;
            this.label类型.Focus();
        }

        private void textBox类型名称_Enter(object sender, EventArgs e)
        {
            this.treeView服装类型.Size = new Size(200, 200);
        }

        private void textBox类型名称_Leave(object sender, EventArgs e)
        {
            this.treeView服装类型.Size = new Size(0, 0);
        }

        private void treeView服装类型_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void comboBox类型_Enter(object sender, EventArgs e)
        {
            this.treeView服装类型.Visible = true;
        }

        private void textBox进货批次_Leave(object sender, EventArgs e)
        {
            this.textBox进货批次.Text = this.textBox进货批次.Text.ToUpper().Trim();  //转为大写去掉空格
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var ck = (CheckBox)sender;
            string ckForSize = ck.Name.Replace("checkBox", "");
            NumericUpDown size = (NumericUpDown)this.Controls.Find(ckForSize, true)[0];
            size.Enabled = !size.Enabled;
            size.Value = size.Enabled ? 1 : 0;
        }

        #endregion


        /// <summary>
        /// 添充数据
        /// </summary>
        /// <param name="fillMainTalbe">是否填充主表</param>
        private void dataFill(bool fillMainTalbe)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SIZE”中。您可以根据需要移动或删除它。
            this.f_S_SIZETableAdapter.Fill(this.saleDataSetAll.F_S_SIZE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_USER”中。您可以根据需要移动或删除它。
            this.f_S_USERTableAdapter.Fill(this.saleDataSetAll.F_S_USER);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_COLOR”中。您可以根据需要移动或删除它。
            this.f_S_COLORTableAdapter.Fill(this.saleDataSetAll.F_S_COLOR);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SEASON”中。您可以根据需要移动或删除它。
            this.f_S_SEASONTableAdapter.Fill(this.saleDataSetAll.F_S_SEASON);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_CLOTHTYPE”中。您可以根据需要移动或删除它。
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_CLASS”中。您可以根据需要移动或删除它。
            this.f_CLASSTableAdapter.Fill(this.saleDataSetAll.F_CLASS);


            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_INCOME”中。您可以根据需要移动或删除它。
            if (fillMainTalbe)
            {
                this.f_INCOMETableAdapter.Fill(this.saleDataSetAll.F_INCOME);

            }
        }
        /// <summary>
        /// 双击单元格，如果是备注就显示备注，否则显示整个内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_INCOMEDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (this.f_INCOMEDataGridView.Columns[e.ColumnIndex].Name != "备注")
            {
                if (this.f_INCOMEDataGridView.CurrentRow.Cells["进货数量"].Value.ToString() == "0") return;
                //修改资料
                if (!staticFunc.allowModRecord(this.f_INCOMEDataGridView))
                {
                    MessageBox.Show("你不是当前记录的录入者，不得改动！");
                    return;
                }

                this.comboBox原尺码.SelectedValue = this.f_INCOMEDataGridView.CurrentRow.Cells["尺码"].Value;
                //this.comboBox原尺码.Enabled = false;
                this.label原数量.Text = this.f_INCOMEDataGridView.CurrentRow.Cells["进货数量"].Value.ToString();
                this.label原备注.Text = this.f_INCOMEDataGridView.CurrentRow.Cells["备注"].Value.ToString();

                this.panel1.Visible = true;
                this.f_INCOMEDataGridView.Enabled = false;
                this.groupBoxadd.Visible = false;
                this.groupBoxmod.Visible = true;

                //防止之前的锁定 
                this.comboBox品牌.Enabled = true;
                this.comboBox颜色.Enabled = true;
                this.comboBox类型.Enabled = true;
                this.comboBox季节.Enabled = true;
                this.textBox货号.Focus();
            }
            else
            {
                //显示备注
                string k = this.f_INCOMEDataGridView.CurrentRow.Cells["备注"].Value.ToString();
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

        }
        private void f_INCOMEDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.setRedRows();
            this.income_Activated(new object(), new EventArgs());
        }
        private void f_INCOMEDataGridView_Sorted(object sender, EventArgs e)
        {

        }


        private void enter2TabKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");

            }
        }

        /// <summary>
        /// 将表格当前行置红
        /// </summary>
        private void setRedArow()
        {
            DataGridViewRow s = this.f_INCOMEDataGridView.CurrentRow;
            if ((int)s.Cells["进货数量"].Value == 0) return;

            int orignal = (int)s.Cells["进货数量"].Value;
            if (orignal == 0) return;


            s.Cells["进货数量"].Value = 0;

            s.Cells["备注"].Value = string.Format("清除于{0}by:{1},原数量【{2:d}】，原备注【{3}】",
                DateTime.Now.ToShortDateString(),
                staticLoinUser.loginName,
                orignal,
                s.Cells["备注"].Value.ToString()
                );

            s.DefaultCellStyle.BackColor = Color.MistyRose;
            this.hasmodify = true;
        }

        /// <summary>
        /// 设置所有行的背景
        /// </summary>
        private void setRedRows()
        {
            foreach (DataGridViewRow row in this.f_INCOMEDataGridView.Rows)
            {
                try
                {
                    if (row.Cells["进货数量"].Value.ToString() == "0") row.DefaultCellStyle.BackColor = Color.MistyRose;
                }
                catch { }
            }
        }

        private bool ask(string askstr)
        {
            return MessageBox.Show(askstr, "确认", MessageBoxButtons.OKCancel) == DialogResult.OK;
        }

        private void copyRow(DataGridViewRow t, DataGridViewRow s)
        {
            for (int i = 1; i < s.Cells.Count; i++)
            {
                t.Cells[i].Value = s.Cells[i].Value;
            }
        }








    }
}
