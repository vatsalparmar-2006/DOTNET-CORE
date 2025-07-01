    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Sum
    {
        public abstract void SumOfTwo(int x, int y);
        public abstract void SumOfThree(int x, int y, int z);
    }

    public class Calculate : Sum 
    {
        public override void SumOfTwo(int x, int y)
        {
            Console.WriteLine($"\nSum Of {x} and {y} is {x + y}");
        }

        public override void SumOfThree(int x, int y, int z)
        {
            Console.WriteLine($"Sum Of {x}, {y} and {z} is {x + y + z}");
        }
    }
}
