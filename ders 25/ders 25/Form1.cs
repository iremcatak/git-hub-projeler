using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 4)
            {
              
                this.BackColor = Color.Maroon;
            }
            if (sayac == 12)
            {

                this.BackColor = Color.Moccasin;
            }
            if (sayac == 13)
            {
                sayac = 0;
         
            }
        }
        
    }
}
