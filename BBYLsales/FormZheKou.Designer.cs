namespace BBYLsales
{
    partial class FormZheKou
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button保存 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericTextBox1 = new BBYLsales.numericTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button保存
            // 
            this.button保存.Location = new System.Drawing.Point(228, 166);
            this.button保存.Name = "button保存";
            this.button保存.Size = new System.Drawing.Size(75, 23);
            this.button保存.TabIndex = 0;
            this.button保存.Text = "确定";
            this.button保存.UseVisualStyleBackColor = true;
            this.button保存.Click += new System.EventHandler(this.button保存_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "进货折扣:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进货价折扣";
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BBYLsales.Properties.Settings.Default, "进货折扣", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericTextBox1.Location = new System.Drawing.Point(126, 63);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(100, 21);
            this.numericTextBox1.TabIndex = 3;
            this.numericTextBox1.Text = global::BBYLsales.Properties.Settings.Default.进货折扣;
            // 
            // FormZheKou
            // 
            this.AcceptButton = this.button保存;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 201);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button保存);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormZheKou";
            this.Text = "进货折扣";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormZheKou_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button保存;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private numericTextBox numericTextBox1;
    }
}