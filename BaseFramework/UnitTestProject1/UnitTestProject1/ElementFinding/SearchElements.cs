using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Configuration;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ElementFinding
{
    public static class SearchElements
    {
        public static IWebElement findElements(By locator)
        {
            return ObjectInstances.Element.FindElement(locator);
        }

        public static void IdName(string username)
        {
            ObjectInstances.Driver.FindElement(By.Name("uid")).SendKeys(username);
        }

        public static void IdPassword(string password)
        {
            ObjectInstances.Driver.FindElement(By.Name("password")).SendKeys(password);
        }

        public static void IdsendKeys()
        {
            //ObjectInstances.Driver.FindElement(By.Name("btnLogin")).Click();
            //return ObjectInstances.Element.SendKeys
            //GoToLinkAndClick.ClickLink(By.Name("btnLogin"));
        }

        public static void ElementTagNameLists(string tagType, string value)
        {
            var tagList = ObjectInstances.Driver.FindElements(By.TagName(tagType));
            foreach (var tag in tagList)
            {
                if (tag.GetAttribute("value").Equals(value))
                {
                    tag.Click();
                    break;
                }
            }
        }
    }
}