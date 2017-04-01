using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBYLsales
{
    public partial class FormStocks : Form
    {
        private string huohao;
        private string Huohao
        {
            get
            {
                return huohao;
            }
            set
            {
                huohao = value;
                this.search();
            }
        }

        private int pinpai;
        private int Pinpai
        {
            get
            {
                return pinpai;
            }
            set
            {
                pinpai = value;
                this.search();
            }
        }

        private int clothType;
        private int ClothType
        {
            get
            {
                return clothType;
            }
            set
            {
                clothType = value;
                this.search();
            }
        }

        private void search()
        {
            string fst = "货号 like '*" + this.Huohao + "*'";
            if (this.Pinpai == 9999)
            {
            }
            else
            {
                fst += string.Format(" AND 品牌={0:d}", this.Pinpai);
            }

            if (this.ClothType == 9999)
            {
            }
            else
            {
                fst += string.Format(" AND 类型={0:d}", this.ClothType);
            }

            this.fSTOCKSBindingSource.Filter = fst;
        }
        public FormStocks()
        {
            InitializeComponent();
        }

        private void f_STOCKSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.f_STOCKSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);

        }

        private void FormStocks_Load(object sender, EventArgs e)
        {

            staticFunc.refreshStock();//重计库存
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SEASON”中。您可以根据需要移动或删除它。
            this.f_S_SEASONTableAdapter.Fill(this.saleDataSetAll.F_S_SEASON);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_CLASS”中。您可以根据需要移动或删除它。
            this.f_CLASSTableAdapter.Fill(this.saleDataSetAll.F_CLASS);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_CLOTHTYPE”中。您可以根据需要移动或删除它。
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SIZE”中。您可以根据需要移动或删除它。
            this.f_S_SIZETableAdapter.Fill(this.saleDataSetAll.F_S_SIZE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_COLOR”中。您可以根据需要移动或删除它。
            this.f_S_COLORTableAdapter.Fill(this.saleDataSetAll.F_S_COLOR);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_STOCKS”中。您可以根据需要移动或删除它。
            this.f_STOCKSTableAdapter.Fill(this.saleDataSetAll.F_STOCKS);

            staticFunc.bindClothTypeToTreeView(this.treeView1);
            this.treeView1.Visible = false;
            this.listBox品牌.Visible = false;

            this.Huohao = "";
            this.Pinpai = 9999;  //代表忽略品牌过滤
            this.ClothType = 9999; //代表忽略类型
            this.count();
            toolStripTextBox1.Focus();

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.toolStripTextbox类型.Text = e.Node.Text;
            this.treeView1.Visible = false;
            this.ClothType = int.Parse(e.Node.Name);

        }

        private void toolStripTextbox类型_Enter(object sender, EventArgs e)
        {

        }



        private void listBox品牌_Click(object sender, EventArgs e)
        {
            this.listBox品牌.Visible = false;
            this.toolStripTextbox品牌.Text = this.listBox品牌.Text;
            this.Pinpai = (int)this.listBox品牌.SelectedValue;


        }

        private void toolStripTextbox品牌_Click(object sender, EventArgs e)
        {
            this.listBox品牌.Visible = true;
            this.listBox品牌.Focus();
        }

        private void toolStripTextbox品牌_DoubleClick(object sender, EventArgs e)
        {
            this.toolStripTextbox品牌.Text = "";
            this.listBox品牌.Visible = false;
            this.Pinpai = 9999;
        }

        private void toolStripTextbox类型_Click(object sender, EventArgs e)
        {
            this.treeView1.Visible = true;
            this.treeView1.Focus();
        }

        private void toolStripTextbox类型_DoubleClick(object sender, EventArgs e)
        {
            this.toolStripTextbox类型.Text = "";
            this.ClothType = 9999;

            this.treeView1.Visible = false;
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Huohao = this.toolStripTextBox1.Text.Trim().ToUpper();
            this.count();
        }

        private void f_STOCKSDataGridView_Click(object sender, EventArgs e)
        {
            this.listBox品牌.Visible = false;
            this.treeView1.Visible = false;
        }

        private void toolStripTextBox1_DoubleClick(object sender, EventArgs e)
        {

            this.toolStripTextBox1.Text = "";
        }

        private void toolStripButton显示全部_Click(object sender, EventArgs e)
        {
            this.toolStripTextBox1.Text = "";
            this.toolStripTextbox类型.Text = "";
            this.toolStripTextbox品牌.Text = "";
            this.Pinpai = 9999;
            this.ClothType = 9999;
        }

        private void f_STOCKSDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        /// <summary>
        /// 统计表中的产品总数
        /// 之所以不绑在DataBindingComplete事件中是因为在关闭窗口时带来一系列执行事件
        /// </summary>
        private void count()
        {
            int allProduct = 0;
            foreach (DataGridViewRow dr in this.f_STOCKSDataGridView.Rows)
            {
                allProduct += (int)dr.Cells["库存量"].Value;

            }

            try
            {
                this.toolStripStatusLabelCountall.Text = "|表中产品总量：" + allProduct.ToString();
            }
            catch { }
        }


        /// <summary>
        /// 显示全部该货号或该款式的进销记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_STOCKSDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.f_STOCKSDataGridView.CurrentRow == null) return;
            DataGridViewRow dr = this.f_STOCKSDataGridView.CurrentRow;
            var a = new FormDetails();
            a.huohao = dr.Cells["货号"].Value.ToString();
            a.color = (int)dr.Cells["颜色"].Value;
            a.size = (int)dr.Cells["尺码"].Value;

            a.colorName = dr.Cells["颜色"].FormattedValue.ToString();
            a.sizeName = dr.Cells["尺码"].FormattedValue.ToString();

            a.ShowDialog();
        }





        /// <summary>
        /// 窗口被激活
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormStocks_Activated(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否刷新库存？\n说明：如果从上次刷新之后未进行过销售或进出库操作，请选“否”，以加快数据加载速度", "提醒", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                staticFunc.refreshStock();
                this.saleDataSetAll.F_STOCKS.Clear();
                this.f_STOCKSTableAdapter.Fill(this.saleDataSetAll.F_STOCKS);
            }

        }

        private void toolStripButton修改产品_Click(object sender, EventArgs e)
        {
            if (this.f_STOCKSDataGridView.CurrentRow == null) return;
            FormAllMod m = new FormAllMod();
            m.dr = this.f_STOCKSDataGridView.CurrentRow;
            m.ShowDialog();
        }

        private void toolStripButton盘库存_Click(object sender, EventArgs e)
        {
            var diag = MessageBox.Show("是重新进行盘点吗?这将清除上次盘点记录", "确认", MessageBoxButtons.YesNoCancel);
            switch (diag)
            {
                case DialogResult.Yes:
                    //清理盘点
                    string refreshCount = "delete  dbo.F_STOCKSCOUNT";
                    staticFunc.exeSQL(refreshCount);
                    refreshCount = "insert into dbo.F_STOCKSCOUNT (货号,颜色,尺码,品牌,类型,季节,库存量) SELECT 货号,颜色,尺码,品牌,类型,季节,库存量  FROM    dbo.F_STOCKS";
                    staticFunc.exeSQL(refreshCount);
                    break;
                case DialogResult.No:
                    //do nothing
                    break;
                case DialogResult.Cancel:
                    //退出
                    return;
            }


            FormStockCount fm = new FormStockCount();
            fm.WindowState = FormWindowState.Maximized;
            fm.MdiParent = this.MdiParent;
            fm.Show();
        }

    }
}
