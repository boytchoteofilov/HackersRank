﻿using System.CodeDom.Compiler;
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

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {

        var itemsOut = new Queue<int>();
        var result = new List<int>();
        var number = 0;

        for (int i = 0; i < a.Count(); i++)
        {
            
            if (i<d)
            {
                itemsOut.Enqueue(a[i]);
                number++;
            }
            if (i>=d)
            {
                result.Add(a[i]);
            }

        }

        for (int i = 0; i < number; i++)
        {
            result.Add( itemsOut.Dequeue());
        }
        
        return result.ToArray();
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var reader = new StreamReader(@"C:\Users\boytcho\source\repos\HackersRank\RotateArrayLeft\input.txt");

        string[] nd = reader.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(reader.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        //textWriter.WriteLine(string.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}

