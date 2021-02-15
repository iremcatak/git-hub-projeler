using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt16(textBox1.Text);
            if (sayı %2 ==0 || sayı>=10)
            {
                label1.Text = "10'dan büyük veya çift";
            }
            else
            {
                label1.Text = "10'dan büyük değil veya çift değil";
            }
        }
    }
}
