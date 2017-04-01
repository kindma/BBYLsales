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
    public partial class FormDetails : Form
    {
        public FormDetails()
        {
            InitializeComponent();
        }

        public int color;
        public int size;
        public string colorName;
        public string sizeName;
        public string huohao;
        public bool isDisplayAll;
        public bool IsDisplayAll
        {
            get
            {
                return this.isDisplayAll;
            }
            set
            {
                this.isDisplayAll = value;
                if (value)
                {  //显示所有
                    this.toolStripButton显示选项.Text = "仅显示指定款式颜色";

                    this.fINCOMEBindingSource.Filter = string.Format("货号='{0}'", this.huohao);
                    this.fSALEBindingSource.Filter = string.Format("货号='{0}'", this.huohao);
                    this.fKCTZBindingSource.Filter = string.Format("货号='{0}'", this.huohao);
                }
                else
                {
                    //显示指定
                    this.toolStripButton显示选项.Text = "显示此货号所有款式";
                    this.fINCOMEBindingSource.Filter = string.Format("货号='{0}' and 颜色={1} and 尺码={2}",
                         this.huohao, this.color, this.size);
                    this.fSALEBindingSource.Filter = string.Format("货号='{0}' and 颜色={1} and 尺码={2}",
                        this.huohao, this.color, this.size);
                    this.fKCTZBindingSource.Filter = string.Format("货号='{0}' and 颜色={1} and 尺码={2}",
                        this.huohao, this.color, this.size);
                }
            }

        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            this.IsDisplayAll = false;
            
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_USER”中。您可以根据需要移动或删除它。
            this.f_S_USERTableAdapter.Fill(this.saleDataSetAll.F_S_USER);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_VIP”中。您可以根据需要移动或删除它。
            this.f_VIPTableAdapter.Fill(this.saleDataSetAll.F_VIP);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SEASON”中。您可以根据需要移动或删除它。
            this.f_S_SEASONTableAdapter.Fill(this.saleDataSetAll.F_S_SEASON);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_CLOTHTYPE”中。您可以根据需要移动或删除它。
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SIZE”中。您可以根据需要移动或删除它。
            this.f_S_SIZETableAdapter.Fill(this.saleDataSetAll.F_S_SIZE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_COLOR”中。您可以根据需要移动或删除它。
            this.f_S_COLORTableAdapter.Fill(this.saleDataSetAll.F_S_COLOR);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_CLASS”中。您可以根据需要移动或删除它。
            this.f_CLASSTableAdapter.Fill(this.saleDataSetAll.F_CLASS);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_SALE”中。您可以根据需要移动或删除它。
            this.f_SALETableAdapter.Fill(this.saleDataSetAll.F_SALE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_KCTZ”中。您可以根据需要移动或删除它。
            this.f_KCTZTableAdapter.Fill(this.saleDataSetAll.F_KCTZ);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_INCOME”中。您可以根据需要移动或删除它。
            this.f_INCOMETableAdapter.Fill(this.saleDataSetAll.F_INCOME);


            this.toolStripTextBox货号.Text = this.huohao;
            this.toolStripComboBox尺寸.Text = this.sizeName;
            this.toolStripComboBox颜色.Text = this.colorName;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.IsDisplayAll = !this.IsDisplayAll;
        }

        private void toolStripButton退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
