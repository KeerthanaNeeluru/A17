using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17
{
    public class Shape
    {
        string shapeType;
        double area;
        double perimeter;
        public  string ShapeType { get { return shapeType; } set { shapeType = value; } }    
        public virtual double Area { get { return area; } set {  area = value; } }
        public virtual double Perimeter { get {  return perimeter; } set {  perimeter = value; } }

        public Shape()
        {
            
            area= 0;
            perimeter= 0;
        }

    }
}
