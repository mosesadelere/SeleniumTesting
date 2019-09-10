using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;
using UnitTestProject1.DisposePage;
using UnitTestProject1.ElementFinding;

namespace UnitTestProject1.SandBox.PageNavigation
{
    [TestClass]
    public class NavigationTest
    {
        [TestMethod]
        [TestCategory ("PlayGround")]
        public void openPage()
        {
            //Alternative
            // ObjectInstances.Driver.Navigate();
            //ObjectInstances.Config.GetURL();
            /*
            var page = ObjectInstances.Driver.Navigate();
            page.GoToUrl(ObjectInstances.Config.GetURL());
            */
            //PageNavigator.GoToPage(ObjectInstances.Config.GetURL());
            //SearchElements.IdName(ObjectInstances.Config.GetUsername());
            //SearchElements.IdPassword(ObjectInstances.Config.GetPassWord());
            //SearchElements.IdsendKeys();
            //ClosePage.PageDispose();
        }
    }
}
