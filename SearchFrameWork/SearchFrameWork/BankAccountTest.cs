using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchFrameWork
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void TestDebitWithValidAmountAndUpdateBalance()
        {
            double currentBalance = 15.87;
            double amountDebit = 5.99;
            double expected = 9.88;
            BankAccount account = new BankAccount("Aramide Akinteye", currentBalance);

            account.Debit(amountDebit);

            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.0001, "Account not correctly debited");
        }
    }
}
