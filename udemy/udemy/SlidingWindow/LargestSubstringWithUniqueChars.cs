using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.SlidingWindow
{
    class LargestSubstringWithUniqueChars
    {
        static void Main(string[] args)
        {
            string str = "prateekbhaiya";
            Console.WriteLine(LargestSubstrWithUniqueChars(str));
        }

        private static string LargestSubstrWithUniqueChars(string str)
        {
            var dict = new Dictionary<char, int>();
            string longest = "";
            string temp = "";
            int i = 0;
            int j = 0;

            while(j < str.Length)
            {
                char ch = str[j];
                if(dict.ContainsKey(ch))
                {
                   
                    dict.Clear();
                    dict[ch] = j; // override with latest index

                    temp = ch.ToString();
                    j++;
                }
                else
                {
                    dict.Add(ch, j);
                    temp = temp + ch.ToString();
                    j++;

                }

                if(temp.Length > longest.Length)
                {
                    longest = temp;
                }
            }

            return longest;
        }
    }
}
