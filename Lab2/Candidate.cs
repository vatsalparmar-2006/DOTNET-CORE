using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Candidate
    {
        int ID, Age, Weight, Height;
        string Name;

        public void GetCandidateDetails()
        {
            Console.Write("Enter your Candidate ID : ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter your Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Weight : ");
            Weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Height : ");
            Height = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("\n---------- Candidate Details ----------");
            Console.WriteLine($"\nCandidate ID : {ID}");
            Console.WriteLine($"Candidate Name : {Name}");
            Console.WriteLine($"Candidate Age : {Age}");
            Console.WriteLine($"Candidate Weight : {Weight}");
            Console.WriteLine($"Candidate Height : {Height}");
        }
    }
}
