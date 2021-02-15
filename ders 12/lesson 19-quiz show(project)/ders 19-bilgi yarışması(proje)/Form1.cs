using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_19_bilgi_yarışması_proje_
{
    public partial class BilgiYarısması : Form
    {
        public BilgiYarısması()
        {
            InitializeComponent();
        }
        int questionno = 0, trueans = 0, wrongans = 0;
        private void butonsonrakisoru_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            butonnextquestion.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            questionno++;
            labelquestiono.Text = questionno.ToString();
            if (questionno == 1)
            {
                richTextBox1.Text = "In what year was the republic declared?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label4.Text = "1923";
            }
            if (questionno == 2)
            {
                richTextBox1.Text = "Which city is not found in our Aegean region?";
                buttonA.Text = "İzmir";
                buttonB.Text = "Balıkesir";
                buttonC.Text = "Aydın";
                buttonD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if (questionno == 3)
            {
                richTextBox1.Text = "Which author does 'Son Kuslar' belong to?";
                buttonA.Text = "Sait Faik";
                buttonB.Text = "Cemal Süreyya";
                buttonC.Text = "Atilla İlhan";
                buttonD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                butonnextquestion.Text = "Answers:";
            }
            if (questionno == 4)
            {
                butonnextquestion.Text = "Answers:";
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                butonnextquestion.Enabled = false;
                MessageBox.Show("Correct" + trueans + "\n" + "Wrong" + wrongans);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            butonnextquestion.Enabled = true;

            label5.Text = buttonB.Text;
            if (label4.Text == label5.Text)
            {
                trueans++;
                labeltrue.Text = trueans.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrongans++;
                labelfalse.Text = wrongans.ToString();
                pictureBox2.Visible = true;
            }
        }
        

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            butonnextquestion.Enabled = true;

            label5.Text = buttonA.Text;
            if (label4.Text == label5.Text)
            {
                trueans++;
                labeltrue.Text = trueans.ToString();
                pictureBox1.Visible = true;
            }
             else
            {
                wrongans++;
                labelfalse.Text = wrongans.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            butonnextquestion.Enabled = true;

            label5.Text = buttonC.Text;
            if (label4.Text == label5.Text)
            {
                trueans++;
                labeltrue.Text = trueans.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrongans++;
                labelfalse.Text = wrongans.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            butonnextquestion.Enabled = true;

            label5.Text = buttonD.Text;
            if (label4.Text == label5.Text)
            {
                trueans++;
                labeltrue.Text = trueans.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrongans++;
                labelfalse.Text = wrongans.ToString();
                pictureBox2.Visible = true;
            }
        }
    
        private void BilgiYarısması_Load(object sender, EventArgs e)
        {
           
        }
    }
}
