using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_information_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double exam1, exam2, exam3, average, project;
            exam1 = Convert.ToDouble(textBox3.Text);
            exam2 = Convert.ToDouble(textBox4.Text);
            exam3 = Convert.ToDouble(textBox6.Text);
            project = Convert.ToDouble(textBox7.Text);
            average = (exam1 + exam2 + exam3 + project) / 4;
            textBox5.Text = average.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Name: " + textBox1.Text +" " +textBox2.Text + " Exams: " + textBox3.Text + "," + textBox4.Text + "," + textBox6.Text + " Project: " + textBox7.Text + "  Average: " + textBox5.Text);
        }
    }
}
