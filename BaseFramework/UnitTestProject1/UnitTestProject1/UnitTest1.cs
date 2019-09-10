using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Configuration;
using UnitTestProject1.DisposePage;
using UnitTestProject1.ElementFinding;
using UnitTestProject1.Interfaces;
using UnitTestProject1.Settings;

namespace UnitTestProject1
{
    
    [TestClass]
    
    public class UnitTest1
    {
        //IWebDriver driver;
        //IWebElement elem;
        //public const string url = "https://kress2m1.github.io/prog-mine.html";
        //private readonly AppConfigReader _config = new AppConfigReader();


        //[TestMethod, TestCategory("Smoke Test")]
        //public void LaunchBrowser()
        //{
        //    driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl(url);
        //    driver.FindElement(By.LinkText("Automation Course")).Click();
        //    //elem.Click();
        //    driver.Dispose();
        //}
        //#endregion
        //[TestMethod, TestCategory("Navigates")]
        //public void Navigates()
        //{
        //    ConfigurationManager.AppSettings.Get("Browser");
        //    Console.WriteLine(BrowserTypes.Chrome);
        //    Console.WriteLine((int)(BrowserTypes.Firefox));
        //}
        [TestMethod]
       // [DataSource("TestData")]
        public void SimpleMethod()
        {
            //TestContext context = null;
            PageNavigator.GoToPage(ObjectInstances.Config.GetURL());
           /* SearchElements.IdName(ObjectInstances.Config.GetUsername());
           // SearchElements.IdPassword(ObjectInstances.Config.GetPassWord());
            SearchElements.IdsendKeys();*/
            string pageTitle = ObjectInstances.Driver.Title;
           // var user = context.DataRow["Arg1"];
            if (pageTitle.Equals(ObjectInstances.Config.GetTitle()))
            {
                Console.WriteLine("Test is successful.");
            }
            else
            {
                Console.WriteLine("Test fails.... Alert developer.");
            }
            if (ObjectInstances.Driver != null)
            {
                ClosePage.PageDispose();
            }
        }
    }
}
