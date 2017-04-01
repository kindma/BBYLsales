using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace BBYLsales
{
    public partial class FormBaseBackup : Form
    {
        public FormBaseBackup()
        {
            InitializeComponent();
        }
        private string path;

        private SqlConnection con;

        private void FormBaseBackup_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 备份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            this.path = @"d:\数据库备份\";
            DirectoryInfo dir = new DirectoryInfo(this.path);
            if (!dir.Exists) dir.Create();


            string fileName = "";
            fileName = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString().Replace(':', '-') + "备份.bak";

            string backupstr = "backup database sale to disk='" + this.path + fileName + "';";
            this.con = new SqlConnection(Properties.Settings.Default.saleConnectionString.Replace("sale", "master"));
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


        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button还原_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还原前将先备份当前数据");
            this.button1.PerformClick();
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "数据库备份文件*.bak|*.bak";
            string newpath = "";

            if (a.ShowDialog() == DialogResult.OK) newpath = a.FileName;
            else return;


            if (MessageBox.Show("确定要还原" + newpath + "吗?", "警告", MessageBoxButtons.YesNo) == DialogResult.No) return;
            
            this.ExecSQL("ALTER DATABASE [sale] SET OFFLINE WITH ROLLBACK IMMEDIATE");
            this.ExecSQL("restore database [sale] from disk='" + newpath + "' with replace");
            this.ExecSQL("alter database  [sale]  set   online");

            MessageBox.Show("成功还原,需要退出本软件后重新进入");
            Application.Exit();

  
        }

        private void ExecSQL(string sqlstr)
        {
            this.con = new SqlConnection(Properties.Settings.Default.saleConnectionString.Replace("sale", "master"));
            try
            {
                SqlCommand cmd = new SqlCommand(sqlstr, this.con);
                this.con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                this.con.Close();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
