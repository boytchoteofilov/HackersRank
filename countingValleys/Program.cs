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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        var valleysCount = 0;
        bool inValey = false;
        var level = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]=='U')
            {
                level++;
            }

            if (s[i]=='D')
            {
                level--;
            }

            if (level<0)
            {
                inValey = true;


            }
            if (level>0)
            {
                inValey = false;
            }

            if (inValey && level==0)
            {
                valleysCount++;
            }
        }

        return valleysCount;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var reader = new StreamReader(@"C:\Users\boytcho\source\repos\HackersRank\countingValleys\input.txt");
        int n = Convert.ToInt32(reader.ReadLine());

        string s = reader.ReadLine();

        int result = countingValleys(n, s);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}

