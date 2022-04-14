namespace AJ78
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_退件处理 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_退件入库 = new System.Windows.Forms.Button();
            this.button_SDate = new System.Windows.Forms.Button();
            this.button_SCode = new System.Windows.Forms.Button();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.radioButton_Done = new System.Windows.Forms.RadioButton();
            this.radioButton_NotDone = new System.Windows.Forms.RadioButton();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.button_get = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_getClipboardImage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号DataGridViewTextBoxColumn = new AJ78.Form1.CustomDGVComboBoxColumn();
            this.selectstockNumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new AJ78.DatabaseDataSet();
            this.数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.图片DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.处理DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.入库DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recoveredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_商品列表 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button_stockNum_Save = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商家编码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.占用库存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.可用库存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总库存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.隐藏DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stockNumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_库存查看 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.button_撤销出入库 = new System.Windows.Forms.Button();
            this.button_库存查看刷新 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_orderList = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_orderList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商家编码DataGridViewTextBoxColumn1 = new AJ78.Form1.CustomDGVComboBoxColumn();
            this.数量DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_出库 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.button_出库单保存 = new System.Windows.Forms.Button();
            this.button_出库 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView_出库 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商家编码DataGridViewTextBoxColumn2 = new AJ78.Form1.CustomDGVComboBoxColumn();
            this.数量DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderList出库BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_入库 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button_入库 = new System.Windows.Forms.Button();
            this.button_入库单保存 = new System.Windows.Forms.Button();
            this.dataGridView_入库 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商家编码DataGridViewTextBoxColumn3 = new AJ78.Form1.CustomDGVComboBoxColumn();
            this.数量DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderList入库BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockNumTableAdapter = new AJ78.DatabaseDataSetTableAdapters.stockNumTableAdapter();
            this.select_stockNumTableAdapter = new AJ78.DatabaseDataSetTableAdapters.Select_stockNumTableAdapter();
            this.orderListTableAdapter = new AJ78.DatabaseDataSetTableAdapters.orderListTableAdapter();
            this.recoveredTableAdapter = new AJ78.DatabaseDataSetTableAdapters.recoveredTableAdapter();
            this.orderList_出库TableAdapter = new AJ78.DatabaseDataSetTableAdapters.orderList_出库TableAdapter();
            this.orderList_入库TableAdapter = new AJ78.DatabaseDataSetTableAdapters.orderList_入库TableAdapter();
            this.button_选中出库 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_退件处理.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectstockNumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveredBindingSource)).BeginInit();
            this.tabPage_商品列表.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumBindingSource)).BeginInit();
            this.tabPage_库存查看.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).BeginInit();
            this.tabPage_出库.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_出库)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderList出库BindingSource)).BeginInit();
            this.tabPage_入库.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_入库)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderList入库BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_退件处理);
            this.tabControl1.Controls.Add(this.tabPage_商品列表);
            this.tabControl1.Controls.Add(this.tabPage_库存查看);
            this.tabControl1.Controls.Add(this.tabPage_出库);
            this.tabControl1.Controls.Add(this.tabPage_入库);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage_退件处理
            // 
            this.tabPage_退件处理.Controls.Add(this.splitContainer1);
            this.tabPage_退件处理.Location = new System.Drawing.Point(4, 22);
            this.tabPage_退件处理.Name = "tabPage_退件处理";
            this.tabPage_退件处理.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_退件处理.Size = new System.Drawing.Size(932, 424);
            this.tabPage_退件处理.TabIndex = 0;
            this.tabPage_退件处理.Text = "退件处理";
            this.tabPage_退件处理.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_add);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button_退件入库);
            this.splitContainer1.Panel1.Controls.Add(this.button_SDate);
            this.splitContainer1.Panel1.Controls.Add(this.button_SCode);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_code);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton_Done);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton_NotDone);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton_all);
            this.splitContainer1.Panel1.Controls.Add(this.button_get);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.button_Save);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button_getClipboardImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(926, 418);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(557, 12);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 18;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_退件入库
            // 
            this.button_退件入库.Location = new System.Drawing.Point(469, 56);
            this.button_退件入库.Name = "button_退件入库";
            this.button_退件入库.Size = new System.Drawing.Size(75, 23);
            this.button_退件入库.TabIndex = 16;
            this.button_退件入库.Text = "退件入库";
            this.button_退件入库.UseVisualStyleBackColor = true;
            this.button_退件入库.Click += new System.EventHandler(this.button_退件入库_Click);
            // 
            // button_SDate
            // 
            this.button_SDate.Location = new System.Drawing.Point(156, 14);
            this.button_SDate.Name = "button_SDate";
            this.button_SDate.Size = new System.Drawing.Size(75, 23);
            this.button_SDate.TabIndex = 15;
            this.button_SDate.Text = "查询指定日期";
            this.button_SDate.UseVisualStyleBackColor = true;
            this.button_SDate.Click += new System.EventHandler(this.button_SDate_Click);
            // 
            // button_SCode
            // 
            this.button_SCode.Location = new System.Drawing.Point(469, 14);
            this.button_SCode.Name = "button_SCode";
            this.button_SCode.Size = new System.Drawing.Size(75, 23);
            this.button_SCode.TabIndex = 14;
            this.button_SCode.Text = "查询单号";
            this.button_SCode.UseVisualStyleBackColor = true;
            this.button_SCode.Click += new System.EventHandler(this.button_SCode_Click);
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(302, 14);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(161, 21);
            this.textBox_code.TabIndex = 12;
            // 
            // radioButton_Done
            // 
            this.radioButton_Done.AutoSize = true;
            this.radioButton_Done.Checked = true;
            this.radioButton_Done.Location = new System.Drawing.Point(14, 68);
            this.radioButton_Done.Name = "radioButton_Done";
            this.radioButton_Done.Size = new System.Drawing.Size(59, 16);
            this.radioButton_Done.TabIndex = 9;
            this.radioButton_Done.TabStop = true;
            this.radioButton_Done.Text = "已处理";
            this.radioButton_Done.UseVisualStyleBackColor = true;
            // 
            // radioButton_NotDone
            // 
            this.radioButton_NotDone.AutoSize = true;
            this.radioButton_NotDone.Checked = true;
            this.radioButton_NotDone.Location = new System.Drawing.Point(14, 90);
            this.radioButton_NotDone.Name = "radioButton_NotDone";
            this.radioButton_NotDone.Size = new System.Drawing.Size(59, 16);
            this.radioButton_NotDone.TabIndex = 8;
            this.radioButton_NotDone.TabStop = true;
            this.radioButton_NotDone.Text = "未处理";
            this.radioButton_NotDone.UseVisualStyleBackColor = true;
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Location = new System.Drawing.Point(14, 43);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(47, 16);
            this.radioButton_all.TabIndex = 7;
            this.radioButton_all.Text = "全部";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(104, 87);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(75, 23);
            this.button_get.TabIndex = 6;
            this.button_get.Text = "刷新";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 21);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(557, 85);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "保存";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(783, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_getClipboardImage
            // 
            this.button_getClipboardImage.Location = new System.Drawing.Point(557, 56);
            this.button_getClipboardImage.Name = "button_getClipboardImage";
            this.button_getClipboardImage.Size = new System.Drawing.Size(75, 23);
            this.button_getClipboardImage.TabIndex = 0;
            this.button_getClipboardImage.Text = "获取";
            this.button_getClipboardImage.UseVisualStyleBackColor = true;
            this.button_getClipboardImage.Click += new System.EventHandler(this.button_getClipboardImage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.日期DataGridViewTextBoxColumn,
            this.单号DataGridViewTextBoxColumn,
            this.型号DataGridViewTextBoxColumn,
            this.数量DataGridViewTextBoxColumn,
            this.备注DataGridViewTextBoxColumn,
            this.图片DataGridViewImageColumn,
            this.处理DataGridViewTextBoxColumn,
            this.入库DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recoveredBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(926, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // 日期DataGridViewTextBoxColumn
            // 
            this.日期DataGridViewTextBoxColumn.DataPropertyName = "日期";
            this.日期DataGridViewTextBoxColumn.HeaderText = "日期";
            this.日期DataGridViewTextBoxColumn.Name = "日期DataGridViewTextBoxColumn";
            // 
            // 单号DataGridViewTextBoxColumn
            // 
            this.单号DataGridViewTextBoxColumn.DataPropertyName = "单号";
            this.单号DataGridViewTextBoxColumn.HeaderText = "单号";
            this.单号DataGridViewTextBoxColumn.Name = "单号DataGridViewTextBoxColumn";
            // 
            // 型号DataGridViewTextBoxColumn
            // 
            this.型号DataGridViewTextBoxColumn.DataPropertyName = "型号";
            this.型号DataGridViewTextBoxColumn.DataSource = this.selectstockNumBindingSource;
            this.型号DataGridViewTextBoxColumn.DisplayMember = "商家编码";
            this.型号DataGridViewTextBoxColumn.HeaderText = "型号";
            this.型号DataGridViewTextBoxColumn.Name = "型号DataGridViewTextBoxColumn";
            this.型号DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.型号DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.型号DataGridViewTextBoxColumn.Width = 120;
            // 
            // selectstockNumBindingSource
            // 
            this.selectstockNumBindingSource.DataMember = "Select_stockNum";
            this.selectstockNumBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 数量DataGridViewTextBoxColumn
            // 
            this.数量DataGridViewTextBoxColumn.DataPropertyName = "数量";
            this.数量DataGridViewTextBoxColumn.HeaderText = "数量";
            this.数量DataGridViewTextBoxColumn.Name = "数量DataGridViewTextBoxColumn";
            this.数量DataGridViewTextBoxColumn.Width = 60;
            // 
            // 备注DataGridViewTextBoxColumn
            // 
            this.备注DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.备注DataGridViewTextBoxColumn.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn.Name = "备注DataGridViewTextBoxColumn";
            // 
            // 图片DataGridViewImageColumn
            // 
            this.图片DataGridViewImageColumn.DataPropertyName = "图片";
            this.图片DataGridViewImageColumn.HeaderText = "图片";
            this.图片DataGridViewImageColumn.Name = "图片DataGridViewImageColumn";
            this.图片DataGridViewImageColumn.Width = 60;
            // 
            // 处理DataGridViewTextBoxColumn
            // 
            this.处理DataGridViewTextBoxColumn.DataPropertyName = "处理";
            this.处理DataGridViewTextBoxColumn.HeaderText = "处理";
            this.处理DataGridViewTextBoxColumn.Name = "处理DataGridViewTextBoxColumn";
            this.处理DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.处理DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.处理DataGridViewTextBoxColumn.Width = 60;
            // 
            // 入库DataGridViewTextBoxColumn
            // 
            this.入库DataGridViewTextBoxColumn.DataPropertyName = "入库";
            this.入库DataGridViewTextBoxColumn.FalseValue = "0";
            this.入库DataGridViewTextBoxColumn.HeaderText = "入库";
            this.入库DataGridViewTextBoxColumn.Name = "入库DataGridViewTextBoxColumn";
            this.入库DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.入库DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.入库DataGridViewTextBoxColumn.TrueValue = "1";
            this.入库DataGridViewTextBoxColumn.Width = 60;
            // 
            // recoveredBindingSource
            // 
            this.recoveredBindingSource.DataMember = "recovered";
            this.recoveredBindingSource.DataSource = this.databaseDataSet;
            // 
            // tabPage_商品列表
            // 
            this.tabPage_商品列表.Controls.Add(this.splitContainer2);
            this.tabPage_商品列表.Location = new System.Drawing.Point(4, 22);
            this.tabPage_商品列表.Name = "tabPage_商品列表";
            this.tabPage_商品列表.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_商品列表.Size = new System.Drawing.Size(932, 424);
            this.tabPage_商品列表.TabIndex = 1;
            this.tabPage_商品列表.Text = "商品列表";
            this.tabPage_商品列表.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button_stockNum_Save);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(926, 418);
            this.splitContainer2.SplitterDistance = 108;
            this.splitContainer2.TabIndex = 1;
            // 
            // button_stockNum_Save
            // 
            this.button_stockNum_Save.Location = new System.Drawing.Point(697, 69);
            this.button_stockNum_Save.Name = "button_stockNum_Save";
            this.button_stockNum_Save.Size = new System.Drawing.Size(75, 23);
            this.button_stockNum_Save.TabIndex = 0;
            this.button_stockNum_Save.Text = "保存 ";
            this.button_stockNum_Save.UseVisualStyleBackColor = true;
            this.button_stockNum_Save.Click += new System.EventHandler(this.button_stockNum_Save_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.商家编码DataGridViewTextBoxColumn,
            this.占用库存DataGridViewTextBoxColumn,
            this.可用库存DataGridViewTextBoxColumn,
            this.总库存DataGridViewTextBoxColumn,
            this.备注DataGridViewTextBoxColumn1,
            this.隐藏DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stockNumBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(926, 306);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 60;
            // 
            // 商家编码DataGridViewTextBoxColumn
            // 
            this.商家编码DataGridViewTextBoxColumn.DataPropertyName = "商家编码";
            this.商家编码DataGridViewTextBoxColumn.HeaderText = "商家编码";
            this.商家编码DataGridViewTextBoxColumn.Name = "商家编码DataGridViewTextBoxColumn";
            this.商家编码DataGridViewTextBoxColumn.Width = 120;
            // 
            // 占用库存DataGridViewTextBoxColumn
            // 
            this.占用库存DataGridViewTextBoxColumn.DataPropertyName = "占用库存";
            this.占用库存DataGridViewTextBoxColumn.HeaderText = "占用库存";
            this.占用库存DataGridViewTextBoxColumn.Name = "占用库存DataGridViewTextBoxColumn";
            // 
            // 可用库存DataGridViewTextBoxColumn
            // 
            this.可用库存DataGridViewTextBoxColumn.DataPropertyName = "可用库存";
            this.可用库存DataGridViewTextBoxColumn.HeaderText = "可用库存";
            this.可用库存DataGridViewTextBoxColumn.Name = "可用库存DataGridViewTextBoxColumn";
            // 
            // 总库存DataGridViewTextBoxColumn
            // 
            this.总库存DataGridViewTextBoxColumn.DataPropertyName = "总库存";
            this.总库存DataGridViewTextBoxColumn.HeaderText = "总库存";
            this.总库存DataGridViewTextBoxColumn.Name = "总库存DataGridViewTextBoxColumn";
            // 
            // 备注DataGridViewTextBoxColumn1
            // 
            this.备注DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.备注DataGridViewTextBoxColumn1.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn1.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn1.Name = "备注DataGridViewTextBoxColumn1";
            // 
            // 隐藏DataGridViewTextBoxColumn
            // 
            this.隐藏DataGridViewTextBoxColumn.DataPropertyName = "隐藏";
            this.隐藏DataGridViewTextBoxColumn.HeaderText = "隐藏";
            this.隐藏DataGridViewTextBoxColumn.Name = "隐藏DataGridViewTextBoxColumn";
            this.隐藏DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.隐藏DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // stockNumBindingSource
            // 
            this.stockNumBindingSource.DataMember = "stockNum";
            this.stockNumBindingSource.DataSource = this.databaseDataSet;
            // 
            // tabPage_库存查看
            // 
            this.tabPage_库存查看.Controls.Add(this.splitContainer5);
            this.tabPage_库存查看.Location = new System.Drawing.Point(4, 22);
            this.tabPage_库存查看.Name = "tabPage_库存查看";
            this.tabPage_库存查看.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_库存查看.Size = new System.Drawing.Size(932, 424);
            this.tabPage_库存查看.TabIndex = 2;
            this.tabPage_库存查看.Text = "库存查看";
            this.tabPage_库存查看.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(926, 418);
            this.splitContainer5.SplitterDistance = 270;
            this.splitContainer5.SplitterWidth = 10;
            this.splitContainer5.TabIndex = 10;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Indent = 25;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(270, 418);
            this.treeView1.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.button_撤销出入库);
            this.splitContainer6.Panel1.Controls.Add(this.button_库存查看刷新);
            this.splitContainer6.Panel1.Controls.Add(this.button5);
            this.splitContainer6.Panel1.Controls.Add(this.button_orderList);
            this.splitContainer6.Panel1.Controls.Add(this.dateTimePicker2);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.dataGridView_orderList);
            this.splitContainer6.Size = new System.Drawing.Size(646, 418);
            this.splitContainer6.SplitterDistance = 60;
            this.splitContainer6.TabIndex = 0;
            // 
            // button_撤销出入库
            // 
            this.button_撤销出入库.Location = new System.Drawing.Point(407, 5);
            this.button_撤销出入库.Name = "button_撤销出入库";
            this.button_撤销出入库.Size = new System.Drawing.Size(75, 23);
            this.button_撤销出入库.TabIndex = 11;
            this.button_撤销出入库.Text = "撤销出入库";
            this.button_撤销出入库.UseVisualStyleBackColor = true;
            this.button_撤销出入库.Click += new System.EventHandler(this.button_撤销出入库_Click);
            // 
            // button_库存查看刷新
            // 
            this.button_库存查看刷新.Location = new System.Drawing.Point(326, 6);
            this.button_库存查看刷新.Name = "button_库存查看刷新";
            this.button_库存查看刷新.Size = new System.Drawing.Size(75, 23);
            this.button_库存查看刷新.TabIndex = 10;
            this.button_库存查看刷新.Text = "刷新";
            this.button_库存查看刷新.UseVisualStyleBackColor = true;
            this.button_库存查看刷新.Click += new System.EventHandler(this.button_库存查看刷新_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(566, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_orderList
            // 
            this.button_orderList.Location = new System.Drawing.Point(222, 6);
            this.button_orderList.Name = "button_orderList";
            this.button_orderList.Size = new System.Drawing.Size(98, 23);
            this.button_orderList.TabIndex = 9;
            this.button_orderList.Text = "查看指定日期";
            this.button_orderList.UseVisualStyleBackColor = true;
            this.button_orderList.Click += new System.EventHandler(this.button_orderList_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dataGridView_orderList
            // 
            this.dataGridView_orderList.AllowUserToAddRows = false;
            this.dataGridView_orderList.AllowUserToDeleteRows = false;
            this.dataGridView_orderList.AutoGenerateColumns = false;
            this.dataGridView_orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.日期DataGridViewTextBoxColumn1,
            this.商家编码DataGridViewTextBoxColumn1,
            this.数量DataGridViewTextBoxColumn1,
            this.备注DataGridViewTextBoxColumn2});
            this.dataGridView_orderList.DataSource = this.orderListBindingSource;
            this.dataGridView_orderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_orderList.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_orderList.Name = "dataGridView_orderList";
            this.dataGridView_orderList.ReadOnly = true;
            this.dataGridView_orderList.RowTemplate.Height = 23;
            this.dataGridView_orderList.Size = new System.Drawing.Size(646, 354);
            this.dataGridView_orderList.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 30;
            // 
            // 日期DataGridViewTextBoxColumn1
            // 
            this.日期DataGridViewTextBoxColumn1.DataPropertyName = "日期";
            this.日期DataGridViewTextBoxColumn1.HeaderText = "日期";
            this.日期DataGridViewTextBoxColumn1.Name = "日期DataGridViewTextBoxColumn1";
            this.日期DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 商家编码DataGridViewTextBoxColumn1
            // 
            this.商家编码DataGridViewTextBoxColumn1.DataPropertyName = "商家编码";
            this.商家编码DataGridViewTextBoxColumn1.DataSource = this.selectstockNumBindingSource;
            this.商家编码DataGridViewTextBoxColumn1.DisplayMember = "商家编码";
            this.商家编码DataGridViewTextBoxColumn1.HeaderText = "商家编码";
            this.商家编码DataGridViewTextBoxColumn1.Name = "商家编码DataGridViewTextBoxColumn1";
            this.商家编码DataGridViewTextBoxColumn1.ReadOnly = true;
            this.商家编码DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.商家编码DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.商家编码DataGridViewTextBoxColumn1.Width = 120;
            // 
            // 数量DataGridViewTextBoxColumn1
            // 
            this.数量DataGridViewTextBoxColumn1.DataPropertyName = "数量";
            this.数量DataGridViewTextBoxColumn1.HeaderText = "数量";
            this.数量DataGridViewTextBoxColumn1.Name = "数量DataGridViewTextBoxColumn1";
            this.数量DataGridViewTextBoxColumn1.ReadOnly = true;
            this.数量DataGridViewTextBoxColumn1.Width = 60;
            // 
            // 备注DataGridViewTextBoxColumn2
            // 
            this.备注DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.备注DataGridViewTextBoxColumn2.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn2.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn2.Name = "备注DataGridViewTextBoxColumn2";
            this.备注DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // orderListBindingSource
            // 
            this.orderListBindingSource.DataMember = "orderList";
            this.orderListBindingSource.DataSource = this.databaseDataSet;
            // 
            // tabPage_出库
            // 
            this.tabPage_出库.Controls.Add(this.splitContainer4);
            this.tabPage_出库.Location = new System.Drawing.Point(4, 22);
            this.tabPage_出库.Name = "tabPage_出库";
            this.tabPage_出库.Size = new System.Drawing.Size(932, 424);
            this.tabPage_出库.TabIndex = 3;
            this.tabPage_出库.Text = "出库 ";
            this.tabPage_出库.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.button_选中出库);
            this.splitContainer4.Panel1.Controls.Add(this.button_出库单保存);
            this.splitContainer4.Panel1.Controls.Add(this.button_出库);
            this.splitContainer4.Panel1.Controls.Add(this.button6);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView_出库);
            this.splitContainer4.Size = new System.Drawing.Size(932, 424);
            this.splitContainer4.SplitterDistance = 101;
            this.splitContainer4.TabIndex = 0;
            // 
            // button_出库单保存
            // 
            this.button_出库单保存.Location = new System.Drawing.Point(263, 67);
            this.button_出库单保存.Name = "button_出库单保存";
            this.button_出库单保存.Size = new System.Drawing.Size(75, 23);
            this.button_出库单保存.TabIndex = 2;
            this.button_出库单保存.Text = "出库单保存";
            this.button_出库单保存.UseVisualStyleBackColor = true;
            this.button_出库单保存.Click += new System.EventHandler(this.button_出库单保存_Click);
            // 
            // button_出库
            // 
            this.button_出库.Location = new System.Drawing.Point(425, 67);
            this.button_出库.Name = "button_出库";
            this.button_出库.Size = new System.Drawing.Size(75, 23);
            this.button_出库.TabIndex = 1;
            this.button_出库.Text = "全部出库";
            this.button_出库.UseVisualStyleBackColor = true;
            this.button_出库.Click += new System.EventHandler(this.button_出库_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(709, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView_出库
            // 
            this.dataGridView_出库.AutoGenerateColumns = false;
            this.dataGridView_出库.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_出库.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.日期DataGridViewTextBoxColumn2,
            this.商家编码DataGridViewTextBoxColumn2,
            this.数量DataGridViewTextBoxColumn2,
            this.备注DataGridViewTextBoxColumn3});
            this.dataGridView_出库.DataSource = this.orderList出库BindingSource;
            this.dataGridView_出库.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_出库.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_出库.Name = "dataGridView_出库";
            this.dataGridView_出库.RowTemplate.Height = 23;
            this.dataGridView_出库.Size = new System.Drawing.Size(932, 319);
            this.dataGridView_出库.TabIndex = 0;
            this.dataGridView_出库.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_出库_CellBeginEdit);
            this.dataGridView_出库.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_出库_RowsAdded);
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.Width = 60;
            // 
            // 日期DataGridViewTextBoxColumn2
            // 
            this.日期DataGridViewTextBoxColumn2.DataPropertyName = "日期";
            this.日期DataGridViewTextBoxColumn2.HeaderText = "日期";
            this.日期DataGridViewTextBoxColumn2.Name = "日期DataGridViewTextBoxColumn2";
            // 
            // 商家编码DataGridViewTextBoxColumn2
            // 
            this.商家编码DataGridViewTextBoxColumn2.DataPropertyName = "商家编码";
            this.商家编码DataGridViewTextBoxColumn2.DataSource = this.selectstockNumBindingSource;
            this.商家编码DataGridViewTextBoxColumn2.DisplayMember = "商家编码";
            this.商家编码DataGridViewTextBoxColumn2.HeaderText = "商家编码";
            this.商家编码DataGridViewTextBoxColumn2.Name = "商家编码DataGridViewTextBoxColumn2";
            this.商家编码DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.商家编码DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.商家编码DataGridViewTextBoxColumn2.Width = 120;
            // 
            // 数量DataGridViewTextBoxColumn2
            // 
            this.数量DataGridViewTextBoxColumn2.DataPropertyName = "数量";
            this.数量DataGridViewTextBoxColumn2.HeaderText = "数量";
            this.数量DataGridViewTextBoxColumn2.Name = "数量DataGridViewTextBoxColumn2";
            this.数量DataGridViewTextBoxColumn2.Width = 60;
            // 
            // 备注DataGridViewTextBoxColumn3
            // 
            this.备注DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.备注DataGridViewTextBoxColumn3.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn3.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn3.Name = "备注DataGridViewTextBoxColumn3";
            // 
            // orderList出库BindingSource
            // 
            this.orderList出库BindingSource.DataMember = "orderList_出库";
            this.orderList出库BindingSource.DataSource = this.databaseDataSet;
            // 
            // tabPage_入库
            // 
            this.tabPage_入库.Controls.Add(this.splitContainer3);
            this.tabPage_入库.Location = new System.Drawing.Point(4, 22);
            this.tabPage_入库.Name = "tabPage_入库";
            this.tabPage_入库.Size = new System.Drawing.Size(932, 424);
            this.tabPage_入库.TabIndex = 4;
            this.tabPage_入库.Text = "入库";
            this.tabPage_入库.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.button_入库);
            this.splitContainer3.Panel1.Controls.Add(this.button_入库单保存);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView_入库);
            this.splitContainer3.Size = new System.Drawing.Size(932, 424);
            this.splitContainer3.SplitterDistance = 95;
            this.splitContainer3.TabIndex = 0;
            // 
            // button_入库
            // 
            this.button_入库.Location = new System.Drawing.Point(434, 58);
            this.button_入库.Name = "button_入库";
            this.button_入库.Size = new System.Drawing.Size(75, 23);
            this.button_入库.TabIndex = 1;
            this.button_入库.Text = "入库";
            this.button_入库.UseVisualStyleBackColor = true;
            this.button_入库.Click += new System.EventHandler(this.button_入库_Click);
            // 
            // button_入库单保存
            // 
            this.button_入库单保存.Location = new System.Drawing.Point(353, 58);
            this.button_入库单保存.Name = "button_入库单保存";
            this.button_入库单保存.Size = new System.Drawing.Size(75, 23);
            this.button_入库单保存.TabIndex = 0;
            this.button_入库单保存.Text = "入库单保存";
            this.button_入库单保存.UseVisualStyleBackColor = true;
            this.button_入库单保存.Click += new System.EventHandler(this.button_入库单保存_Click);
            // 
            // dataGridView_入库
            // 
            this.dataGridView_入库.AutoGenerateColumns = false;
            this.dataGridView_入库.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_入库.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.日期DataGridViewTextBoxColumn3,
            this.商家编码DataGridViewTextBoxColumn3,
            this.数量DataGridViewTextBoxColumn3,
            this.备注DataGridViewTextBoxColumn4});
            this.dataGridView_入库.DataSource = this.orderList入库BindingSource;
            this.dataGridView_入库.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_入库.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_入库.Name = "dataGridView_入库";
            this.dataGridView_入库.RowTemplate.Height = 23;
            this.dataGridView_入库.Size = new System.Drawing.Size(932, 325);
            this.dataGridView_入库.TabIndex = 0;
            this.dataGridView_入库.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_入库_CellBeginEdit);
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.Width = 60;
            // 
            // 日期DataGridViewTextBoxColumn3
            // 
            this.日期DataGridViewTextBoxColumn3.DataPropertyName = "日期";
            this.日期DataGridViewTextBoxColumn3.HeaderText = "日期";
            this.日期DataGridViewTextBoxColumn3.Name = "日期DataGridViewTextBoxColumn3";
            // 
            // 商家编码DataGridViewTextBoxColumn3
            // 
            this.商家编码DataGridViewTextBoxColumn3.DataPropertyName = "商家编码";
            this.商家编码DataGridViewTextBoxColumn3.DataSource = this.selectstockNumBindingSource;
            this.商家编码DataGridViewTextBoxColumn3.DisplayMember = "商家编码";
            this.商家编码DataGridViewTextBoxColumn3.HeaderText = "商家编码";
            this.商家编码DataGridViewTextBoxColumn3.Name = "商家编码DataGridViewTextBoxColumn3";
            this.商家编码DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.商家编码DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.商家编码DataGridViewTextBoxColumn3.Width = 120;
            // 
            // 数量DataGridViewTextBoxColumn3
            // 
            this.数量DataGridViewTextBoxColumn3.DataPropertyName = "数量";
            this.数量DataGridViewTextBoxColumn3.HeaderText = "数量";
            this.数量DataGridViewTextBoxColumn3.Name = "数量DataGridViewTextBoxColumn3";
            this.数量DataGridViewTextBoxColumn3.Width = 60;
            // 
            // 备注DataGridViewTextBoxColumn4
            // 
            this.备注DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.备注DataGridViewTextBoxColumn4.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn4.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn4.Name = "备注DataGridViewTextBoxColumn4";
            // 
            // orderList入库BindingSource
            // 
            this.orderList入库BindingSource.DataMember = "orderList_入库";
            this.orderList入库BindingSource.DataSource = this.databaseDataSet;
            // 
            // stockNumTableAdapter
            // 
            this.stockNumTableAdapter.ClearBeforeFill = true;
            // 
            // select_stockNumTableAdapter
            // 
            this.select_stockNumTableAdapter.ClearBeforeFill = true;
            // 
            // orderListTableAdapter
            // 
            this.orderListTableAdapter.ClearBeforeFill = true;
            // 
            // recoveredTableAdapter
            // 
            this.recoveredTableAdapter.ClearBeforeFill = true;
            // 
            // orderList_出库TableAdapter
            // 
            this.orderList_出库TableAdapter.ClearBeforeFill = true;
            // 
            // orderList_入库TableAdapter
            // 
            this.orderList_入库TableAdapter.ClearBeforeFill = true;
            // 
            // button_选中出库
            // 
            this.button_选中出库.Location = new System.Drawing.Point(344, 67);
            this.button_选中出库.Name = "button_选中出库";
            this.button_选中出库.Size = new System.Drawing.Size(75, 23);
            this.button_选中出库.TabIndex = 3;
            this.button_选中出库.Text = "选中出库";
            this.button_选中出库.UseVisualStyleBackColor = true;
            this.button_选中出库.Visible = false;
            this.button_选中出库.Click += new System.EventHandler(this.button_选中出库_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_退件处理.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectstockNumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveredBindingSource)).EndInit();
            this.tabPage_商品列表.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumBindingSource)).EndInit();
            this.tabPage_库存查看.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).EndInit();
            this.tabPage_出库.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_出库)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderList出库BindingSource)).EndInit();
            this.tabPage_入库.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_入库)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderList入库BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_退件处理;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage_商品列表;
        private System.Windows.Forms.Button button_getClipboardImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton_NotDone;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.RadioButton radioButton_Done;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Button button_SCode;
        private System.Windows.Forms.Button button_SDate;
        private System.Windows.Forms.Button button_退件入库;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource stockNumBindingSource;
        private DatabaseDataSetTableAdapters.stockNumTableAdapter stockNumTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button_stockNum_Save;
        private System.Windows.Forms.BindingSource selectstockNumBindingSource;
        private DatabaseDataSetTableAdapters.Select_stockNumTableAdapter select_stockNumTableAdapter;
        private System.Windows.Forms.TabPage tabPage_库存查看;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage_出库;
        private System.Windows.Forms.TabPage tabPage_入库;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView_入库;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataGridView_出库;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView_orderList;
        private System.Windows.Forms.BindingSource orderListBindingSource;
        private DatabaseDataSetTableAdapters.orderListTableAdapter orderListTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button_orderList;
        private DatabaseDataSetTableAdapters.recoveredTableAdapter recoveredTableAdapter;
        private System.Windows.Forms.BindingSource recoveredBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商家编码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 占用库存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 可用库存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总库存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 隐藏DataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn1;
        private CustomDGVComboBoxColumn 商家编码DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource orderList出库BindingSource;
        private DatabaseDataSetTableAdapters.orderList_出库TableAdapter orderList_出库TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn2;
        private CustomDGVComboBoxColumn 商家编码DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource orderList入库BindingSource;
        private DatabaseDataSetTableAdapters.orderList_入库TableAdapter orderList_入库TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn3;
        private CustomDGVComboBoxColumn 商家编码DataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button_出库;
        private System.Windows.Forms.Button button_出库单保存;
        private System.Windows.Forms.Button button_入库;
        private System.Windows.Forms.Button button_入库单保存;
        private System.Windows.Forms.Button button_库存查看刷新;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单号DataGridViewTextBoxColumn;
        private CustomDGVComboBoxColumn 型号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn 图片DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 处理DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 入库DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_撤销出入库;
        private System.Windows.Forms.Button button_选中出库;
    }
}

