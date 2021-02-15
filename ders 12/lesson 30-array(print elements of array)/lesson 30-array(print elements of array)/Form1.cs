using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_30_array_print_elements_of_array_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string[] cities = { "Ankara", "Paris", "Osaka", "Dubai" };
             for (int i = 0; i <cities.Length; i++)
             {
                 listBox1.Items.Add(cities[i]);
             }*/
            int[] numbers = { 4, 2, 3, 1, 6, 5, 9, 7 };
           
                 for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) { 
                    listBox1.Items.Add(numbers[i]);
                }
            }
        }

    }
}
