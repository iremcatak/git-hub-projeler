using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q1
{
    public class Circle : Point
    {
        public double r;
        public Circle()
        { }
        public Circle(double x,double y,double r) : base(x, y)
        {  this.r = r; }
        public override double Area()
        { return (3.14 * r * r); }
        public override string Name()
        { return "Circle"; }
    }
}
