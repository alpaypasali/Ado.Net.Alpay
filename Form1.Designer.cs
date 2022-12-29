namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.alpayADONETDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alpay_ADONETDataSet = new WindowsFormsApp1.alpay_ADONETDataSet();
            this.studentTableAdapter = new WindowsFormsApp1.alpay_ADONETDataSetTableAdapters.StudentTableAdapter();
            this.consultantTableAdapter = new WindowsFormsApp1.alpay_ADONETDataSetTableAdapters.ConsultantTableAdapter();
            this.birthdayTableAdapter = new WindowsFormsApp1.alpay_ADONETDataSetTableAdapters.BirthdayTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpayADONETDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpay_ADONETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.birthdayIDDataGridViewTextBoxColumn,
            this.consultantIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.courseYearDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 119);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(974, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.alpayADONETDataSetBindingSource;
            this.bindingSource1.Position = 0;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Student";
            this.bindingSource2.DataSource = this.bindingSource1;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "Consultant";
            this.bindingSource3.DataSource = this.bindingSource1;
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "Birthday";
            this.bindingSource4.DataSource = this.bindingSource1;
            // 
            // alpayADONETDataSetBindingSource
            // 
            this.alpayADONETDataSetBindingSource.DataSource = this.alpay_ADONETDataSet;
            this.alpayADONETDataSetBindingSource.Position = 0;
            // 
            // alpay_ADONETDataSet
            // 
            this.alpay_ADONETDataSet.DataSetName = "alpay_ADONETDataSet";
            this.alpay_ADONETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // consultantTableAdapter
            // 
            this.consultantTableAdapter.ClearBeforeFill = true;
            // 
            // birthdayTableAdapter
            // 
            this.birthdayTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayIDDataGridViewTextBoxColumn
            // 
            this.birthdayIDDataGridViewTextBoxColumn.DataPropertyName = "BirthdayID";
            this.birthdayIDDataGridViewTextBoxColumn.HeaderText = "BirthdayID";
            this.birthdayIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayIDDataGridViewTextBoxColumn.Name = "birthdayIDDataGridViewTextBoxColumn";
            this.birthdayIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // consultantIDDataGridViewTextBoxColumn
            // 
            this.consultantIDDataGridViewTextBoxColumn.DataPropertyName = "ConsultantID";
            this.consultantIDDataGridViewTextBoxColumn.HeaderText = "ConsultantID";
            this.consultantIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.consultantIDDataGridViewTextBoxColumn.Name = "consultantIDDataGridViewTextBoxColumn";
            this.consultantIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 150;
            // 
            // courseYearDataGridViewTextBoxColumn
            // 
            this.courseYearDataGridViewTextBoxColumn.DataPropertyName = "CourseYear";
            this.courseYearDataGridViewTextBoxColumn.HeaderText = "CourseYear";
            this.courseYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseYearDataGridViewTextBoxColumn.Name = "courseYearDataGridViewTextBoxColumn";
            this.courseYearDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn1,
            this.consultantNameDataGridViewTextBoxColumn,
            this.facultyDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(12, 137);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1125, 127);
            this.dataGridView2.TabIndex = 2;
            // 
            // ıDDataGridViewTextBoxColumn1
            // 
            this.ıDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.ıDDataGridViewTextBoxColumn1.Name = "ıDDataGridViewTextBoxColumn1";
            this.ıDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // consultantNameDataGridViewTextBoxColumn
            // 
            this.consultantNameDataGridViewTextBoxColumn.DataPropertyName = "ConsultantName";
            this.consultantNameDataGridViewTextBoxColumn.HeaderText = "ConsultantName";
            this.consultantNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.consultantNameDataGridViewTextBoxColumn.Name = "consultantNameDataGridViewTextBoxColumn";
            this.consultantNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            this.facultyDataGridViewTextBoxColumn.DataPropertyName = "Faculty";
            this.facultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.facultyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            this.facultyDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn2,
            this.birthdayDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bindingSource4;
            this.dataGridView3.Location = new System.Drawing.Point(12, 270);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(786, 168);
            this.dataGridView3.TabIndex = 3;
            // 
            // ıDDataGridViewTextBoxColumn2
            // 
            this.ıDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.ıDDataGridViewTextBoxColumn2.Name = "ıDDataGridViewTextBoxColumn2";
            this.ıDDataGridViewTextBoxColumn2.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "a";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpayADONETDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpay_ADONETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource alpayADONETDataSetBindingSource;
        private alpay_ADONETDataSet alpay_ADONETDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private alpay_ADONETDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource3;
        private alpay_ADONETDataSetTableAdapters.ConsultantTableAdapter consultantTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource4;
        private alpay_ADONETDataSetTableAdapters.BirthdayTableAdapter birthdayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}

