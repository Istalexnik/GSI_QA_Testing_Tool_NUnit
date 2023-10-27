using GSI_QA_Testing_Tool_NUnit.Utilities;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Data
{
    public static class TestData
    {
        static TestData()
        {
            Site = "NE UAT";
            WorkBeginDate = "11/11/2011";
            WorkEndDate = DateTime.Today.ToString("MM/dd/yyyy");
            FirstName = "Alex";
            LastName = "Istomin";
            DOB = "11/11/1959";
            SSN = DataGenerator.GenerateRandomNumbers(1, "234567") + DataGenerator.GenerateRandomNumbers(8);
            Username = "GSIUIAI" + DataGenerator.GenerateRandomLetters(7) + 1;
            Password = "Olga2011!";
            SecurityResponse = "Test";
            Email = Username + "@geosolinc.com";
            Address1 = "2714 Park Avenue";
            Phone = "8135647356";
            JobTitle = "Test";
            Environment? selectedEnvironment = envs.FirstOrDefault(e => e.SiteName == Site);
            if (selectedEnvironment != null)
            {
                Url = selectedEnvironment.SiteUrl;
                Zip = selectedEnvironment.ZipCode;
                Employer = selectedEnvironment.Employer1;
                StateAbbreviation = selectedEnvironment.StateAbbreviation;
            }
            else
            {
                Console.WriteLine("Environment not found.");
            }
        }

        static readonly List<Environment> envs = Environment.CreateEnvironments();

        public static string Site { get; private set; }

        public static string? StateAbbreviation { get; private set;}
        public static string? Url { get; private set; }
        public static string? Zip { get; private set; }
        public static string? Employer { get; private set; }
        public static string WorkBeginDate { get; private set; }
        public static string WorkEndDate { get; private set; }
        public static string FirstName { get; private set; }
        public static string LastName { get; private set; }
        public static string DOB { get; private set; }
        public static string SSN { get; private set; }
        public static string Username { get; private set; }
        public static string Password { get; private set; }
        public static string SecurityResponse { get; private set; }
        public static string Email { get; private set; }
        public static string Address1 { get; private set; }
        public static string Phone { get; private set; }
        public static string JobTitle { get; private set; }





    }
}
