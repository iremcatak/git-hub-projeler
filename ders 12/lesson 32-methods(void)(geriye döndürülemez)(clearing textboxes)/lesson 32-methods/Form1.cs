using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_32_methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        void coloring()
        {
            textBox1.BackColor = Color.DarkRed;
            textBox2.BackColor = Color.AliceBlue;
            textBox3.BackColor = Color.SaddleBrown;
            textBox4.BackColor = Color.DeepPink;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coloring();
        }
    }
}
