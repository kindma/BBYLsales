using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace BBYLsales
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }



        private void test_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_STOCKSCOUNT”中。您可以根据需要移动或删除它。
            this.f_STOCKSCOUNTTableAdapter.Fill(this.saleDataSetAll.F_STOCKSCOUNT);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_CLOTHTYPE”中。您可以根据需要移动或删除它。
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);
           

        }

        private void f_S_CLOTHTYPEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.f_S_CLOTHTYPEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);

        }

    

       

    }
}
