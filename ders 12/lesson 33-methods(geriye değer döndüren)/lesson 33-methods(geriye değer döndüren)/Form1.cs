using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_33_methods_geriye_değer_döndüren_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sum(int num1,int num2)
        {
            int num3 = num1 + num2;
            return num3;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=sum(98,5).ToString();
        }
    }
}
