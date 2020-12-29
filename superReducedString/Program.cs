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
    public static void RemoveAdjacent(string str)
    {

    }

    // Complete the superReducedString function below.
    public static string superReducedString(string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            sb.Append(s[i]);
        }

        var changed = false;
        do
        {
            changed = false;
            for (int i = 0; i < sb.Length-1; i++)
            {
                if (sb[i] != sb[i + 1])
                {
                    continue;
                }
                else
                {
                    sb.Remove(i, 2);
                    changed = true;
                }
            }
        } while (changed);

        return sb.ToString();

    }

    static void Main(string[] args)
    {
        var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\superReducedString\input.txt");

        string s = reader.ReadLine();

        string result = superReducedString(s);

        if (result.Length == 0)
        {
            Console.WriteLine("Empty String");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}
