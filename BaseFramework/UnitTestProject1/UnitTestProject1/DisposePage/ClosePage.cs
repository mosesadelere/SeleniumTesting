using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.DisposePage
{
    public static class ClosePage
    {
        [AssemblyCleanup]
        public static void PageDispose()
        {
            ObjectInstances.Driver.Dispose();
        }
    }
}
