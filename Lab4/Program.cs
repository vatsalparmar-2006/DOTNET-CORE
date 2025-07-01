// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lab4;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1; 

        while (choice != 0)
        {
            Console.WriteLine("\n---------- Exception Handling Programs ----------");
            Console.WriteLine("1. Addition - Overloading");
            Console.WriteLine("2. Find Area");
            Console.WriteLine("3. Bank Interest");
            Console.WriteLine("4. Hospital Details");
            Console.WriteLine("5. Area of Shapes");
            Console.WriteLine("6. Bank Account");
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
                    AdditionOfDifferentDatatypes additionOfDifferentDatatypes = new AdditionOfDifferentDatatypes();
                    additionOfDifferentDatatypes.Addition(2, 4);
                    additionOfDifferentDatatypes.Addition(3.5f, 1.2f);
                    break;

                case 2:
                    CalculateArea calculateArea = new CalculateArea();
                    calculateArea.FindArea(5, 10);
                    calculateArea.FindArea(5);
                    break;

                case 3:
                    RBI rBI = new RBI();
                    rBI.calculateInterest();

                    HDFC hDFC = new HDFC();
                    hDFC.calculateInterest();

                    SBI sBI = new SBI();
                    sBI.calculateInterest();

                    ICICI iCICI = new ICICI();
                    iCICI.calculateInterest();
                    break;

                case 4:
                    Hospital hospital = new Hospital();
                    hospital.HospitalDetails();

                    Apollo apollo = new Apollo();
                    apollo.HospitalDetails();

                    Wockhardt wockhardt = new Wockhardt();
                    wockhardt.HospitalDetails();

                    Gokul_Superspeciality gokul_Superspeciality = new Gokul_Superspeciality();
                    gokul_Superspeciality.HospitalDetails();
                    break;

                case 5:
                    CalculateArea calculateArea2 = new CalculateArea();
                    calculateArea2.FindArea(5.2);
                    calculateArea2.FindArea(5, 10);
                    calculateArea2.FindArea(5);
                    break;

                case 6:
                    BankAccount account = new BankAccount("Mr. Parmar", 10000);

                    account.ShowDetails();

                    account.Deposit(2000);
                    account.Deposit("CHQNO_101", 3000);

                    account.Withdraw(2500);
                    account.Withdraw("CHQNO_202", 5000);

                    account.ShowDetails();
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