using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Staff
    {
        public string Name, Department, Designation;
        public double Salary, Experience;

        public void GetStaffDetails()
        {
            Console.Write("Enter your Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter your Department : ");
            Department = Console.ReadLine();
            Console.Write("Enter your Designation : ");
            Designation = Console.ReadLine();
            Console.Write("Enter your Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Experience : ");
            Experience = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"----------");
        }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("\n---------- Staff Details ----------");
            Console.WriteLine($"\nStaff Name : {Name}");
            Console.WriteLine($"Staff Department : {Department}");
            Console.WriteLine($"Staff Designation : {Designation}");
            Console.WriteLine($"Staff Salary : {Salary}");
            Console.WriteLine($"Staff Experience : {Experience}");
            Console.WriteLine($"----------");
        }
    }
}
