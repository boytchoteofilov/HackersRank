using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotation
{
    class Solution
    {

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {

            var itemsOut = new Queue<int>();
            var result = new List<int>();
            var number = 0;

            for (int i = 0; i < a.Count(); i++)
            {

                if (i < d)
                {
                    itemsOut.Enqueue(a[i]);
                    number++;
                }
                if (i >= d)
                {
                    result.Add(a[i]);
                }

            }

            for (int i = 0; i < number; i++)
            {
                result.Add(itemsOut.Dequeue());
            }

            return result.ToArray();
        }
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\hourglassSum\input.txt");

            string[] nd = reader.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(reader.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));

            
        }
    }
}
