using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] symbol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] symbol2 = { "+", "-", "*", "/", "#" };
            Random r = new Random();
            int s1, s2, s3;
            s1 = r.Next(0, symbol1.Length);
            s2 = r.Next(0, symbol2.Length);
            s3 = r.Next(0, 10);
            label1.Text = symbol1[s1].ToString() + symbol2[s2].ToString() + s3.ToString();
                   }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
