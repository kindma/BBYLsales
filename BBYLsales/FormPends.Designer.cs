namespace BBYLsales
{
    partial class FormPends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPends));
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.f_PENDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_PENDTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_PENDTableAdapter();
            this.tableAdapterManager = new BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager();
            this.f_S_PENDTYPETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_PENDTYPETableAdapter();
            this.f_S_USERTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_USERTableAdapter();
            this.f_PENDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.fSPENDTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fSUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button保存 = new System.Windows.Forms.Button();
            this.comboBox录入人员 = new System.Windows.Forms.ComboBox();
            this.textBox备注 = new System.Windows.Forms.TextBox();
            this.comboBox收支类型 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox录入时间 = new System.Windows.Forms.TextBox();
            this.numericTextBox金额 = new BBYLsales.numericTextBox();
            this.dateTimePicker时间 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.f_PENDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_PENDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_PENDBindingNavigator)).BeginInit();
            this.f_PENDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSPENDTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSUSERBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_PENDDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_PENDBindingSource
            // 
            this.f_PENDBindingSource.DataMember = "F_PEND";
            this.f_PENDBindingSource.DataSource = this.saleDataSetAll;
            // 
            // f_PENDTableAdapter
            // 
            this.f_PENDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.F_CLASSTableAdapter = null;
            this.tableAdapterManager.F_INCOMETableAdapter = null;
            this.tableAdapterManager.F_KCTZTableAdapter = null;
            this.tableAdapterManager.F_PENDTableAdapter = this.f_PENDTableAdapter;
            this.tableAdapterManager.F_S_CLOTHTYPETableAdapter = null;
            this.tableAdapterManager.F_S_COLORTableAdapter = null;
            this.tableAdapterManager.F_S_KCTZTYPETableAdapter = null;
            this.tableAdapterManager.F_S_PENDTYPETableAdapter = this.f_S_PENDTYPETableAdapter;
            this.tableAdapterManager.F_S_SEASONTableAdapter = null;
            this.tableAdapterManager.F_S_SIZETableAdapter = null;
            this.tableAdapterManager.F_S_USERTableAdapter = this.f_S_USERTableAdapter;
            this.tableAdapterManager.F_SALETableAdapter = null;
            this.tableAdapterManager.F_STOCKSCOUNTTableAdapter = null;
            this.tableAdapterManager.F_STOCKSTableAdapter = null;
            this.tableAdapterManager.F_VIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // f_S_PENDTYPETableAdapter
            // 
            this.f_S_PENDTYPETableAdapter.ClearBeforeFill = true;
            // 
            // f_S_USERTableAdapter
            // 
            this.f_S_USERTableAdapter.ClearBeforeFill = true;
            // 
            // f_PENDBindingNavigator
            // 
            this.f_PENDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.f_PENDBindingNavigator.BindingSource = this.f_PENDBindingSource;
            this.f_PENDBindingNavigator.CountItem = null;
            this.f_PENDBindingNavigator.DeleteItem = null;
            this.f_PENDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.f_PENDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.f_PENDBindingNavigator.MoveFirstItem = null;
            this.f_PENDBindingNavigator.MoveLastItem = null;
            this.f_PENDBindingNavigator.MoveNextItem = null;
            this.f_PENDBindingNavigator.MovePreviousItem = null;
            this.f_PENDBindingNavigator.Name = "f_PENDBindingNavigator";
            this.f_PENDBindingNavigator.PositionItem = null;
            this.f_PENDBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.f_PENDBindingNavigator.Size = new System.Drawing.Size(956, 25);
            this.f_PENDBindingNavigator.TabIndex = 0;
            this.f_PENDBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(49, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(49, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(113, 22);
            this.toolStripLabel1.Text = "表格中双击可以修改";
            // 
            // fSPENDTYPEBindingSource
            // 
            this.fSPENDTYPEBindingSource.DataMember = "F_S_PENDTYPE";
            this.fSPENDTYPEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // fSUSERBindingSource
            // 
            this.fSUSERBindingSource.DataMember = "F_S_USER";
            this.fSUSERBindingSource.DataSource = this.saleDataSetAll;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button保存);
            this.groupBox1.Controls.Add(this.comboBox录入人员);
            this.groupBox1.Controls.Add(this.textBox备注);
            this.groupBox1.Controls.Add(this.comboBox收支类型);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox录入时间);
            this.groupBox1.Controls.Add(this.numericTextBox金额);
            this.groupBox1.Controls.Add(this.dateTimePicker时间);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加修改";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button保存
            // 
            this.button保存.Location = new System.Drawing.Point(760, 41);
            this.button保存.Name = "button保存";
            this.button保存.Size = new System.Drawing.Size(84, 49);
            this.button保存.TabIndex = 6;
            this.button保存.Text = "保存";
            this.button保存.UseVisualStyleBackColor = true;
            this.button保存.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox录入人员
            // 
            this.comboBox录入人员.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox录入人员.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.f_PENDBindingSource, "录入人员", true));
            this.comboBox录入人员.DataSource = this.fSUSERBindingSource;
            this.comboBox录入人员.DisplayMember = "名称";
            this.comboBox录入人员.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox录入人员.FormattingEnabled = true;
            this.comboBox录入人员.Location = new System.Drawing.Point(655, 72);
            this.comboBox录入人员.Name = "comboBox录入人员";
            this.comboBox录入人员.Size = new System.Drawing.Size(89, 18);
            this.comboBox录入人员.TabIndex = 5;
            this.comboBox录入人员.ValueMember = "id";
            this.comboBox录入人员.Enter += new System.EventHandler(this.焦点离开);
            // 
            // textBox备注
            // 
            this.textBox备注.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_PENDBindingSource, "备注", true));
            this.textBox备注.Location = new System.Drawing.Point(348, 20);
            this.textBox备注.Multiline = true;
            this.textBox备注.Name = "textBox备注";
            this.textBox备注.Size = new System.Drawing.Size(292, 74);
            this.textBox备注.TabIndex = 3;
            // 
            // comboBox收支类型
            // 
            this.comboBox收支类型.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.f_PENDBindingSource, "费用描述", true));
            this.comboBox收支类型.DataSource = this.fSPENDTYPEBindingSource;
            this.comboBox收支类型.DisplayMember = "支出理由";
            this.comboBox收支类型.FormattingEnabled = true;
            this.comboBox收支类型.Location = new System.Drawing.Point(76, 72);
            this.comboBox收支类型.Name = "comboBox收支类型";
            this.comboBox收支类型.Size = new System.Drawing.Size(236, 20);
            this.comboBox收支类型.TabIndex = 1;
            this.comboBox收支类型.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "收支类型:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "备注:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(151, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "注:支出添写负数,收入写正数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "金额:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "时间:";
            // 
            // textBox录入时间
            // 
            this.textBox录入时间.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox录入时间.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_PENDBindingSource, "录入时间", true));
            this.textBox录入时间.Location = new System.Drawing.Point(655, 41);
            this.textBox录入时间.Name = "textBox录入时间";
            this.textBox录入时间.Size = new System.Drawing.Size(89, 21);
            this.textBox录入时间.TabIndex = 3;
            this.textBox录入时间.Enter += new System.EventHandler(this.焦点离开);
            // 
            // numericTextBox金额
            // 
            this.numericTextBox金额.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_PENDBindingSource, "金额", true));
            this.numericTextBox金额.Location = new System.Drawing.Point(76, 46);
            this.numericTextBox金额.Name = "numericTextBox金额";
            this.numericTextBox金额.Size = new System.Drawing.Size(69, 21);
            this.numericTextBox金额.TabIndex = 2;
            // 
            // dateTimePicker时间
            // 
            this.dateTimePicker时间.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.f_PENDBindingSource, "支出时间", true));
            this.dateTimePicker时间.Location = new System.Drawing.Point(76, 20);
            this.dateTimePicker时间.Name = "dateTimePicker时间";
            this.dateTimePicker时间.Size = new System.Drawing.Size(224, 21);
            this.dateTimePicker时间.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 607);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "汇总:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(53, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // f_PENDDataGridView
            // 
            this.f_PENDDataGridView.AllowUserToAddRows = false;
            this.f_PENDDataGridView.AllowUserToDeleteRows = false;
            this.f_PENDDataGridView.AllowUserToResizeRows = false;
            this.f_PENDDataGridView.AutoGenerateColumns = false;
            this.f_PENDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f_PENDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.金额,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.f_PENDDataGridView.DataSource = this.f_PENDBindingSource;
            this.f_PENDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_PENDDataGridView.Location = new System.Drawing.Point(0, 125);
            this.f_PENDDataGridView.Name = "f_PENDDataGridView";
            this.f_PENDDataGridView.ReadOnly = true;
            this.f_PENDDataGridView.RowTemplate.Height = 23;
            this.f_PENDDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.f_PENDDataGridView.Size = new System.Drawing.Size(956, 482);
            this.f_PENDDataGridView.TabIndex = 5;
            this.f_PENDDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.f_PENDDataGridView_CellMouseDoubleClick);
            this.f_PENDDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.f_PENDDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "支出时间";
            this.dataGridViewTextBoxColumn3.HeaderText = "收付时间";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "费用描述";
            this.dataGridViewTextBoxColumn2.DataSource = this.fSPENDTYPEBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "支出理由";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "费用描述";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // 金额
            // 
            this.金额.DataPropertyName = "金额";
            this.金额.HeaderText = "金额";
            this.金额.Name = "金额";
            this.金额.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "录入时间";
            this.dataGridViewTextBoxColumn5.HeaderText = "录入时间";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "录入人员";
            this.dataGridViewTextBoxColumn6.DataSource = this.fSUSERBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "名称";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.HeaderText = "录入人员";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "备注";
            this.dataGridViewTextBoxColumn7.HeaderText = "备注";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 300;
            // 
            // FormPends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 663);
            this.Controls.Add(this.f_PENDDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.f_PENDBindingNavigator);
            this.Name = "FormPends";
            this.Text = "费用管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_PENDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_PENDBindingNavigator)).EndInit();
            this.f_PENDBindingNavigator.ResumeLayout(false);
            this.f_PENDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSPENDTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSUSERBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_PENDDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource f_PENDBindingSource;
        private saleDataSetAllTableAdapters.F_PENDTableAdapter f_PENDTableAdapter;
        private saleDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator f_PENDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private saleDataSetAllTableAdapters.F_S_PENDTYPETableAdapter f_S_PENDTYPETableAdapter;
        private System.Windows.Forms.BindingSource fSPENDTYPEBindingSource;
        private saleDataSetAllTableAdapters.F_S_USERTableAdapter f_S_USERTableAdapter;
        private System.Windows.Forms.BindingSource fSUSERBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox备注;
        private numericTextBox numericTextBox金额;
        private System.Windows.Forms.ComboBox comboBox收支类型;
        private System.Windows.Forms.DateTimePicker dateTimePicker时间;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox录入时间;
        private System.Windows.Forms.ComboBox comboBox录入人员;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button保存;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView f_PENDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}