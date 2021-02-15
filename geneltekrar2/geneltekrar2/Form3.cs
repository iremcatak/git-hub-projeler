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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] people = { "Jack", "Rose", "Caledon", "Fabrizio", "Ruth", "Tommy", "Spicer" };
           foreach (string k in people)
            {
                listBox1.Items.Add(k);
            }
        }
    }
}
