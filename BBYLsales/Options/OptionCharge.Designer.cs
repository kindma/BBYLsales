namespace BBYLsales.Options
{
    partial class OptionCharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionCharge));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.f_S_PENDTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.CheckBoxAllowModify = new System.Windows.Forms.CheckBox();
            this.f_S_PENDTYPETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_PENDTYPETableAdapter();
            this.tableAdapterManager = new BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager();
            this.f_S_PENDTYPEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.f_S_PENDTYPEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.f_S_PENDTYPEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_PENDTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_PENDTYPEBindingNavigator)).BeginInit();
            this.f_S_PENDTYPEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_PENDTYPEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "收支理由:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_S_PENDTYPEBindingSource, "支出理由", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(76, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 23);
            this.textBox1.TabIndex = 3;
            // 
            // f_S_PENDTYPEBindingSource
            // 
            this.f_S_PENDTYPEBindingSource.DataMember = "F_S_PENDTYPE";
            this.f_S_PENDTYPEBindingSource.DataSource = this.saleDataSetAll;
            this.f_S_PENDTYPEBindingSource.CurrentChanged += new System.EventHandler(this.f_S_PENDTYPEBindingSource_CurrentChanged);
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CheckBoxAllowModify
            // 
            this.CheckBoxAllowModify.AutoSize = true;
            this.CheckBoxAllowModify.Location = new System.Drawing.Point(611, 40);
            this.CheckBoxAllowModify.Name = "CheckBoxAllowModify";
            this.CheckBoxAllowModify.Size = new System.Drawing.Size(82, 18);
            this.CheckBoxAllowModify.TabIndex = 5;
            this.CheckBoxAllowModify.Text = "允许修改";
            this.CheckBoxAllowModify.UseVisualStyleBackColor = true;
            this.CheckBoxAllowModify.CheckedChanged += new System.EventHandler(this.CheckBoxAllowModify_CheckedChanged);
            // 
            // f_S_PENDTYPETableAdapter
            // 
            this.f_S_PENDTYPETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.F_CLASSTableAdapter = null;
            this.tableAdapterManager.F_INCOMETableAdapter = null;
            this.tableAdapterManager.F_KCTZTableAdapter = null;
            this.tableAdapterManager.F_PENDTableAdapter = null;
            this.tableAdapterManager.F_S_CLOTHTYPETableAdapter = null;
            this.tableAdapterManager.F_S_COLORTableAdapter = null;
            this.tableAdapterManager.F_S_KCTZTYPETableAdapter = null;
            this.tableAdapterManager.F_S_PENDTYPETableAdapter = this.f_S_PENDTYPETableAdapter;
            this.tableAdapterManager.F_S_SEASONTableAdapter = null;
            this.tableAdapterManager.F_S_SIZETableAdapter = null;
            this.tableAdapterManager.F_S_USERTableAdapter = null;
            this.tableAdapterManager.F_SALETableAdapter = null;
            this.tableAdapterManager.F_VIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // f_S_PENDTYPEBindingNavigator
            // 
            this.f_S_PENDTYPEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.f_S_PENDTYPEBindingNavigator.BindingSource = this.f_S_PENDTYPEBindingSource;
            this.f_S_PENDTYPEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.f_S_PENDTYPEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.f_S_PENDTYPEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.f_S_PENDTYPEBindingNavigatorSaveItem});
            this.f_S_PENDTYPEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.f_S_PENDTYPEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.f_S_PENDTYPEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.f_S_PENDTYPEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.f_S_PENDTYPEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.f_S_PENDTYPEBindingNavigator.Name = "f_S_PENDTYPEBindingNavigator";
            this.f_S_PENDTYPEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.f_S_PENDTYPEBindingNavigator.Size = new System.Drawing.Size(773, 25);
            this.f_S_PENDTYPEBindingNavigator.TabIndex = 6;
            this.f_S_PENDTYPEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(49, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(49, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // f_S_PENDTYPEBindingNavigatorSaveItem
            // 
            this.f_S_PENDTYPEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("f_S_PENDTYPEBindingNavigatorSaveItem.Image")));
            this.f_S_PENDTYPEBindingNavigatorSaveItem.Name = "f_S_PENDTYPEBindingNavigatorSaveItem";
            this.f_S_PENDTYPEBindingNavigatorSaveItem.Size = new System.Drawing.Size(73, 22);
            this.f_S_PENDTYPEBindingNavigatorSaveItem.Text = "保存数据";
            this.f_S_PENDTYPEBindingNavigatorSaveItem.Click += new System.EventHandler(this.f_S_PENDTYPEBindingNavigatorSaveItem_Click_1);
            // 
            // f_S_PENDTYPEDataGridView
            // 
            this.f_S_PENDTYPEDataGridView.AutoGenerateColumns = false;
            this.f_S_PENDTYPEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f_S_PENDTYPEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.f_S_PENDTYPEDataGridView.DataSource = this.f_S_PENDTYPEBindingSource;
            this.f_S_PENDTYPEDataGridView.Location = new System.Drawing.Point(12, 67);
            this.f_S_PENDTYPEDataGridView.Name = "f_S_PENDTYPEDataGridView";
            this.f_S_PENDTYPEDataGridView.RowTemplate.Height = 23;
            this.f_S_PENDTYPEDataGridView.Size = new System.Drawing.Size(749, 386);
            this.f_S_PENDTYPEDataGridView.TabIndex = 6;
            this.f_S_PENDTYPEDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.f_S_PENDTYPEDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "支出理由";
            this.dataGridViewTextBoxColumn3.HeaderText = "支出理由";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 450;
            // 
            // OptionCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(773, 465);
            this.Controls.Add(this.f_S_PENDTYPEDataGridView);
            this.Controls.Add(this.f_S_PENDTYPEBindingNavigator);
            this.Controls.Add(this.CheckBoxAllowModify);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "OptionCharge";
            this.Text = "费用收支";
            this.Load += new System.EventHandler(this.OptionCharge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f_S_PENDTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_PENDTYPEBindingNavigator)).EndInit();
            this.f_S_PENDTYPEBindingNavigator.ResumeLayout(false);
            this.f_S_PENDTYPEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_PENDTYPEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox CheckBoxAllowModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource f_S_PENDTYPEBindingSource;
        private saleDataSetAllTableAdapters.F_S_PENDTYPETableAdapter f_S_PENDTYPETableAdapter;
        private saleDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator f_S_PENDTYPEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton f_S_PENDTYPEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView f_S_PENDTYPEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    }
}
