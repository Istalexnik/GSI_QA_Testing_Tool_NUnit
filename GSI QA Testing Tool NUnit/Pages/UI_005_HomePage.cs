using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GSI_QA_Testing_Tool_NUnit.Data;
using System.Threading;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_005_HomePage
    {
        By ddLanguage = By.Id("langtrig");
        By btnFileRegUIClaim = By.LinkText("File a regular unemployment claim");
        By btnLogin = By.Id("btnguestlogina");
        By btnLogin2 = By.Id("btnguestloginb");
        By btnSignInRegister = By.Id("ctl00_hlNotRegistered");

        public UI_005_HomePage()
        {
            if (new[] {"AZ"}.Any(site => TestData.Site.Contains(site)))
            {
                btnFileRegUIClaim.KeepSameWindow().Click();
            }

            else
            {
                if (new[] { "PR" }.Any(site => TestData.Site.Contains(site)))
                {
                    ddLanguage.WaitFor(300).SelectDropdownByValue("E");
                }

                btnLogin.IsPresent()?.Click();
                btnLogin2.IsPresent()?.Click();
                btnSignInRegister.IsPresent()?.Click();
            }
        }

    }
}
