using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            //label2.Text = Math.Abs(number).ToString();
            //Ceil üste yuvarlamak---floor taban
            label2.Text = Math.Floor(number).ToString();
        }
    }
}
