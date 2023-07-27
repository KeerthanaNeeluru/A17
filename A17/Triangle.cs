using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace A17
{
    internal class Triangle:Shape
    {
        double SideA, SideB, SideC;
        
        public Triangle(double a,double b,double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            ShapeType = "Triangle";
        }
        double s;
        public double Sides
        {
            set { s = (SideA + SideB + SideC) / 2; }
        }
        public override double Area
        {
            set { Area = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC)); }
        }
        public override double Perimeter
        {
            set { Perimeter = SideA + SideB + SideC; }
        }
       
        public void print()
        {
            Console.WriteLine("Shape : " + ShapeType);
            Console.WriteLine("Area : " + Area);
            Console.WriteLine("Peerimeter : " + Perimeter);
        }


    }
}
