using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public BankAccount()
        {
        }

        public BankAccount(double amount)
        {
            _balance = amount;
        }

        public void Deposit(double amount)
        {
            Console.WriteLine($"Simulating a deposit of {amount, 0:c} to your account");
            _balance = amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void Withdrawal(double amount)
        {
            _balance -= amount;
        }
    }
}
