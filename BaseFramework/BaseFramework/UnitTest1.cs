using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;
        IWebElement element;
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver(); 
        }

        [Test]
        public void Test1()
        {
            driver.Url = "http://www.google.com";
            element = driver.FindElement(By.Name("q"));
            element.Clear();
            element.SendKeys("Man utd really sucks now!");
            element.Submit();
            Console.WriteLine(driver.Title);
            driver.Quit();
            

          //  Assert.Pass();
        }
    }
}