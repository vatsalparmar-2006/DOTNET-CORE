using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class StringFunc
    {
        public void StrFunction(string s)
        {
            Console.WriteLine("\nToLower(): " + s.ToLower());
            Console.WriteLine("ToUpper(): " + s.ToUpper());
            Console.WriteLine("IndexOf(): " + s.IndexOf("a"));
            Console.WriteLine("StartsWith(): " + s.StartsWith("v"));
            Console.WriteLine("EndsWith(): " + s.EndsWith("r"));
            //Console.WriteLine("Remove(): " + s.Remove(5, 7));
            Console.WriteLine("Insert(): " + s.Insert(0, "mr. "));
            Console.WriteLine("Replace(): " + s.Replace("parmar", "PARMAR"));
        }

        public void CaseChanger(string s)
        {
            Console.WriteLine($"\nBefore : {s}");

            char[] characters = s.ToCharArray();
            string str = "";
            foreach (char c in characters)
            {
                if (char.IsLower(c))
                {
                    str += char.ToUpper(c);
                }
                else
                {
                    str += char.ToLower(c);
                }
            }

            Console.WriteLine($"After : {str}");
        }

        public void CharCaseChanger(char ch)
        {
            if (char.IsLower(ch))
                Console.WriteLine($"\nUppercase: {char.ToUpper(ch)}");
            else if (char.IsUpper(ch))
                Console.WriteLine($"Lowercase : {char.ToLower(ch)}");
            else
                Console.WriteLine($"Not an alphabetic character : {ch}");
        }
    }
}
