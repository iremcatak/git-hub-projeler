using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q3
{
    public class My_Circle : Shape
    {
        public double r;
       

        public override double Get_Area()
        { return 3.14*r*r; }

        public override string To_String()
        { return "Circle"; }
    }
}
