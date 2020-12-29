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

    // Complete the minimumDistances function below.
    static int minimumDistances(int[] a)
    {
        var n = a.Count();
        var minDistance = int.MaxValue;
        // 7 1 3 4 1 7
        for (int i = 0; i < n-1; i++)
        {
            for (int j = i+1; j < n; j++)
            {
                if (a[i] == a[j])
                {
                    if ((j-i) < minDistance)
                    {
                        minDistance = j - i;
                    }
                    
                }
            }
        }
        if (minDistance==int.MaxValue)
        {
            return -1;
        }
        return minDistance;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var reader = new StreamReader(@"C:\Users\boytcho\source\repos\HackersRank\minimumDistances\input.txt");

        int n = Convert.ToInt32(reader.ReadLine());

        int[] a = Array.ConvertAll(reader.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        int result = minimumDistances(a);
        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}

