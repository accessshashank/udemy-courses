using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class Subsequence
    {
        static void Main(string[] args)
        {
            string original = "codingminutes";
            string find = "cines";
            Console.WriteLine(IsSubsequence(original, find));
            Console.WriteLine(IsSubsequenceInNTime(original, find));
        }

        private static bool IsSubsequence(string original, string find)
        {
            return Subseq(original, 0, find, 0, 0);
        }

        private static bool Subseq(string original, int i, string find, int j, int count)
        {
            if (find.Length == count) return true;

            if (i >= original.Length || j >= find.Length) return false;
            
            if(original[i] == find[j])
            {
                count++;
                return Subseq(original, i + 1, find, j + 1, count);
            }

            return Subseq(original, i + 1, find, j, count) || Subseq(original, i, find, j + 1, count);
        }

        private static bool IsSubsequenceInNTime(string original, string find)
        {
            int i = original.Length - 1;
            int j = find.Length - 1;

            while(j > -1 && i > -1)
            {
                if(original[i] == find[j])
                {
                    i--;
                    j--;
                }
                else
                {
                    i--;
                }
            }

            return j == -1;
        }
    }
}
