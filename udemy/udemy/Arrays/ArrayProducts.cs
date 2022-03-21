using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class ArrayProducts
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(",", Products(arr)));
            Console.WriteLine(string.Join(",", ProductsV2(arr)));
        }

        private static int[] Products(int[] arr)
        {
            int prod = 1;
            for(int i=0; i<arr.Length;i++)
            {
                prod *= arr[i];
            }

            var result = new int[arr.Length];

            for(int i=0; i<arr.Length;i++)
            {
                result[i] = (int)(prod * Math.Pow(arr[i], -1));
            }
            return result;
        }

        private static int[] ProductsV2(int[] arr)
        {
            int prod = 1;
            var result = new int[arr.Length];

            for(int i=0;i<arr.Length;i++)
            {
                result[i] = prod;
                prod = prod * arr[i];
            }

            prod = 1;

            for(int i=arr.Length-1;i>=0;i--)
            {
                result[i] = result[i] * prod;
                prod = prod * arr[i];
            }
            
            return result;
        }
    }
}
