
namespace practice2
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
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new practice2.Properties.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.accounIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerditDebitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accounBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.techIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.engIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empTableAdapter = new practice2.Properties.DataSet1TableAdapters.EmpTableAdapter();
            this.empTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techTableAdapter = new practice2.Properties.DataSet1TableAdapters.TechTableAdapter();
            this.accounTableAdapter = new practice2.Properties.DataSet1TableAdapters.AccounTableAdapter();
            this.engiTableAdapter = new practice2.Properties.DataSet1TableAdapters.EngiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empTechBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empSalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_Name";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "Emp_Name";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            // 
            // empSalaryDataGridViewTextBoxColumn
            // 
            this.empSalaryDataGridViewTextBoxColumn.DataPropertyName = "Emp_Salary";
            this.empSalaryDataGridViewTextBoxColumn.HeaderText = "Emp_Salary";
            this.empSalaryDataGridViewTextBoxColumn.Name = "empSalaryDataGridViewTextBoxColumn";
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataMember = "Emp";
            this.empBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accounIDDataGridViewTextBoxColumn,
            this.cerditDebitDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.accounBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(400, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 143);
            this.dataGridView2.TabIndex = 1;
            // 
            // accounIDDataGridViewTextBoxColumn
            // 
            this.accounIDDataGridViewTextBoxColumn.DataPropertyName = "Accoun_ID";
            this.accounIDDataGridViewTextBoxColumn.HeaderText = "Accoun_ID";
            this.accounIDDataGridViewTextBoxColumn.Name = "accounIDDataGridViewTextBoxColumn";
            // 
            // cerditDebitDataGridViewTextBoxColumn
            // 
            this.cerditDebitDataGridViewTextBoxColumn.DataPropertyName = "Cerdit_Debit";
            this.cerditDebitDataGridViewTextBoxColumn.HeaderText = "Cerdit_Debit";
            this.cerditDebitDataGridViewTextBoxColumn.Name = "cerditDebitDataGridViewTextBoxColumn";
            // 
            // accounBindingSource
            // 
            this.accounBindingSource.DataMember = "Accoun";
            this.accounBindingSource.DataSource = this.dataSet1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.techIDDataGridViewTextBoxColumn1,
            this.serviceDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.techBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(24, 192);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(344, 143);
            this.dataGridView3.TabIndex = 2;
            // 
            // techIDDataGridViewTextBoxColumn1
            // 
            this.techIDDataGridViewTextBoxColumn1.DataPropertyName = "Tech_ID";
            this.techIDDataGridViewTextBoxColumn1.HeaderText = "Tech_ID";
            this.techIDDataGridViewTextBoxColumn1.Name = "techIDDataGridViewTextBoxColumn1";
            // 
            // serviceDataGridViewTextBoxColumn1
            // 
            this.serviceDataGridViewTextBoxColumn1.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn1.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn1.Name = "serviceDataGridViewTextBoxColumn1";
            // 
            // techBindingSource
            // 
            this.techBindingSource.DataMember = "Tech";
            this.techBindingSource.DataSource = this.dataSet1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.engIDDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.engiBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(400, 192);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(344, 143);
            this.dataGridView4.TabIndex = 3;
            // 
            // engIDDataGridViewTextBoxColumn
            // 
            this.engIDDataGridViewTextBoxColumn.DataPropertyName = "Eng_ID";
            this.engIDDataGridViewTextBoxColumn.HeaderText = "Eng_ID";
            this.engIDDataGridViewTextBoxColumn.Name = "engIDDataGridViewTextBoxColumn";
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            // 
            // engiBindingSource
            // 
            this.engiBindingSource.DataMember = "Engi";
            this.engiBindingSource.DataSource = this.dataSet1;
            // 
            // empTableAdapter
            // 
            this.empTableAdapter.ClearBeforeFill = true;
            // 
            // empTechBindingSource
            // 
            this.empTechBindingSource.DataMember = "Emp_Tech";
            this.empTechBindingSource.DataSource = this.empBindingSource;
            // 
            // techTableAdapter
            // 
            this.techTableAdapter.ClearBeforeFill = true;
            // 
            // accounTableAdapter
            // 
            this.accounTableAdapter.ClearBeforeFill = true;
            // 
            // engiTableAdapter
            // 
            this.engiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empTechBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private Properties.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource empBindingSource;
        private Properties.DataSet1TableAdapters.EmpTableAdapter empTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empTechBindingSource;
        private Properties.DataSet1TableAdapters.TechTableAdapter techTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn techIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource techBindingSource;
        private System.Windows.Forms.BindingSource accounBindingSource;
        private Properties.DataSet1TableAdapters.AccounTableAdapter accounTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accounIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cerditDebitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource engiBindingSource;
        private Properties.DataSet1TableAdapters.EngiTableAdapter engiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn engIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

