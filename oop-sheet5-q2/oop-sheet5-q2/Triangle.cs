using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q2
{
    public class Triangle:Shape
    {
        public double B;
        public double H;

        public override double Get_Area()
        { return 0.5 * B * H; }

        public override string To_String()
        { return "Triangle"; }
    }
}
