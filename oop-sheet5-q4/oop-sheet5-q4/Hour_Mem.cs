using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q4
{
   public class Hour_Mem:Member
    {
        public int Hours;
        public double Rate;
        public Hour_Mem() : base()
        {
            Hours = 0;
            Rate = 0;
        }
        public override string Print_Mem_Data()
        { return ID.ToString() + " " + Name + " Hours:" + Hours + " Rate: " + Rate; }
        public Hour_Mem(int ID, string Name, string Address, int Hours, double Rate) : base(ID, Name, Address)
        {
            this.Hours = Hours;
            this.Rate = Rate;
        }
        public override string To_String()
        {
            return "Hourly Member";
        }

    }
}
