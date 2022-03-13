using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class HighestMountain
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {5, 6, 1, 2, 3, 4, 5, 4, 3, 2, 0, 1, 2, 3, -2, 4 };

            Console.WriteLine(Find(arr));
        }

        private static int Find(int[] arr)
        {
            int maxLength = 0;
            for(int i=0; i<arr.Length;i++)
            {
                if(i > 0 && i < arr.Length-1)
                {
                    if(arr[i-1] < arr[i] && arr[i] > arr[i+1])
                    {
                        // i is the peak
                        int k = i;
                        int counter = 1; // because we need to include current element too.
                        while(k > 0 && arr[k] > arr[k-1])
                        {
                            counter++;
                            k--;
                        }

                        while(i < arr.Length && arr[i] > arr[i+1])
                        {
                            counter++;
                            i++;
                        }

                        maxLength = Math.Max(maxLength, counter);
                    }
                }
            }

            return maxLength;
        }
    }
}
