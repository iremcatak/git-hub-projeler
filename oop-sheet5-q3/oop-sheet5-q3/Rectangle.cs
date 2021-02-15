using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q3
{
    public class My_Rectangle : Shape
    {
        public double L;
        public double W;

        public override double Get_Area()
        { return L * W; }

        public override string To_String()
        { return "Rectangle"; }
    }
}
