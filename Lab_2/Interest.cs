using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class AccountDetails
    {
        public string AccountNo;
        public double Balance;

        public AccountDetails(string accountNo, double balance)
        {
            AccountNo = accountNo;
            Balance = balance;
        }
    }

    class Interest : AccountDetails
    {
        public Interest(string accountNo, double balance) : base(accountNo, balance)
        { }

        public void CalculateInterest()
        {
            double interest = Balance * 0.05;
            double totalBalance = Balance + interest;
            Console.WriteLine($"Total balance including interest: {totalBalance}");
        }
    }

}
