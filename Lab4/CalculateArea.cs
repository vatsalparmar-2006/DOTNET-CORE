using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class CalculateArea
    {
        public void FindArea(double radius)
        {
            Console.WriteLine($"Area of Circle : {(3.14 * radius * radius)}");
        }

        public void FindArea(double length, double width)
        {
            Console.WriteLine($"Area of Rectangle : {length * width}");
        }

        public void FindArea(int length)
        {
            Console.WriteLine($"Area of Square : {length * length}");
        }
    }
}
