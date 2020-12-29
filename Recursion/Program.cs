using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Program
    {
        public static long Factorial(int n)
        {
            long result = 1;


            if (n == 0)
            {
                return 1;
            }
            
            result = n * Factorial(n - 1);

            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
        }
    }
}
