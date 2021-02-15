using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170201027_irem_çatak_assignment_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_DataSet1.T2' table. You can move, or remove it, as needed.
            this.t2TableAdapter.Fill(this.my_DataSet1.T2);
            // TODO: This line of code loads data into the 'my_DataSet1.T1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.my_DataSet1.T1);

        }
    }
}
