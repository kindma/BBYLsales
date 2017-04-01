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
    public partial class FormCount : Form
    {
        public FormCount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCount_Load(object sender, EventArgs e)
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

            this.dateTimePicker1.Value = DateTime.Now.AddDays(-30);
            this.dateTimePicker2.Value = DateTime.Now;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.f_SALEBindingSource.Filter = string.Format("销售日期>='{0}' and 销售日期<='{1}'", this.dateTimePicker1.Value.Date.ToShortDateString(),
                this.dateTimePicker2.Value.Date.ToShortDateString());
        }

        private void f_SALEDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            DataClassLinqDataContext linqd = new DataClassLinqDataContext();
            var k = (from q in linqd.F_INCOME
                     select new
                     {
                         huohao = q.货号,
                         diaopai = q.进货价
                     }).Distinct().ToList();

            if (this.f_SALEDataGridView.Rows.Count == 0) return;

            decimal allMount = 0;
            decimal allLiren = 0;

            foreach (DataGridViewRow dr in this.f_SALEDataGridView.Rows)
            {
                if (((int)dr.Cells["销量"].Value) > 0) dr.Cells["进销"].Value = "销售";
                else
                    if (((int)dr.Cells["销量"].Value) == 0) { dr.DefaultCellStyle.BackColor = Color.MistyRose; }
                    else
                    {
                        dr.Cells["进销"].Value = "退货";
                        dr.DefaultCellStyle.BackColor = Color.Cyan;

                    }
                dr.Cells["成本价"].Value = k.Where(p => p.huohao == dr.Cells["货号"].Value.ToString()).Select(p => p.diaopai).First();
                dr.Cells["毛利"].Value = ((decimal)dr.Cells["开票价"].Value - (decimal)dr.Cells["成本价"].Value)*(int)dr.Cells["销量"].Value;

                allMount += (int)dr.Cells["销量"].Value;
                allLiren += (decimal)dr.Cells["毛利"].Value;
            }
            this.label总件数.Text = allMount.ToString();
            this.label总毛利.Text = allLiren.ToString();
            
        }
    }
}
