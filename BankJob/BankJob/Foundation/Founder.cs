using BankJob.Configuration;
using BankJob.DriverInstance;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankJob.Foundation
{
    [TestClass]
    public static class Founder
    {
        private static IWebDriver GetChrome()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver GetFireFox()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;

        }

        private static IWebDriver GetIExplorer()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void initialise(TestContext testContext)
        {
            ObjectInstance.Config = new GetAppRunning();
            switch (ObjectInstance.Config.GetbrowserType())
            {
                case BrowserType.Firefox:
                    ObjectInstance.Driver = GetFireFox();
                    Thread.Sleep(3000);
                    ObjectInstance.Driver.Dispose();
                    break;
                case BrowserType.Chrome:
                    ObjectInstance.Driver = GetChrome();
                    Thread.Sleep(3000);
                    ObjectInstance.Driver.Dispose();
                    break;
                case BrowserType.IExplorer:
                    ObjectInstance.Driver = GetIExplorer();
                    Thread.Sleep(3000);
                    ObjectInstance.Driver.Dispose();
                    break;
                default:
                    throw new Exception("Invalid browser or Browser not configure.");
            }
        }
    }
}
