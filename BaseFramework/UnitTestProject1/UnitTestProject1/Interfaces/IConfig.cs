using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Configuration;
using OpenQA.Selenium;

namespace UnitTestProject1.Interfaces
{
    public interface IConfig
    {
        string GetUsername();
        string GetPassWord();
        BrowserTypes GetBrowser();
        string GetURL();
        string GetTitle();
        string GetFilename();
        string GetSheetname();
        string GetTablename();
        string GetDataFromExcel();
        string GetCssSelector();
        string GetId();
        string GetName();
        string GetTagName();
        string GetLinkText();
        string GetPartialLinkText();
        string GetClassName();
    }
}
