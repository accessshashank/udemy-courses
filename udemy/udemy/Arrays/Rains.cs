using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class Rains
    {
        static void Main(string[] args)
        {
            // given n non-negative integers representing elevation map where
            // width of each bar is 1, compute how much water it can trap when it rains
            // https://www.udemy.com/course/cpp-data-structures-algorithms-levelup-prateek-narang/learn/lecture/25191100?start=0#overview

            int[] arr = new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            Console.WriteLine(FindMaxWater(arr));
        }

        private static int FindMaxWater(int[] arr)
        {
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];

            // finding max height to the left of given index
            left[0] = arr[0];
            int max = left[0];
            for (int i=1; i<arr.Length;i++)
            {
                if(arr[i] > max)
                {
                    left[i] = arr[i];
                    max = arr[i];
                }
                else
                {
                    left[i] = max;
                }
            }

            // finding max height to the right of given index
            right[right.Length - 1] = arr[arr.Length - 1];
            max = right[right.Length - 1];

            for(int i = arr.Length-2;i>=0;i--)
            {
                if(arr[i] > max)
                {
                    right[i] = arr[i];
                    max = arr[i];
                }
                else
                {
                    right[i] = max;
                }
            }

            int sum = 0;
            for(int i=0; i<arr.Length;i++)
            {
                sum = sum + (Math.Min(left[i], right[i]) - arr[i]);
            }
            return sum;
        }
    }
}
