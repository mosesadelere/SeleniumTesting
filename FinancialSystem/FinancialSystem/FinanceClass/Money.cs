using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystem.FinanceClass
{
    public class Money
    {
        private int amount;
        private string currency;
        

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public int Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }
        public string Currency
        {
            get
            {
                return this.currency;
            }
            set
            {
                this.currency = value;
            }
        }

        public bool equals(Object anObject)
        {
            if (typeof(Object)==typeof(Money))
            {
                Money money = (Money)anObject;
                return money.Currency.Equals(Currency) && money.Amount == Amount;
            }
            return false;
        }
    }
}
