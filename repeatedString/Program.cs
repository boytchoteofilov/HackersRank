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

    // others solution
    // 1. class Program
//    {
//        static void Main(String[] args)
//    {
//        string s = Console.ReadLine();
//        long n = Convert.ToInt64(Console.ReadLine());

//        var inSingle = s.Count(x => x == 'a');

//        var full = n / s.Length;

//        var rest = n % s.Length;

//        var inRest = s.Substring(0, (int)rest).Count(x => x == 'a');

//        var result = (inSingle * full) + inRest;

//        Console.WriteLine(result);

//    }
//}

//2.
// Complete the repeatedString function below.
//static long repeatedString(string s, long n)
//{
//    int numberOfA = s.Count(x => x.Equals('a'));

//    long div = n / s.Length;
//    int resti = (int)n % s.Length;

//    if (resti < 0) resti = 0;
//    long total = div * numberOfA;
//    int rest = s.Substring(0, resti).Count(x => x.Equals('a'));


//    return total + rest;
//}


// Complete the repeatedString function below.

// multiply cycle
static long repeatedString(string s, long n)
    {
        
        long count = 0;
        long numberOfCycles = n / s.Length;
        long substringLeft = n % s.Length;

        var stringLeft = s.Substring(0, (int)substringLeft);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                count++;
                
            }           
        }
        count = count * numberOfCycles;
        for (int i = 0; i < stringLeft.Length; i++)
        {
            if (stringLeft[i] == 'a')
            {
                count++;

            }
        }
        return count;


    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var reader = new StreamReader(@"C:\Users\boytcho\source\repos\HackersRank\repeatedString\input.txt");

        string s = reader.ReadLine();

        long n = Convert.ToInt64(reader.ReadLine());

        long result = repeatedString(s, n);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //
    }
}

