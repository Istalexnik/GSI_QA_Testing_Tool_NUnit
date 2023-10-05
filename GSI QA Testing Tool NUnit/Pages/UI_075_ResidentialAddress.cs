using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_075_ResidentialAddress
    {

        By txtAddress1 = By.Id("ctl00_Main_content_ucAddress_txtAddress1");
        By cbSameAddress = By.Id("ctl00_Main_content_ucAddress_chkPopulateMailAddress");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        
        public UI_075_ResidentialAddress()
        {
            txtAddress1.WaitForElementToBeClickable().SendKeys(TestData.Address1);

            cbSameAddress.Click();

            btnNext.Click();

        }

    }
}
