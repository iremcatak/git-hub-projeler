using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_35_class_example
{
    class car:cardetail
    {
        public string color;
        public int speed;
        public double motor;
        public char usagestatus;
        public int price;
        private int year;
        private string brand;

        public int YEAR
        {
            get { return year; }
            set { year = Math.Abs(value); }//yıl yerine negatif deger girilmesini onler.
        }
        public string BRAND
        {
            get { return brand; }
            set { brand = value.ToUpper(); }//buyuk harfe donusturur.
        }
    }
}
