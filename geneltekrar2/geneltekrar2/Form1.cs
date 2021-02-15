using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geneltekrar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
         
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;

            }
            textBox1.Text = Convert.ToString(sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int j = 2; j <= 10; j+=2)
            {
                sum = sum + j;

            }
            textBox1.Text = Convert.ToString(sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int k = 1; k <= 10; k++)
            {
                if (k % 3 == 0)
                {
                    listBox1.Items.Add(k);
                }
            }
        }
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 10)
            {
              //  timer1.Stop();
                this.BackColor = Color.PeachPuff;
            }
            if (sayac == 20)
            {
                //  timer1.Stop();
                this.BackColor = Color.AliceBlue;
                sayac = 0;
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
