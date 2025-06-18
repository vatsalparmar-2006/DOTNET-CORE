// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Program 1
//Console.WriteLine("Vatsal Parmar.");
//Console.WriteLine("Bhaktinagar.");
//Console.WriteLine("1234567891");
//Console.Write("Rajkot.");



// Program 2
//int a, b;

//Console.Write("Enter first number : ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number : ");
//b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("First Number : " + a);
//Console.WriteLine($"Second Number : {b}");



// Program 3
//string name, countryname;

//Console.Write("Enter your name : ");
//name = Console.ReadLine();
//Console.Write("Enter your countryname : ");
//countryname = Console.ReadLine();

//Console.WriteLine($"\nHello {name} from country {countryname}");



// Program 4
//double length, width, area;

//Console.Write("Enter length : ");
//length = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter width : ");
//width = Convert.ToDouble(Console.ReadLine());

//area = length * width;

//Console.WriteLine($"\nArea : {area}");



// Program 5
//double radius, length, circleArea, squareArea;

//Console.Write("Enter length for Square : ");
//length = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter radius for Circle : ");
//radius = Convert.ToDouble(Console.ReadLine());

//squareArea = length * length;
//circleArea = 3.14 * (radius) * (radius);

//Console.WriteLine($"\nArea of Square : {squareArea}");
//Console.WriteLine($"Area of Circle : {circleArea}");




// Program 6
//Console.Write("Enter temperature in celcius : ");
//double c = double.Parse(Console.ReadLine());
//Console.WriteLine("Temperature in farenheit : " + CelciusToFarenheit(c));

//Console.Write("Enter temperature in farenheit : ");
//double f = double.Parse(Console.ReadLine());
//Console.WriteLine("Temperature in celcius : " + FarenheitToCelcius(f));

//static double CelciusToFarenheit(double c)
//{
//    return (9 / 5 * c) + 32;
//}

//static double FarenheitToCelcius(double f)
//{
//    return (f - 32) * 5 / 9;
//}



// Program 7
//double p, r, n, interest;

//Console.Write("Enter value for P : ");
//p = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter value of R : ");
//r = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter value of N : ");
//n = Convert.ToDouble(Console.ReadLine());

//interest = (p * r * n) / 100; 

//Console.WriteLine($"\nSimple Interest : {interest}");




// Program 8

// ---------- Using if/else ----------

//int a, b;
//char operation;
//Console.Write("Enter first number : ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number : ");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter operations (+, - , /, *) : ");
//operation = Convert.ToChar(Console.ReadLine());

//if(operation == '+')
//{
//    Console.WriteLine($"\nAddition : {a + b}");
//}
//else if(operation == '-')
//{
//    Console.WriteLine($"\nSubstraction : {a - b}");  
//}
//else if (operation == '*')
//{
//    Console.WriteLine($"\nMultiplication : {a * b}");
//}
//else if (operation == '/')
//{
//    if(b == 0)
//    {
//        Console.WriteLine("\nB can not equal to Zero.");
//    }
//    else
//    {
//        Console.WriteLine($"\nDivision : {a / b}");
//    }
//}
//else
//{
//    Console.WriteLine("\nEnter valid Operations.");
//}

// ---------- Using switch case ----------
//int a, b;
//char operation;
//Console.Write("Enter first number : ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number : ");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter operations (+, - , /, *) : ");
//operation = Convert.ToChar(Console.ReadLine());

//switch (operation)
//{
//    case '+':
//        Console.WriteLine($"\nAddition : {a + b}");
//        break;

//    case '-':
//        Console.WriteLine($"\nSubstraction : {a - b}");
//        break;

//    case '*':
//        Console.WriteLine($"\nMultiplication : {a * b}");
//        break;

//    case '/':
//        if(b == 0)
//        {
//            Console.WriteLine("\nB can not equal to Zero.");
//            break;
//        }
//        else
//        {
//            Console.WriteLine($"\nDivision : {a / b}");
//            break;
//        }

//    default:
//        Console.WriteLine("\nInvalid Operator.");
//        break;
//}



// Program 9
//int a, b;
//Console.Write("Enter first number : ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number : ");
//b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"\nBefore Swapping ->  a: {a} , b: {b}");

//a = a + b;
//b = a - b;
//a = a - b;

//Console.WriteLine($"After Swapping ->  a: {a} , b: {b}");



// Program 10
//int a, b, c;
//Console.Write("Enter first number : ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number : ");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number : ");
//c = Convert.ToInt32(Console.ReadLine());

//int largest = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
//Console.WriteLine($"\n{largest} is largest");
