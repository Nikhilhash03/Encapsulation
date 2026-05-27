using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Account
    {
        private double balance;
        public void deposit(double amount)
        {
            if (balance > 0)
            {
                balance += amount;
            }
        }
        public void withdraw(double amount)
        {
            if (balance <= 0)
            {
                balance -= amount;
            }
        }
        public double getbalance()
        {
            return balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Account acc = new Account();
                acc.deposit(5000);
                acc.withdraw(2000);

                Console.WriteLine("Balance "+ acc.getbalance());
        }
    }
}
