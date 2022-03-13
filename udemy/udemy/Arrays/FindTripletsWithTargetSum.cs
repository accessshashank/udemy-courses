using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class FindTripletsWithTargetSum
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 };
            int target = 18;
            var triplets = FindTriplets(arr, target);
            foreach (var item in triplets)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2 + " " + item.Item3);
            }
        }

        private static List<Tuple<int, int, int>> FindTriplets(int[] arr, int target)
        {
            var triplets = new List<Tuple<int, int, int>>();
            Array.Sort(arr); // if input is not sorted then sort it
            for(int i=0; i<arr.Length;i++)
            {
                int first = arr[i];
                int[] copyArray = new int[arr.Length - 1 - i];
                Array.Copy(arr, i + 1, copyArray, 0, arr.Length - 1 - i);
                var pair = FindPair(copyArray, target - first);
                if(pair.Item1 != int.MinValue)
                {
                    triplets.Add(Tuple.Create(first, pair.Item1, pair.Item2));
                }
            }
            return triplets;
        }

        private static Tuple<int, int> FindPair(int[] a, int sum)
        {
            int start = 0;
            int end = a.Length-1;

            while(start <= end)
            {
                int summation = a[start] + a[end];
                if (summation == sum) return Tuple.Create(a[start], a[end]);
                else if (summation > sum) end--;
                else start++;
            }

            return Tuple.Create(int.MinValue, int.MinValue);
        }
    }
}
