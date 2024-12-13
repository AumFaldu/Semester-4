using System;

namespace Lab_4
{
    class BankAccount
    {
        double initialBalance;
        string accountHolderName;

        public BankAccount(double initialBalance, string accountHolderName)
        {
            this.initialBalance = initialBalance;
            this.accountHolderName = accountHolderName;
        }

        public void Deposite(double amount)
        {
            initialBalance += amount;
            Console.WriteLine("Current Balance = " + initialBalance);
        }

        public void Withdraw(double amount)
        {
            if (initialBalance < amount)
            {
                Console.WriteLine("Not Enough Balance");
                Console.WriteLine("Current Balance = " + initialBalance);
            }
            else
            {
                initialBalance -= amount;
                Console.WriteLine("Current Balance = " + initialBalance);
            }
        }

        public double GetBalance()
        {
            return initialBalance;
        }
    }

    internal class Lab_4_6
    {
        public void run()
        {
            Console.Write("Enter Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            BankAccount ba = new BankAccount(balance, name);
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Enter 1 to deposit:");
                Console.WriteLine("Enter 2 to withdraw:");
                Console.WriteLine("Enter 3 to check current balance:");
                Console.WriteLine("Enter 4 to exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        ba.Deposite(depositAmount);
                        break;
                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        ba.Withdraw(withdrawAmount);
                        break;
                    case 3:
                        Console.WriteLine("Current Balance = " + ba.GetBalance());
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
        }
    }
}
