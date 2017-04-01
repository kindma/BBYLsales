using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BBYLsales
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            wellcom welcom = new wellcom();
            welcom.MdiParent = this;
            welcom.Show();
            this.toolStripStatusLabel1.Text = "当前登录用户：" + staticLoinUser.loginName;
            if (staticLoinUser.isAdminUser())
            {
                this.buttonOption.Visible = true;
                this.button备份.Visible = true;
                this.buttonChargs.Visible = true;
            }
            else
            {
                this.buttonOption.Visible = false; ;
                this.button备份.Visible = false;
                this.buttonChargs.Visible = false;

            }


        }

        /// <summary>
        /// 选项窗口打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            if (staticLoinUser.isAdminUser())
            {
                OPTION opt = new OPTION();
                opt.ShowDialog();
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            this.Validate();
            Application.Exit();
        }
        /// <summary>
        /// 打开唯一窗体，关掉其它无用窗体
        /// </summary>
        /// <param name="w"></param>
        /// <param name="specil"></param>
        private void openSingWindow(Form w)
        {
            bool thisWindowHasOpened = false;
            string windowsName = w.Name;


            foreach (Form a in this.MdiChildren)
            {

                if (a.Name == windowsName)
                {
                    a.Activate();
                    thisWindowHasOpened = true;
                    w.Dispose();
                }

            }
            if (!thisWindowHasOpened)
            {
                w.MdiParent = this;
                w.Show();
            }
        }

        private void buttonInOut_Click(object sender, EventArgs e)
        {
            this.openSingWindow(new income());
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            this.openSingWindow(new FormSales());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonStockAdjust_Click(object sender, EventArgs e)
        {
            this.openSingWindow(new FormKCTZ());
        }

        private void buttonStockCount_Click(object sender, EventArgs e)
        {
            this.openSingWindow(new FormStocks());
        }

        private void buttonSalesCout_Click(object sender, EventArgs e)
        {
            this.openSingWindow(new FormCount());
        }

        private void buttonBackUP_Click(object sender, EventArgs e)
        {
            foreach (Form a in this.MdiChildren) a.Close();
            (new FormBaseBackup()).ShowDialog();
        }

        private void buttonChargs_Click(object sender, EventArgs e)
        {
            this.openSingWindow(new FormPends());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出?", "确认", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            if (MessageBox.Show("是否备份数据库?", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string path = @"d:\数据库备份\";
                DirectoryInfo dir = new DirectoryInfo(path);
                if (!dir.Exists) dir.Create();


                string fileName = "";
                fileName = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString().Replace(':', '-') + "备份.bak";

                string backupstr = "backup database sale to disk='" + path + fileName + "';";
                SqlConnection con = new SqlConnection(Properties.Settings.Default.saleConnectionString.Replace("sale", "master"));
                SqlCommand cmd = new SqlCommand(backupstr, con);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("成功备份到" + fileName);
                    // Process.Start(@"c:\windows\explorer.exe", this.path);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    MessageBox.Show("您可以尝试在关闭本软件后再打开本软件，然后立即进行备份操作");
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
