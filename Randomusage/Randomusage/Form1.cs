using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomusage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Random rdm = new Random();
            int num;
            num = rdm.Next(1, 79);
            label1.Text = num.ToString();*/
            Random rdm = new Random();
            int n1, n2, n3;
            n1 = rdm.Next(1, 100);
            n2 = rdm.Next(5, 84);
            n3= rdm.Next(2, 43);
            label1.Text = n1.ToString();
            label2.Text = n2.ToString();
            label3.Text = n3.ToString();
        }
    }
}
