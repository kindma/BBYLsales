using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBYLsales
{
    public partial class FormAllMod : Form
    {
        public FormAllMod()
        {
            InitializeComponent();
        }

        public DataGridViewRow dr;

        private void FormAllMod_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_COLOR”中。您可以根据需要移动或删除它。
            this.f_S_COLORTableAdapter.Fill(this.saleDataSetAll.F_S_COLOR);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_CLOTHTYPE”中。您可以根据需要移动或删除它。
            this.f_S_CLOTHTYPETableAdapter.Fill(this.saleDataSetAll.F_S_CLOTHTYPE);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_CLASS”中。您可以根据需要移动或删除它。
            this.f_CLASSTableAdapter.Fill(this.saleDataSetAll.F_CLASS);
            // TODO: 这行代码将数据加载到表“saleDataSetAll.F_S_SEASON”中。您可以根据需要移动或删除它。
            this.f_S_SEASONTableAdapter.Fill(this.saleDataSetAll.F_S_SEASON);

            this.textBox货号.Text = dr.Cells["货号"].Value.ToString();
            this.comboBox季节D.SelectedValue = dr.Cells["季节"].Value;
            this.comboBox类型D.SelectedValue = dr.Cells["类型"].Value;
            this.comboBox品牌D.SelectedValue = dr.Cells["品牌"].Value;
            this.comboBox颜色D.SelectedValue = dr.Cells["颜色"].Value;
            this.numericTextBox吊牌价D.Text = dr.Cells["吊牌价"].Value.ToString();
            this.numericTextBox进货价D.Text = dr.Cells["进货价"].Value.ToString();



            this.comboBox季节.SelectedValue = dr.Cells["季节"].Value;
            this.comboBox类型.SelectedValue = dr.Cells["类型"].Value;
            this.comboBox品牌.SelectedValue = dr.Cells["品牌"].Value;
            this.comboBox颜色.SelectedValue = dr.Cells["颜色"].Value;
            this.numericTextBox吊牌价.Text = dr.Cells["吊牌价"].Value.ToString();
            this.numericTextBox进货价.Text = dr.Cells["进货价"].Value.ToString();

            staticFunc.bindClothTypeToTreeView(this.treeView服装类型);

        }

       

        private void comboBox类型_Enter(object sender, EventArgs e)
        {   
            this.treeView服装类型.Visible = true;
            this.button关闭类型.Visible = true;
            this.treeView服装类型.Focus();              
        }

        private void treeView服装类型_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level < 2) return;  ///只能选子结点
            this.comboBox类型.SelectedValue = e.Node.Name;
            this.button关闭类型.PerformClick();
        }

        

        private void button关闭类型_Click(object sender, EventArgs e)
        {
            this.treeView服装类型.Visible = false;
            this.button关闭类型.Visible = false;
            this.label类型.Focus(); //避免焦点返回;               
        }

        private void 取消焦点_Enter(object sender, EventArgs e)
        {
            this.label类型.Focus(); //避免焦点返回;  
        }

        private void button确定_Click(object sender, EventArgs e)
        {
           
            string s = "updateProductALL";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.saleConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.Parameters.Add(new SqlParameter("@huohao",this.textBox货号.Text));
            cmd.Parameters.Add(new SqlParameter("@color", (int)this.comboBox颜色.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@colorD", (int)this.comboBox颜色D.SelectedValue));

            cmd.Parameters.Add(new SqlParameter("@class", (int)this.comboBox品牌.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@type", (int)this.comboBox类型.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@season", (int)this.comboBox季节.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@dprice", (decimal.Parse(this.numericTextBox吊牌价.Text))));
            cmd.Parameters.Add(new SqlParameter("@jprice", (decimal.Parse(this.numericTextBox进货价.Text))));

            cmd.CommandType = CommandType.StoredProcedure;
            var mout = cmd.ExecuteNonQuery();
            con.Close();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
    }
}
