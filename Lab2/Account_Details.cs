using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_2
{
    public class Account_Detials
    {
        public int Account_No;
        public string Name;
        public double Balance;
        public double Time;
        public double Rate;

        public void GetAccountDetails()
        {
            Console.Write("Enter Account Number : ");
            Account_No = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter User Name : ");
            Name = Console.ReadLine();

            Console.Write("Enter Account Balance : ");
            Balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time (in years) : ");
            Time = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate (in %): ");
            Rate = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\n--- Bank Account Details ---");
            Console.WriteLine($"Account Number  : {Account_No}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Balance : {Balance}");
            Console.WriteLine($"Interest Rate   : {Rate}");
            Console.WriteLine($"Interest Time   : {Time}");
        }
    }

    public class Interest : Account_Detials
    {
        public void CalculateInterest()
        {
            double interest = (Balance * Rate * Time) / 100;

            Console.WriteLine("\n--- Interest Calculation ---");
            Console.WriteLine($"Account Number   : {Account_No}");
            Console.WriteLine($"Account Holder   : {Name}");
            Console.WriteLine($"Amount           : {Balance}");
            Console.WriteLine($"Rate of Interest : {Rate}%");
            Console.WriteLine($"Time             : {Time} years");
            Console.WriteLine($"Total Interest   : {interest}");
        }
    }
}

