
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void testMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url("https://www.google.com");
            //IWebElement searchElement = driver.FindElement(using = "name", value = "q");
            findElement(using = "name", value = "q");
            driver.SendKeys("try method java");
            driver.Quit();

        }
    }
}

