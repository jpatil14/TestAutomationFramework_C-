using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace TestAutomationFramework.Helpers
{
    public class DataHelperExtensions
    {
        public static Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }
    }
}
