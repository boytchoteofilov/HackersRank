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

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        var result = 0;

        for (int i = 0; i < ar.Length; i++)
        {
            for (int j = i + 1; j < ar.Length; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    result++;
                }
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\divisibleSumPairs\input.txt");
        string[] nk = reader.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(reader.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = divisibleSumPairs(n, k, ar);

        Console.WriteLine(result);
    }
}

