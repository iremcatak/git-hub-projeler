using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_sheet5_q2
{
    public partial class Form1 : Form
    {
        Rectangle R = new Rectangle();
        Triangle T = new Triangle();
        Shape S = new Shape();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox3.Text, out R.L);
            double.TryParse(textBox4.Text, out R.W);
            textBox1.Text = R.Get_Area().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = R.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox6.Text, out T.B);
            double.TryParse(textBox5.Text, out T.H);
           textBox8.Text = T.Get_Area().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = T.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox11.Text = S.ToString();
        }
    }
}
