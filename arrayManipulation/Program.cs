using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static void Main(String[] args)
    {

        string[] inString = Console.ReadLine().Split(' ');
        uint[] initParams = Array.ConvertAll(inString, UInt32.Parse);
        uint n = initParams[0];
        uint m = initParams[1];

        long[] numList = new long[n];

        for (int i = 0; i < m; i++)
        {
            string[] opString = Console.ReadLine().Split(' ');
            uint a = UInt32.Parse(opString[0])-1;
            uint b = UInt32.Parse(opString[1])-1;
            long k = long.Parse(opString[2]);

            numList[a] += k;
            if (b <= n)
            {
                numList[b] -= k;
            }
        }

        long tempMax = 0;
        long max = 0;
        for (int i = 0; i < n; i++)
        {
            tempMax += numList[i];
            if (tempMax > max)
            {
                max = tempMax;
            }
        }

        Console.WriteLine(max.ToString());
    }
}