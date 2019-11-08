using System;
using System.Collections.Generic;
using System.Text;
using BaseFramework.BrowserCconfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace BaseFramework.BasicSettings
{
    public static class SettingClass
    {
        public static IWebDriver Driver { set; get; }
        public static IConfig Config { get; set; }
        public static IWebElement Element { get; set; }
        public static TestContext TestContext { get; set; }
    }
}
