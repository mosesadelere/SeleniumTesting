using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ElementFinding
{
    public static class CheckElementPresence
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return ObjectInstances.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator))
            {
                return ObjectInstances.Driver.FindElement(locator);
            }
            else
            {
                throw new NoSuchElementException("Element " + locator.ToString() + " is missing!");
            }
        }

        public static IWebElement GetElements(By locator, string value)
        {
            if (IsElementPresent(locator))
            {
                return ObjectInstances.Driver.FindElement(locator);
            }
            else
            {
                throw new NoSuchElementException("Element " + locator.ToString() + " is missing!");
            }
        }
    }
}