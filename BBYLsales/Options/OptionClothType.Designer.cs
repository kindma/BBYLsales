namespace BBYLsales
{
    partial class OptionClothType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionClothType));
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.f_S_CLOTHTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_S_CLOTHTYPETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_CLOTHTYPETableAdapter();
            this.tableAdapterManager = new BBYLsales.saleDataSetAllTableAdapters.TableAdapterManager();
            this.f_S_CLOTHTYPEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.f_S_CLOTHTYPEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.textBox类别名称 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox父类ID = new System.Windows.Forms.ComboBox();
            this.fSCLOTHTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_CLOTHTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_CLOTHTYPEBindingNavigator)).BeginInit();
            this.f_S_CLOTHTYPEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSCLOTHTYPEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_S_CLOTHTYPEBindingSource
            // 
            this.f_S_CLOTHTYPEBindingSource.DataMember = "F_S_CLOTHTYPE";
            this.f_S_CLOTHTYPEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // f_S_CLOTHTYPETableAdapter
            // 
            this.f_S_CLOTHTYPETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.F_CLASSTableAdapter = null;
            this.tableAdapterManager.F_INCOMETableAdapter = null;
            this.tableAdapterManager.F_KCTZTableAdapter = null;
            this.tableAdapterManager.F_PENDTableAdapter = null;
            this.tableAdapterManager.F_S_CLOTHTYPETableAdapter = this.f_S_CLOTHTYPETableAdapter;
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
            // f_S_CLOTHTYPEBindingNavigator
            // 
            this.f_S_CLOTHTYPEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.f_S_CLOTHTYPEBindingNavigator.BindingSource = this.f_S_CLOTHTYPEBindingSource;
            this.f_S_CLOTHTYPEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.f_S_CLOTHTYPEBindingNavigator.DeleteItem = null;
            this.f_S_CLOTHTYPEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.f_S_CLOTHTYPEBindingNavigatorSaveItem});
            this.f_S_CLOTHTYPEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.f_S_CLOTHTYPEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.f_S_CLOTHTYPEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.f_S_CLOTHTYPEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.f_S_CLOTHTYPEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.f_S_CLOTHTYPEBindingNavigator.Name = "f_S_CLOTHTYPEBindingNavigator";
            this.f_S_CLOTHTYPEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.f_S_CLOTHTYPEBindingNavigator.Size = new System.Drawing.Size(672, 25);
            this.f_S_CLOTHTYPEBindingNavigator.TabIndex = 0;
            this.f_S_CLOTHTYPEBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(57, 21);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(49, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // f_S_CLOTHTYPEBindingNavigatorSaveItem
            // 
            this.f_S_CLOTHTYPEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("f_S_CLOTHTYPEBindingNavigatorSaveItem.Image")));
            this.f_S_CLOTHTYPEBindingNavigatorSaveItem.Name = "f_S_CLOTHTYPEBindingNavigatorSaveItem";
            this.f_S_CLOTHTYPEBindingNavigatorSaveItem.Size = new System.Drawing.Size(73, 22);
            this.f_S_CLOTHTYPEBindingNavigatorSaveItem.Text = "保存数据";
            this.f_S_CLOTHTYPEBindingNavigatorSaveItem.Click += new System.EventHandler(this.f_S_CLOTHTYPEBindingNavigatorSaveItem_Click);
            // 
            // textBox类别名称
            // 
            this.textBox类别名称.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_S_CLOTHTYPEBindingSource, "类别", true));
            this.textBox类别名称.Location = new System.Drawing.Point(83, 36);
            this.textBox类别名称.Margin = new System.Windows.Forms.Padding(4);
            this.textBox类别名称.Name = "textBox类别名称";
            this.textBox类别名称.ReadOnly = true;
            this.textBox类别名称.Size = new System.Drawing.Size(116, 23);
            this.textBox类别名称.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "类别名称";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(13, 80);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(646, 394);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "隶属于:";
            // 
            // comboBox父类ID
            // 
            this.comboBox父类ID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.f_S_CLOTHTYPEBindingSource, "父类ID", true));
            this.comboBox父类ID.DataSource = this.fSCLOTHTYPEBindingSource;
            this.comboBox父类ID.DisplayMember = "类别";
            this.comboBox父类ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox父类ID.Enabled = false;
            this.comboBox父类ID.FormattingEnabled = true;
            this.comboBox父类ID.Location = new System.Drawing.Point(296, 36);
            this.comboBox父类ID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox父类ID.Name = "comboBox父类ID";
            this.comboBox父类ID.Size = new System.Drawing.Size(140, 22);
            this.comboBox父类ID.TabIndex = 5;
            this.comboBox父类ID.ValueMember = "ID";
            // 
            // fSCLOTHTYPEBindingSource
            // 
            this.fSCLOTHTYPEBindingSource.DataMember = "F_S_CLOTHTYPE";
            this.fSCLOTHTYPEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(461, 39);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 18);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "修改";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OptionClothType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 502);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox父类ID);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox类别名称);
            this.Controls.Add(this.f_S_CLOTHTYPEBindingNavigator);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "OptionClothType";
            this.Text = "服装类型";
            this.Load += new System.EventHandler(this.OptionClothType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_CLOTHTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_S_CLOTHTYPEBindingNavigator)).EndInit();
            this.f_S_CLOTHTYPEBindingNavigator.ResumeLayout(false);
            this.f_S_CLOTHTYPEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSCLOTHTYPEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource f_S_CLOTHTYPEBindingSource;
        private saleDataSetAllTableAdapters.F_S_CLOTHTYPETableAdapter f_S_CLOTHTYPETableAdapter;
        private saleDataSetAllTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator f_S_CLOTHTYPEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton f_S_CLOTHTYPEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBox类别名称;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox父类ID;
        private System.Windows.Forms.BindingSource fSCLOTHTYPEBindingSource;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    }
}