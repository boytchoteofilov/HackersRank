using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearChaos
{
    class Program
    {
        public static void minimumBribes(int[] q)
        {
            var swaps = 0;
            var lastInQueNotBribing = q.Length;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - i > 3)
                {
                    Console.WriteLine("Too chaotic"); //1 2 5 3 7 8 6 4
                    return;                           //0 1 2 3 4 5 6 7
                }

                if (q[i] > i + 1)
                {
                    swaps += (q[i] - (i + 1));
                }
                else
                {
                    if (lastInQueNotBribing > q[i])
                    {
                        lastInQueNotBribing = q[i];
                    }
                    else
                    {
                        swaps++;
                    }
                }
            }

            Console.WriteLine(swaps);
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);
            }
        }
    }
}
