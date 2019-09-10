using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnitTestProject1.Interfaces;

namespace UnitTestProject1.Settings
{
    public static class ObjectInstances
    {
        public static IWebDriver Driver { get; set; }
        public static IConfig Config { get; set; }
        public static IWebElement Element { get; set; }
        public static TestContext TestContext { get; set; }

    }
}
