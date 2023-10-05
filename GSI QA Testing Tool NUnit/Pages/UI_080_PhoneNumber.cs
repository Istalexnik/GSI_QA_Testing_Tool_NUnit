using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_080_PhoneNumber
    {
        By txtPhone1 = By.Id("ctl00_Main_content_ucPhone_txtPrimePhone1");
        By txtPhone2 = By.Id("ctl00_Main_content_ucPhone_txtPrimePhone2");
        By txtPhone3 = By.Id("ctl00_Main_content_ucPhone_txtPrimePhone3");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_080_PhoneNumber()
        {
            txtPhone1.SendKeys(TestData.Phone.Substring(0, 3));
            txtPhone2.SendKeys(TestData.Phone.Substring(3, 3));
            txtPhone3.SendKeys(TestData.Phone.Substring(6, 4));

            btnNext.Click();

        }
    }
}
