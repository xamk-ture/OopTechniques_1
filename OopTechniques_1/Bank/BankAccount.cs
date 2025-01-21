using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTechniques_1.Bank
{
    // Poorly Implemented BankAccount Class
    public class BankAccount
    {
        public double Balance;

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }

}
