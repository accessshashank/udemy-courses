using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy
{
    class FindPairWithTargetSum
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {10, 5, 2, 3, -6, 9, 11 };
            int target = 4;
            var tuple = Find(arr, target);
            Console.WriteLine(tuple.Item1 + " " + tuple.Item2);
        }

        private static Tuple<int, int> Find(int[] arr, int target)
        {
            int a = 0;
            int b = 0;

            var dict = new Dictionary<int, int>();
            for(int i =0; i<arr.Length;i++)
            {
                int val = arr[i];
                int remaining = target - val;
                if(dict.ContainsKey(remaining))
                {
                    a = val;
                    b = remaining;
                    break;
                }
                else
                {
                    dict.Add(val, 0);
                }
            }

            return Tuple.Create(a, b);
        }
    }
}
