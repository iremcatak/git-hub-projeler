using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] array = new int[2, 2];
            array[0,0]=25;
            array[0,1]=36;
            array[1,0]=85;
            array[1,1]=74;
            label1.Text = array[1, 0].ToString();
        }
    }
}
