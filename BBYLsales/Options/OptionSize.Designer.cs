namespace BBYLsales.Options
{
    partial class OptionSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionSize));
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.f_S_SIZEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_S_SIZETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_SIZETableAdapter();
            this.tableAdapterManager = new BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager();
            this.f_S_SIZEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.f_S_SIZEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.f_S_SIZEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxAllowModify = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_SIZEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_SIZEBindingNavigator)).BeginInit();
            this.f_S_SIZEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_SIZEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_S_SIZEBindingSource
            // 
            this.f_S_SIZEBindingSource.DataMember = "F_S_SIZE";
            this.f_S_SIZEBindingSource.DataSource = this.saleDataSetAll;
            this.f_S_SIZEBindingSource.CurrentChanged += new System.EventHandler(this.f_S_SIZEBindingSource_CurrentChanged_1);
            // 
            // f_S_SIZETableAdapter
            // 
            this.f_S_SIZETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.F_S_PENDTYPETableAdapter = null;
            this.tableAdapterManager.F_S_SEASONTableAdapter = null;
            this.tableAdapterManager.F_S_SIZETableAdapter = this.f_S_SIZETableAdapter;
            this.tableAdapterManager.F_S_USERTableAdapter = null;
            this.tableAdapterManager.F_SALETableAdapter = null;
            this.tableAdapterManager.F_VIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // f_S_SIZEBindingNavigator
            // 
            this.f_S_SIZEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.f_S_SIZEBindingNavigator.BindingSource = this.f_S_SIZEBindingSource;
            this.f_S_SIZEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.f_S_SIZEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.f_S_SIZEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.f_S_SIZEBindingNavigatorSaveItem});
            this.f_S_SIZEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.f_S_SIZEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.f_S_SIZEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.f_S_SIZEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.f_S_SIZEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.f_S_SIZEBindingNavigator.Name = "f_S_SIZEBindingNavigator";
            this.f_S_SIZEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.f_S_SIZEBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.f_S_SIZEBindingNavigator.Size = new System.Drawing.Size(693, 25);
            this.f_S_SIZEBindingNavigator.TabIndex = 0;
            this.f_S_SIZEBindingNavigator.Text = "bindingNavigator1";
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
            // f_S_SIZEBindingNavigatorSaveItem
            // 
            this.f_S_SIZEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("f_S_SIZEBindingNavigatorSaveItem.Image")));
            this.f_S_SIZEBindingNavigatorSaveItem.Name = "f_S_SIZEBindingNavigatorSaveItem";
            this.f_S_SIZEBindingNavigatorSaveItem.Size = new System.Drawing.Size(73, 22);
            this.f_S_SIZEBindingNavigatorSaveItem.Text = "保存数据";
            this.f_S_SIZEBindingNavigatorSaveItem.Click += new System.EventHandler(this.f_S_SIZEBindingNavigatorSaveItem_Click);
            // 
            // f_S_SIZEDataGridView
            // 
            this.f_S_SIZEDataGridView.AllowUserToAddRows = false;
            this.f_S_SIZEDataGridView.AllowUserToDeleteRows = false;
            this.f_S_SIZEDataGridView.AllowUserToOrderColumns = true;
            this.f_S_SIZEDataGridView.AllowUserToResizeColumns = false;
            this.f_S_SIZEDataGridView.AllowUserToResizeRows = false;
            this.f_S_SIZEDataGridView.AutoGenerateColumns = false;
            this.f_S_SIZEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f_S_SIZEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.f_S_SIZEDataGridView.DataSource = this.f_S_SIZEBindingSource;
            this.f_S_SIZEDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.f_S_SIZEDataGridView.Location = new System.Drawing.Point(12, 89);
            this.f_S_SIZEDataGridView.MultiSelect = false;
            this.f_S_SIZEDataGridView.Name = "f_S_SIZEDataGridView";
            this.f_S_SIZEDataGridView.ReadOnly = true;
            this.f_S_SIZEDataGridView.RowHeadersVisible = false;
            this.f_S_SIZEDataGridView.RowTemplate.Height = 23;
            this.f_S_SIZEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.f_S_SIZEDataGridView.Size = new System.Drawing.Size(669, 430);
            this.f_S_SIZEDataGridView.TabIndex = 1;
            this.f_S_SIZEDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.f_S_SIZEDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "尺寸";
            this.dataGridViewTextBoxColumn2.HeaderText = "尺寸";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "描述";
            this.dataGridViewTextBoxColumn3.HeaderText = "描述";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_S_SIZEBindingSource, "尺寸", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(60, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_S_SIZEBindingSource, "描述", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(60, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "尺寸:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "描述:";
            // 
            // CheckBoxAllowModify
            // 
            this.CheckBoxAllowModify.AutoSize = true;
            this.CheckBoxAllowModify.Location = new System.Drawing.Point(224, 33);
            this.CheckBoxAllowModify.Name = "CheckBoxAllowModify";
            this.CheckBoxAllowModify.Size = new System.Drawing.Size(82, 18);
            this.CheckBoxAllowModify.TabIndex = 4;
            this.CheckBoxAllowModify.Text = "允许修改";
            this.CheckBoxAllowModify.UseVisualStyleBackColor = true;
            this.CheckBoxAllowModify.CheckedChanged += new System.EventHandler(this.CheckBoxAllowModify_CheckedChanged);
            // 
            // OptionSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(693, 531);
            this.Controls.Add(this.CheckBoxAllowModify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.f_S_SIZEDataGridView);
            this.Controls.Add(this.f_S_SIZEBindingNavigator);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "OptionSize";
            this.Text = "尺寸表";
            this.Load += new System.EventHandler(this.OptionSize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_SIZEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_SIZEBindingNavigator)).EndInit();
            this.f_S_SIZEBindingNavigator.ResumeLayout(false);
            this.f_S_SIZEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_SIZEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource f_S_SIZEBindingSource;
        private saleDataSetAllTableAdapters.F_S_SIZETableAdapter f_S_SIZETableAdapter;
        private saleDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator f_S_SIZEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton f_S_SIZEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView f_S_SIZEDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxAllowModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
