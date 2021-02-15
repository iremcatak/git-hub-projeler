using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_34_calculating_cube_by_using_method_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cube(int number)
        {
            int result = number * number * number;
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox1.Text);
            label1.Text = cube(s).ToString();
        }
    }
}
