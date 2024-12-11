using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args) { 
                Console.WriteLine("Select a problem to run (1-10):");
                Console.WriteLine("1. Candidate Class");
                Console.WriteLine("2. Staff Class (HOD)");
                Console.WriteLine("3. Bank Account Class");
                Console.WriteLine("4. Student Class with Constructor");
                Console.WriteLine("5. Rectangle Area using Constructor");
                Console.WriteLine("6. Single Inheritance (Account Details + Interest)");
                Console.WriteLine("7. Salary Class with Constructor");
                Console.WriteLine("8. Distance Class with Constructor");
                Console.WriteLine("9. Furniture & Table Class (Single Inheritance)");
                Console.WriteLine("10. Multiple Inheritance using Interface");
                Console.Write("Enter your choice (1-10): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Candidate candidate = new Candidate();
                        candidate.GetCandidateDetails();
                        candidate.DisplayCandidateDetails();
                        break;
                    case 2:
                        Staff staff = new Staff();
                        staff.AcceptStaffDetails();
                        staff.DisplayHODs();
                        break;
                    case 3:
                        BankAccount bankAccount = new BankAccount();
                        bankAccount.GetAccountDetails();
                        bankAccount.DisplayAccountDetails();
                        break;
                    case 4:
                        Student student = new Student("123", "John Doe", "Semester 5", 8.9, 9.0);
                        student.DisplayStudentDetails();
                        break;
                    case 5:
                        Rectangle rectangle = new Rectangle(5.0, 10.0);
                        rectangle.DisplayArea();
                        break;
                    case 6:
                        Interest interest = new Interest("AC123", 10000);
                        interest.CalculateInterest();
                        break;
                    case 7:
                        Salary salary = new Salary(5000, 200, 300);
                        salary.DisplaySalary();
                        break;
                    case 8:
                        Distance distance = new Distance(10, 20);
                        distance.AddDistances();
                        break;
                    case 9:
                        Table table = new Table("Wood", 1500, 4, 50);
                        table.DisplayTableDetails();
                        break;
                    case 10:
                        Employee employee = new Employee();
                        employee.basic_sal();
                        employee.Disp_sal();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
}
