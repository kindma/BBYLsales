namespace BBYLsales
{
    partial class FormCount
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.f_SALEDataGridView = new System.Windows.Forms.DataGridView();
            this.进销 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.毛利 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label总件数 = new System.Windows.Forms.Label();
            this.label总毛利 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.颜色 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fSCOLORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.尺码 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fSSIZEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.销量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.活动优惠 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fVIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.销售员 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fSUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.开票价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_SALEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager();
            this.f_S_COLORTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_COLORTableAdapter();
            this.f_S_SIZETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_SIZETableAdapter();
            this.f_S_USERTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_USERTableAdapter();
            this.f_SALETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_SALETableAdapter();
            this.f_VIPTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_VIPTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_SALEDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSCOLORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSIZEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fVIPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_SALEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 56);
            this.panel1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(456, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(127, 21);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 21);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "进销统计";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "结束时间:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "起始时间:";
            // 
            // f_SALEDataGridView
            // 
            this.f_SALEDataGridView.AllowUserToAddRows = false;
            this.f_SALEDataGridView.AllowUserToDeleteRows = false;
            this.f_SALEDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f_SALEDataGridView.AutoGenerateColumns = false;
            this.f_SALEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f_SALEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.进销,
            this.销售日期,
            this.货号,
            this.颜色,
            this.尺码,
            this.销量,
            this.活动优惠,
            this.销售员,
            this.开票价,
            this.成本价,
            this.毛利});
            this.f_SALEDataGridView.DataSource = this.f_SALEBindingSource;
            this.f_SALEDataGridView.Location = new System.Drawing.Point(0, 56);
            this.f_SALEDataGridView.MultiSelect = false;
            this.f_SALEDataGridView.Name = "f_SALEDataGridView";
            this.f_SALEDataGridView.ReadOnly = true;
            this.f_SALEDataGridView.RowHeadersVisible = false;
            this.f_SALEDataGridView.RowTemplate.Height = 23;
            this.f_SALEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.f_SALEDataGridView.Size = new System.Drawing.Size(825, 405);
            this.f_SALEDataGridView.TabIndex = 5;
            this.f_SALEDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.f_SALEDataGridView_DataBindingComplete);
            // 
            // 进销
            // 
            this.进销.HeaderText = "进销";
            this.进销.Name = "进销";
            this.进销.ReadOnly = true;
            this.进销.Width = 60;
            // 
            // 成本价
            // 
            this.成本价.HeaderText = "成本价";
            this.成本价.Name = "成本价";
            this.成本价.ReadOnly = true;
            this.成本价.Width = 70;
            // 
            // 毛利
            // 
            this.毛利.HeaderText = "毛利";
            this.毛利.Name = "毛利";
            this.毛利.ReadOnly = true;
            this.毛利.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "总件数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "总毛利:";
            // 
            // label总件数
            // 
            this.label总件数.AutoSize = true;
            this.label总件数.Location = new System.Drawing.Point(55, 23);
            this.label总件数.Name = "label总件数";
            this.label总件数.Size = new System.Drawing.Size(11, 12);
            this.label总件数.TabIndex = 6;
            this.label总件数.Text = "0";
            // 
            // label总毛利
            // 
            this.label总毛利.AutoSize = true;
            this.label总毛利.Location = new System.Drawing.Point(179, 23);
            this.label总毛利.Name = "label总毛利";
            this.label总毛利.Size = new System.Drawing.Size(11, 12);
            this.label总毛利.TabIndex = 6;
            this.label总毛利.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label总件数);
            this.groupBox1.Controls.Add(this.label总毛利);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 56);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // 销售日期
            // 
            this.销售日期.DataPropertyName = "销售日期";
            this.销售日期.HeaderText = "日期";
            this.销售日期.Name = "销售日期";
            this.销售日期.ReadOnly = true;
            this.销售日期.Width = 80;
            // 
            // 货号
            // 
            this.货号.DataPropertyName = "货号";
            this.货号.HeaderText = "货号";
            this.货号.Name = "货号";
            this.货号.ReadOnly = true;
            this.货号.Width = 70;
            // 
            // 颜色
            // 
            this.颜色.DataPropertyName = "颜色";
            this.颜色.DataSource = this.fSCOLORBindingSource;
            this.颜色.DisplayMember = "颜色";
            this.颜色.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.颜色.HeaderText = "颜色";
            this.颜色.Name = "颜色";
            this.颜色.ReadOnly = true;
            this.颜色.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.颜色.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.颜色.ValueMember = "ID";
            this.颜色.Width = 70;
            // 
            // fSCOLORBindingSource
            // 
            this.fSCOLORBindingSource.DataMember = "F_S_COLOR";
            this.fSCOLORBindingSource.DataSource = this.saleDataSetAll;
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 尺码
            // 
            this.尺码.DataPropertyName = "尺码";
            this.尺码.DataSource = this.fSSIZEBindingSource;
            this.尺码.DisplayMember = "尺寸";
            this.尺码.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.尺码.HeaderText = "尺码";
            this.尺码.Name = "尺码";
            this.尺码.ReadOnly = true;
            this.尺码.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.尺码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.尺码.ValueMember = "id";
            this.尺码.Width = 70;
            // 
            // fSSIZEBindingSource
            // 
            this.fSSIZEBindingSource.DataMember = "F_S_SIZE";
            this.fSSIZEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // 销量
            // 
            this.销量.DataPropertyName = "数量";
            this.销量.HeaderText = "数量";
            this.销量.Name = "销量";
            this.销量.ReadOnly = true;
            this.销量.Width = 70;
            // 
            // 活动优惠
            // 
            this.活动优惠.DataPropertyName = "活动优惠";
            this.活动优惠.DataSource = this.fVIPBindingSource;
            this.活动优惠.DisplayMember = "优惠名称";
            this.活动优惠.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.活动优惠.HeaderText = "活动优惠";
            this.活动优惠.Name = "活动优惠";
            this.活动优惠.ReadOnly = true;
            this.活动优惠.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.活动优惠.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.活动优惠.ValueMember = "ID";
            // 
            // fVIPBindingSource
            // 
            this.fVIPBindingSource.DataMember = "F_VIP";
            this.fVIPBindingSource.DataSource = this.saleDataSetAll;
            // 
            // 销售员
            // 
            this.销售员.DataPropertyName = "销售员";
            this.销售员.DataSource = this.fSUSERBindingSource;
            this.销售员.DisplayMember = "名称";
            this.销售员.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.销售员.HeaderText = "销售员";
            this.销售员.Name = "销售员";
            this.销售员.ReadOnly = true;
            this.销售员.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.销售员.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.销售员.ValueMember = "id";
            this.销售员.Width = 70;
            // 
            // fSUSERBindingSource
            // 
            this.fSUSERBindingSource.DataMember = "F_S_USER";
            this.fSUSERBindingSource.DataSource = this.saleDataSetAll;
            // 
            // 开票价
            // 
            this.开票价.DataPropertyName = "开票价";
            this.开票价.HeaderText = "开票价";
            this.开票价.Name = "开票价";
            this.开票价.ReadOnly = true;
            this.开票价.Width = 70;
            // 
            // f_SALEBindingSource
            // 
            this.f_SALEBindingSource.DataMember = "F_SALE";
            this.f_SALEBindingSource.DataSource = this.saleDataSetAll;
            this.f_SALEBindingSource.Sort = "";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.F_CLASSTableAdapter = null;
            this.tableAdapterManager.F_INCOMETableAdapter = null;
            this.tableAdapterManager.F_KCTZTableAdapter = null;
            this.tableAdapterManager.F_PENDTableAdapter = null;
            this.tableAdapterManager.F_S_CLOTHTYPETableAdapter = null;
            this.tableAdapterManager.F_S_COLORTableAdapter = this.f_S_COLORTableAdapter;
            this.tableAdapterManager.F_S_KCTZTYPETableAdapter = null;
            this.tableAdapterManager.F_S_PENDTYPETableAdapter = null;
            this.tableAdapterManager.F_S_SEASONTableAdapter = null;
            this.tableAdapterManager.F_S_SIZETableAdapter = this.f_S_SIZETableAdapter;
            this.tableAdapterManager.F_S_USERTableAdapter = this.f_S_USERTableAdapter;
            this.tableAdapterManager.F_SALETableAdapter = this.f_SALETableAdapter;
            this.tableAdapterManager.F_STOCKSTableAdapter = null;
            this.tableAdapterManager.F_VIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // f_S_COLORTableAdapter
            // 
            this.f_S_COLORTableAdapter.ClearBeforeFill = true;
            // 
            // f_S_SIZETableAdapter
            // 
            this.f_S_SIZETableAdapter.ClearBeforeFill = true;
            // 
            // f_S_USERTableAdapter
            // 
            this.f_S_USERTableAdapter.ClearBeforeFill = true;
            // 
            // f_SALETableAdapter
            // 
            this.f_SALETableAdapter.ClearBeforeFill = true;
            // 
            // f_VIPTableAdapter
            // 
            this.f_VIPTableAdapter.ClearBeforeFill = true;
            // 
            // FormCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.f_SALEDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FormCount";
            this.Text = "FormCount";
            this.Load += new System.EventHandler(this.FormCount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_SALEDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSCOLORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSIZEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fVIPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_SALEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource fSCOLORBindingSource;
        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource fSSIZEBindingSource;
        private System.Windows.Forms.BindingSource fVIPBindingSource;
        private System.Windows.Forms.BindingSource fSUSERBindingSource;
        private System.Windows.Forms.BindingSource f_SALEBindingSource;
        private saleDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private saleDataSetAllTableAdapters.F_S_COLORTableAdapter f_S_COLORTableAdapter;
        private saleDataSetAllTableAdapters.F_S_SIZETableAdapter f_S_SIZETableAdapter;
        private saleDataSetAllTableAdapters.F_S_USERTableAdapter f_S_USERTableAdapter;
        private saleDataSetAllTableAdapters.F_SALETableAdapter f_SALETableAdapter;
        private saleDataSetAllTableAdapters.F_VIPTableAdapter f_VIPTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView f_SALEDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label总件数;
        private System.Windows.Forms.Label label总毛利;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进销;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货号;
        private System.Windows.Forms.DataGridViewComboBoxColumn 颜色;
        private System.Windows.Forms.DataGridViewComboBoxColumn 尺码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销量;
        private System.Windows.Forms.DataGridViewComboBoxColumn 活动优惠;
        private System.Windows.Forms.DataGridViewComboBoxColumn 销售员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开票价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 毛利;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}