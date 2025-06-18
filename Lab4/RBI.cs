using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class RBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Simple Interest Of RBI.");
        }
    }

    class HDFC : RBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Simple Interest of HDFC.");
        }
    }

    class SBI : RBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Simple Interest of SBI.");
        }
    }

    class ICICI : RBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Simple Interest of ICICI.");
        }
    }
}
