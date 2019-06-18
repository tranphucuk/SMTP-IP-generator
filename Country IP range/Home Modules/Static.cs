using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Country_IP_range.Home_Modules
{
   public class Static
    {
        public static List<string> countryList = new List<string>();
        public readonly static List<KeyValuePair<string, string>> saveOptions = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("Text","0"),
            new KeyValuePair<string, string>("Excel","1"),
        };

        public readonly static List<KeyValuePair<string, string>> levelSplit = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("Level 1","1"),
            new KeyValuePair<string, string>("Level 2","2"),
            new KeyValuePair<string, string>("Level 3","3"),
        };

        public static List<string> GetCountryToList()
        {
            var filePath = Application.StartupPath + "\\data\\Region.txt";
            string[] file = File.ReadAllLines(filePath);
            for (int i = 0; i < file.Length; i++)
            {
                string country = file[i];
                countryList.Add(country);
            }
            return countryList;
        }
    }
}
