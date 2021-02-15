using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnlocation = new Point(20, 10);
            btn.Location = btnlocation;
            btn.Name = "Button1";
            btn.Text = "Click";
            btn.BackColor = Color.DeepPink;
            btn.Height = 90;
            btn.Width = 78;
            this.Controls.Add(btn);
            Label lbl = new Label();
            Point lblLocation = new Point(200,50);
            lbl.Location = lblLocation;
            lbl.Name = "Label1";
            lbl.Text = "Hello";
            lbl.BackColor = Color.Yellow;
            this.Controls.Add(lbl);
            lbl.AutoSize = true;
           
          for(int i = 1; i <= 6; i++)
            {
                TextBox txt = new TextBox();
                Point txtlocation = new Point(350,i*35);
                txt.Location = txtlocation;
                txt.Name = "Texbox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }

        }
    }
}
