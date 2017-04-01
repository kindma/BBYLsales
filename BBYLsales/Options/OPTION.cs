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
    public partial class OPTION : Form
    {
        public OPTION()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new OptionColor());

        }

        private void buttonClothType_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new OptionClothType());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        /// <summary>
        /// 避免多次打开同一子窗体
        /// </summary>
        /// <param name="f"></param>
        private void ShowNewForm(Form f)
        {
            bool haveShow = false ;
            foreach (Form a in this.MdiChildren)
            {
                if (a.Name == f.Name) {
                    a.Activate();
                    haveShow=true;
                    f.Dispose();
                }

            }
            if(!haveShow){
                f.MdiParent = this;
                f.Show();
            }
        }

        private void buttonClothSize_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new Options.OptionSize());
        }

        private void buttonStockAdjustReson_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new Options.OptionStockAdjustReason());
        }

        private void buttonCharge_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new Options.OptionCharge());
        }

        private void buttonSeason_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new Options.OptionSeason());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new Options.OptionClass());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new Options.OptionUsers());
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("锁定资料后,普通用户将不能修改已有数据,请确认", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (staticFunc.exeSQL("update F_INCOME set 录入人员=1") &&
                 staticFunc.exeSQL("update F_KCTZ set 录入人员=1") &&
                 staticFunc.exeSQL("update F_SALE set 录入人员=1"))
                {
                    MessageBox.Show("成功锁定!需要重启本软件");
                    Application.Exit();
                }

            }
        }

       
    }
}
