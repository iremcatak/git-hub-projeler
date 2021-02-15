using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace chart_graphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Book"].Points.AddXY("Center Anatolia", 20);
            chart1.Series["Book"].Points.AddXY("Aegan", 30);
            chart1.Series["Book"].Points.AddXY("Black Sea", 5);
        }
    }
}
