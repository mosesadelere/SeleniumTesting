using BankJob.Interface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankJob.DriverInstance
{
    public static class ObjectInstance
    {
        public static IConFig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
