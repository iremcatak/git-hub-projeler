using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* for(int i = 1; i <= 10; i++)
             {
                 if(i%3==0)
                 {
                     listBox1.Items.Add(i);
                 }
             }*/
            /* for(int i = 1; i <= 100; i++)
              {
                 if (i % 5 == 0 && i%7==0)


                 {
                     listBox1.Items.Add(i);
                 }
             }*/

            /*int sayı = Convert.ToInt16(textBox1.Text);
            for(int i = 1; i <= sayı; i++)
            {
                listBox1.Items.Add(i);

            }*/

            int sayı = Convert.ToInt16(textBox1.Text);
            for (int i = 1; i <= sayı; i++)
            {
                if (sayı % i == 0)
                {
                    listBox1.Items.Add(i);
  }

            }
        }
}
