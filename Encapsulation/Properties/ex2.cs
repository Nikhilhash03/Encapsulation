using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Properties
{
    class Account
    {
        private double balance;
        private int pin = 2001;
        public void deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        public void withdraw(double amount,int enteredpin)
        {
            if (amount <= 0 && pin == enteredpin)
            {
                balance -= amount;
            }
        }
        public double getbalance()
        {
            return balance;
        }
    }
    internal class ex2
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.deposit(5000);
            acc.withdraw(2000,2001);

            Console.WriteLine("Balance " + acc.getbalance());
        }
    }
}


