using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_005_HomePage : BasePage
    {

        By loginButton = By.Id("btnguestlogina");

        public UI_005_HomePage(IWebDriver driver) : base(driver) { }

        public UI_010_LoginIntroPage ClickLoginButton()
        {
            loginButton.WaitForElementToBeClickable(Driver).Click();
            return new UI_010_LoginIntroPage(Driver);
        }

    }
}
