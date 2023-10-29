//using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//using System.Text;
//using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit
{
    public class Environment
    {

        public static List<Environment> CreateEnvironments()
        {
            return new List<Environment>
      {
    new Environment("IA UAT", "https://uat-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "SERDINO INC", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("IA QA", "https://qa-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "Target", "Amazon Com Services Inc", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("IA STAGING", "https://staging-app-vos19000000.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "Target", "Amazon Com Services Inc", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("PR UAT", "https://uat-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Publix", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("PR QA", "https://qa-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Publix", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("PR STAGING", "https://staging-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("DC UI UAT", "https://uat-app-vos11000000-ui.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "SERDINO INC", "Toyota", "GSISA0", "GeoDCGUSSol22*@"),
    new Environment("DC UI QA", "https://qa-app-vos11000000-ui.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("DC UI STAGING", "https://staging-app-vos11000000-ui.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Publix", "Toyota", "GSISA0", "GeoDCGUSSol22*@"),
    new Environment("DC PFL UAT", "https://uat-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("DC PFL CUAT", "https://cuat-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("DC PFL STAGING", "https://staging-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("PA UAT", "https://uat-app-vos42000000.geosolinc.com/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "SERDINO INC", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("PA CIT", "https://cit.benefits.uc.pa.gov/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "SERDINO INC", "Toyota", "Gsisa02", "UIgsiA1*"),
    new Environment("PA CUAT", "https://uat.benefits.uc.pa.gov/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "Target", "Toyota", "gsisa0", "UIgsiA1*"),
    new Environment("PA QA", "https://qa-app-vos42000000.geosolinc.com/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "SERDINO INC", "Publix", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("NE UAT", "https://uat-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "Amazon", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("NE QA", "https://qa-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("NE STAGING", "https://staging-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "gsitaxmc080701", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("LA UAT", "https://uat-app-vos22000000.geosolinc.com/vosnet/default.aspx", "70803", "Louisiana", "LA", "MICROCHIP LLC", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("LA QA", "https://qa-app-vos22000000.geosolinc.com/vosnet/default.aspx", "70803", "Louisiana", "LA", "CRAZY MIKE'S", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("TN UAT", "https://uat-app-vos47000000.geosolinc.com/vosnet/default.aspx", "37243", "Tennessee", "TN", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("TN QA", "https://qa-app-vos47000000.geosolinc.com/vosnet/default.aspx", "37243", "Tennessee", "TN", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("AZ UAT", "https://uat-app-vos04000000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("AZ QA", "https://qa-app-vos04000000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("AZ STAGING", "https://staging-app-vos04000000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
    new Environment("NV UAT", "https://uat-app-vos32000000.geosolinc.com/vosnet/default.aspx", "89101", "Nevada", "NV", "Publix", "Toyota", "GSISA0", "GeoIAGUSSol22*@")
            };
    }




        public string SiteName { get; }
        public string SiteUrl { get; }
        public string ZipCode { get; }
        public string StateName { get; }
        public string StateAbbreviation { get; }
        public string Employer1 { get; }
        public string Employer2 { get; }
        public string StaffLogin { get; }
        public string StaffPass { get; }




        public Environment(string siteName, string siteUrl, string zipCode, string stateName, string stateAbbreviation, string employer1, string employer2, string staffLogin, string staffPass)
        {
            SiteName = siteName;
            SiteUrl = siteUrl;
            ZipCode = zipCode;
            StateName = stateName;
            StateAbbreviation = stateAbbreviation;
            Employer1 = employer1;
            Employer2 = employer2;
            StaffLogin = staffLogin;
            StaffPass = staffPass;
        }


    }
}
