using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankJob.Foundation
{
    public interface WebDriverConfig
    {
        IWebDriver GetFireFox();
        IWebDriver GetChrome();
        IWebDriver GetIExplorer();
    }
}
