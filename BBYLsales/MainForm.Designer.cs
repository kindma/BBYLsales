namespace BBYLsales
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOption = new System.Windows.Forms.Button();
            this.button备份 = new System.Windows.Forms.Button();
            this.buttonChargs = new System.Windows.Forms.Button();
            this.buttonSalesCout = new System.Windows.Forms.Button();
            this.buttonStockCount = new System.Windows.Forms.Button();
            this.buttonStockAdjust = new System.Windows.Forms.Button();
            this.buttonInOut = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.statusStripThis = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip状态栏 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStripThis.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonOption);
            this.groupBox1.Controls.Add(this.button备份);
            this.groupBox1.Controls.Add(this.buttonChargs);
            this.groupBox1.Controls.Add(this.buttonSalesCout);
            this.groupBox1.Controls.Add(this.buttonStockCount);
            this.groupBox1.Controls.Add(this.buttonStockAdjust);
            this.groupBox1.Controls.Add(this.buttonInOut);
            this.groupBox1.Controls.Add(this.buttonSales);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 656);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "V20120222";
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.Location = new System.Drawing.Point(7, 542);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(105, 80);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "退出";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOption
            // 
            this.buttonOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOption.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOption.Image = ((System.Drawing.Image)(resources.GetObject("buttonOption.Image")));
            this.buttonOption.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOption.Location = new System.Drawing.Point(6, 463);
            this.buttonOption.Name = "buttonOption";
            this.buttonOption.Size = new System.Drawing.Size(106, 73);
            this.buttonOption.TabIndex = 0;
            this.buttonOption.Text = "系统选项";
            this.buttonOption.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOption.UseVisualStyleBackColor = true;
            this.buttonOption.Visible = false;
            this.buttonOption.Click += new System.EventHandler(this.button8_Click);
            // 
            // button备份
            // 
            this.button备份.Image = ((System.Drawing.Image)(resources.GetObject("button备份.Image")));
            this.button备份.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button备份.Location = new System.Drawing.Point(2, 371);
            this.button备份.Name = "button备份";
            this.button备份.Size = new System.Drawing.Size(110, 55);
            this.button备份.TabIndex = 0;
            this.button备份.Text = "数据备份";
            this.button备份.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button备份.UseVisualStyleBackColor = true;
            this.button备份.Click += new System.EventHandler(this.buttonBackUP_Click);
            // 
            // buttonChargs
            // 
            this.buttonChargs.Image = ((System.Drawing.Image)(resources.GetObject("buttonChargs.Image")));
            this.buttonChargs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChargs.Location = new System.Drawing.Point(4, 310);
            this.buttonChargs.Name = "buttonChargs";
            this.buttonChargs.Size = new System.Drawing.Size(110, 55);
            this.buttonChargs.TabIndex = 0;
            this.buttonChargs.Text = "费用管理";
            this.buttonChargs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChargs.UseVisualStyleBackColor = true;
            this.buttonChargs.Click += new System.EventHandler(this.buttonChargs_Click);
            // 
            // buttonSalesCout
            // 
            this.buttonSalesCout.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalesCout.Image")));
            this.buttonSalesCout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalesCout.Location = new System.Drawing.Point(4, 251);
            this.buttonSalesCout.Name = "buttonSalesCout";
            this.buttonSalesCout.Size = new System.Drawing.Size(110, 55);
            this.buttonSalesCout.TabIndex = 0;
            this.buttonSalesCout.Text = "进销统计";
            this.buttonSalesCout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalesCout.UseVisualStyleBackColor = true;
            this.buttonSalesCout.Click += new System.EventHandler(this.buttonSalesCout_Click);
            // 
            // buttonStockCount
            // 
            this.buttonStockCount.Image = ((System.Drawing.Image)(resources.GetObject("buttonStockCount.Image")));
            this.buttonStockCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStockCount.Location = new System.Drawing.Point(4, 192);
            this.buttonStockCount.Name = "buttonStockCount";
            this.buttonStockCount.Size = new System.Drawing.Size(110, 55);
            this.buttonStockCount.TabIndex = 0;
            this.buttonStockCount.Text = "库存查看";
            this.buttonStockCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStockCount.UseVisualStyleBackColor = true;
            this.buttonStockCount.Click += new System.EventHandler(this.buttonStockCount_Click);
            // 
            // buttonStockAdjust
            // 
            this.buttonStockAdjust.Image = ((System.Drawing.Image)(resources.GetObject("buttonStockAdjust.Image")));
            this.buttonStockAdjust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStockAdjust.Location = new System.Drawing.Point(4, 133);
            this.buttonStockAdjust.Name = "buttonStockAdjust";
            this.buttonStockAdjust.Size = new System.Drawing.Size(110, 55);
            this.buttonStockAdjust.TabIndex = 0;
            this.buttonStockAdjust.Text = "进库出库";
            this.buttonStockAdjust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonStockAdjust, "如快递，调货，赠送，返厂等\r\n");
            this.buttonStockAdjust.UseVisualStyleBackColor = true;
            this.buttonStockAdjust.Click += new System.EventHandler(this.buttonStockAdjust_Click);
            // 
            // buttonInOut
            // 
            this.buttonInOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonInOut.Image")));
            this.buttonInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInOut.Location = new System.Drawing.Point(4, 15);
            this.buttonInOut.Name = "buttonInOut";
            this.buttonInOut.Size = new System.Drawing.Size(110, 55);
            this.buttonInOut.TabIndex = 0;
            this.buttonInOut.Text = "进货入库";
            this.buttonInOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInOut.UseVisualStyleBackColor = true;
            this.buttonInOut.Click += new System.EventHandler(this.buttonInOut_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Image = ((System.Drawing.Image)(resources.GetObject("buttonSales.Image")));
            this.buttonSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSales.Location = new System.Drawing.Point(4, 74);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(110, 55);
            this.buttonSales.TabIndex = 0;
            this.buttonSales.Text = "销售.退货";
            this.buttonSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // statusStripThis
            // 
            this.statusStripThis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStrip状态栏});
            this.statusStripThis.Location = new System.Drawing.Point(118, 634);
            this.statusStripThis.Name = "statusStripThis";
            this.statusStripThis.Size = new System.Drawing.Size(861, 22);
            this.statusStripThis.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip状态栏
            // 
            this.toolStrip状态栏.Name = "toolStrip状态栏";
            this.toolStrip状态栏.Size = new System.Drawing.Size(23, 17);
            this.toolStrip状态栏.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(979, 656);
            this.Controls.Add(this.statusStripThis);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "服装销售管理软件门店版";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStripThis.ResumeLayout(false);
            this.statusStripThis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonChargs;
        private System.Windows.Forms.Button buttonSalesCout;
        private System.Windows.Forms.Button buttonStockCount;
        private System.Windows.Forms.Button buttonStockAdjust;
        private System.Windows.Forms.Button buttonInOut;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonOption;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.StatusStrip statusStripThis;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripStatusLabel toolStrip状态栏;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button备份;
    }
}

