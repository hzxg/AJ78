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
            this.button1 = new System.Windows.Forms.Button();
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
            this.recoveredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_商品列表 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button_sumUsable = new System.Windows.Forms.Button();
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
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.recoveredTableAdapter = new AJ78.DatabaseDataSetTableAdapters.recoveredTableAdapter();
            this.stockNumTableAdapter = new AJ78.DatabaseDataSetTableAdapters.stockNumTableAdapter();
            this.select_stockNumTableAdapter = new AJ78.DatabaseDataSetTableAdapters.Select_stockNumTableAdapter();
            this.tabPage_出库 = new System.Windows.Forms.TabPage();
            this.tabPage_入库 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_入库 = new System.Windows.Forms.DataGridView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_出库 = new System.Windows.Forms.DataGridView();
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
            this.tabPage_出库.SuspendLayout();
            this.tabPage_入库.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_入库)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_出库)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage_退件处理
            // 
            this.tabPage_退件处理.Controls.Add(this.splitContainer1);
            this.tabPage_退件处理.Location = new System.Drawing.Point(4, 22);
            this.tabPage_退件处理.Name = "tabPage_退件处理";
            this.tabPage_退件处理.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_退件处理.Size = new System.Drawing.Size(792, 424);
            this.tabPage_退件处理.TabIndex = 0;
            this.tabPage_退件处理.Text = "退件处理";
            this.tabPage_退件处理.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_add);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
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
            this.splitContainer1.Size = new System.Drawing.Size(786, 418);
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
            this.button2.Location = new System.Drawing.Point(383, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button_get.Location = new System.Drawing.Point(79, 90);
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
            this.pictureBox1.Location = new System.Drawing.Point(638, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 117);
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
            this.处理DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recoveredBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(786, 291);
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
            this.idDataGridViewTextBoxColumn.Width = 30;
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
            this.图片DataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
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
            this.tabPage_商品列表.Size = new System.Drawing.Size(792, 424);
            this.tabPage_商品列表.TabIndex = 1;
            this.tabPage_商品列表.Text = "商品列表";
            this.tabPage_商品列表.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button_sumUsable);
            this.splitContainer2.Panel1.Controls.Add(this.button_stockNum_Save);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(786, 418);
            this.splitContainer2.SplitterDistance = 108;
            this.splitContainer2.TabIndex = 1;
            // 
            // button_sumUsable
            // 
            this.button_sumUsable.Location = new System.Drawing.Point(594, 69);
            this.button_sumUsable.Name = "button_sumUsable";
            this.button_sumUsable.Size = new System.Drawing.Size(75, 23);
            this.button_sumUsable.TabIndex = 1;
            this.button_sumUsable.Text = "合计可用";
            this.button_sumUsable.UseVisualStyleBackColor = true;
            this.button_sumUsable.Click += new System.EventHandler(this.button_sumUsable_Click);
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
            this.dataGridView2.Size = new System.Drawing.Size(786, 306);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 商家编码DataGridViewTextBoxColumn
            // 
            this.商家编码DataGridViewTextBoxColumn.DataPropertyName = "商家编码";
            this.商家编码DataGridViewTextBoxColumn.HeaderText = "商家编码";
            this.商家编码DataGridViewTextBoxColumn.Name = "商家编码DataGridViewTextBoxColumn";
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
            this.tabPage_库存查看.Controls.Add(this.button5);
            this.tabPage_库存查看.Controls.Add(this.textBoxOutput);
            this.tabPage_库存查看.Controls.Add(this.button4);
            this.tabPage_库存查看.Controls.Add(this.textBox1);
            this.tabPage_库存查看.Controls.Add(this.button3);
            this.tabPage_库存查看.Controls.Add(this.treeView1);
            this.tabPage_库存查看.Location = new System.Drawing.Point(4, 22);
            this.tabPage_库存查看.Name = "tabPage_库存查看";
            this.tabPage_库存查看.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_库存查看.Size = new System.Drawing.Size(792, 424);
            this.tabPage_库存查看.TabIndex = 2;
            this.tabPage_库存查看.Text = "库存查看";
            this.tabPage_库存查看.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(614, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(565, 112);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(202, 278);
            this.textBoxOutput.TabIndex = 5;
            this.textBoxOutput.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 21);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Indent = 30;
            this.treeView1.Location = new System.Drawing.Point(21, 34);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(329, 382);
            this.treeView1.TabIndex = 0;
            // 
            // recoveredTableAdapter
            // 
            this.recoveredTableAdapter.ClearBeforeFill = true;
            // 
            // stockNumTableAdapter
            // 
            this.stockNumTableAdapter.ClearBeforeFill = true;
            // 
            // select_stockNumTableAdapter
            // 
            this.select_stockNumTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage_出库
            // 
            this.tabPage_出库.Controls.Add(this.splitContainer4);
            this.tabPage_出库.Location = new System.Drawing.Point(4, 22);
            this.tabPage_出库.Name = "tabPage_出库";
            this.tabPage_出库.Size = new System.Drawing.Size(792, 424);
            this.tabPage_出库.TabIndex = 3;
            this.tabPage_出库.Text = "出库 ";
            this.tabPage_出库.UseVisualStyleBackColor = true;
            // 
            // tabPage_入库
            // 
            this.tabPage_入库.Controls.Add(this.splitContainer3);
            this.tabPage_入库.Location = new System.Drawing.Point(4, 22);
            this.tabPage_入库.Name = "tabPage_入库";
            this.tabPage_入库.Size = new System.Drawing.Size(792, 424);
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
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView_入库);
            this.splitContainer3.Size = new System.Drawing.Size(792, 424);
            this.splitContainer3.SplitterDistance = 95;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridView_入库
            // 
            this.dataGridView_入库.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_入库.Location = new System.Drawing.Point(344, 72);
            this.dataGridView_入库.Name = "dataGridView_入库";
            this.dataGridView_入库.RowTemplate.Height = 23;
            this.dataGridView_入库.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_入库.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView_出库);
            this.splitContainer4.Size = new System.Drawing.Size(792, 424);
            this.splitContainer4.SplitterDistance = 101;
            this.splitContainer4.TabIndex = 0;
            // 
            // dataGridView_出库
            // 
            this.dataGridView_出库.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_出库.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_出库.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_出库.Name = "dataGridView_出库";
            this.dataGridView_出库.RowTemplate.Height = 23;
            this.dataGridView_出库.Size = new System.Drawing.Size(792, 319);
            this.dataGridView_出库.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.tabPage_库存查看.PerformLayout();
            this.tabPage_出库.ResumeLayout(false);
            this.tabPage_入库.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_入库)).EndInit();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_出库)).EndInit();
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
        private System.Windows.Forms.BindingSource recoveredBindingSource;
        private DatabaseDataSetTableAdapters.recoveredTableAdapter recoveredTableAdapter;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton_NotDone;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.RadioButton radioButton_Done;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Button button_SCode;
        private System.Windows.Forms.Button button_SDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource stockNumBindingSource;
        private DatabaseDataSetTableAdapters.stockNumTableAdapter stockNumTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商家编码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 占用库存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 可用库存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总库存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 隐藏DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_stockNum_Save;
        private System.Windows.Forms.BindingSource selectstockNumBindingSource;
        private DatabaseDataSetTableAdapters.Select_stockNumTableAdapter select_stockNumTableAdapter;
        private System.Windows.Forms.TabPage tabPage_库存查看;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单号DataGridViewTextBoxColumn;
        private CustomDGVComboBoxColumn 型号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn 图片DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 处理DataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_sumUsable;
        private System.Windows.Forms.TabPage tabPage_出库;
        private System.Windows.Forms.TabPage tabPage_入库;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView_入库;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataGridView_出库;
    }
}

