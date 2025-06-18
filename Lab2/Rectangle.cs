using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Rectangle
    {
        int length, width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("---------- Area of Rectangle ----------");
            Console.WriteLine($"Length: {length}, Width: {width}");
            Console.WriteLine($"Area : {length* width}");
        }
    }
}

