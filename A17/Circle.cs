using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17
{
    public class Circle:Shape
    {
        double Radius;

        public Circle(double r)
        {
          Radius=r;
            ShapeType = "Circle";
        }
        public override double Area => 2 * Math.PI * Math.Pow(Radius, 2);

        public override double Perimeter => 2 * Math.PI * Radius;


        public void print()
        {
            Console.WriteLine("Shape : " +ShapeType);
            Console.WriteLine("Area : " + Area);
            Console.WriteLine("Peerimeter : " + Perimeter);
        }

    }
}
