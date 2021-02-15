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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int second, minute,hour;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            label1.Text = second.ToString();
            if (second == 60)
            {
                minute++;
                label2.Text = minute.ToString();
                second = 0;
                if (minute == 60)
                {
                    hour++;
                    label3.Text = hour.ToString();
                    minute = 0;
                }
            }
        }
    }
}
