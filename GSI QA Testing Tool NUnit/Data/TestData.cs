using GSI_QA_Testing_Tool_NUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Data
{
    public class TestData
    {
        public string Url { get; private set; }
     //   public string Name { get; private set; }
    //    public DateTime Birthdate { get; private set; }
        public string SSN { get; private set; }


        public TestData()
        {
            Url = "https://uat-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx";
            //   Name = DataGenerator.GenerateUniqueName();
            //   Birthdate = DataGenerator.GenerateUniqueBirthdate();
            SSN = DataGenerator.GenerateUniqueSSN();
            //   Employer = DataGenerator.GenerateUniqueEmployer();
        }

    }
}
