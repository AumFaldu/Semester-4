using System;

namespace Lab_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1: Write a program to print your name, address, contact number & city.
            /*
            Console.WriteLine("Name: John Doe");
            Console.WriteLine("Address: 1234 Elm Street");
            Console.WriteLine("Contact Number: +1234567890");
            Console.WriteLine("City: Sample City");
            */

            // Problem 2: Write a program to get two numbers from user and print those two numbers.
            /*
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered: {num1} and {num2}");
            */

            // Problem 3: Write program to prompt a user to input his/her name and country name 
            // and then output will be shown as given: Hello <yourname> from country <countryname>
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your country: ");
            string country = Console.ReadLine();
            Console.WriteLine($"Hello {name} from country {country}");
            */

            // Problem 4: Write a program to calculate the size of the area in square-feet based on specified length and width.
            /*
            Console.Write("Enter length in feet: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter width in feet: ");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            Console.WriteLine($"The area is {area} square feet.");
            */

            // Problem 5: Write a program to calculate area of Square, Rectangle, and Circle.
            /*
            // Area of Square
            Console.Write("Enter the side length of the square: ");
            double side = double.Parse(Console.ReadLine());
            double areaSquare = side * side;
            Console.WriteLine($"Area of Square: {areaSquare}");

            // Area of Rectangle
            Console.Write("Enter the length of the rectangle: ");
            double lengthRectangle = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double widthRectangle = double.Parse(Console.ReadLine());
            double areaRectangle = lengthRectangle * widthRectangle;
            Console.WriteLine($"Area of Rectangle: {areaRectangle}");

            // Area of Circle
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double areaCircle = Math.PI * radius * radius;
            Console.WriteLine($"Area of Circle: {areaCircle}");
            */

            // Problem 6: Write a program to calculate Celsius to Fahrenheit and vice-versa using function.
            /*
            // Function to convert Celsius to Fahrenheit
            double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            // Function to convert Fahrenheit to Celsius
            double FahrenheitToCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }

            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Temperature in Fahrenheit: {CelsiusToFahrenheit(celsius)}");

            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"Temperature in Celsius: {FahrenheitToCelsius(fahrenheit)}");
            */

            // Problem 7: Write a program to find out Simple Interest using function. (I = PRN/100)
            /*
            double CalculateSimpleInterest(double principal, double rate, double time)
            {
                return (principal * rate * time) / 100;
            }

            Console.Write("Enter principal amount: ");
            double principal = double.Parse(Console.ReadLine());
            Console.Write("Enter rate of interest: ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter time period in years: ");
            double time = double.Parse(Console.ReadLine());

            double simpleInterest = CalculateSimpleInterest(principal, rate, time);
            Console.WriteLine($"The Simple Interest is: {simpleInterest}");
            */

            // Problem 8: Write a program to create a Simple Calculator for two numbers (Addition, Multiplication, Subtraction, Division)
            // [Also using if…else & Switch Case]
            /*
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Select an operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            // Using if-else
            if (operation == "+")
            {
                Console.WriteLine($"Result: {num1 + num2}");
            }
            else if (operation == "-")
            {
                Console.WriteLine($"Result: {num1 - num2}");
            }
            else if (operation == "*")
            {
                Console.WriteLine($"Result: {num1 * num2}");
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                    Console.WriteLine($"Result: {num1 / num2}");
                else
                    Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                Console.WriteLine("Invalid operation.");
            }

            // Using switch-case
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
            */

            // Problem 9: Write a program to Swap two numbers without using third variable.
            /*
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            // Swapping without using third variable
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After swapping: a = {a}, b = {b}");
            */

            // Problem 10: Write a program to find maximum number from given 3 numbers using ternary operator.
            /*
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = (num1 > num2) ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine($"The maximum number is: {max}");
            */
        }
    }
}
