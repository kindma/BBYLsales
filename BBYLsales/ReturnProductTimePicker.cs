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
    public partial class ReturnProductTimePicker : Form
    {
        public ReturnProductTimePicker()
        {
            InitializeComponent();
        }

        public delegate void pickDatetime(DateTime d);
        public event pickDatetime datePicked; //声明事件



        public string AskString;
        public DateTime returnDate;

        private void ReturnProductTimePicker_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.AskString;
            this.returnDate = DateTime.Now;
            this.dateTimePicker1.MaxDate = DateTime.Now;
            this.dateTimePicker1.Value = DateTime.Now.Date;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.returnDate = this.dateTimePicker1.Value;
            datePicked(this.dateTimePicker1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
