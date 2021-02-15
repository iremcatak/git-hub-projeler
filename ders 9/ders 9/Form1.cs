using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı, sonuç;
            sayı = Convert.ToInt16(textBox1.Text);
            sonuç = sayı * sayı * sayı;
            label2.Text = sonuç.ToString;

           

        }
    }
}
