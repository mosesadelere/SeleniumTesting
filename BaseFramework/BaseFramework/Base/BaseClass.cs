using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;

namespace BaseFramework.Base
{
    public static class BaseClass
    {

        private static ChromeOptions GetChromeOptions()
        {
            var chromeOption = new ChromeOptions();
            chromeOption.AddArgument("--start-maximize");
            return chromeOption;
        }

        private static FirefoxOptions GetFirefoxOptions()
        {
            var firefoxOption = new FirefoxOptions();
            firefoxOption.AddArgument("");
            return firefoxOption;
        }

        private static IWebDriver GetChrome()
        {
            var driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        private static IWebDriver GetFirefox()
        {
            var driver = new FirefoxDriver();
            return driver;
        }
    }
}
