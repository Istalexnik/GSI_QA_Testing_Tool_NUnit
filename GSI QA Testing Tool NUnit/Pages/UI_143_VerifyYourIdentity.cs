using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_143_VerifyYourIdentity
    {
        By elementVerifyYourIdentity = By.XPath("(//h2[text()='Verify Your Identity'])");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_143_VerifyYourIdentity()
        {
            if (!elementVerifyYourIdentity.FindIt()) { return; }


            btnNext.Click();

            //problem in GUS that th epage shows twice
            btnNext.IsPresent()?.Click();
        }
    }
}
