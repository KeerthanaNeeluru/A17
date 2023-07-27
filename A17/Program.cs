using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace A17
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string ch;
            int shape;
            do
            {
                Console.WriteLine("Select shape to find area and perimeter\n1.Circle\n2.Triangle\n3.Rectangle");
                shape = int.Parse(Console.ReadLine());
                switch (shape)
                {
                    case 1:
                        Console.WriteLine("Enter the Radius");
                       double r=double.Parse(Console.ReadLine());
                        Circle circle = new Circle(r);
                        circle.print();
                        break;
                    case 2:
                        Console.WriteLine("Enter Sides");
                       double a=int.Parse(Console.ReadLine());
                        double b =int.Parse(Console.ReadLine());
                        double c =int.Parse(Console.ReadLine());
                        Triangle triangle = new Triangle(a, b, c);
                        triangle.print();
                        break;
                    case 3:Console.WriteLine("Enter width and Height");
                        double w=int.Parse(Console.ReadLine());
                        double h=int.Parse(Console.ReadLine());
                        Rectangle rectangle=new Rectangle(w, h);
                        rectangle.print();
                        break;
                    default:
                        Console.WriteLine("Invalid shape");
                        break;


                }
                Console.WriteLine("press y to continue");
                ch = Console.ReadLine();
            } while (ch == "y");
            
            Console.ReadKey();
        }
    }
}
