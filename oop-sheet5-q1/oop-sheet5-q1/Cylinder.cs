using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q1
{
   public class Cylinder :  Circle
    {
        public double h;
        public Cylinder()
        { }
        public Cylinder   (double x, double y, double r, double h):base (x, y, r)
            {this.h=h;}
    public override double Area ()
    { return (2 * 3.14 * r * h + 2 * base.Area()); }
    public override double Volume()
    { return (h * Circle::Area()); }
    public override string Name()
    { return "Cylinder"; }
}
}
