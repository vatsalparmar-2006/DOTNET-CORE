// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lab5;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1;
        Collections collections = new Collections();

        while (choice != 0)
        {
            Console.WriteLine("\n---------- Exception Handling Programs ----------");
            Console.WriteLine("1. ArrayList");
            Console.WriteLine("2. List");
            Console.WriteLine("3. Stack");
            Console.WriteLine("4. Queue");
            Console.WriteLine("5. Dictionary");
            Console.WriteLine("6. Hashtable");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice : ");
            bool validInput = int.TryParse(Console.ReadLine(), out choice);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    collections.ArrayListDemo();
                    break;

                case 2:
                    collections.ListDemo();
                    break;

                case 3:
                    collections.StackDemo();
                    break;

                case 4:
                    collections.QueueDemo();
                    break;

                case 5:
                    collections.DictionaryDemo();
                    break;

                case 6:
                    collections.HashTableDemo();
                    break;

                case 0:
                    Console.WriteLine("\nExiting program...");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }
        }
    }
}