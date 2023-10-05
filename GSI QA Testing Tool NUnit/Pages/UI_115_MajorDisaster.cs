using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_115_MajorDisaster
    {
        By rbMajorDisasterNo = By.Id("ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_115_MajorDisaster()
        {
            rbMajorDisasterNo.Click();

            btnNext.Click();
        }
    }
}
