using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_100_EmploymentInformation
    {
        By ddCurrentEmpStatus = By.Id("ctl00_Main_content_ucEmployment_ddlEmployStatus");

        By ddTypeOfBusiness = By.Id("ctl00_Main_content_ucEmployment_ddlTypeBusiness");

        By ddUnempEligibilityStatus = By.Id("ctl00_Main_content_ucEmployment_ddlUnemploymentInsurance");

        By rbLookingForWorkYes = By.Id("ctl00_Main_content_ucEmployment_rblLookingForWork_0");

        By rbApprenticeshipNo = By.Id("ctl00_Main_content_ucEmployment_rblInterestedInRegisteredApprenticeship_1");

        By rbCertificationsNo = By.Id("ctl00_Main_content_ucEmployment_rblCertifications_1");

        By rbDomesticViolenceNo = By.CssSelector("label[for='ctl00_Main_content_ucEmployment_rblFilingclaimDueToDomesticViolence_1']");

        By rbFarmworkerNo = By.Id("ctl00_Main_content_ucEmployment_rblMigrant_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_100_EmploymentInformation()
        {
            ddCurrentEmpStatus.SelectDropdownByValue("3");

            ddTypeOfBusiness.IsPresent()?.SelectDropdownByIndex("1");

            ddUnempEligibilityStatus.IsPresent()?.SelectDropdownByIndex("1");

            rbLookingForWorkYes.Click();

            rbApprenticeshipNo.IsPresent()?.Click();

            rbCertificationsNo.Click();

            rbDomesticViolenceNo.IsPresent()?.Click();

            rbFarmworkerNo.Click();

            btnNext.Click();

        }
    }
}
