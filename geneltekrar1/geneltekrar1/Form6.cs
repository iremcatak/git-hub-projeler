using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geneltekrar1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int questionno = 0;
        private void buttonNextQ_Click(object sender, EventArgs e)
        {
            questionno++;
            labelQuestionNo.Text = questionno.ToString();
            if (questionno == 1)
            {
                richTextBox1.Text = "What is the name of a rabbit who is a cartoon character and loves carrots very much?";
                buttonA.Text = "Road Runner";
                buttonB.Text = "Yosemite Sam";
                buttonC.Text = "Pepé Le Pew";
                buttonD.Text = "Bugs Bunny";
            }

        }
    }
}
