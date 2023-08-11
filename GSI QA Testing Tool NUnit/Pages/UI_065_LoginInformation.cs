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

        public UI_065_LoginInformation EnterUsername(string username)
        {
            txtUsername.SendKeys(username);
            return this;
        }
        public UI_065_LoginInformation EnterPassword(string password)
        {
            txtPassword.SendKeys(password);
            return this;
        }
        public UI_065_LoginInformation EnterPassword2(string password)
        {
            txtPassword2.SendKeys(password);
            return this;
        }
        public UI_065_LoginInformation SelectSecurityQuestion(int index)
        {
            ddSecurityQuestion.SelectDropdownByIndex(index);
            return this;
        }
        public UI_065_LoginInformation EnterSecurityResponse(string securityResponse)
        {
            txtSecurityResponse.SendKeys(securityResponse);
            return this;
        }
        public UI_065_LoginInformation EnterZip(string zip)
        {
            txtZip.SendKeys(zip);
            return this;
        }
        public UI_065_LoginInformation ClickrbAuthorizedToWorke()
        {
            rbAuthorizedToWork.Click();
            return this;
        }
        public UI_065_LoginInformation EntertxtEmail(string email)
        {
            txtEmail.SendKeys(email);
            return this;
        }
        public UI_065_LoginInformation EntertxtEmail2(string email)
        {
            txtEmail2.SendKeys(email);
            return this;
        }
        public UI_065_LoginInformation EntertxtDOB(string dob)
        {
            txtDOB.SendKeys(dob);
            return this;
        }
        public UI_065_LoginInformation ClickrbGender()
        {
            rbGender.Click().WaitForElementToBeStaleAndRefind();
            return this;
        }
        public UI_070_NamePage ClickbtnNext()
        {
            btnNext.Click();
            return new UI_070_NamePage();
        }
    }
}
