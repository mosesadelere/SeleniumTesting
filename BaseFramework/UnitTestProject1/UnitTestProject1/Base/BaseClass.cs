using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using UnitTestProject1.Configuration;
using UnitTestProject1.CustomException;
using UnitTestProject1.Settings;

namespace UnitTestProject1.Base
{
    [TestClass]
    public static class BaseClass
    {
        //private static FirefoxProfileManager GetFirefoxOptions()
        //{
        //    //FirefoxProfileManager firefoxOptions = new FirefoxProfileManager();
        //    //firefoxOptions.GetProfile("default");
        //    //firefoxOptions.AddArgument("--start-maximized");
        //    return null;
        //}

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            return chromeOptions;
        }

        private static bool GetExplorerOptions()
        {
            var explorerOption = new InternetExplorerOptions();
            var x = explorerOption.IntroduceInstabilityByIgnoringProtectedModeSettings;
            return x;
        }
        private static IWebDriver GetChrome()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
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
        public static void init(TestContext testContext)
        {
            ObjectInstances.Config = new AppConfigReader();

            switch (ObjectInstances.Config.GetBrowser())
            {
                case BrowserTypes.Chrome:
                    ObjectInstances.Driver = GetChrome();
                    break;

                case BrowserTypes.Firefox:
                    ObjectInstances.Driver = GetFireFox();
                    break;

                case BrowserTypes.IExplorer:
                    ObjectInstances.Driver = GetIExplorer();
                    break;

                default:
                    throw new InvalidBrowser("Driver not found.");
                    //throw new InvalidBrowser("Driver not found, {0}", ObjectInstances.Config.GetBrowser());
            }
             
        }
    }
}
