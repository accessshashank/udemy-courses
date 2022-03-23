using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy.Arrays
{
    class BusyLife
    {
        static void Main(string[] args)
        {
            var actitities = new List<Tuple<int, int>>();
            actitities.Add(Tuple.Create(7, 9));
            actitities.Add(Tuple.Create(0, 10));
            actitities.Add(Tuple.Create(4, 5));
            actitities.Add(Tuple.Create(8, 9));
            actitities.Add(Tuple.Create(4, 10));
            actitities.Add(Tuple.Create(5, 7));

            Console.WriteLine(MaxActivity(actitities));
        }

        public class ActivityComparer : IComparer<Tuple<int, int>>
        {
            public int Compare(Tuple<int, int> x, Tuple<int, int> y)
            {
                return x.Item2.CompareTo(y.Item2);
            }
        }
        private static int MaxActivity(List<Tuple<int, int>> actitities)
        {
            actitities.Sort((x, y) => x.Item2.CompareTo(y.Item2));
            var previousActivity = actitities[0];
            int counter = 1;
            for(int i=1; i<actitities.Count;i++)
            {
                var currentActivity = actitities[i];
                if(currentActivity.Item1 >= previousActivity.Item2)
                {
                    counter++;
                    previousActivity = currentActivity;
                }
            }
            return counter;
        }
    }
}
