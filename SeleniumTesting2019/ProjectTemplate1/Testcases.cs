using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ProjectTemplate1
{
    [TestFixture]
    public class Testcases
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            IWebElement searchElement = driver.FindElement(By.Name("q"));
            searchElement.SendKeys("try method java");
            driver.Close();

        }
    }
}

