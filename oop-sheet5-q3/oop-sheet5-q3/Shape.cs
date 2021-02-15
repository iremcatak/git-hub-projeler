using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q3
{
    public class Shape
    {
        public int MyColor { get; set; }

        public virtual double Get_Area()
        { return 0.0; }

        public virtual string To_String()
        { return "Shape"; }

    }
}
