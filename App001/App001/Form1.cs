using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: This line of code loads data into the 'dataSet1.T2' table. You can move, or remove it, as needed.
            this.t2TableAdapter.Fill(this.dataSet1.T2);
            // TODO: This line of code loads data into the 'dataSet1.T1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.dataSet1.T1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*this.t1TableAdapter.Insert(1,"A");
            this.t1TableAdapter.Fill(this.dataSet1.T1);*/
        }
    }
}
