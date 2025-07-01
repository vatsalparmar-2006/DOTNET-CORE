// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lab3;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1; // In C#, a variable must be assigned before it is used.

        while (choice != 0)
        {
            Console.WriteLine("\n---------- Exception Handling Programs ----------");
            Console.WriteLine("1. Divide By Zero Exception");
            Console.WriteLine("2. Index Out Of Range Exception");
            Console.WriteLine("3. Abstract Class Sum");
            Console.WriteLine("4. Interface Calculate");
            Console.WriteLine("5. String Methods");
            Console.WriteLine("6. Change Case");
            Console.WriteLine("7. Area Of Shapes");
            Console.WriteLine("8. Custom Exception for Non-Even Number");
            Console.WriteLine("9. Find the Longest Word");
            Console.WriteLine("10. Change the Case of Entered Character");
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
                    DivideByZeroExample();
                    break;

                case 2:
                    IndexOutOfRangeExample();
                    break;

                case 3:
                    Calculate calc = new Calculate();
                    calc.SumOfTwo(5, 6);
                    calc.SumOfThree(5, 5, 5);
                    break;

                case 4:
                    Result result = new Result();
                    result.Addition(5, 6);
                    result.Subtraction(9, 6);
                    break;

                case 5:
                    StringFunc func = new StringFunc();
                    func.StrFunction("vatsal parmar");
                    break;

                case 6:
                    StringFunc func2 = new StringFunc();
                    func2.CaseChanger("VaTsAl PaRmAr");
                    break;

                case 7:
                    AreaCalculator calculator = new AreaCalculator();
                    calculator.Circle(8.6);
                    calculator.Triangle(6, 9);
                    calculator.Square(5);
                    break;

                case 8:
                    EvenNumberCheck obj = new EvenNumberCheck();
                    obj.EvenCheck(22);
                    obj.EvenCheck(21);
                    break;

                case 9:
                    LongestWordFinder obj2 = new LongestWordFinder();
                    obj2.LongestWord("Find the Longest Word");
                    break;

                case 10:
                    StringFunc func3 = new StringFunc();
                    func3.CharCaseChanger('p');
                    func3.CharCaseChanger('V');
                    func3.CharCaseChanger('9');
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

    static void DivideByZeroExample()
    {
        try
        {
            Console.Write("\nEnter numerator : ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator : ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine($"\nResult: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("\nError: Cannot divide by zero.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nError: Please enter valid numbers only.");
        }
    }

    static void IndexOutOfRangeExample()
    {
        try
        {
            int[] numbers = new int[5];

            Console.WriteLine("\nEnter 5 numbers :");
            for (int i = 0; i <= 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("\nError: You tried to access an index that doesn't exist in the array.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nError: Please enter only integer values.");
        }
    }
}