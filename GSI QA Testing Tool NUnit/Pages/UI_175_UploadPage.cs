﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_175_UploadPage
    {
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_175_UploadPage()
        {
            btnNext.Click();
        }
    }
}
