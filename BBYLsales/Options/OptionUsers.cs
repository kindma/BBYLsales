using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBYLsales.Options
{
    public partial class OptionUsers : BBYLsales.OptionModel
    {
        public OptionUsers()
        {
            InitializeComponent();
        }

        private void f_S_USERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.f_S_USERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);

        }

        private void OptionUsers_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_USER”中。您可以根据需要移动或删除它。
            this.f_S_USERTableAdapter.Fill(this.saleDataSetAll.F_S_USER);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_USER”中。您可以根据需要移动或删除它。
            this.f_S_USERTableAdapter.Fill(this.saleDataSetAll.F_S_USER);

        }

        private void f_S_USERBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.f_S_USERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleDataSetAll);

        }
    }
}
