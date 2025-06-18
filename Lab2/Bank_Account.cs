using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    internal class Bank_Account
    {
        int Account_No;
        string Email, User_Name, Account_Type;
        double Account_Balance;
        
        public void GetAccountDetails()
        {
            Console.Write("Enter your Account_No : ");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Email : ");
            Email = Console.ReadLine();
            Console.Write("Enter your User_Name : ");
            User_Name = Console.ReadLine();
            Console.Write("Enter your Account_Type : ");
            Account_Type = Console.ReadLine();
            Console.Write("Enter your Account_Balance : ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\n---------- Account Holder's Details ----------");
            Console.WriteLine($"\nAccount_No : {Account_No}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"User_Name : {User_Name}");
            Console.WriteLine($"Account_Type : {Account_Type}");
            Console.WriteLine($"Account_Balance : {Account_Balance}");
        }
    }
}
