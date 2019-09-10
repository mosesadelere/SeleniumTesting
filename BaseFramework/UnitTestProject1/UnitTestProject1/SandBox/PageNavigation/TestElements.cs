using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.DisposePage;
using UnitTestProject1.ElementFinding;
using UnitTestProject1.Settings;

namespace UnitTestProject1
{
    [TestClass]
    public class TestElements
    {
        [TestMethod]
        public void Elements()
        {
            PageNavigator.GoToPage(ObjectInstances.Config.GetURL());
            SendQuery.ClearText(By.Name("search"));
            SendQuery.Queries(By.Name("search"), "selenium");
            GoToLinkAndClick.ClickLink(By.Name("search"));
            if (ObjectInstances.Driver != null)
            {
                ClosePage.PageDispose();
            }
        }
    }
}