using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geneltekrar1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname;
            int exam1, exam2, project;
            double average;
            name = textBox1.Text;
            surname = textBox2.Text;
            exam1 = Convert.ToInt32(textBox3.Text);
            exam2 = Convert.ToInt32(textBox4.Text);
            project = Convert.ToInt32(textBox5.Text);
            average = (exam1 + exam2 + project) / 3;
            listBox1.Items.Add( name + "  " + surname + " average: " + average);
        }
    }
}
