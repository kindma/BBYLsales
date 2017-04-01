using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBYLsales.Options
{
    public partial class OptionClass : Form
    {
        public OptionClass()
        {
            InitializeComponent();
        }

        private void f_CLASSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.f_CLASSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);

        }

        private void OptionClass_Load(object sender, EventArgs e)
        {
         
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_CLASS”中。您可以根据需要移动或删除它。
            this.f_CLASSTableAdapter.Fill(this.saleDataSetAll.F_CLASS);

        }
    }
}
