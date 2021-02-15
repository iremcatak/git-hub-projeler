using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q4
{
   public class Com_Mem:Member
    {
       public double Sales;
        public Com_Mem():base()
        {      Sales = 0;   }
        public override string Print_Mem_Data()
        { return ID.ToString() + " " + Name + " Sales:" + Sales; }

        public Com_Mem(int ID, string Name, string Address, double Sales) : base(ID, Name,Address)
        {
            this.Sales = Sales;
        }
        public override string To_String()
        {
            return "Commissioned Member";
        }
    }
}
