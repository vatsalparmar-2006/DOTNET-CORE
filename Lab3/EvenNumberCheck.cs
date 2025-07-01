using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class EvenNumberCheck
    {
        class NotEvenNumberException : Exception
        {
            public NotEvenNumberException(string message) : base(message)
            {
            }
        }

        public void EvenCheck(int number)
        {
            try
            {
                if (number % 2 != 0)
                    throw new NotEvenNumberException("\nThe number is not even.");

                Console.WriteLine("\nThe number is even.");
            }
            catch (NotEvenNumberException ex)
            {
                Console.Write($"\nCustom Exception : {ex.Message}");
            }
        }
    }
}
