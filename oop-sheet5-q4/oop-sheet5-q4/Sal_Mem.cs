using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q4
{
  public  class Sal_Mem:Member
    {
        public double Salary;
        public Sal_Mem() : base()
        { Salary = 0; }
        public override string Print_Mem_Data()
        { return ID.ToString() + " Salary:" + Salary; }
        public Sal_Mem(int ID, string Name, double Salary) : base(ID, Name, Salary)
        {
            this.Salary = Salary;
        }
        public override string To_String()
        {
            return "Salaried Member";
        }
    }
}
