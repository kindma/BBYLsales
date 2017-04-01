namespace BBYLsales
{
	partial class FormNewSale
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
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.f_SALETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_SALETableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox货号 = new System.Windows.Forms.TextBox();
            this.f_SALEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LABLE货号 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericTextBox数量 = new BBYLsales.numericTextBox();
            this.numericTextBox开票价 = new BBYLsales.numericTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fSCOLORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.fSSIZEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox优惠 = new System.Windows.Forms.ListBox();
            this.fVIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox销售员 = new System.Windows.Forms.ListBox();
            this.fSUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox录入人员 = new System.Windows.Forms.TextBox();
            this.textBox录入时间 = new System.Windows.Forms.TextBox();
            this.f_S_COLORTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_COLORTableAdapter();
            this.f_S_SIZETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_SIZETableAdapter();
            this.f_VIPTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_VIPTableAdapter();
            this.f_S_USERTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_USERTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager();
            this.StockDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.颜色 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.尺码 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fSCLOTHTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.品牌 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSTOCKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox颜色 = new System.Windows.Forms.ComboBox();
            this.comboBox尺码 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.f_STOCKSTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_STOCKSTableAdapter();
            this.f_S_CLOTHTYPETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_CLOTHTYPETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_SALEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCOLORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSIZEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fVIPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCLOTHTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSTOCKSBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_SALETableAdapter
            // 
            this.f_SALETableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox货号);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.LABLE货号);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 52);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "销售货号";
            // 
            // textBox货号
            // 
            this.textBox货号.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_SALEBindingSource, "货号", true));
            this.textBox货号.Location = new System.Drawing.Point(231, 20);
            this.textBox货号.Name = "textBox货号";
            this.textBox货号.Size = new System.Drawing.Size(125, 21);
            this.textBox货号.TabIndex = 1;
            this.textBox货号.TextChanged += new System.EventHandler(this.textBox货号_TextChanged);
            this.textBox货号.Leave += new System.EventHandler(this.textBox货号_Leave);
            // 
            // f_SALEBindingSource
            // 
            this.f_SALEBindingSource.DataMember = "F_SALE";
            this.f_SALEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.f_SALEBindingSource, "销售日期", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // LABLE货号
            // 
            this.LABLE货号.AutoSize = true;
            this.LABLE货号.Location = new System.Drawing.Point(198, 24);
            this.LABLE货号.Name = "LABLE货号";
            this.LABLE货号.Size = new System.Drawing.Size(35, 12);
            this.LABLE货号.TabIndex = 9;
            this.LABLE货号.Text = "货号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "销售日期:";
            // 
            // numericTextBox数量
            // 
            this.numericTextBox数量.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_SALEBindingSource, "数量", true));
            this.numericTextBox数量.Location = new System.Drawing.Point(208, 50);
            this.numericTextBox数量.Name = "numericTextBox数量";
            this.numericTextBox数量.Size = new System.Drawing.Size(75, 21);
            this.numericTextBox数量.TabIndex = 10;
            // 
            // numericTextBox开票价
            // 
            this.numericTextBox开票价.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_SALEBindingSource, "开票价", true));
            this.numericTextBox开票价.Location = new System.Drawing.Point(67, 49);
            this.numericTextBox开票价.Name = "numericTextBox开票价";
            this.numericTextBox开票价.Size = new System.Drawing.Size(75, 21);
            this.numericTextBox开票价.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "销售员:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "优惠:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_SALEBindingSource, "备注", true));
            this.textBox3.Location = new System.Drawing.Point(11, 22);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(317, 153);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "尺码:";
            // 
            // fSCOLORBindingSource
            // 
            this.fSCOLORBindingSource.DataMember = "F_S_COLOR";
            this.fSCOLORBindingSource.DataSource = this.saleDataSetAll;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "颜色:";
            // 
            // fSSIZEBindingSource
            // 
            this.fSSIZEBindingSource.DataMember = "F_S_SIZE";
            this.fSSIZEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "开票价:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "数量:";
            // 
            // listBox优惠
            // 
            this.listBox优惠.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.f_SALEBindingSource, "活动优惠", true));
            this.listBox优惠.DataSource = this.fVIPBindingSource;
            this.listBox优惠.DisplayMember = "优惠名称";
            this.listBox优惠.FormattingEnabled = true;
            this.listBox优惠.ItemHeight = 12;
            this.listBox优惠.Location = new System.Drawing.Point(205, 89);
            this.listBox优惠.Name = "listBox优惠";
            this.listBox优惠.Size = new System.Drawing.Size(123, 112);
            this.listBox优惠.TabIndex = 7;
            this.listBox优惠.ValueMember = "ID";
            // 
            // fVIPBindingSource
            // 
            this.fVIPBindingSource.DataMember = "F_VIP";
            this.fVIPBindingSource.DataSource = this.saleDataSetAll;
            // 
            // listBox销售员
            // 
            this.listBox销售员.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.f_SALEBindingSource, "销售员", true));
            this.listBox销售员.DataSource = this.fSUSERBindingSource;
            this.listBox销售员.DisplayMember = "名称";
            this.listBox销售员.FormattingEnabled = true;
            this.listBox销售员.ItemHeight = 12;
            this.listBox销售员.Location = new System.Drawing.Point(67, 89);
            this.listBox销售员.Name = "listBox销售员";
            this.listBox销售员.Size = new System.Drawing.Size(75, 112);
            this.listBox销售员.TabIndex = 8;
            this.listBox销售员.ValueMember = "id";
            // 
            // fSUSERBindingSource
            // 
            this.fSUSERBindingSource.DataMember = "F_S_USER";
            this.fSUSERBindingSource.DataSource = this.saleDataSetAll;
            // 
            // textBox录入人员
            // 
            this.textBox录入人员.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox录入人员.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_SALEBindingSource, "录入人员", true));
            this.textBox录入人员.Location = new System.Drawing.Point(520, 421);
            this.textBox录入人员.Name = "textBox录入人员";
            this.textBox录入人员.ReadOnly = true;
            this.textBox录入人员.Size = new System.Drawing.Size(100, 21);
            this.textBox录入人员.TabIndex = 20;
            // 
            // textBox录入时间
            // 
            this.textBox录入时间.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox录入时间.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_SALEBindingSource, "录入时间", true));
            this.textBox录入时间.Location = new System.Drawing.Point(615, 421);
            this.textBox录入时间.Name = "textBox录入时间";
            this.textBox录入时间.ReadOnly = true;
            this.textBox录入时间.Size = new System.Drawing.Size(100, 21);
            this.textBox录入时间.TabIndex = 19;
            // 
            // f_S_COLORTableAdapter
            // 
            this.f_S_COLORTableAdapter.ClearBeforeFill = true;
            // 
            // f_S_SIZETableAdapter
            // 
            this.f_S_SIZETableAdapter.ClearBeforeFill = true;
            // 
            // f_VIPTableAdapter
            // 
            this.f_VIPTableAdapter.ClearBeforeFill = true;
            // 
            // f_S_USERTableAdapter
            // 
            this.f_S_USERTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(553, 494);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.tableAdapterManager.F_VIPTableAdapter = this.f_VIPTableAdapter;
            this.tableAdapterManager.UpdateOrder = BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // StockDataGridView
            // 
            this.StockDataGridView.AllowUserToAddRows = false;
            this.StockDataGridView.AllowUserToDeleteRows = false;
            this.StockDataGridView.AllowUserToResizeRows = false;
            this.StockDataGridView.AutoGenerateColumns = false;
            this.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.货号,
            this.颜色,
            this.尺码,
            this.类型,
            this.品牌,
            this.库存量});
            this.StockDataGridView.DataSource = this.fSTOCKSBindingSource;
            this.StockDataGridView.Location = new System.Drawing.Point(8, 20);
            this.StockDataGridView.MultiSelect = false;
            this.StockDataGridView.Name = "StockDataGridView";
            this.StockDataGridView.ReadOnly = true;
            this.StockDataGridView.RowHeadersVisible = false;
            this.StockDataGridView.RowTemplate.Height = 23;
            this.StockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockDataGridView.Size = new System.Drawing.Size(408, 389);
            this.StockDataGridView.TabIndex = 9;
            this.StockDataGridView.SelectionChanged += new System.EventHandler(this.fmainProductStockDataGridView_SelectionChanged);
            this.StockDataGridView.Click += new System.EventHandler(this.fmainProductStockDataGridView_SelectionChanged);
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
            this.货号.Width = 80;
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
            this.颜色.Width = 80;
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
            this.尺码.Width = 80;
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
            this.类型.Width = 80;
            // 
            // fSCLOTHTYPEBindingSource
            // 
            this.fSCLOTHTYPEBindingSource.DataMember = "F_S_CLOTHTYPE";
            this.fSCLOTHTYPEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // 品牌
            // 
            this.品牌.DataPropertyName = "品牌";
            this.品牌.HeaderText = "品牌";
            this.品牌.Name = "品牌";
            this.品牌.ReadOnly = true;
            this.品牌.Visible = false;
            this.品牌.Width = 80;
            // 
            // 库存量
            // 
            this.库存量.DataPropertyName = "库存量";
            this.库存量.HeaderText = "库存量";
            this.库存量.Name = "库存量";
            this.库存量.ReadOnly = true;
            this.库存量.Width = 80;
            // 
            // fSTOCKSBindingSource
            // 
            this.fSTOCKSBindingSource.DataMember = "F_STOCKS";
            this.fSTOCKSBindingSource.DataSource = this.saleDataSetAll;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StockDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 420);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "库存表";
            // 
            // comboBox颜色
            // 
            this.comboBox颜色.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.f_SALEBindingSource, "颜色", true));
            this.comboBox颜色.DataSource = this.fSCOLORBindingSource;
            this.comboBox颜色.DisplayMember = "颜色";
            this.comboBox颜色.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox颜色.FormattingEnabled = true;
            this.comboBox颜色.Location = new System.Drawing.Point(67, 24);
            this.comboBox颜色.Name = "comboBox颜色";
            this.comboBox颜色.Size = new System.Drawing.Size(75, 20);
            this.comboBox颜色.TabIndex = 22;
            this.comboBox颜色.ValueMember = "ID";
            this.comboBox颜色.Enter += new System.EventHandler(this.comboBox颜色_Enter);
            // 
            // comboBox尺码
            // 
            this.comboBox尺码.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.f_SALEBindingSource, "尺码", true));
            this.comboBox尺码.DataSource = this.fSSIZEBindingSource;
            this.comboBox尺码.DisplayMember = "尺寸";
            this.comboBox尺码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox尺码.FormattingEnabled = true;
            this.comboBox尺码.Location = new System.Drawing.Point(208, 24);
            this.comboBox尺码.Name = "comboBox尺码";
            this.comboBox尺码.Size = new System.Drawing.Size(75, 20);
            this.comboBox尺码.TabIndex = 22;
            this.comboBox尺码.ValueMember = "id";
            this.comboBox尺码.Enter += new System.EventHandler(this.comboBox颜色_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericTextBox数量);
            this.groupBox3.Controls.Add(this.comboBox尺码);
            this.groupBox3.Controls.Add(this.comboBox颜色);
            this.groupBox3.Controls.Add(this.numericTextBox开票价);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.listBox优惠);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.listBox销售员);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(445, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 216);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "销售数据";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(445, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 186);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "备注";
            // 
            // f_STOCKSTableAdapter
            // 
            this.f_STOCKSTableAdapter.ClearBeforeFill = true;
            // 
            // f_S_CLOTHTYPETableAdapter
            // 
            this.f_S_CLOTHTYPETableAdapter.ClearBeforeFill = true;
            // 
            // FormNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 543);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox录入时间);
            this.Controls.Add(this.textBox录入人员);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewSale";
            this.Text = "新销售记录";
            this.Load += new System.EventHandler(this.FormNewSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_SALEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCOLORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSIZEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fVIPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCLOTHTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSTOCKSBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource f_SALEBindingSource;
        private saleDataSetAllTableAdapters.F_SALETableAdapter f_SALETableAdapter;
        private saleDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private numericTextBox numericTextBox开票价;
        private System.Windows.Forms.TextBox textBox货号;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LABLE货号;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox优惠;
        private System.Windows.Forms.ListBox listBox销售员;
        private System.Windows.Forms.BindingSource fSCOLORBindingSource;
        private saleDataSetAllTableAdapters.F_S_COLORTableAdapter f_S_COLORTableAdapter;
        private System.Windows.Forms.BindingSource fSSIZEBindingSource;
        private saleDataSetAllTableAdapters.F_S_SIZETableAdapter f_S_SIZETableAdapter;
        private System.Windows.Forms.BindingSource fVIPBindingSource;
        private saleDataSetAllTableAdapters.F_VIPTableAdapter f_VIPTableAdapter;
        private System.Windows.Forms.BindingSource fSUSERBindingSource;
        private saleDataSetAllTableAdapters.F_S_USERTableAdapter f_S_USERTableAdapter;
        private System.Windows.Forms.TextBox textBox录入时间;
        private System.Windows.Forms.TextBox textBox录入人员;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private numericTextBox numericTextBox数量;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView StockDataGridView;
        private System.Windows.Forms.ComboBox comboBox尺码;
        private System.Windows.Forms.ComboBox comboBox颜色;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource fSTOCKSBindingSource;
        private saleDataSetAllTableAdapters.F_STOCKSTableAdapter f_STOCKSTableAdapter;
        private System.Windows.Forms.BindingSource fSCLOTHTYPEBindingSource;
        private saleDataSetAllTableAdapters.F_S_CLOTHTYPETableAdapter f_S_CLOTHTYPETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货号;
        private System.Windows.Forms.DataGridViewComboBoxColumn 颜色;
        private System.Windows.Forms.DataGridViewComboBoxColumn 尺码;
        private System.Windows.Forms.DataGridViewComboBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存量;
	}
}