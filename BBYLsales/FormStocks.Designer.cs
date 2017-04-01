namespace BBYLsales
{
    partial class FormStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStocks));
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.f_STOCKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_STOCKSTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_STOCKSTableAdapter();
            this.tableAdapterManager = new BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager();
            this.f_STOCKSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextbox品牌 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel类型 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextbox类型 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton显示全部 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton盘库存 = new System.Windows.Forms.ToolStripButton();
            this.f_STOCKSDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.颜色 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fSCOLORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.尺码 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fSSIZEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.类型 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fSCLOTHTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.品牌 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fCLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.季节 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fSSEASONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.库存量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSTOCKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_S_COLORTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_COLORTableAdapter();
            this.f_S_SIZETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_SIZETableAdapter();
            this.f_S_CLOTHTYPETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_CLOTHTYPETableAdapter();
            this.f_CLASSTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_CLASSTableAdapter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox品牌 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.f_S_SEASONTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_SEASONTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCountall = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_STOCKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_STOCKSBindingNavigator)).BeginInit();
            this.f_STOCKSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_STOCKSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCOLORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSIZEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCLOTHTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fCLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSEASONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSTOCKSBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_STOCKSBindingSource
            // 
            this.f_STOCKSBindingSource.DataSource = this.saleDataSetAll;
            this.f_STOCKSBindingSource.Position = 0;
            this.f_STOCKSBindingSource.Sort = "";
            // 
            // f_STOCKSTableAdapter
            // 
            this.f_STOCKSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.F_CLASSTableAdapter = null;
            this.tableAdapterManager.F_INCOMETableAdapter = null;
            this.tableAdapterManager.F_KCTZTableAdapter = null;
            this.tableAdapterManager.F_PENDTableAdapter = null;
            this.tableAdapterManager.F_S_CLOTHTYPETableAdapter = null;
            this.tableAdapterManager.F_S_COLORTableAdapter = null;
            this.tableAdapterManager.F_S_KCTZTYPETableAdapter = null;
            this.tableAdapterManager.F_S_PENDTYPETableAdapter = null;
            this.tableAdapterManager.F_S_SEASONTableAdapter = null;
            this.tableAdapterManager.F_S_SIZETableAdapter = null;
            this.tableAdapterManager.F_S_USERTableAdapter = null;
            this.tableAdapterManager.F_SALETableAdapter = null;
            this.tableAdapterManager.F_STOCKSCOUNTTableAdapter = null;
            this.tableAdapterManager.F_STOCKSTableAdapter = null;
            this.tableAdapterManager.F_VIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // f_STOCKSBindingNavigator
            // 
            this.f_STOCKSBindingNavigator.AddNewItem = null;
            this.f_STOCKSBindingNavigator.BindingSource = this.f_STOCKSBindingSource;
            this.f_STOCKSBindingNavigator.CountItem = null;
            this.f_STOCKSBindingNavigator.DeleteItem = null;
            this.f_STOCKSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.bindingNavigatorSeparator2,
            this.toolStripButton2,
            this.toolStripLabel2,
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextbox品牌,
            this.toolStripSeparator2,
            this.toolStripLabel类型,
            this.toolStripTextbox类型,
            this.toolStripSeparator3,
            this.toolStripButton显示全部,
            this.toolStripSeparator4,
            this.toolStripButton盘库存});
            this.f_STOCKSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.f_STOCKSBindingNavigator.MoveFirstItem = null;
            this.f_STOCKSBindingNavigator.MoveLastItem = null;
            this.f_STOCKSBindingNavigator.MoveNextItem = null;
            this.f_STOCKSBindingNavigator.MovePreviousItem = null;
            this.f_STOCKSBindingNavigator.Name = "f_STOCKSBindingNavigator";
            this.f_STOCKSBindingNavigator.PositionItem = null;
            this.f_STOCKSBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.f_STOCKSBindingNavigator.Size = new System.Drawing.Size(1033, 29);
            this.f_STOCKSBindingNavigator.TabIndex = 0;
            this.f_STOCKSBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("黑体", 16F);
            this.toolStripButton1.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(74, 26);
            this.toolStripButton1.Text = "库存";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 26);
            this.toolStripButton2.Text = "查找";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(103, 26);
            this.toolStripLabel2.Text = "货号(双击可清空):";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBox1.DoubleClick += new System.EventHandler(this.toolStripTextBox1_DoubleClick);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 26);
            this.toolStripLabel1.Text = "品牌:";
            // 
            // toolStripTextbox品牌
            // 
            this.toolStripTextbox品牌.Name = "toolStripTextbox品牌";
            this.toolStripTextbox品牌.Size = new System.Drawing.Size(121, 29);
            this.toolStripTextbox品牌.Click += new System.EventHandler(this.toolStripTextbox品牌_Click);
            this.toolStripTextbox品牌.DoubleClick += new System.EventHandler(this.toolStripTextbox品牌_DoubleClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripLabel类型
            // 
            this.toolStripLabel类型.Name = "toolStripLabel类型";
            this.toolStripLabel类型.Size = new System.Drawing.Size(35, 26);
            this.toolStripLabel类型.Text = "类型:";
            // 
            // toolStripTextbox类型
            // 
            this.toolStripTextbox类型.Name = "toolStripTextbox类型";
            this.toolStripTextbox类型.Size = new System.Drawing.Size(121, 29);
            this.toolStripTextbox类型.Click += new System.EventHandler(this.toolStripTextbox类型_Click);
            this.toolStripTextbox类型.DoubleClick += new System.EventHandler(this.toolStripTextbox类型_DoubleClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton显示全部
            // 
            this.toolStripButton显示全部.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton显示全部.Image")));
            this.toolStripButton显示全部.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton显示全部.Name = "toolStripButton显示全部";
            this.toolStripButton显示全部.Size = new System.Drawing.Size(76, 26);
            this.toolStripButton显示全部.Text = "显示全部";
            this.toolStripButton显示全部.Click += new System.EventHandler(this.toolStripButton显示全部_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton盘库存
            // 
            this.toolStripButton盘库存.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton盘库存.Image")));
            this.toolStripButton盘库存.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton盘库存.Name = "toolStripButton盘库存";
            this.toolStripButton盘库存.Size = new System.Drawing.Size(76, 26);
            this.toolStripButton盘库存.Text = "库存盘点";
            this.toolStripButton盘库存.Click += new System.EventHandler(this.toolStripButton盘库存_Click);
            // 
            // f_STOCKSDataGridView
            // 
            this.f_STOCKSDataGridView.AllowUserToAddRows = false;
            this.f_STOCKSDataGridView.AllowUserToDeleteRows = false;
            this.f_STOCKSDataGridView.AutoGenerateColumns = false;
            this.f_STOCKSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f_STOCKSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.货号,
            this.颜色,
            this.尺码,
            this.类型,
            this.品牌,
            this.季节,
            this.库存量});
            this.f_STOCKSDataGridView.DataSource = this.fSTOCKSBindingSource;
            this.f_STOCKSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_STOCKSDataGridView.Location = new System.Drawing.Point(0, 29);
            this.f_STOCKSDataGridView.Name = "f_STOCKSDataGridView";
            this.f_STOCKSDataGridView.ReadOnly = true;
            this.f_STOCKSDataGridView.RowTemplate.Height = 23;
            this.f_STOCKSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.f_STOCKSDataGridView.Size = new System.Drawing.Size(1033, 548);
            this.f_STOCKSDataGridView.TabIndex = 1;
            this.f_STOCKSDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.f_STOCKSDataGridView_DataBindingComplete);
            this.f_STOCKSDataGridView.Click += new System.EventHandler(this.f_STOCKSDataGridView_Click);
            this.f_STOCKSDataGridView.DoubleClick += new System.EventHandler(this.f_STOCKSDataGridView_DoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 货号
            // 
            this.货号.DataPropertyName = "货号";
            this.货号.HeaderText = "货号";
            this.货号.Name = "货号";
            this.货号.ReadOnly = true;
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
            // 
            // fSCOLORBindingSource
            // 
            this.fSCOLORBindingSource.DataMember = "F_S_COLOR";
            this.fSCOLORBindingSource.DataSource = this.saleDataSetAll;
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
            // 
            // fSSIZEBindingSource
            // 
            this.fSSIZEBindingSource.DataMember = "F_S_SIZE";
            this.fSSIZEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // 类型
            // 
            this.类型.DataPropertyName = "类型";
            this.类型.DataSource = this.fSCLOTHTYPEBindingSource;
            this.类型.DisplayMember = "类别";
            this.类型.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.类型.HeaderText = "类型";
            this.类型.Name = "类型";
            this.类型.ReadOnly = true;
            this.类型.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.类型.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.类型.ValueMember = "ID";
            // 
            // fSCLOTHTYPEBindingSource
            // 
            this.fSCLOTHTYPEBindingSource.DataMember = "F_S_CLOTHTYPE";
            this.fSCLOTHTYPEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // 品牌
            // 
            this.品牌.DataPropertyName = "品牌";
            this.品牌.DataSource = this.fCLASSBindingSource;
            this.品牌.DisplayMember = "品牌名称";
            this.品牌.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.品牌.HeaderText = "品牌";
            this.品牌.Name = "品牌";
            this.品牌.ReadOnly = true;
            this.品牌.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.品牌.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.品牌.ValueMember = "ID";
            // 
            // fCLASSBindingSource
            // 
            this.fCLASSBindingSource.DataMember = "F_CLASS";
            this.fCLASSBindingSource.DataSource = this.saleDataSetAll;
            // 
            // 季节
            // 
            this.季节.DataPropertyName = "季节";
            this.季节.DataSource = this.fSSEASONBindingSource;
            this.季节.DisplayMember = "季节名称";
            this.季节.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.季节.HeaderText = "季节";
            this.季节.Name = "季节";
            this.季节.ReadOnly = true;
            this.季节.ValueMember = "ID";
            // 
            // fSSEASONBindingSource
            // 
            this.fSSEASONBindingSource.DataMember = "F_S_SEASON";
            this.fSSEASONBindingSource.DataSource = this.saleDataSetAll;
            // 
            // 库存量
            // 
            this.库存量.DataPropertyName = "库存量";
            this.库存量.HeaderText = "库存量";
            this.库存量.Name = "库存量";
            this.库存量.ReadOnly = true;
            // 
            // fSTOCKSBindingSource
            // 
            this.fSTOCKSBindingSource.DataMember = "F_STOCKS";
            this.fSTOCKSBindingSource.DataSource = this.f_STOCKSBindingSource;
            // 
            // f_S_COLORTableAdapter
            // 
            this.f_S_COLORTableAdapter.ClearBeforeFill = true;
            // 
            // f_S_SIZETableAdapter
            // 
            this.f_S_SIZETableAdapter.ClearBeforeFill = true;
            // 
            // f_S_CLOTHTYPETableAdapter
            // 
            this.f_S_CLOTHTYPETableAdapter.ClearBeforeFill = true;
            // 
            // f_CLASSTableAdapter
            // 
            this.f_CLASSTableAdapter.ClearBeforeFill = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(552, 22);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(186, 310);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // listBox品牌
            // 
            this.listBox品牌.DataSource = this.fCLASSBindingSource;
            this.listBox品牌.DisplayMember = "品牌名称";
            this.listBox品牌.FormattingEnabled = true;
            this.listBox品牌.ItemHeight = 12;
            this.listBox品牌.Location = new System.Drawing.Point(389, 22);
            this.listBox品牌.Name = "listBox品牌";
            this.listBox品牌.Size = new System.Drawing.Size(122, 124);
            this.listBox品牌.TabIndex = 3;
            this.listBox品牌.ValueMember = "ID";
            this.listBox品牌.Click += new System.EventHandler(this.listBox品牌_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "双击显示详情";
            // 
            // f_S_SEASONTableAdapter
            // 
            this.f_S_SEASONTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCountall});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCountall
            // 
            this.toolStripStatusLabelCountall.Name = "toolStripStatusLabelCountall";
            this.toolStripStatusLabelCountall.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabelCountall.Text = "...";
            // 
            // FormStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 577);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox品牌);
            this.Controls.Add(this.f_STOCKSDataGridView);
            this.Controls.Add(this.f_STOCKSBindingNavigator);
            this.Name = "FormStocks";
            this.Text = "FormStocks";
            this.Activated += new System.EventHandler(this.FormStocks_Activated);
            this.Load += new System.EventHandler(this.FormStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_STOCKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_STOCKSBindingNavigator)).EndInit();
            this.f_STOCKSBindingNavigator.ResumeLayout(false);
            this.f_STOCKSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_STOCKSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCOLORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSIZEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCLOTHTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fCLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSEASONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSTOCKSBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource f_STOCKSBindingSource;
        private saleDataSetAllTableAdapters.F_STOCKSTableAdapter f_STOCKSTableAdapter;
        private saleDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator f_STOCKSBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView f_STOCKSDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel类型;
        private System.Windows.Forms.BindingSource fSTOCKSBindingSource;
        private System.Windows.Forms.BindingSource fSCOLORBindingSource;
        private saleDataSetAllTableAdapters.F_S_COLORTableAdapter f_S_COLORTableAdapter;
        private System.Windows.Forms.BindingSource fSSIZEBindingSource;
        private saleDataSetAllTableAdapters.F_S_SIZETableAdapter f_S_SIZETableAdapter;
        private System.Windows.Forms.BindingSource fSCLOTHTYPEBindingSource;
        private saleDataSetAllTableAdapters.F_S_CLOTHTYPETableAdapter f_S_CLOTHTYPETableAdapter;
        private System.Windows.Forms.BindingSource fCLASSBindingSource;
        private saleDataSetAllTableAdapters.F_CLASSTableAdapter f_CLASSTableAdapter;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextbox品牌;
        private System.Windows.Forms.ToolStripTextBox toolStripTextbox类型;
        private System.Windows.Forms.ListBox listBox品牌;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton显示全部;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource fSSEASONBindingSource;
        private saleDataSetAllTableAdapters.F_S_SEASONTableAdapter f_S_SEASONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货号;
        private System.Windows.Forms.DataGridViewComboBoxColumn 颜色;
        private System.Windows.Forms.DataGridViewComboBoxColumn 尺码;
        private System.Windows.Forms.DataGridViewComboBoxColumn 类型;
        private System.Windows.Forms.DataGridViewComboBoxColumn 品牌;
        private System.Windows.Forms.DataGridViewComboBoxColumn 季节;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存量;
        private System.Windows.Forms.ToolStripButton toolStripButton盘库存;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountall;
    }
}