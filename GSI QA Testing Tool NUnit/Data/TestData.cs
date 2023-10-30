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
        static readonly List<Environment> envs = Environment.CreateEnvironments();

        public static string Site { get; private set; } = "LA UAT";

        public static string SSN { get; private set; } = "";
        public static string? Employer1 { get; private set; } = "";
        public static string FirstName { get; private set; } = "";
        public static string LastName { get; private set; } = "";
        public static string DOB { get; private set; } = "";
        public static string? Zip { get; private set; } = "";
        public static string Email { get; private set; } = "";
        public static string Address1 { get; private set; } = "";
        public static string Phone { get; private set; } = "";
        public static string WorkBeginDate { get; private set; } = "";
        public static string WorkEndDate { get; private set; } = "";
        public static string? StateAbbreviation { get; private set; }
        public static string? Url { get; private set; }
        public static string Username { get; private set; }
        public static string Password { get; private set; }
        public static string SecurityResponse { get; private set; }
        public static string JobTitle { get; private set; }
        static TestData()
        {
            if (String.IsNullOrWhiteSpace(SSN))
            {
                SSN = DataGenerator.GenerateRandomNumbers(1, "234567") + DataGenerator.GenerateRandomNumbers(8);
            }

            Environment? selectedEnvironment = envs.FirstOrDefault(e => e.SiteName == Site);
            if (selectedEnvironment != null)
            {
                Url = selectedEnvironment.SiteUrl;
                StateAbbreviation = selectedEnvironment.StateAbbreviation;
                if (String.IsNullOrWhiteSpace(Zip))
                {
                    Zip = selectedEnvironment.ZipCode;
                }
                if (String.IsNullOrWhiteSpace(Employer1))
                {
                    Employer1 = selectedEnvironment.Employer1;
                }
            } else
            {
                Console.WriteLine("Environment not found.");
            }

            if (String.IsNullOrWhiteSpace(FirstName))
            {
                FirstName = "Alex";
            }

            if (String.IsNullOrWhiteSpace(LastName))
            {
                LastName = "Istomin";
            }

            if (String.IsNullOrWhiteSpace(DOB))
            {
                DOB = "11/11/1959";
            }

            Username = "GSIUIAI" + DataGenerator.GenerateRandomLetters(7) + "01";

            if (String.IsNullOrWhiteSpace(Email))
            {
                Email = Username + "@geosolinc.com";
            }

            if (String.IsNullOrWhiteSpace(Address1))
            {
                Address1 = "2714 Park Avenue";
            }

            if (String.IsNullOrWhiteSpace(Phone))
            {
                Phone = "8135647356";
            }

            if (String.IsNullOrWhiteSpace(WorkBeginDate))
            {
                WorkBeginDate = "11/11/2011";
            }

            if (String.IsNullOrWhiteSpace(WorkEndDate))
            {
                WorkEndDate = DateTime.Today.ToString("MM/dd/yyyy");
            }

            Password = "Olga2011!!!!!!";
            SecurityResponse = "test";
            JobTitle = "test";

        }







    }
}
