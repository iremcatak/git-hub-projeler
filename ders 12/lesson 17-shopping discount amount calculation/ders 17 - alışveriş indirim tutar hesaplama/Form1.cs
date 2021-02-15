using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_17___alışveriş_indirim_tutar_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookamount;
            double total;
            bookamount = Convert.ToInt16(textBox1.Text);
            if (bookamount >= 0 && bookamount <= 20)
            {
                total = (bookamount * 8) - (bookamount * 8 * 0.20);
                label3.Text = total + "$";
            }
            if (bookamount >= 21 && bookamount <= 40)
            {
                total = (bookamount * 8) - (bookamount * 8 * 0.40);
                label3.Text = total + "$";
            }
            if (bookamount >= 41 )
            {
                total =( bookamount * 8) - (bookamount * 8 * 0.50);
                label3.Text = total + "$";
            }
        }
    }
}
