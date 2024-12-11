using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Student
    {
        public string EnrollmentNo;
        public string StudentName;
        public string Semester;
        public double CPI;
        public double SPI;

        public Student(string enrollmentNo, string studentName, string semester, double cpi, double spi)
        {
            EnrollmentNo = enrollmentNo;
            StudentName = studentName;
            Semester = semester;
            CPI = cpi;
            SPI = spi;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Enrollment No: {EnrollmentNo}\nStudent Name: {StudentName}\nSemester: {Semester}\nCPI: {CPI}\nSPI: {SPI}");
        }
    }
}
