using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class Program
    {
        public static double Mean(int[] input)
        {
            double result;
            double sum = 0;
            int count = input.Length;

            for (int i = 0; i < count; i++)
            {
                sum += input[i];
            }

            result = sum / count;

            return result;
        }

        public static double WeightetMean(int[] input, int[] weight)
        {
            double up = 0;
            double down = 0;
            int n = input.Length;
            double result;

            for (int i = 0; i < n; i++)
            {
                up += (input[i] * weight[i]);
                down += weight[i];
            }

            result = up / down;
            return result;
        }

        public static double StandardDeviation(int[] input)
        {
            int n = input.Length;
            var mean = Mean(input);
            double[] squaredDistance = new double[n];

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                squaredDistance[i] = Math.Pow(input[i] - mean, 2);
                sum += squaredDistance[i];
            }
            double sd = Math.Sqrt(sum / n);
            return sd;
        }



        public static double Median(int[] input)
        {
            double result;
            int count = input.Length;
            int[] sorted = input.OrderBy(x => x).ToArray();

            if (count % 2 != 0)
            {
                result = sorted[count / 2];
                return result;
            }
            else
            {
                result = (sorted[(count / 2) - 1] + sorted[(count / 2)]) / 2.00;
                return result;
            }

        }

        public static int Mode(int[] input)
        {
            int result = 0;
            int[] sorted = input.OrderBy(x => x).ToArray();

            var numberAndCount = new Dictionary<int, int>();
            numberAndCount = sorted.GroupBy(x => x).ToDictionary(k => k.Key, c => c.Count());
            var maxCount = numberAndCount.OrderByDescending(x => x.Value).Take(2).ToDictionary(k => k.Key, c => c.Value);

            if (maxCount.First().Value == maxCount.Last().Value)
            {
                if (maxCount.First().Key < maxCount.Last().Key)
                {
                    result = maxCount.First().Key;
                }
                else
                {
                    result = maxCount.Last().Key;
                }
            }
            else
            {
                result = maxCount.First().Key;
            }

            return result;
        }

        public static void splitArray<T>(T[] array, int index, out T[] first, out T[] second)
        {
            if (array.Length % 2 == 0)
            {
                first = array.Take(index).ToArray();
                second = array.Skip(index).ToArray();
            }
            else
            {
                first = array.Take(index).ToArray();
                second = array.Skip(index + 1).ToArray();
            }
        }

        public static List<double> Quartiles(int[] inputArr)
        {
            var input = inputArr.OrderBy(x => x).ToArray();
            double firstQ;
            double secondQ;
            double thirdQ;

            int[] firstHalf;
            int[] secondHalf;

            var median = Median(input);
            secondQ = (int)median;
            splitArray(input, input.Length/2, out firstHalf, out secondHalf);

            firstQ = Median(firstHalf);
            thirdQ = Median(secondHalf);

            var result = new List<double>();
            result.Add(firstQ);
            result.Add(secondQ);
            result.Add(thirdQ);

            return result;
        }

        public static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var stringAsConsoleInput = Console.ReadLine().Split(' ');

            int[] input = Array.ConvertAll(stringAsConsoleInput, arrayItem => Convert.ToInt32(arrayItem));

            var mean = Mean(input);
            var median = Median(input);
            var mode = Mode(input);


            //Console.WriteLine(String.Format("{0:0.0}", mean));
            //Console.WriteLine(String.Format("{0:0.0}", median));
            //Console.WriteLine(mode);

            //var sd = StandardDeviation(input);
            //Console.WriteLine(string.Format("{0:0.0}", sd));
            var quartils = Quartiles(input);
            Console.WriteLine(quartils[0]);
            Console.WriteLine(quartils[1]);
            Console.WriteLine(quartils[2]);
        }


    }
}
