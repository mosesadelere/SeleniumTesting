using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Interfaces;
using UnitTestProject1.Settings;

namespace UnitTestProject1.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserTypes GetBrowser()
        {
            string newBrowser = ConfigurationManager.AppSettings["Browser"];
            return (BrowserTypes)Enum.Parse(typeof(BrowserTypes), newBrowser);  
        }

        public string GetClassName()
        {
            string classname = ConfigurationManager.AppSettings["classname"];
            //ConnectionStringSettings test = ConfigurationManager.ConnectionStrings["datasource"];
            return classname;
        }

        public string GetCssSelector()
        {
            string cssselector = ConfigurationManager.AppSettings["cssselector"];
            return cssselector;
        }

        public string GetDataFromExcel()
        {
            string[] data = new string[2];
            data[0] = (string)ObjectInstances.TestContext.DataRow["Arg1"];
            data[1] = (string)ObjectInstances.TestContext.DataRow["Arg2"];

            return data.ToString();
        }

        public string GetFilename()
        {
            string filename = ConfigurationManager.AppSettings["filename"];
            return filename;
        }

        public string GetId()
        {
            string id = ConfigurationManager.AppSettings["id"];
            return id;
        }

        public string GetLinkText()
        {
            string linktext = ConfigurationManager.AppSettings["linktext"];
            return linktext;
        }

        public string GetName()
        {
            string name = ConfigurationManager.AppSettings["name"];
            return name;
        }

        public string GetPartialLinkText()
        {
            string partiallinktext = ConfigurationManager.AppSettings["partiallinktext"];
            return partiallinktext;
        }

        public string GetPassWord()
        {
            string password = ConfigurationManager.AppSettings["password"];
            return password;
        }

        public string GetSheetname()
        {
            string sheetname = ConfigurationManager.AppSettings["sheetname"];
            return sheetname;
        }

        public string GetTablename()
        {
            string tablename = ConfigurationManager.AppSettings["tablename"];
            return tablename;
        }

        public string GetTagName()
        {
            string tagname = ConfigurationManager.AppSettings["tagname"];
            return tagname;
        }

        public string GetTitle()
        {
            string title = ConfigurationManager.AppSettings["Title"];
            return title;
        }

        public string GetURL()
        {
            string url = ConfigurationManager.AppSettings["url"];
            return url;
        }

        public string GetUsername()
        {
            string username = ConfigurationManager.AppSettings["username"];
            return username;
        }
    }
}
