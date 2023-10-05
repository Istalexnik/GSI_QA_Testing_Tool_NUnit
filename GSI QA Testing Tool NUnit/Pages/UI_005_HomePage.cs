using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_005_HomePage
    {
       
        By btnLogin = By.Id("btnguestlogina");


        public UI_005_HomePage()
        {
            btnLogin.IsPresent()?.Click();
        }

    }
}
