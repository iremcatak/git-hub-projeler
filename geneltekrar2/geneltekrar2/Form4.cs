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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        void paint()
        {
            textBox1.BackColor = Color.CadetBlue;
            textBox2.BackColor = Color.Chocolate;
            textBox3.BackColor = Color.Honeydew;
            textBox4.BackColor = Color.Salmon;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paint();
        }
    }
}