using System;
using System.Configuration;


namespace BaseFramework.BrowserCconfiguration
{
    public class AppConfigReader : IConfig
    {
        public BrowserTypes GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings["Browser"];
            return (BrowserTypes)Enum.Parse(typeof(BrowserTypes), browser);
        }

        public string GetTitle()
        {
            string title = ConfigurationManager.AppSettings["Title"];
            return title;
        }

        public string GetSheetname()
        {
            string sheetname = ConfigurationManager.AppSettings["sheetname"];
            return sheetname;
        }

        public string GetClassname()
        {
            string classname = ConfigurationManager.AppSettings["classname"];
            return classname;
        }

        public string GetUrl()
        {
            string url = ConfigurationManager.AppSettings["url"];
            return url;
        }

        public string GetTablename()
        {
            string tablename = ConfigurationManager.AppSettings["tablename"];
            return tablename;
        }

        public string GetUsername()
        {
            string username = ConfigurationManager.AppSettings["username"];
            return username;
        }

        public string GetPassword()
        {
            string password = ConfigurationManager.AppSettings["password"];
            return password;
        }

        public string GetId()
        {
            string id = ConfigurationManager.AppSettings["id"];
            return id;
        }
    }
}
