using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class SortSubsequence
    {
        static void Main(string[] args)
        {
            string input = "abcd";
            var all = new List<string>();
            GenerateAndSort("", input, all);
            Console.WriteLine(string.Join(", ", all));
        }

        private static void GenerateAndSort(string processed, string unprocessed, List<string> all)
        {
            if(string.IsNullOrEmpty(unprocessed))
            {
                all.Add(processed);
                return;
            }

            char ch = unprocessed[0];
            GenerateAndSort(processed + ch, unprocessed.Substring(1, unprocessed.Length - 1), all);
            GenerateAndSort(processed, unprocessed.Substring(1, unprocessed.Length - 1), all);
            var comparer = new StringComparer();
            all.Sort(comparer);
        } 
    }

    public class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length == y.Length)
            {
                return x.CompareTo(y);
            }
            return x.Length.CompareTo(y.Length);
        }
    }

}
