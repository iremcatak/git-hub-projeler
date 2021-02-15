namespace _170201027_irem_çatak_assignment_
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
            this.my_DataSet1 = new _170201027_irem_çatak_assignment_.my_DataSet1();
            this.t1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t1TableAdapter = new _170201027_irem_çatak_assignment_.my_DataSet1TableAdapters.T1TableAdapter();
            this.t1IdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1AAADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.myDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t2TableAdapter = new _170201027_irem_çatak_assignment_.my_DataSet1TableAdapters.T2TableAdapter();
            this.t2IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2XXXXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1IDFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t1IdDataGridViewTextBoxColumn,
            this.t1NameDataGridViewTextBoxColumn,
            this.t1AAADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // my_DataSet1
            // 
            this.my_DataSet1.DataSetName = "my_DataSet1";
            this.my_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t1BindingSource
            // 
            this.t1BindingSource.DataMember = "T1";
            this.t1BindingSource.DataSource = this.my_DataSet1;
            // 
            // t1TableAdapter
            // 
            this.t1TableAdapter.ClearBeforeFill = true;
            // 
            // t1IdDataGridViewTextBoxColumn
            // 
            this.t1IdDataGridViewTextBoxColumn.DataPropertyName = "T1_Id";
            this.t1IdDataGridViewTextBoxColumn.HeaderText = "T1_Id";
            this.t1IdDataGridViewTextBoxColumn.Name = "t1IdDataGridViewTextBoxColumn";
            // 
            // t1NameDataGridViewTextBoxColumn
            // 
            this.t1NameDataGridViewTextBoxColumn.DataPropertyName = "T1_Name";
            this.t1NameDataGridViewTextBoxColumn.HeaderText = "T1_Name";
            this.t1NameDataGridViewTextBoxColumn.Name = "t1NameDataGridViewTextBoxColumn";
            // 
            // t1AAADataGridViewTextBoxColumn
            // 
            this.t1AAADataGridViewTextBoxColumn.DataPropertyName = "T1_AAA";
            this.t1AAADataGridViewTextBoxColumn.HeaderText = "T1_AAA";
            this.t1AAADataGridViewTextBoxColumn.Name = "t1AAADataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t2IDDataGridViewTextBoxColumn,
            this.t2XXXXDataGridViewTextBoxColumn,
            this.t1IDFKDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.t2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(369, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(398, 236);
            this.dataGridView2.TabIndex = 1;
            // 
            // myDataSet1BindingSource
            // 
            this.myDataSet1BindingSource.DataSource = this.my_DataSet1;
            this.myDataSet1BindingSource.Position = 0;
            // 
            // t2BindingSource
            // 
            this.t2BindingSource.DataMember = "T2";
            this.t2BindingSource.DataSource = this.myDataSet1BindingSource;
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
            // t2XXXXDataGridViewTextBoxColumn
            // 
            this.t2XXXXDataGridViewTextBoxColumn.DataPropertyName = "T2_XXXX";
            this.t2XXXXDataGridViewTextBoxColumn.HeaderText = "T2_XXXX";
            this.t2XXXXDataGridViewTextBoxColumn.Name = "t2XXXXDataGridViewTextBoxColumn";
            // 
            // t1IDFKDataGridViewTextBoxColumn
            // 
            this.t1IDFKDataGridViewTextBoxColumn.DataPropertyName = "T1_ID_FK";
            this.t1IDFKDataGridViewTextBoxColumn.HeaderText = "T1_ID_FK";
            this.t1IDFKDataGridViewTextBoxColumn.Name = "t1IDFKDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private my_DataSet1 my_DataSet1;
        private System.Windows.Forms.BindingSource t1BindingSource;
        private my_DataSet1TableAdapters.T1TableAdapter t1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1IdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1AAADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource myDataSet1BindingSource;
        private System.Windows.Forms.BindingSource t2BindingSource;
        private my_DataSet1TableAdapters.T2TableAdapter t2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2XXXXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1IDFKDataGridViewTextBoxColumn;
    }
}

