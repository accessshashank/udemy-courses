using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Strings
{
    class RunLengthEncoding
    {
        static void Main(string[] args)
        {
            string ip = "aaaabcccccaaa";
            Console.WriteLine(Encode(ip));
        }

        private static string Encode(string ip)
        {

            string op = string.Empty;

            for(int i=0;i<ip.Length;i++)
            {
                int counter = 1;
                char ch = ip[i];
                while((i+1 < ip.Length) && ch == ip[i+1])
                {
                    counter++;
                    i = i + 1;
                }
                op = op + ch + counter.ToString();
            }

            if (op.Length <= ip.Length) return op;
            return ip;
        }
    }
}
