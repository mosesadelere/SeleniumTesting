using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFrameWork
{
    class BankAccount
    {
        private string customerName;
        private double balance;

        public double Balance
        {
            get { return balance; }
        }

        public BankAccount(string customerName, double balance)
        {
            this.customerName = customerName;
            this.balance = balance;
        }

        public void Debit(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException("You have {0} left." + balance);
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            balance -= amount;
        }
    }
}
