﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public static class PageNavigator
    {
        public static void GoToPage(string url)
        {
            ObjectInstances.Driver.Navigate().GoToUrl(url);
        }
        
    }
}
