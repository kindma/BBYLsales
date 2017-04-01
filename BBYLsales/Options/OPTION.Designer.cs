namespace BBYLsales
{
    partial class OPTION
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.buttonCharge = new System.Windows.Forms.Button();
            this.buttonSeason = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonStockAdjustReson = new System.Windows.Forms.Button();
            this.buttonClothSize = new System.Windows.Forms.Button();
            this.buttonClothType = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.buttonLock = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.buttonClass);
            this.groupBox1.Controls.Add(this.buttonCharge);
            this.groupBox1.Controls.Add(this.buttonSeason);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.buttonLock);
            this.groupBox1.Controls.Add(this.buttonStockAdjustReson);
            this.groupBox1.Controls.Add(this.buttonClothSize);
            this.groupBox1.Controls.Add(this.buttonClothType);
            this.groupBox1.Controls.Add(this.btnColor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(719, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(12, 434);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(101, 32);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "关 闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClass
            // 
            this.buttonClass.Location = new System.Drawing.Point(12, 53);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(101, 32);
            this.buttonClass.TabIndex = 0;
            this.buttonClass.Text = "品牌管理";
            this.buttonClass.UseVisualStyleBackColor = true;
            this.buttonClass.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCharge
            // 
            this.buttonCharge.Location = new System.Drawing.Point(12, 258);
            this.buttonCharge.Name = "buttonCharge";
            this.buttonCharge.Size = new System.Drawing.Size(101, 32);
            this.buttonCharge.TabIndex = 0;
            this.buttonCharge.Text = "费用收支类型";
            this.buttonCharge.UseVisualStyleBackColor = true;
            this.buttonCharge.Click += new System.EventHandler(this.buttonCharge_Click);
            // 
            // buttonSeason
            // 
            this.buttonSeason.Location = new System.Drawing.Point(12, 217);
            this.buttonSeason.Name = "buttonSeason";
            this.buttonSeason.Size = new System.Drawing.Size(101, 32);
            this.buttonSeason.TabIndex = 0;
            this.buttonSeason.Text = "季节管理";
            this.buttonSeason.UseVisualStyleBackColor = true;
            this.buttonSeason.Click += new System.EventHandler(this.buttonSeason_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 32);
            this.button5.TabIndex = 0;
            this.button5.Text = "用户管理";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonStockAdjustReson
            // 
            this.buttonStockAdjustReson.Location = new System.Drawing.Point(12, 299);
            this.buttonStockAdjustReson.Name = "buttonStockAdjustReson";
            this.buttonStockAdjustReson.Size = new System.Drawing.Size(101, 32);
            this.buttonStockAdjustReson.TabIndex = 0;
            this.buttonStockAdjustReson.Text = "库存调整理由";
            this.buttonStockAdjustReson.UseVisualStyleBackColor = true;
            this.buttonStockAdjustReson.Click += new System.EventHandler(this.buttonStockAdjustReson_Click);
            // 
            // buttonClothSize
            // 
            this.buttonClothSize.Location = new System.Drawing.Point(12, 176);
            this.buttonClothSize.Name = "buttonClothSize";
            this.buttonClothSize.Size = new System.Drawing.Size(101, 32);
            this.buttonClothSize.TabIndex = 0;
            this.buttonClothSize.Text = "尺寸表";
            this.buttonClothSize.UseVisualStyleBackColor = true;
            this.buttonClothSize.Click += new System.EventHandler(this.buttonClothSize_Click);
            // 
            // buttonClothType
            // 
            this.buttonClothType.Location = new System.Drawing.Point(12, 135);
            this.buttonClothType.Name = "buttonClothType";
            this.buttonClothType.Size = new System.Drawing.Size(101, 32);
            this.buttonClothType.TabIndex = 0;
            this.buttonClothType.Text = "服装类型";
            this.buttonClothType.UseVisualStyleBackColor = true;
            this.buttonClothType.Click += new System.EventHandler(this.buttonClothType_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 94);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(101, 32);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "颜色管理";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(12, 395);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(101, 32);
            this.buttonLock.TabIndex = 0;
            this.buttonLock.Text = "锁定当前数据";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // OPTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(844, 535);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OPTION";
            this.ShowInTaskbar = false;
            this.Text = "系统管理";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStockAdjustReson;
        private System.Windows.Forms.Button buttonClothSize;
        private System.Windows.Forms.Button buttonClothType;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button buttonCharge;
        private System.Windows.Forms.Button buttonSeason;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClass;
        private System.Windows.Forms.Button buttonLock;
    }
}