using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Collections.ObjectModel;


namespace SearchFrameWork
{
    [TestClass]
    public class BrowserSearchTest
    {
        public IWebDriver driver;
        public IWebElement elem;
        public const string url = "http://www.google.com";
        [TestMethod]
        public void TestChrome()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            elem = driver.FindElement(By.Name("q"));
            elem.SendKeys("saving account");
            elem.Submit();

            Thread.Sleep(2000);
            driver.Dispose();
            
        }

        [TestMethod]
        public void TestIE()
        {
            driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl(url);

            elem = driver.FindElement(By.Name("q"));
            elem.SendKeys("saving account");
            elem.Submit();

            Thread.Sleep(2000);
            driver.Dispose();

        }

        [TestMethod]
        public void TestFirefox()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(url);

            elem = driver.FindElement(By.Name("q"));
            elem.SendKeys("saving account");
            elem.Submit();

            Thread.Sleep(2000);
            driver.Dispose();

        }
    }
}
