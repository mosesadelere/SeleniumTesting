using BaseFramework.BasicSettings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseFramework.SearchElements
{
    public static class SearchElement
    {
        public static IWebElement findElement(By locator)
        {
            return SettingClass.Element.FindElement(locator);
        }

        public static void idName()
        {
            SettingClass.Driver.FindElement(By.Name("uid")).SendKeys("username");
        }

        public static void idPass()
        {
            SettingClass.Driver.FindElement(By.Name("password")).SendKeys("password");
        }
    }
}
