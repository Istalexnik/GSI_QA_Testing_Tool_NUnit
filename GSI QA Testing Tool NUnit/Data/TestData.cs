using GSI_QA_Testing_Tool_NUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Data
{
    public static class TestData
    {
        public static string Url { get; private set; }
        public static string Zip { get; private set; }
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



        static TestData()
        {
            Url = "https://uat-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx";
            Zip = "50001";
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
        }

    }
}
