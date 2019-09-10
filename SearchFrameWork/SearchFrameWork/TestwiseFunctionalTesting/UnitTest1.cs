using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SearchFrameWork.TestwiseFunctionalTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://travel.agileway.net/login");
            driver.FindElement(By.Id("username")).SendKeys("agileway");
            driver.FindElement(By.Id("password")).SendKeys("testwise");
            driver.FindElement(By.Name("commit")).Click();
            driver.FindElement(By.LinkText("Sign off")).Click();
            //Assert.AreEqual("Welcome agileway",driver.FindElement(By.TagName("Welcome agileway")));
            driver.Dispose();
        }
    }
}
