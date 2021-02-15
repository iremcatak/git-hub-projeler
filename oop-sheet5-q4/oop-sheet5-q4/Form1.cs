using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_sheet5_q4
{
    public partial class Form1 : Form
    {
        Member x = new Member();
        Com_Mem Cmember = new Com_Mem();
        Sal_Mem Smember = new Sal_Mem();
        Hour_Mem Hmember = new Hour_Mem();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out Smember.Salary);

            textBox6.Text = Smember.Print_Mem_Data().ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out Cmember.Sales);
            
            textBox5.Text = Cmember.Print_Mem_Data().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out Hmember.Hours);
            double.TryParse(textBox4.Text, out Hmember.Rate);
            textBox7.Text = Hmember.Print_Mem_Data().ToString();
        }
    }
}
