using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface Shape
    {
        public void Circle(double radius);
        public void Triangle(double b, double h);
        public void Square(double side);
    }

    class AreaCalculator : Shape
    {
        public void Circle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"\nArea of Circle : {area}");
        }

        public void Triangle(double b, double h)
        {
            double area = 0.5 * b * h;
            Console.WriteLine($"Area of Triangle : {area}");
        }

        public void Square(double side)
        {
            double area = side * side;
            Console.WriteLine($"Area of Square : {area}");
        }
    }
}
