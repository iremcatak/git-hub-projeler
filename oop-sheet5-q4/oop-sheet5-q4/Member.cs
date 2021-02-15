using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sheet5_q4
{
    public class Member
    {
        public int ID;
        public string Name;
        public string Address;
        private int ıD;
        private double salary;

        public Member()
        {
            ID = 0;
            Name = "";
            Address = "";
        }
        public Member(int ID, string Name,string Address)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
        }

        public Member(int ıD, string name, double salary)
        {
            this.ıD = ıD;
            Name = name;
            this.salary = salary;
        }

        public virtual string To_String()
        { return "Member"; }
        public virtual string Print_Mem_Data()
        { return ID.ToString() + " " + Name; }
        
       
       

       

    }
}
