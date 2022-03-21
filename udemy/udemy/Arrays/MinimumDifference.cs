using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class MinimumDifference
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 23, 5, 10, 17, 30};
            int[] arr2 = new int[] { 26, 134, 135, 14, 19};
            var tuple = FindMinDiff(arr1, arr2);
            Console.WriteLine(tuple.Item1 + " " + tuple.Item2);
        }

        private static Tuple<int,int> FindMinDiff(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);

            int n = arr1.Length;
            int m = arr2.Length;

            int previ = 0;
            int prevj = 0;
            int i = 0;
            int j = 0;
            int diff = int.MaxValue;

            while (i < n && j < m)
            {
                if(Math.Abs(arr1[i] - arr2[j]) < diff)
                {
                    diff = Math.Abs(arr1[i] - arr2[j]);
                    previ = i;
                    prevj = j;
                }

                if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return Tuple.Create(arr1[previ], arr2[prevj]);
        }
    }
}
