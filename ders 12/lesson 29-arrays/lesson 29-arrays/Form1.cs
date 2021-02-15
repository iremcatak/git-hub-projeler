using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_29_arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string[] people = { "Ali", "Ahmet", "Aslı", "Hakan", "Ayse", "Demet" };
            label1.Text = people[4];*/
            int[] numbers = { 3, 4, 5, 6, 7, 8, 9 };
            label1.Text = numbers[5].ToString();
            
        }
    }
}
