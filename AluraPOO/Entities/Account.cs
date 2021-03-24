using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    class Account
    {
        private int NumberAccount { get; set; }
        private double Balance { get; set; }

        public Account(int numberAccount, double balance)
        {
            NumberAccount = numberAccount;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
       
        public override string ToString()
        {
            return $"\nNumber of the Account: {NumberAccount}\nBalance actual: {Balance}";
        }
    }
}
