using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//If  is odd, print Weird
//If  is even and in the inclusive range of  to , print Not Weird
//If  is even and in the inclusive range of  to , print Weird
//If  is even and greater than, print Not Weird 

namespace IntrotoConditionalStatements
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 != 0)
            {
                Console.WriteLine("Weird");
            }

            else if ((n % 2 == 0) && (n>=2 &&n<=5))
            {
                Console.WriteLine("Not Weird");
            }

            else if ((n % 2 == 0) && (n >= 6 && n <= 20))
            {
                Console.WriteLine("Weird");
            }
            else if ((n % 2 == 0) && (n > 20))
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
