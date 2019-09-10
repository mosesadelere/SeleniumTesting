using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialSystem.FinanceClass;

namespace Bank
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void constructorshouldSetAmountAndCurrency()
        {
            Money money = new Money(10, "USD");

            Assert.AreEqual(10, money.Amount);
            Assert.AreEqual("USD", money.Currency);
        }
    }
}
