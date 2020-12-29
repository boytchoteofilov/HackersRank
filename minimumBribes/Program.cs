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
    // Complete the minimumBribes function below.

    public static void min(int[] q)
    {
        var swaps = 0;
        var lastInQueNotBribing = q.Length;
        for (int i = q.Length - 1; i >= 0; i--)
        {            
            if (q[i] - i > 3)
            {                
                Console.WriteLine("Too chaotic"); //1 2 5 3 7 8 6 4
                return;                           //0 1 2 3 4 5 6 7
            }

            if (q[i] > i + 1)
            {
                swaps += (q[i] - (i + 1));
            }
            else
            {
                if (lastInQueNotBribing > q[i])
                {
                    lastInQueNotBribing = q[i];
                }
                else 
                {
                    swaps++;
                }
            }
        }

        Console.WriteLine(swaps);

    }
    static void Main(string[] args)
    {

        var reader = new StreamReader(@"c:\Users\boytc\source\repos\HackersRank\minimumBribes\input.txt");

        int t = Convert.ToInt32(reader.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(reader.ReadLine());

            int[] q = Array.ConvertAll(reader.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            min(q);
        }
    }
}
