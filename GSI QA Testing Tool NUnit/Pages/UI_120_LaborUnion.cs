using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_120_LaborUnion
    {
        By rbMemberNo = By.Id("ctl00_Main_content_ucUILaborUnion_rblUnionMember_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_120_LaborUnion()
        {
            rbMemberNo.Click();

            btnNext.Click();
        }
    }
}
