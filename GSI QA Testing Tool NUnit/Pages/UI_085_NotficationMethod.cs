using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_085_NotficationMethod
    {
        By ddUINotices = By.Id("ctl00_Main_content_ucNotificationMethod_ddlPrefDelMethods");
        By ddOtherNotices = By.Id("ctl00_Main_content_ucNotificationMethod_ddlDeterminationNotificationMethod");
        By ddFromWhereAccessing = By.Id("ctl00_Main_content_ucSiteAccess_ddlSiteAccess");
        By dd1099TaxForm = By.Id("ctl00_Main_content_ucNotificationMethod_ddl1099GNotificationMethod");
        By rbLaborMSG = By.CssSelector("label[for='ctl00_Main_content_ucNotificationMethod_rblSignUpMessageLaborService_1']");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_085_NotficationMethod()
        {
            ddUINotices.SelectDropdownByValue("7");

            ddOtherNotices.IsPresent()?.SelectDropdownByValue("7");

            ddFromWhereAccessing.IsPresent()?.SelectDropdownByIndex("1");

            dd1099TaxForm.IsPresent()?.SelectDropdownByValue("7");

            rbLaborMSG.IsPresent()?.Click();

            btnNext.Click();
        }
    }
}
