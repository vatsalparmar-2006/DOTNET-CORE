// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lab_2;
using Lab2;
using static Lab2.MultipleInheritance;


//1.Write a program to create a class named Candidate with ID, Name, Age,
//Weight and Height as data members & also create a member functions like
//GetCandidateDetails() and DisplayCandidateDetails().

Candidate c1 = new Candidate();
c1.GetCandidateDetails();
c1.DisplayCandidateDetails();


//2.Write a program to create a class Staff having data members as Name,
//Department, Designation, Experience & Salary. Accept this data for 5 
//different staffs and display only names & salary of those staff who are      
//HOD.

Staff[] staff = new Staff[5];
for (int i = 0; i < 5; i++)
{
    staff[i] = new Staff();

    staff[i].GetStaffDetails();

    if (staff[i].Designation.ToLower() == "HOD")
    {
        staff[i].DisplayStaffDetails();
    }

}


//3.Write a pogram to Create a class Bank_Account with Account_No, Email,
//User_Name, Account_Type and Account_Balance as data members. Also 
//create a Member function GetAccountDetails() & DisplayAccountDetails().

Bank_Account bank_Account = new Bank_Account();
bank_Account.GetAccountDetails();
bank_Account.DisplayAccountDetails();


//4.Write a program with following specifications:
//Class Name: Student
//Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
//Get Students Details using constructor and DisplayStudentDetails() using
//member function.

Student s1 = new Student(23010101196, 5, "Vatsal", 8.45, 8.70f);
s1.DisplayStudentDetails();


//5.Write a program to calculate area of a Rectangle using constructor.

Rectangle r = new Rectangle(4, 3);
r.DisplayStudentDetails();


//6.Write a program for implementing single inheritance which creates one
//class Account_Details for getting account information and another class
//Interest for calculating and displaying total interest from the data inserted
//from account details.

Interest interest = new Interest();
interest.GetAccountDetails();
interest.CalculateInterest();
interest.DisplayAccountDetails();


//7. Write a program to Define a class Salary which will contain member
//variable Basic, TA, DA, HRA. Write a program using Constructor with default
//values for DA and HRA and calculate the salary of employee.

Salary emp = new Salary();
emp.TotalSalary();


//8.Write a program to Define a class Distance have data members dist1, dist2,
//dist3. Initialize the two data members using constructor and store their
//addition in third data member using function and display addition.

Console.Write("Enter Distance 1: ");
double dis1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Distance 2: ");
double dis2 = Convert.ToDouble(Console.ReadLine());

Distance location = new Distance(dis1, dis2);
location.CalculateDistance();


//9.Create a class Furniture with material, price as data members. Create
//another class Table with Height, surface_area as data members. Write a
//program to implement single inheritance.

Table table = new Table();
table.GetFurnitureDetails();
table.GetTableDetails();
table.DisplayTableDetails();


//10.Program to implement the following multiple inheritance using interface
//Interface : Gross
//Method- Gross_sal()

//Class : Salary
//Data Members - HRA, TA, DA
//Methods - Disp_sal()

//Class : Employee
//Data Members - Name
//Methods - basic_sal()

Employee employee = new Employee();
employee.Basic_sal();
employee.Gross_sal();
employee.Disp_sal();