using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geneltekrar2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int sum(int n1,int n2)
        {
            int n3 = n1 + n2;
            return n3;
        }
        int cube(int number)
        {
            int result = number * number * number;
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = sum(4, 6).ToString();
            label2.Text = sum(1214, 6442).ToString();
            int n = Convert.ToInt16(textBox1.Text);
            label3.Text = cube(n).ToString();
        }

    }
}
