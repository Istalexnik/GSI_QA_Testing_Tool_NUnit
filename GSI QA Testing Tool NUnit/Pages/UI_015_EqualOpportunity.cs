using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_015_EqualOpportunity
    {


        By btnAgree = By.Id("ctl00_Main_content_btnAgree");

        public UI_015_EqualOpportunity()
        {
            if(!btnAgree.FindIt()) { return;}


            btnAgree.Click();
        }
    }
}
