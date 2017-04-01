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
    public partial class FormZheKou : Form
    {
        public FormZheKou()
        {
            InitializeComponent();
        }

        private void button取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button保存_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void FormZheKou_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.numericTextBox1.Text.Trim() == "") e.Cancel = true;
        }
    }
}
