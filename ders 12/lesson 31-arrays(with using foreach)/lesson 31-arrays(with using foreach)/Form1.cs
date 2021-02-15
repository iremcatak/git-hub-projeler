using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_31_arrays_with_using_foreach_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string[] people = { "Kerem", "Tuna", "Ali", "Vefa", "Ediz", "Melike" };
             foreach(string k in people)
             {
                 listBox1.Items.Add(k);
             }*/
            int sum = 0;
            int[] exams = { 12,65, 23, 78, 90 };
            foreach(int x in exams)
            {
                listBox1.Items.Add(x);
                sum = sum + x;
            }
            label1.Text = sum.ToString();
            int average = sum / exams.Length;
            label2.Text = average.ToString();
        }
    }
}
