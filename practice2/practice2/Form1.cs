using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Engi' table. You can move, or remove it, as needed.
            this.engiTableAdapter.Fill(this.dataSet1.Engi);
            // TODO: This line of code loads data into the 'dataSet1.Accoun' table. You can move, or remove it, as needed.
            this.accounTableAdapter.Fill(this.dataSet1.Accoun);
            // TODO: This line of code loads data into the 'dataSet1.Tech' table. You can move, or remove it, as needed.
            this.techTableAdapter.Fill(this.dataSet1.Tech);
            // TODO: This line of code loads data into the 'dataSet1.Emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.dataSet1.Emp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* this.empTableAdapter.Insert(1, "a");
            this.empTableAdapter.Fill(this.dataSet1.Emp);*/
        }
    }
}
