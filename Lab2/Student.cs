using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        long Enrollment_No;
        int Semester;
        string Student_Name;
        double CPI;
        float SPI;
        
        public Student(long Enrollment_No, int Semester, string Student_Name, double CPI, float SPI)
        {
            this.Enrollment_No = Enrollment_No;
            this.Semester = Semester;
            this.Student_Name = Student_Name;
            this.SPI = SPI;
            this.CPI = CPI;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n---------- Student's Details ----------");
            Console.WriteLine($"\nEnrollment_No : {Enrollment_No}");
            Console.WriteLine($"Semester : {Semester}");
            Console.WriteLine($"Student_Name : {Student_Name}");
            Console.WriteLine($"CPI : {CPI}");
            Console.WriteLine($"SPI : {SPI}");
        }
    }
}
