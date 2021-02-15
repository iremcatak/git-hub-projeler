using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar, alan, çevre;
            kenar = 10;
            alan = kenar * kenar;
            çevre = kenar * 4;
            label1.Text = "Alan: " + alan + " Çevre:"+çevre;
        }
    }
}
