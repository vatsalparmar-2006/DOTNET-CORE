using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface ICalculate
    {
        public void Addition(double x, double y);
        public void Subtraction(double x, double y);
    }
    
    public class Result : ICalculate
    {
        public void Addition(double x, double y)
        {
            Console.WriteLine($"\nAddition of {x} and {y} is {x + y}");
        }

        public void Subtraction(double x, double y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is {x - y}");
        }
    }
}
