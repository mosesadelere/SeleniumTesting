using BankJob.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankJob.Configuration
{
    public class GetAppRunning : IConFig
    {
        public BrowserType GetbrowserType()
        {
            string newBrowserType = ConfigurationManager.AppSettings["browser"];
            return (BrowserType)Enum.Parse(typeof(BrowserType), newBrowserType);
        }

        public string GetPassWord()
        {
            string password = ConfigurationManager.AppSettings["password"];
            return password;
        }

        public string GetURL()
        {
            string url = ConfigurationManager.AppSettings["url"];
            return url;
        }

        public string GetUserName()
        {
            string username = ConfigurationManager.AppSettings["username"];
            return username;
        }
    }
}
