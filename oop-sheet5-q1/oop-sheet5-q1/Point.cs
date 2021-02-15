using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q1
{
   public class Point: Shape
    {
        public double x, y;
        public Point()
        { }
        public Point(double x,double y) {
            this.x = x;
            this.y = y;
        }
        public override string Name()
        { return "Point"; }
    }
}
