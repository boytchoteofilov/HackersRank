using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningTimendComplexity
{
    class Solution
    {
        static void Main(String[] args)
        {
            /* Enter your code here. 
             * Read input from STDIN. Print output to STDOUT.
             * Your class should be named Solution */

            long n = Int64.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var p = int.Parse(Console.ReadLine());
                Console.WriteLine(IsPrime(p));
            }
        }

        private static string IsPrime(long n)
        {
            string result = "Prime";

            if (n <= 1)
            {
                return "Not prime";
            }

            if (n ==2)
            {
                return "Prime";
            }

            var limit = Math.Ceiling(Math.Sqrt(n));

            for (long i = 2; i <= limit; i++)
            {
                if (n % i == 0)
                {
                    result = "Not prime";
                    break;
                }
            }

            return result;
        }
    }
}
