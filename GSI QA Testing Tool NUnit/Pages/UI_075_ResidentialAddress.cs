using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSI_QA_Testing_Tool_NUnit.Data;
using System.Threading;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_075_ResidentialAddress
    {
        By rbValidation = By.CssSelector("label[for='ctl00_Main_content_ucAddress_rdoCorrectedResidentialAddress_0']");
        By txtAddress1 = By.Id("ctl00_Main_content_ucAddress_txtAddress1");
        By ddWard = By.Id("ctl00_Main_content_ucAddress_ddlAltGeo");
        By rbAddressConfidentialityProgram = By.CssSelector("label[for='ctl00_Main_content_ucAddress_rbACPEnrollment_1']");
        By cbSameAddress = By.Id("ctl00_Main_content_ucAddress_chkPopulateMailAddress");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        
        public UI_075_ResidentialAddress()
        {
            Thread.Sleep(200);

            rbAddressConfidentialityProgram.IsPresent()?.Click();

            txtAddress1.WaitForElementToBeClickable().SendKeys(TestData.Address1);

            if (new[] { "LA", "IA", "AZ" }.Any(site => TestData.Site.Contains(site)))
            {
                txtAddress1.SendKeys(Keys.Tab).WaitForElementToBeStaleAndRefind();
            }

            ddWard.IsPresent()?.SelectDropdownByIndex("1").WaitForElementToBeStaleAndRefind();

            rbValidation.IsPresent()?.Click().WaitForElementToBeStaleAndRefind();

            cbSameAddress.Click();

            btnNext.WaitForElementToBeClickable().Click();

        }

    }
}
