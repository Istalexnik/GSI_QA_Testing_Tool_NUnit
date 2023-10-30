﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_010_IntroPage
    {
         By btnRegistration = By.Id("btnIndRegistration");


        public UI_010_IntroPage()
        {
            if (!btnRegistration.FindIt()) { return; }

            btnRegistration.JSClick();
        }

    }
}
