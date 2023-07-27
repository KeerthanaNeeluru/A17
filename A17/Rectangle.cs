using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17
{
    public class Rectangle:Shape
    {
        double Width, Height;
       
       
        public Rectangle(double w,double h)
        {
            Width = w;
            Height = h;
            ShapeType = "Rectangle";
        }
        public override double Area=> Width * Height;

        public override double Perimeter =>  2 * Width * Height;

        public void print()
        {
            Console.WriteLine("Shape : "+ShapeType);
            Console.WriteLine("Area : "+Area);
            Console.WriteLine("Peerimeter : " + Perimeter);
        }


    }
}
