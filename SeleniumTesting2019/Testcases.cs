using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;



namespace Test
{
    [TestFixture]
    public class Test
    {
        [Test]
	    public void testMethod()
	    {
            IWebDriver driver = new FireFox();
            driver.Url("https://www.google.com");
            IWebElement searchElement = driver.FindElement(By.Name("q"));
            driver.SendKeys("try method java");
            driver.Quit();

	    }
    }
}

