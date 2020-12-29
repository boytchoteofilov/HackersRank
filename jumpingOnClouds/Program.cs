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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        // 0 1 2 3 4 5   i
        // 0 0 0 1 0 0   c[i]

        var totalJumps = c.Count()-1;


        for (int i = 0; i < c.Count()-2 ; )
        {

            if (c[i] == 0 && c[i + 1] == 1)
            {
                totalJumps--;
                i+= 2;
               
            }

            else if (c[i] == 0 && c[i + 1] == 0)
            {
                totalJumps--;
                i += 2;
               
            }
            else
            {
               
                i ++;
            }

        }

        return totalJumps;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var reader = new StreamReader(@"C:\Users\boytcho\source\repos\HackersRank\jumpingOnClouds\TextFile1.txt");

        int n = Convert.ToInt32(reader.ReadLine());

        int[] c = Array.ConvertAll(reader.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}

