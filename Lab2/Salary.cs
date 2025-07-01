using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Salary
    {
        public double Basic;
        public double TA;
        public double DA;
        public double HRA;
            
        public Salary()
        {
            Console.Write("Enter Basic : ");
            Basic = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter TA : ");
            TA = Convert.ToDouble(Console.ReadLine());
            DA = 20000;
            HRA = 25000;
        }

        public void TotalSalary()
        {
            Console.WriteLine($"Total Salary : {Basic + TA + HRA + DA}");
        }
    }
}
