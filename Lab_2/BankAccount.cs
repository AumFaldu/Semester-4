using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class BankAccount
    {
        public string AccountNo;
        public string Email;
        public string UserName;
        public string AccountType;
        public double AccountBalance;

        public void GetAccountDetails()
        {
            Console.Write("Enter Account Number: ");
            AccountNo = Console.ReadLine();
            Console.Write("Enter Email: ");
            Email = Console.ReadLine();
            Console.Write("Enter Username: ");
            UserName = Console.ReadLine();
            Console.Write("Enter Account Type: ");
            AccountType = Console.ReadLine();
            Console.Write("Enter Account Balance: ");
            AccountBalance = double.Parse(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"\nAccount Details:\nAccount No: {AccountNo}\nEmail: {Email}\nUsername: {UserName}\nAccount Type: {AccountType}\nAccount Balance: {AccountBalance}");
        }
    }
}
