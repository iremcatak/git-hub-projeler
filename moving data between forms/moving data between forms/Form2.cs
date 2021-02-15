using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moving_data_between_forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      public  string message;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = message;
        }
    }
}
