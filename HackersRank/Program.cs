using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        var result = new List<int>();

        var sortedAr = ar.OrderBy(x=>x).ToArray();
        var distinct = ar.Distinct().ToArray();

        var currentCount = 0;
        for (int j = 0; j < distinct.Count(); j++)
        {
            for (int i = 0; i < sortedAr.Count(); i++)
            {
                if (distinct[j]==sortedAr[i])
                {
                    currentCount++;
                }
            }
            result.Add(currentCount);
            currentCount = 0;
            
        }

        var totalPairs = 0;

        for (int i = 0; i < result.Count(); i++)
        {
            totalPairs += result[i] / 2;
        }
        

        return totalPairs;

        // other's solution
        // 1
        //int res = c.GroupBy(x => x).Where(y => y.Count() >= 2)
        //   .Select(z => z.Count() / 2).Sum();
        //Console.WriteLine(res);
        //2
        //Console.WriteLine(c.GroupBy(x => x).Select(x => x.Count() / 2).Sum());
    }

    static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var reader = new StreamReader(@"C:\Users\boytcho\source\repos\HackersRank\HackersRank\input.txt");
        int n = Convert.ToInt32(reader.ReadLine());

        int[] ar = Array.ConvertAll(reader.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //
    }
}
