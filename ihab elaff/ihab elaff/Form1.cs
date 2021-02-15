using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ihab_elaff
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XXX M1 = new XXX();
            XXX M2 = new XXX(3);
            textBox1.Text = M1.A.ToString();
            textBox2.Text = M2.A.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XXX M1 = new XXX();
            XXX M2 = new XXX(3);
            textBox1.Text = M1.A.ToString();
            textBox2.Text = M2.A.ToString();
        }
    }
    class XXX
    {
        public int A;
        XXX()
        { A = 0; }
       public  XXX(int a)
        { A = a; }
    }
}
