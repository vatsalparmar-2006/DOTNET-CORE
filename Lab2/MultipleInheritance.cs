    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class MultipleInheritance
    {
        interface Gross
        {
            void Gross_sal();
        }

        public class Salary2
        {
            public double HRA;
            public double TA;
            public double DA;

            public Salary2() { }

            public Salary2(double HRA, double TA, double DA)
            {
                this.HRA = HRA;
                this.TA = TA;
                this.DA = DA;
            }


            public void Disp_sal()
            {
                Console.WriteLine($"HRA: {HRA}");
                Console.WriteLine($"TA: {TA}");
                Console.WriteLine($"DA: {DA}");
            }
        }

        // In multiple inhetitance
        // 1) allow class & interface
        // 2) first write interface and then write class
        // 3) only allow one class but allow multiple interfaces
        public class Employee : Salary2, Gross
        {
            public string Name;
            public double Basic;

            public void Basic_sal()
            {
                Console.Write("Enter Employee Name: ");
                Name = Console.ReadLine();

                Console.Write("Enter Basic Salary: ");
                Basic = Convert.ToDouble(Console.ReadLine());
            }

            public void Gross_sal()
            {
                Console.Write("Enter salary of HRA: ");
                HRA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter salary of TA: ");
                TA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter salary of DA: ");
                DA = Convert.ToDouble(Console.ReadLine());

                Salary2 salary = new Salary2(HRA, TA, DA);
                double gross = Basic + HRA + TA + DA;

                Console.WriteLine("\n----- Salary Summary -----");
                Console.WriteLine($"Employee Name: {Name}");
                Console.WriteLine($"Basic Salary: {Basic}");
                Console.WriteLine($"Gross Salary: {gross}");
            }
        }
        }
    }
