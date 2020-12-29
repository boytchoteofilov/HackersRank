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
    // 1 2 1 3 2
    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m)
    {
        var result = 0;
        for (int i = 0; i <= s.Count-m; i++)
        {
            var sum = 0;
            for (int j = i; j < i+m; j++)
            {
                
                sum += s[j];
                
            }

            if (sum == d)
            {
                result++;
            }
        }
        return result;

    }

    static void Main(string[] args)
    {
        var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\birthday\input.txt");

        int n = Convert.ToInt32(reader.ReadLine().Trim());

        List<int> s = reader.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] dm = reader.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = birthday(s, d, m);
        Console.WriteLine(result);
    }
}

