using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class AdditionOfDifferentDatatypes
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine($"\nAddition({a},{b}) : {a + b}");
        }

        public void Addition(float a, float b)
        {
            Console.WriteLine($"Addition({a},{b}) : {a + b}");
        }
    }
}
