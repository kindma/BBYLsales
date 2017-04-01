namespace BBYLsales
{
    partial class FormAllMod
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
            this.treeView服装类型 = new System.Windows.Forms.TreeView();
            this.comboBox类型 = new System.Windows.Forms.ComboBox();
            this.bindingSource类型 = new System.Windows.Forms.BindingSource(this.components);
            this.saleDataSetAll = new BBYLsales.saleDataSetAll();
            this.fSCLOTHTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericTextBox进货价 = new BBYLsales.numericTextBox();
            this.numericTextBox吊牌价 = new BBYLsales.numericTextBox();
            this.comboBox品牌 = new System.Windows.Forms.ComboBox();
            this.bindingSource品牌 = new System.Windows.Forms.BindingSource(this.components);
            this.fCLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox货号 = new System.Windows.Forms.TextBox();
            this.comboBox颜色 = new System.Windows.Forms.ComboBox();
            this.bindingSource颜色 = new System.Windows.Forms.BindingSource(this.components);
            this.fSCOLORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox季节 = new System.Windows.Forms.ComboBox();
            this.bindingSource季节 = new System.Windows.Forms.BindingSource(this.components);
            this.fSSEASONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label类型 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button关闭类型 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox类型D = new System.Windows.Forms.ComboBox();
            this.numericTextBox进货价D = new BBYLsales.numericTextBox();
            this.numericTextBox吊牌价D = new BBYLsales.numericTextBox();
            this.comboBox季节D = new System.Windows.Forms.ComboBox();
            this.comboBox品牌D = new System.Windows.Forms.ComboBox();
            this.comboBox颜色D = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button确定 = new System.Windows.Forms.Button();
            this.button取消 = new System.Windows.Forms.Button();
            this.f_S_SEASONTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_SEASONTableAdapter();
            this.f_CLASSTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_CLASSTableAdapter();
            this.f_S_CLOTHTYPETableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_CLOTHTYPETableAdapter();
            this.f_S_COLORTableAdapter = new BBYLsales.saleDataSetAllTableAdapters.F_S_COLORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource类型)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCLOTHTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource品牌)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fCLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource颜色)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCOLORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource季节)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSEASONBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView服装类型
            // 
            this.treeView服装类型.Location = new System.Drawing.Point(86, 92);
            this.treeView服装类型.Name = "treeView服装类型";
            this.treeView服装类型.Size = new System.Drawing.Size(135, 162);
            this.treeView服装类型.TabIndex = 126;
            this.treeView服装类型.Visible = false;
            this.treeView服装类型.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView服装类型_NodeMouseDoubleClick);
            // 
            // comboBox类型
            // 
            this.comboBox类型.DataSource = this.bindingSource类型;
            this.comboBox类型.DisplayMember = "类别";
            this.comboBox类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox类型.FormattingEnabled = true;
            this.comboBox类型.Location = new System.Drawing.Point(86, 73);
            this.comboBox类型.Name = "comboBox类型";
            this.comboBox类型.Size = new System.Drawing.Size(100, 20);
            this.comboBox类型.TabIndex = 127;
            this.comboBox类型.ValueMember = "ID";
            this.comboBox类型.Enter += new System.EventHandler(this.comboBox类型_Enter);
            // 
            // bindingSource类型
            // 
            this.bindingSource类型.DataMember = "F_S_CLOTHTYPE";
            this.bindingSource类型.DataSource = this.saleDataSetAll;
            // 
            // saleDataSetAll
            // 
            this.saleDataSetAll.DataSetName = "saleDataSetAll";
            this.saleDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fSCLOTHTYPEBindingSource
            // 
            this.fSCLOTHTYPEBindingSource.DataMember = "F_S_CLOTHTYPE";
            this.fSCLOTHTYPEBindingSource.DataSource = this.saleDataSetAll;
            // 
            // numericTextBox进货价
            // 
            this.numericTextBox进货价.Location = new System.Drawing.Point(86, 151);
            this.numericTextBox进货价.Name = "numericTextBox进货价";
            this.numericTextBox进货价.Size = new System.Drawing.Size(100, 21);
            this.numericTextBox进货价.TabIndex = 119;
            // 
            // numericTextBox吊牌价
            // 
            this.numericTextBox吊牌价.Location = new System.Drawing.Point(86, 125);
            this.numericTextBox吊牌价.Name = "numericTextBox吊牌价";
            this.numericTextBox吊牌价.Size = new System.Drawing.Size(100, 21);
            this.numericTextBox吊牌价.TabIndex = 118;
            // 
            // comboBox品牌
            // 
            this.comboBox品牌.DataSource = this.bindingSource品牌;
            this.comboBox品牌.DisplayMember = "品牌名称";
            this.comboBox品牌.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox品牌.FormattingEnabled = true;
            this.comboBox品牌.Location = new System.Drawing.Point(86, 49);
            this.comboBox品牌.Name = "comboBox品牌";
            this.comboBox品牌.Size = new System.Drawing.Size(100, 20);
            this.comboBox品牌.TabIndex = 116;
            this.comboBox品牌.ValueMember = "ID";
            // 
            // bindingSource品牌
            // 
            this.bindingSource品牌.DataMember = "F_CLASS";
            this.bindingSource品牌.DataSource = this.saleDataSetAll;
            // 
            // fCLASSBindingSource
            // 
            this.fCLASSBindingSource.DataMember = "F_CLASS";
            this.fCLASSBindingSource.DataSource = this.saleDataSetAll;
            // 
            // textBox货号
            // 
            this.textBox货号.BackColor = System.Drawing.SystemColors.Window;
            this.textBox货号.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox货号.Location = new System.Drawing.Point(66, 16);
            this.textBox货号.Name = "textBox货号";
            this.textBox货号.ReadOnly = true;
            this.textBox货号.Size = new System.Drawing.Size(119, 23);
            this.textBox货号.TabIndex = 104;
            // 
            // comboBox颜色
            // 
            this.comboBox颜色.DataSource = this.bindingSource颜色;
            this.comboBox颜色.DisplayMember = "颜色";
            this.comboBox颜色.DropDownHeight = 200;
            this.comboBox颜色.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox颜色.FormattingEnabled = true;
            this.comboBox颜色.IntegralHeight = false;
            this.comboBox颜色.Location = new System.Drawing.Point(86, 99);
            this.comboBox颜色.Name = "comboBox颜色";
            this.comboBox颜色.Size = new System.Drawing.Size(100, 20);
            this.comboBox颜色.TabIndex = 117;
            this.comboBox颜色.ValueMember = "ID";
            // 
            // bindingSource颜色
            // 
            this.bindingSource颜色.DataMember = "F_S_COLOR";
            this.bindingSource颜色.DataSource = this.saleDataSetAll;
            // 
            // fSCOLORBindingSource
            // 
            this.fSCOLORBindingSource.DataMember = "F_S_COLOR";
            this.fSCOLORBindingSource.DataSource = this.saleDataSetAll;
            // 
            // comboBox季节
            // 
            this.comboBox季节.DataSource = this.bindingSource季节;
            this.comboBox季节.DisplayMember = "季节名称";
            this.comboBox季节.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox季节.FormattingEnabled = true;
            this.comboBox季节.Location = new System.Drawing.Point(86, 24);
            this.comboBox季节.Name = "comboBox季节";
            this.comboBox季节.Size = new System.Drawing.Size(100, 20);
            this.comboBox季节.TabIndex = 105;
            this.comboBox季节.ValueMember = "ID";
            // 
            // bindingSource季节
            // 
            this.bindingSource季节.DataMember = "F_S_SEASON";
            this.bindingSource季节.DataSource = this.saleDataSetAll;
            // 
            // fSSEASONBindingSource
            // 
            this.fSSEASONBindingSource.DataMember = "F_S_SEASON";
            this.fSSEASONBindingSource.DataSource = this.saleDataSetAll;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 106;
            this.label10.Text = "品牌：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 113;
            this.label17.Text = "款式季节：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 114;
            this.label2.Text = "货号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 115;
            this.label3.Text = "吊牌价：";
            // 
            // label类型
            // 
            this.label类型.AutoSize = true;
            this.label类型.Location = new System.Drawing.Point(50, 78);
            this.label类型.Name = "label类型";
            this.label类型.Size = new System.Drawing.Size(41, 12);
            this.label类型.TabIndex = 111;
            this.label类型.Text = "类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 112;
            this.label4.Text = "进货价：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 110;
            this.label6.Text = "颜色：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button关闭类型);
            this.groupBox1.Controls.Add(this.treeView服装类型);
            this.groupBox1.Controls.Add(this.comboBox类型);
            this.groupBox1.Controls.Add(this.numericTextBox进货价);
            this.groupBox1.Controls.Add(this.numericTextBox吊牌价);
            this.groupBox1.Controls.Add(this.comboBox季节);
            this.groupBox1.Controls.Add(this.comboBox品牌);
            this.groupBox1.Controls.Add(this.comboBox颜色);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label类型);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(239, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 260);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "现产品资料";
            // 
            // button关闭类型
            // 
            this.button关闭类型.BackColor = System.Drawing.SystemColors.Window;
            this.button关闭类型.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button关闭类型.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button关闭类型.Location = new System.Drawing.Point(196, 73);
            this.button关闭类型.Margin = new System.Windows.Forms.Padding(0);
            this.button关闭类型.Name = "button关闭类型";
            this.button关闭类型.Size = new System.Drawing.Size(25, 20);
            this.button关闭类型.TabIndex = 128;
            this.button关闭类型.Text = "×";
            this.button关闭类型.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button关闭类型.UseVisualStyleBackColor = false;
            this.button关闭类型.Visible = false;
            this.button关闭类型.Click += new System.EventHandler(this.button关闭类型_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox类型D);
            this.groupBox2.Controls.Add(this.numericTextBox进货价D);
            this.groupBox2.Controls.Add(this.numericTextBox吊牌价D);
            this.groupBox2.Controls.Add(this.comboBox季节D);
            this.groupBox2.Controls.Add(this.comboBox品牌D);
            this.groupBox2.Controls.Add(this.comboBox颜色D);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 260);
            this.groupBox2.TabIndex = 128;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "源产品资料";
            // 
            // comboBox类型D
            // 
            this.comboBox类型D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboBox类型D.DataSource = this.fSCLOTHTYPEBindingSource;
            this.comboBox类型D.DisplayMember = "类别";
            this.comboBox类型D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox类型D.FormattingEnabled = true;
            this.comboBox类型D.Location = new System.Drawing.Point(86, 73);
            this.comboBox类型D.Name = "comboBox类型D";
            this.comboBox类型D.Size = new System.Drawing.Size(100, 20);
            this.comboBox类型D.TabIndex = 127;
            this.comboBox类型D.ValueMember = "ID";
            this.comboBox类型D.Enter += new System.EventHandler(this.取消焦点_Enter);
            // 
            // numericTextBox进货价D
            // 
            this.numericTextBox进货价D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numericTextBox进货价D.Location = new System.Drawing.Point(86, 151);
            this.numericTextBox进货价D.Name = "numericTextBox进货价D";
            this.numericTextBox进货价D.ReadOnly = true;
            this.numericTextBox进货价D.Size = new System.Drawing.Size(100, 21);
            this.numericTextBox进货价D.TabIndex = 119;
            // 
            // numericTextBox吊牌价D
            // 
            this.numericTextBox吊牌价D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numericTextBox吊牌价D.Location = new System.Drawing.Point(86, 125);
            this.numericTextBox吊牌价D.Name = "numericTextBox吊牌价D";
            this.numericTextBox吊牌价D.ReadOnly = true;
            this.numericTextBox吊牌价D.Size = new System.Drawing.Size(100, 21);
            this.numericTextBox吊牌价D.TabIndex = 118;
            // 
            // comboBox季节D
            // 
            this.comboBox季节D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboBox季节D.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.saleDataSetAll, "F_INCOME.季节", true));
            this.comboBox季节D.DataSource = this.fSSEASONBindingSource;
            this.comboBox季节D.DisplayMember = "季节名称";
            this.comboBox季节D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox季节D.FormattingEnabled = true;
            this.comboBox季节D.Location = new System.Drawing.Point(86, 24);
            this.comboBox季节D.Name = "comboBox季节D";
            this.comboBox季节D.Size = new System.Drawing.Size(100, 20);
            this.comboBox季节D.TabIndex = 105;
            this.comboBox季节D.ValueMember = "ID";
            this.comboBox季节D.Enter += new System.EventHandler(this.取消焦点_Enter);
            // 
            // comboBox品牌D
            // 
            this.comboBox品牌D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboBox品牌D.DataSource = this.fCLASSBindingSource;
            this.comboBox品牌D.DisplayMember = "品牌名称";
            this.comboBox品牌D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox品牌D.FormattingEnabled = true;
            this.comboBox品牌D.Location = new System.Drawing.Point(86, 49);
            this.comboBox品牌D.Name = "comboBox品牌D";
            this.comboBox品牌D.Size = new System.Drawing.Size(100, 20);
            this.comboBox品牌D.TabIndex = 116;
            this.comboBox品牌D.ValueMember = "ID";
            this.comboBox品牌D.Enter += new System.EventHandler(this.取消焦点_Enter);
            // 
            // comboBox颜色D
            // 
            this.comboBox颜色D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboBox颜色D.DataSource = this.fSCOLORBindingSource;
            this.comboBox颜色D.DisplayMember = "颜色";
            this.comboBox颜色D.DropDownHeight = 200;
            this.comboBox颜色D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox颜色D.FormattingEnabled = true;
            this.comboBox颜色D.IntegralHeight = false;
            this.comboBox颜色D.Location = new System.Drawing.Point(86, 99);
            this.comboBox颜色D.Name = "comboBox颜色D";
            this.comboBox颜色D.Size = new System.Drawing.Size(100, 20);
            this.comboBox颜色D.TabIndex = 117;
            this.comboBox颜色D.ValueMember = "ID";
            this.comboBox颜色D.Enter += new System.EventHandler(this.取消焦点_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 113;
            this.label1.Text = "款式季节：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 110;
            this.label5.Text = "颜色：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 112;
            this.label7.Text = "进货价：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 111;
            this.label8.Text = "类型：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 115;
            this.label9.Text = "吊牌价：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 106;
            this.label11.Text = "品牌：";
            // 
            // button确定
            // 
            this.button确定.Location = new System.Drawing.Point(346, 344);
            this.button确定.Name = "button确定";
            this.button确定.Size = new System.Drawing.Size(75, 23);
            this.button确定.TabIndex = 129;
            this.button确定.Text = "确定";
            this.button确定.UseVisualStyleBackColor = true;
            this.button确定.Click += new System.EventHandler(this.button确定_Click);
            // 
            // button取消
            // 
            this.button取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button取消.Location = new System.Drawing.Point(423, 344);
            this.button取消.Name = "button取消";
            this.button取消.Size = new System.Drawing.Size(75, 23);
            this.button取消.TabIndex = 129;
            this.button取消.Text = "取消";
            this.button取消.UseVisualStyleBackColor = true;
            // 
            // f_S_SEASONTableAdapter
            // 
            this.f_S_SEASONTableAdapter.ClearBeforeFill = true;
            // 
            // f_CLASSTableAdapter
            // 
            this.f_CLASSTableAdapter.ClearBeforeFill = true;
            // 
            // f_S_CLOTHTYPETableAdapter
            // 
            this.f_S_CLOTHTYPETableAdapter.ClearBeforeFill = true;
            // 
            // f_S_COLORTableAdapter
            // 
            this.f_S_COLORTableAdapter.ClearBeforeFill = true;
            // 
            // FormAllMod
            // 
            this.AcceptButton = this.button确定;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button取消;
            this.ClientSize = new System.Drawing.Size(508, 384);
            this.Controls.Add(this.button取消);
            this.Controls.Add(this.button确定);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox货号);
            this.Controls.Add(this.label2);
            this.Name = "FormAllMod";
            this.Text = "批量修改资料";
            this.Load += new System.EventHandler(this.FormAllMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource类型)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCLOTHTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource品牌)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fCLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource颜色)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSCOLORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource季节)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSSEASONBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView服装类型;
        private System.Windows.Forms.ComboBox comboBox类型;
        private numericTextBox numericTextBox进货价;
        private numericTextBox numericTextBox吊牌价;
        private System.Windows.Forms.ComboBox comboBox品牌;
        protected System.Windows.Forms.TextBox textBox货号;
        private System.Windows.Forms.ComboBox comboBox颜色;
        private System.Windows.Forms.ComboBox comboBox季节;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label类型;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox类型D;
        private numericTextBox numericTextBox进货价D;
        private numericTextBox numericTextBox吊牌价D;
        private System.Windows.Forms.ComboBox comboBox季节D;
        private System.Windows.Forms.ComboBox comboBox品牌D;
        private System.Windows.Forms.ComboBox comboBox颜色D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button确定;
        private System.Windows.Forms.Button button取消;
        private saleDataSetAll saleDataSetAll;
        private System.Windows.Forms.BindingSource fSSEASONBindingSource;
        private saleDataSetAllTableAdapters.F_S_SEASONTableAdapter f_S_SEASONTableAdapter;
        private System.Windows.Forms.BindingSource fCLASSBindingSource;
        private saleDataSetAllTableAdapters.F_CLASSTableAdapter f_CLASSTableAdapter;
        private System.Windows.Forms.BindingSource fSCLOTHTYPEBindingSource;
        private saleDataSetAllTableAdapters.F_S_CLOTHTYPETableAdapter f_S_CLOTHTYPETableAdapter;
        private System.Windows.Forms.BindingSource fSCOLORBindingSource;
        private saleDataSetAllTableAdapters.F_S_COLORTableAdapter f_S_COLORTableAdapter;
        private System.Windows.Forms.Button button关闭类型;
        private System.Windows.Forms.BindingSource bindingSource季节;
        private System.Windows.Forms.BindingSource bindingSource品牌;
        private System.Windows.Forms.BindingSource bindingSource类型;
        private System.Windows.Forms.BindingSource bindingSource颜色;

    }
}