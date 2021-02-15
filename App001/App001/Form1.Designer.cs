
namespace App001
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new App001.DataSet1();
            this.t1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t1TableAdapter = new App001.DataSet1TableAdapters.T1TableAdapter();
            this.t1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1NDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t2TableAdapter = new App001.DataSet1TableAdapters.T2TableAdapter();
            this.t2IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2NDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new App001.DataSet1TableAdapters.DataTable1TableAdapter();
            this.t1IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1NDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2NDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t2IDDataGridViewTextBoxColumn,
            this.t2NDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.t2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(446, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t1IDDataGridViewTextBoxColumn1,
            this.t1NDataGridViewTextBoxColumn1,
            this.t2NDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.dataTable1BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(238, 226);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t1IDDataGridViewTextBoxColumn,
            this.t1NDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t1BindingSource
            // 
            this.t1BindingSource.DataMember = "T1";
            this.t1BindingSource.DataSource = this.dataSet1;
            // 
            // t1TableAdapter
            // 
            this.t1TableAdapter.ClearBeforeFill = true;
            // 
            // t1IDDataGridViewTextBoxColumn
            // 
            this.t1IDDataGridViewTextBoxColumn.DataPropertyName = "T1_ID";
            this.t1IDDataGridViewTextBoxColumn.HeaderText = "T1_ID";
            this.t1IDDataGridViewTextBoxColumn.Name = "t1IDDataGridViewTextBoxColumn";
            // 
            // t1NDataGridViewTextBoxColumn
            // 
            this.t1NDataGridViewTextBoxColumn.DataPropertyName = "T1_N";
            this.t1NDataGridViewTextBoxColumn.HeaderText = "T1_N";
            this.t1NDataGridViewTextBoxColumn.Name = "t1NDataGridViewTextBoxColumn";
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // t2BindingSource
            // 
            this.t2BindingSource.DataMember = "T2";
            this.t2BindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // t2TableAdapter
            // 
            this.t2TableAdapter.ClearBeforeFill = true;
            // 
            // t2IDDataGridViewTextBoxColumn
            // 
            this.t2IDDataGridViewTextBoxColumn.DataPropertyName = "T2_ID";
            this.t2IDDataGridViewTextBoxColumn.HeaderText = "T2_ID";
            this.t2IDDataGridViewTextBoxColumn.Name = "t2IDDataGridViewTextBoxColumn";
            // 
            // t2NDataGridViewTextBoxColumn
            // 
            this.t2NDataGridViewTextBoxColumn.DataPropertyName = "T2_N";
            this.t2NDataGridViewTextBoxColumn.HeaderText = "T2_N";
            this.t2NDataGridViewTextBoxColumn.Name = "t2NDataGridViewTextBoxColumn";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // t1IDDataGridViewTextBoxColumn1
            // 
            this.t1IDDataGridViewTextBoxColumn1.DataPropertyName = "T1_ID";
            this.t1IDDataGridViewTextBoxColumn1.HeaderText = "T1_ID";
            this.t1IDDataGridViewTextBoxColumn1.Name = "t1IDDataGridViewTextBoxColumn1";
            // 
            // t1NDataGridViewTextBoxColumn1
            // 
            this.t1NDataGridViewTextBoxColumn1.DataPropertyName = "T1_N";
            this.t1NDataGridViewTextBoxColumn1.HeaderText = "T1_N";
            this.t1NDataGridViewTextBoxColumn1.Name = "t1NDataGridViewTextBoxColumn1";
            // 
            // t2NDataGridViewTextBoxColumn1
            // 
            this.t2NDataGridViewTextBoxColumn1.DataPropertyName = "T2_N";
            this.t2NDataGridViewTextBoxColumn1.HeaderText = "T2_N";
            this.t2NDataGridViewTextBoxColumn1.Name = "t2NDataGridViewTextBoxColumn1";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(509, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(647, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource t1BindingSource;
        private DataSet1TableAdapters.T1TableAdapter t1TableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1NDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource t2BindingSource;
        private DataSet1TableAdapters.T2TableAdapter t2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2NDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1NDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2NDataGridViewTextBoxColumn1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

