using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "2";
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "3";
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "4";
            textBox1.Text += button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "5";
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "6";
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "7";
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "8";
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "9";
            textBox1.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            button0.Text = "0";
            textBox1.Text += button0.Text;
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            buttonmultiply.Text = "*";
            textBox1.Text = Console.ReadLine();
           
            textBox1.Text += buttonmultiply.Text;
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            buttondivide.Text = "/";
            textBox1.Text = Console.ReadLine();
            textBox1.Text += buttondivide.Text;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            buttonplus.Text = "+";
            textBox1.Text = Console.ReadLine();
            textBox1.Text += buttonplus.Text;
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            buttonminus.Text = "-";
            textBox1.Text = Console.ReadLine();
            textBox1.Text += buttonminus.Text;
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            textBox1.Text = Console.ReadLine();
        }
    }
}
