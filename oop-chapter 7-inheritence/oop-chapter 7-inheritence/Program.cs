using System;

namespace oop_chapter_7_inheritence
{
    class MyCircle
    {
        private double r;
        public MyCircle()
        { }
        public MyCircle(double val)
        { r = val; }
        public double getR()
        { return r; }
        public void setR(double val)
        { r = val; }
    
    public double Circle_Perimeter
()
    {
        double ret;
        ret = 2 * 3.142 * r;
        return ret;
    }
    public double Circle_Area()
    {
        double ret;
        ret = 3.142 * r * r;
        return ret;
    }
    }
    class MyCylinder : MyCircle
    {
        private double h;
        public MyCylinder() { }
        public MyCylinder(double valR, double valH) : MyCircle
        (valR)
        { h = valH; }
        public double getH()
        { return h; }
        public void setH(double val)
        { h = val; }
        public double Cylinder_Area()
        {
            double ret;
            ret = h * Circle_Perimeter();
            return ret;
        }
        public double Cylinder_Volume()
        {
            double ret;
            ret = h * Circle_Area();
            return ret;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
