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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_getClipboardImage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Save = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_get = new System.Windows.Forms.Button();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.radioButton_NotDone = new System.Windows.Forms.RadioButton();
            this.radioButton_Done = new System.Windows.Forms.RadioButton();
            this.radioButton_Date = new System.Windows.Forms.RadioButton();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.radioButton_code = new System.Windows.Forms.RadioButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.图片DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.处理DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recoveredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new AJ78.DatabaseDataSet();
            this.recoveredTableAdapter = new AJ78.DatabaseDataSetTableAdapters.recoveredTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveredBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.radioButton_code);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_code);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton_Date);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(786, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 21);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 29, 0, 0, 0, 0);
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
            // radioButton_Done
            // 
            this.radioButton_Done.AutoSize = true;
            this.radioButton_Done.Location = new System.Drawing.Point(91, 43);
            this.radioButton_Done.Name = "radioButton_Done";
            this.radioButton_Done.Size = new System.Drawing.Size(59, 16);
            this.radioButton_Done.TabIndex = 9;
            this.radioButton_Done.TabStop = true;
            this.radioButton_Done.Text = "已处理";
            this.radioButton_Done.UseVisualStyleBackColor = true;
            // 
            // radioButton_Date
            // 
            this.radioButton_Date.AutoSize = true;
            this.radioButton_Date.Location = new System.Drawing.Point(156, 43);
            this.radioButton_Date.Name = "radioButton_Date";
            this.radioButton_Date.Size = new System.Drawing.Size(71, 16);
            this.radioButton_Date.TabIndex = 11;
            this.radioButton_Date.TabStop = true;
            this.radioButton_Date.Text = "指定日期";
            this.radioButton_Date.UseVisualStyleBackColor = true;
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(263, 16);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(128, 21);
            this.textBox_code.TabIndex = 12;
            // 
            // radioButton_code
            // 
            this.radioButton_code.AutoSize = true;
            this.radioButton_code.Location = new System.Drawing.Point(293, 43);
            this.radioButton_code.Name = "radioButton_code";
            this.radioButton_code.Size = new System.Drawing.Size(47, 16);
            this.radioButton_code.TabIndex = 13;
            this.radioButton_code.TabStop = true;
            this.radioButton_code.Text = "单号";
            this.radioButton_code.UseVisualStyleBackColor = true;
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
            this.型号DataGridViewTextBoxColumn.HeaderText = "型号";
            this.型号DataGridViewTextBoxColumn.Name = "型号DataGridViewTextBoxColumn";
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
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recoveredTableAdapter
            // 
            this.recoveredTableAdapter.ClearBeforeFill = true;
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
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveredBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_getClipboardImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource recoveredBindingSource;
        private DatabaseDataSetTableAdapters.recoveredTableAdapter recoveredTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn 图片DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 处理DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton_NotDone;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.RadioButton radioButton_Done;
        private System.Windows.Forms.RadioButton radioButton_Date;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.RadioButton radioButton_code;
    }
}

