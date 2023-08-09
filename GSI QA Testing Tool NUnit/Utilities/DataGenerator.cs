using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Utilities
{
    public static class DataGenerator
    {
        private static Random random = new Random();

        public static string GenerateUniqueSSN()
        {
            return $"{random.Next(2, 8)}{random.Next(1000, 9999)}{random.Next(1000, 9999)}";
        }

        public static DateTime GenerateUniqueBirthdate()
        {
            int year = random.Next(1920, 2020);
            int month = random.Next(1, 13);
            int day = random.Next(1, 29);  // Keeping it simple with up to 28 to avoid invalid dates
            return new DateTime(year, month, day);
        }
    }
}
