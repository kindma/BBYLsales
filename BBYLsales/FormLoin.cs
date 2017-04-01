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
    public partial class FormLoin : Form
    {
        public FormLoin()
        {
            InitializeComponent();
        }

        private void FormLoin_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_USER”中。您可以根据需要移动或删除它。
            this.f_S_USERTableAdapter.Fill(this.saleDataSetAll.F_S_USER);
            this.textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClassesSaleLinqDataContext allusers = new DataClassesSaleLinqDataContext();

            var k = allusers.F_S_USER.Where(p => p.名称 == this.comboBox1.Text).First();

            if (this.textBox1.Text == k.密码)
            {
                staticLoinUser.loginID = k.id;
                staticLoinUser.loginName = k.名称;
                staticLoinUser.loginPower = k.权限;
                this.Hide();
                (new MainForm()).Show();
            }
            else MessageBox.Show("密码错误");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new test()).Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            (new test()).Show();
        }
    }
}
