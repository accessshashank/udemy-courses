using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class MaxSubArraySum
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {-1, 2, 3, 4, -2,6,-8, 3 };
            Console.WriteLine(MaxSum(arr));
        }

        private static int MaxSum(int[] arr)
        {
            int localSum = 0;
            int maxSum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                localSum = localSum + arr[i];
                if(localSum < 0)
                {
                    localSum = 0;
                }

                maxSum = Math.Max(maxSum, localSum);
            }
            return maxSum;
        }
    }
}
