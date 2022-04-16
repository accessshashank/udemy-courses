using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.SlidingWindow
{
    class Housing
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 2, 1, 4, 1, 3, 2, 1, 1, 2 };
            int k = 8;
            var plots = FindPlotsOfSizeK(arr, k);
            foreach (var item in plots)
            {
                Console.Write("(" + item.Item1 + "," + item.Item2 + ")");
            }
        }

        private static List<Tuple<int, int>> FindPlotsOfSizeK(int[] arr, int k)
        {
            var plots = new List<Tuple<int, int>>();
            int i = 0;
            int j = 0;
            int sum = 0;
            while(j < arr.Length)
            {
                if(i ==j)
                {
                    sum += arr[i];
                    if(sum == k)
                    {
                        plots.Add(Tuple.Create(i, j));
                    }
                    j++;
                }
                else
                {
                    sum += arr[j];
                    if(sum == k)
                    {
                        plots.Add(Tuple.Create(i, j));
                        j++;
                    }
                    else if(sum > k)
                    {
                        sum = sum - arr[i] - arr[j];
                        i++;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return plots;
        }
    }
}
