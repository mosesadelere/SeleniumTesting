using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Configuration;
using OpenQA.Selenium;

namespace UnitTestProject1.CustomException
{
    public class InvalidBrowser : Exception
    {
        public InvalidBrowser(string message) : base(message)
        {
            throw new ArgumentException(message);
        }

        public InvalidBrowser(string message, BrowserTypes browserTypes) : this(message)
        {
            throw new ArgumentException(message + browserTypes);
           // Console.WriteLine(message + browserTypes);
        }

        public InvalidBrowser() : base()
        {
        }

        public InvalidBrowser(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidBrowser(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
}
