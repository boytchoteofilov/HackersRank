using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayDS
{
    public class Program
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            var result = int.MinValue;



            for (int i = 1; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < arr[i].GetLength(0) - 1; j++)
                {
                    var clocksum = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] +
                        arr[i][j] +
                        arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    if (clocksum > result)
                    {
                        result = clocksum;
                    }
                }
                Console.WriteLine();
            }
            return result;
        }

        static void Main(string[] args)
        {
            var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\hourglassSum\input.txt");

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                var arrLine = reader.ReadLine().Split(' ');
                arr[i] = Array.ConvertAll(arrLine, arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
            Console.WriteLine(result);

        }
    }
}
