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

class Solutionn
{

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        long[] initialArray = new long[n+1];
        //long maxValue = long.MinValue;
        //var maxValue = new SortedSet<long>();

        int times = queries.GetLength(0);

        for (int i = 0; i < times; i++)
        {
            long a = queries[i][0];
            long b = queries[i][1];
            long k = queries[i][2];

            initialArray[a] += k;
            if (b + 1 <= times)
            {
                initialArray[b+1] -= k;
            }
           
        }



        long tempMax = 0;
        long max = 0;
        for (int i = 1; i <= n; i++)
        {
            tempMax += initialArray[i];
            if (tempMax > max) max = tempMax;
        }

        return max;
    }

    static void mmMain(string[] args)
    {
        var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\arrayManipulation\input.txt");

        string[] nm = reader.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(reader.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        Console.WriteLine(result);
    }
}

