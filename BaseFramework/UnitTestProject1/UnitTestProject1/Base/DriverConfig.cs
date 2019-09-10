using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProject1.Base
{
    public interface DriverConfig
    {
        IWebDriver GetFireFox();
        IWebDriver GetChrome();
        IWebDriver GetIExplorer();
    }
}
