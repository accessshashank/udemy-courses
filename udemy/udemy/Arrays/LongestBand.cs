using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class LongestBand
    {
        static void Main(string[] args)
        {
            // band is subsequence whnich when reordered in such as manner all elements appear consecutive
            // i.e difference of 1 with neignbouring values
            int[] arr = new int[] { 1, 9, 3, 0, 18, 5, 2, 4, 10, 7, 12, 6};

            Console.WriteLine(FindLongest(arr));
        }

        private static int FindLongest(int[] arr)
        {
            int maxBand = 0;
            var dict = new Dictionary<int, int>();

            for(int i=0;i<arr.Length;i++)
            {
                dict.Add(arr[i], 0);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int val = arr[i];
                if(dict.ContainsKey(val-1))
                {
                    continue;
                }
                else
                {
                    // val can be start of a new band
                    int counter = 1;
                    bool found = true;
                    while(found)
                    {
                        val++;
                        if(dict.ContainsKey(val))
                        {
                            counter++;
                        }
                        else
                        {
                            found = false;
                        }
                    }

                    maxBand = Math.Max(maxBand, counter);
                }
            }
            return maxBand;
        }
    }
}
