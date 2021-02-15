using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace geneltekrar2
{
    public partial class diziler : Form
    {
        public diziler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string[] people = { "Jack", "Rose", "Caledon", "Fabrizio","Ruth", "Tommy", "Spicer" };
             label1.Text = people[4];   */
            //-------------------------------------------------------
            /*int[] number = { 1, 4, 6, 7, 74, 2, 421 };
            label1.Text = number[6].ToString();*/
            //-------------------------------------------------------
            /*string[] cities = {"Tokyo","Jakarta","Delhi","Manila","Seoul","Shangai","Karachi","Beijing" };
            for(int i = 0; i <cities.Length; i++) 
            {
                listBox1.Items.Add(cities[i]);
            }*/
            //--------------------------------------------------------
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    listBox1.Items.Add(numbers[i]);
                }

            }

        }
    }
}
