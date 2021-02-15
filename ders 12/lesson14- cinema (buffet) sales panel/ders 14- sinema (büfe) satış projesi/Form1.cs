using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_14__sinema__büfe__satış_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int corn, ticket, water, tea, total;
            corn = Convert.ToInt16(txtcorn.Text);
            ticket = Convert.ToInt16(txtticket.Text);
            water = Convert.ToInt16(txtwater.Text);
            tea = Convert.ToInt16(txttea.Text);
            total = corn * 4 + tea * 2 + water * 1 + ticket * 8;
            lbltotal.Text = total.ToString()+ "TL";
            kasatutar = kasatutar + total;
            lblcasetotal.Text = kasatutar.ToString() + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtticket.Text = "";
            txttea.Text = "";
            txtwater.Text = "";
            txtcorn.Text = "";
            txtcorn.Focus();
        }
    }
}
