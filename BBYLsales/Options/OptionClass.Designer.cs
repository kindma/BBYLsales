namespace BBYLsales.Options
{
    partial class OptionClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionClass));
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.f_CLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_CLASSTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_CLASSTableAdapter();
            this.tableAdapterManager = new BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager();
            this.f_CLASSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.f_CLASSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.f_CLASSDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.颜色货号锁定DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_CLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_CLASSBindingNavigator)).BeginInit();
            this.f_CLASSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_CLASSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_CLASSBindingSource
            // 
            this.f_CLASSBindingSource.DataMember = "F_CLASS";
            this.f_CLASSBindingSource.DataSource = this.saleDataSetAll;
            // 
            // f_CLASSTableAdapter
            // 
            this.f_CLASSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.F_CLASSTableAdapter = this.f_CLASSTableAdapter;
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
            this.tableAdapterManager.F_VIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // f_CLASSBindingNavigator
            // 
            this.f_CLASSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.f_CLASSBindingNavigator.BindingSource = this.f_CLASSBindingSource;
            this.f_CLASSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.f_CLASSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.f_CLASSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.f_CLASSBindingNavigatorSaveItem});
            this.f_CLASSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.f_CLASSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.f_CLASSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.f_CLASSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.f_CLASSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.f_CLASSBindingNavigator.Name = "f_CLASSBindingNavigator";
            this.f_CLASSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.f_CLASSBindingNavigator.Size = new System.Drawing.Size(489, 25);
            this.f_CLASSBindingNavigator.TabIndex = 0;
            this.f_CLASSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(49, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
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
            // f_CLASSBindingNavigatorSaveItem
            // 
            this.f_CLASSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("f_CLASSBindingNavigatorSaveItem.Image")));
            this.f_CLASSBindingNavigatorSaveItem.Name = "f_CLASSBindingNavigatorSaveItem";
            this.f_CLASSBindingNavigatorSaveItem.Size = new System.Drawing.Size(73, 22);
            this.f_CLASSBindingNavigatorSaveItem.Text = "保存数据";
            this.f_CLASSBindingNavigatorSaveItem.Click += new System.EventHandler(this.f_CLASSBindingNavigatorSaveItem_Click);
            // 
            // f_CLASSDataGridView
            // 
            this.f_CLASSDataGridView.AllowUserToAddRows = false;
            this.f_CLASSDataGridView.AutoGenerateColumns = false;
            this.f_CLASSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f_CLASSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.品牌名称DataGridViewTextBoxColumn,
            this.颜色货号锁定DataGridViewCheckBoxColumn});
            this.f_CLASSDataGridView.DataSource = this.f_CLASSBindingSource;
            this.f_CLASSDataGridView.Location = new System.Drawing.Point(12, 38);
            this.f_CLASSDataGridView.Name = "f_CLASSDataGridView";
            this.f_CLASSDataGridView.RowTemplate.Height = 23;
            this.f_CLASSDataGridView.Size = new System.Drawing.Size(465, 345);
            this.f_CLASSDataGridView.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 品牌名称DataGridViewTextBoxColumn
            // 
            this.品牌名称DataGridViewTextBoxColumn.DataPropertyName = "品牌名称";
            this.品牌名称DataGridViewTextBoxColumn.HeaderText = "品牌名称";
            this.品牌名称DataGridViewTextBoxColumn.Name = "品牌名称DataGridViewTextBoxColumn";
            // 
            // 颜色货号锁定DataGridViewCheckBoxColumn
            // 
            this.颜色货号锁定DataGridViewCheckBoxColumn.DataPropertyName = "颜色货号锁定";
            this.颜色货号锁定DataGridViewCheckBoxColumn.HeaderText = "颜色货号锁定";
            this.颜色货号锁定DataGridViewCheckBoxColumn.Name = "颜色货号锁定DataGridViewCheckBoxColumn";
            // 
            // OptionClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 395);
            this.Controls.Add(this.f_CLASSDataGridView);
            this.Controls.Add(this.f_CLASSBindingNavigator);
            this.Name = "OptionClass";
            this.Text = "品牌管理";
            this.Load += new System.EventHandler(this.OptionClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_CLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_CLASSBindingNavigator)).EndInit();
            this.f_CLASSBindingNavigator.ResumeLayout(false);
            this.f_CLASSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_CLASSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource f_CLASSBindingSource;
        private saleDataSetAllTableAdapters.F_CLASSTableAdapter f_CLASSTableAdapter;
        private saleDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator f_CLASSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton f_CLASSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView f_CLASSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 颜色货号锁定DataGridViewCheckBoxColumn;
    }
}