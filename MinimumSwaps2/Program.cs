using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSwaps2
{
    public class Program
    {
        public static int[] Swap(int[] arr, int lowerIndex, int higherIndex)
        {
            var temp = arr[lowerIndex];

            arr[lowerIndex] = arr[higherIndex];
            arr[higherIndex] = temp;

            return arr;
        }

        // Complete the minimumSwaps function below.
        public static int minimumSwaps(int[] arr)
        {
            int swaps = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                while (i + 1 != arr[i])
                {
                    Swap(arr, i, arr[i] - 1);
                    swaps += 1;
                }
            }

            return swaps;
        }

        public static void Main(string[] args)
        {
            var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\MinimumSwaps2\input.txt");

            int n = Convert.ToInt32(reader.ReadLine());

            int[] arr = Array.ConvertAll(reader.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

            Console.WriteLine(res);
        }
    }

}
