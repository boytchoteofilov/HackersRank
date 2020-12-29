using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtentionMethods;

namespace SelectionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var smth = new int[] { 1, 2, 3 };
            smth.SwapArrayElementsAtIndeces(6, 1);
            Console.WriteLine(String.Join(", ", smth));
        }

        static int[] UseSelectionSort(int[] array)
        {
            var n = array.Count();
            var result = new int[n];
            for (int j = 0; j < n - 1; j++)
            {
                int iMin = j;
                for (int i = j + 1; i < n; i++)
                {
                    if (array[i] < array[iMin])
                    {
                        iMin = i;
                    }

                    if (iMin != i)
                    {
                        var smth = array.SwapArrayElementsAtIndeces(array[j], array[iMin]);
                    }
                }
            }

            return result;
        }
    }
}
