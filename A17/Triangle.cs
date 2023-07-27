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

       
        public override double Area=> Math.Sqrt(((SideA + SideB + SideC) / 2) * (((SideA + SideB + SideC) / 2) - SideA) * (((SideA + SideB + SideC) / 2) - SideB) * (((SideA + SideB + SideC) / 2) - SideC));

        public override double Perimeter=> Perimeter = SideA + SideB + SideC;


        public void print()
        {
            Console.WriteLine("Shape : " + ShapeType);
            Console.WriteLine("Area : " + Area);
            Console.WriteLine("Peerimeter : " + Perimeter);
        }


    }
}
