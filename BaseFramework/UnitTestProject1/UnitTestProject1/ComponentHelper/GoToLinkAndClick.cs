using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ElementFinding;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public static class GoToLinkAndClick
    {
        private static IWebElement _element;
        public static void ClickLink(By locator)
        {
            _element = CheckElementPresence.GetElement(locator);
            _element.Click();
        }
    }
}
