using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class SubArraySort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 3,4, 5, 8, 6, 7, 9, 10, 11 };
            var output = FindIndex(arr);
            Console.WriteLine(output.Item1 + " " + output.Item2);
        }

        private static Tuple<int,int> FindIndex(int[] arr)
        {
            int maxElement = 0;
            int minElement = 0;

            for(int i=1; i<arr.Length-1;i++)
            {
                if((arr[i] < arr[i-1]) || (arr[i] > arr[i+1]))
                {
                    if(maxElement == 0 && minElement == 0)
                    {
                        maxElement = arr[i];
                        minElement = arr[i];
                    }
                    else
                    {
                        if(arr[i] < maxElement)
                        {
                            minElement = arr[i];
                        }
                        else
                        {
                            maxElement = arr[i];
                        }
                    }
                }
            }

            if (maxElement == 0 && minElement == 0) return Tuple.Create(-1, -1);

            int minIndex = -1;
            int maxIndex = -1;

            for(int i=0; i< arr.Length;i++)
            {
                if(arr[i] > minElement)
                {
                    minIndex = i;
                    break;
                }
            }

            for(int i=arr.Length-1;i>=0;i--)
            {
                if(arr[i] < maxElement)
                {
                    maxIndex = i;
                    break;
                }
            }

            return Tuple.Create(minIndex, maxIndex);
        }
    }
}
