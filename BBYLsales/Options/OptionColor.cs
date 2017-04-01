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
    public partial class OptionColor : OptionModel
    {
        public OptionColor()
        {
            InitializeComponent();
        }

        private  bool isAddingVar;

        private  bool isAdding
        {
            get { return isAddingVar; }
            set
            {
                isAddingVar = value;
                this.toolStripButton保存.Enabled = value;
                this.textBox颜色名称.ReadOnly = !value;
                this.buttonColor.Enabled = value;
            }
               
        }

        private void OptionColor_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSet.F_S_COLOR”中。您可以根据需要移动或删除它。
            this.f_S_COLORTableAdapter.Fill(this.saleDataSet.F_S_COLOR);
            this.isAdding = false;

        }

        /// <summary>
        /// 颜色值选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            var a = new ColorDialog();
            if (a.ShowDialog() == DialogResult.OK)
            {
                Color b = a.Color;
                var bt = (Button)sender;
                bt.BackColor = b;
                this.textBox颜色值.Text = b.ToArgb().ToString();

                //Color c = Color.FromArgb(b.ToArgb());

            }
        }

        
        /// <summary>
        /// 当前选择行变化时，颜色按钮的背景色产生相对变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox颜色名称_TextChanged(object sender, EventArgs e)
        {
            TextBox bt = (TextBox)sender;
            if (bt.Text == "") this.buttonColor.BackColor = Color.White;
            else
            {
                Color c = Color.FromArgb(int.Parse(bt.Text));
                this.buttonColor.BackColor = c;
            }
        }

        /// <summary>
        /// 对每行的值单元格背景进行设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)row.Cells[2];
                if (cell.Value.ToString() != "")
                {
                    var a = (int)cell.Value;
                    cell.Style.BackColor = Color.FromArgb(a);
                }
            }
        }

        /// <summary>
        /// 输入不全时提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("颜色名称不得为空或是未选择颜色！");
            this.textBox颜色名称.Focus();
            e.Cancel = true;
        }

        /// <summary>
        /// 添加新颜色 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.isAdding = true;
            this.fSCOLORBindingSource.AddNew();
            this.textBox颜色名称.ReadOnly = false;
            this.buttonColor.Enabled = true;
        }

        /// <summary>
        /// 选择变化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save()
        {
            this.Validate();
            try
            {
                this.fSCOLORBindingSource.EndEdit();
            }
            catch (NoNullAllowedException exp)
            {
                MessageBox.Show("颜色输入不全！");
                return;
            }
            this.f_S_COLORTableAdapter.Update(this.saleDataSet);

            this.isAdding = false;
        }

        /// <summary>
        /// 删除并自动保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.fSCOLORBindingSource.RemoveCurrent();
                this.save();
            }
            catch (Exception ex) { 
                MessageBox.Show("删除被禁止，提示信息："+ex.Message);
                this.f_S_COLORTableAdapter.Fill(this.saleDataSet.F_S_COLOR);                
                this.isAdding = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.save();
        }

        private void OptionColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isAdding)
            {
                if (MessageBox.Show("有未保存的数据,是否继续退出?") == DialogResult.OK)
                {
                }
                else e.Cancel = true;
            }
        }
    }
}
