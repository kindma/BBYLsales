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
    public partial class FormStockCount : Form
    {
        public FormStockCount()
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
                this.f_STOCKSCOUNTBindingNavigatorSaveItem.Enabled = value;
            }
        }
      
        private void f_STOCKSCOUNTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void f_STOCKSCOUNTBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.f_STOCKSCOUNTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);
            MessageBox.Show("       已保存      ","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.hasChang = false;

        }

        private void FormStockCount_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SEASON”中。您可以根据需要移动或删除它。
            this.f_S_SEASONTableAdapter.Fill(this.saleDataSetAll.F_S_SEASON);
            this.hasChang = false;
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_CLASS”中。您可以根据需要移动或删除它。
            this.f_CLASSTableAdapter.Fill(this.saleDataSetAll.F_CLASS);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_CLOTHTYPE”中。您可以根据需要移动或删除它。
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SIZE”中。您可以根据需要移动或删除它。
            this.f_S_SIZETableAdapter.Fill(this.saleDataSetAll.F_S_SIZE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_COLOR”中。您可以根据需要移动或删除它。
            this.f_S_COLORTableAdapter.Fill(this.saleDataSetAll.F_S_COLOR);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_STOCKSCOUNT”中。您可以根据需要移动或删除它。
            this.f_STOCKSCOUNTTableAdapter.Fill(this.saleDataSetAll.F_STOCKSCOUNT);

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.f_STOCKSCOUNTBindingSource.Filter = "货号 like '*"+((ToolStripTextBox)sender).Text.Trim().ToUpper()+"*'";
        }

        private void toolStripTextBox1_DoubleClick(object sender, EventArgs e)
        {
            ((ToolStripTextBox)sender).Text = "";
        }

        /// <summary>
        /// 盘点状态已改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_STOCKSCOUNTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if(this.f_STOCKSCOUNTDataGridView.Columns[e.ColumnIndex].HeaderText=="已盘")   this.hasChang = true;
        }

        private void f_STOCKSCOUNTDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.CountMount();
        }

        private void FormStockCount_Activated(object sender, EventArgs e)
        {
            this.CountMount();
        }

        /// <summary>
        /// 统计库存量
        /// </summary>
        private void CountMount()
        {
            int allProduct = 0;
            foreach (DataGridViewRow dr in this.f_STOCKSCOUNTDataGridView.Rows)
            {
                try
                {
                    allProduct += (int)dr.Cells["库存量"].Value;
                }
                catch { }

            }
            MainForm f = (MainForm)this.MdiParent;
            try
            {
                f.toolStrip状态栏.Text = "|表中产品总量：" + allProduct.ToString();
            }
            catch { }
        }

        private void FormStockCount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hasChang)
            {
                if (MessageBox.Show("您有未保存的盘点数据,确定要退出吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //do nothing
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
