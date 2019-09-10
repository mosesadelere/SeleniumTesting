using BankJob.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankJob.Interface
{
    public interface IConFig
    {
        string GetUserName();
        string GetPassWord();
        BrowserType GetbrowserType();
        string GetURL();

    }
}
