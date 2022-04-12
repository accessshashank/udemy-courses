using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Strings
{
    class PalindromeBreak
    {
        static void Main(string[] args)
        {
            string ip = "abccba";
            Console.WriteLine(BreakPalindromeWithLexicographicallySmallest(ip));
        }

        private static string BreakPalindromeWithLexicographicallySmallest(string ip)
        {
            if (ip.Length == 1) return "";
            int nonA = -1;

            for(int i=0;i<ip.Length;i++)
            {
                if(ip[i] != 'a')
                {
                    nonA = i;
                    break;
                }
            }

            return ip.Substring(0, nonA) + 'a' + ip.Substring(nonA + 1);
        }
    }
}
