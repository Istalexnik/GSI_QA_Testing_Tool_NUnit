using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_065_LoginInformation
    {
        By txtUsername = By.Id("ctl00_Main_content_ucLogin_txtUsername");
        By txtPassword = By.Id("ctl00_Main_content_ucLogin_ucPassword_txtPwd");
        By txtPassword2 = By.Id("ctl00_Main_content_ucLogin_ucPassword_txtPwdConfirm");
        By ddSecurityQuestion = By.Id("ctl00_Main_content_ucLogin_ddlSecurityQuestion");
        By txtSecurityResponse = By.Id("txtSecurityQuestionResponse");
        By txtZip = By.Id("ctl00_Main_content_txtZip");
        By rbAuthorizedToWork = By.CssSelector("label[for='ctl00_Main_content_radAuthorizedToWork_0']");
        By txtEmail = By.Id("ctl00_Main_content_ucEmailTextBox_txtEmail");
        By txtEmail2 = By.Id("ctl00_Main_content_ucEmailTextBox_txtEmailConfirm");
        By txtDOB = By.Id("ctl00_Main_content_ucRegDemographics_txtDOB");
        By rbGender = By.CssSelector("label[for='ctl00_Main_content_ucRegDemographics_rblGender_1']");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_065_LoginInformation()
        {
            txtUsername.SendKeys(TestData.Username);

            txtPassword.SendKeys(TestData.Password);

            txtPassword2.SendKeys(TestData.Password);

            ddSecurityQuestion.SelectDropdownByIndex("1");

            txtSecurityResponse.SendKeys(TestData.SecurityResponse);

            Thread.Sleep(100);

            txtZip.WaitForElementToBeClickable().SendKeys(TestData.Zip);
            
            rbAuthorizedToWork.Click();

            txtEmail.WaitForElementToBeClickable().SendKeys(TestData.Email);

            txtEmail2.SendKeys(TestData.Email);

            txtDOB.SendKeys(TestData.DOB);

            rbGender.Click();

            btnNext.Click();

        }
    }
}
