namespace BBYLsales.Options
{
    partial class OptionStockAdjustReason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionStockAdjustReason));
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.f_S_KCTZTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_S_KCTZTYPETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_KCTZTYPETableAdapter();
            this.tableAdapterManager = new BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager();
            this.f_S_KCTZTYPEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.f_S_KCTZTYPEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.f_S_KCTZTYPEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxAllowModify = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_KCTZTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_KCTZTYPEBindingNavigator)).BeginInit();
            this.f_S_KCTZTYPEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_KCTZTYPEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_S_KCTZTYPEBindingSource
            // 
            this.f_S_KCTZTYPEBindingSource.DataMember = "F_S_KCTZTYPE";
            this.f_S_KCTZTYPEBindingSource.DataSource = this.saleDataSetAll;
            this.f_S_KCTZTYPEBindingSource.CurrentChanged += new System.EventHandler(this.f_S_KCTZTYPEBindingSource_CurrentChanged);
            // 
            // f_S_KCTZTYPETableAdapter
            // 
            this.f_S_KCTZTYPETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.F_S_KCTZTYPETableAdapter = this.f_S_KCTZTYPETableAdapter;
            this.tableAdapterManager.F_S_PENDTYPETableAdapter = null;
            this.tableAdapterManager.F_S_SEASONTableAdapter = null;
            this.tableAdapterManager.F_S_SIZETableAdapter = null;
            this.tableAdapterManager.F_S_USERTableAdapter = null;
            this.tableAdapterManager.F_SALETableAdapter = null;
            this.tableAdapterManager.F_VIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // f_S_KCTZTYPEBindingNavigator
            // 
            this.f_S_KCTZTYPEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.f_S_KCTZTYPEBindingNavigator.BindingSource = this.f_S_KCTZTYPEBindingSource;
            this.f_S_KCTZTYPEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.f_S_KCTZTYPEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.f_S_KCTZTYPEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.f_S_KCTZTYPEBindingNavigatorSaveItem});
            this.f_S_KCTZTYPEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.f_S_KCTZTYPEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.f_S_KCTZTYPEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.f_S_KCTZTYPEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.f_S_KCTZTYPEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.f_S_KCTZTYPEBindingNavigator.Name = "f_S_KCTZTYPEBindingNavigator";
            this.f_S_KCTZTYPEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.f_S_KCTZTYPEBindingNavigator.Size = new System.Drawing.Size(749, 25);
            this.f_S_KCTZTYPEBindingNavigator.TabIndex = 0;
            this.f_S_KCTZTYPEBindingNavigator.Text = "bindingNavigator1";
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
            // f_S_KCTZTYPEBindingNavigatorSaveItem
            // 
            this.f_S_KCTZTYPEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("f_S_KCTZTYPEBindingNavigatorSaveItem.Image")));
            this.f_S_KCTZTYPEBindingNavigatorSaveItem.Name = "f_S_KCTZTYPEBindingNavigatorSaveItem";
            this.f_S_KCTZTYPEBindingNavigatorSaveItem.Size = new System.Drawing.Size(73, 22);
            this.f_S_KCTZTYPEBindingNavigatorSaveItem.Text = "保存数据";
            this.f_S_KCTZTYPEBindingNavigatorSaveItem.Click += new System.EventHandler(this.f_S_KCTZTYPEBindingNavigatorSaveItem_Click_1);
            // 
            // f_S_KCTZTYPEDataGridView
            // 
            this.f_S_KCTZTYPEDataGridView.AutoGenerateColumns = false;
            this.f_S_KCTZTYPEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f_S_KCTZTYPEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.f_S_KCTZTYPEDataGridView.DataSource = this.f_S_KCTZTYPEBindingSource;
            this.f_S_KCTZTYPEDataGridView.Location = new System.Drawing.Point(12, 60);
            this.f_S_KCTZTYPEDataGridView.Name = "f_S_KCTZTYPEDataGridView";
            this.f_S_KCTZTYPEDataGridView.RowTemplate.Height = 23;
            this.f_S_KCTZTYPEDataGridView.Size = new System.Drawing.Size(725, 448);
            this.f_S_KCTZTYPEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "调整理由描述";
            this.dataGridViewTextBoxColumn2.HeaderText = "调整理由描述";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 450;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_S_KCTZTYPEBindingSource, "调整理由描述", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(53, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "理由:";
            // 
            // CheckBoxAllowModify
            // 
            this.CheckBoxAllowModify.AutoSize = true;
            this.CheckBoxAllowModify.Location = new System.Drawing.Point(521, 34);
            this.CheckBoxAllowModify.Name = "CheckBoxAllowModify";
            this.CheckBoxAllowModify.Size = new System.Drawing.Size(82, 18);
            this.CheckBoxAllowModify.TabIndex = 5;
            this.CheckBoxAllowModify.Text = "允许修改";
            this.CheckBoxAllowModify.UseVisualStyleBackColor = true;
            this.CheckBoxAllowModify.CheckedChanged += new System.EventHandler(this.CheckBoxAllowModify_CheckedChanged);
            // 
            // OptionStockAdjustReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(749, 520);
            this.Controls.Add(this.CheckBoxAllowModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.f_S_KCTZTYPEDataGridView);
            this.Controls.Add(this.f_S_KCTZTYPEBindingNavigator);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "OptionStockAdjustReason";
            this.Text = "库存调整理由";
            this.Load += new System.EventHandler(this.OptionStockAdjustReason_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_KCTZTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_KCTZTYPEBindingNavigator)).EndInit();
            this.f_S_KCTZTYPEBindingNavigator.ResumeLayout(false);
            this.f_S_KCTZTYPEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_KCTZTYPEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource f_S_KCTZTYPEBindingSource;
        private saleDataSetAllTableAdapters.F_S_KCTZTYPETableAdapter f_S_KCTZTYPETableAdapter;
        private saleDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator f_S_KCTZTYPEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton f_S_KCTZTYPEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView f_S_KCTZTYPEDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxAllowModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

         
    }
}
