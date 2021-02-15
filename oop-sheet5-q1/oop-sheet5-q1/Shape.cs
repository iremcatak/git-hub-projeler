using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q1
{
  public  class Shape
    {
        public virtual double Area()
        { return 0; }

        public virtual double Volume()
        { return 0; } 

       public virtual string Name()
        {
            return "";
        }
    }
}
