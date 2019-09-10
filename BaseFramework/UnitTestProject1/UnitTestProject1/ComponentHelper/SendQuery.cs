using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ElementFinding;

namespace UnitTestProject1.ComponentHelper
{
    public static class SendQuery
    {
        public static void Queries(By locator, string message)
        {
            CheckElementPresence.GetElement(locator).SendKeys(message);
        }

        public static void ClearText(By locator)
        {
            // IWebElement _element = SearchElements.findElements(locator);
            CheckElementPresence.GetElement(locator).Clear();
        }
    }
}