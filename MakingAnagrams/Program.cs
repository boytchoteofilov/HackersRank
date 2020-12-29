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
using BasicApp;

public class Solution
{

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b)
    {
        var aCharArr = a.ToCharArray();
        var bCharArr = b.ToCharArray();

        if (a.Length <= b.Length)
        {
            for (int i = 0; i < a.Length; i++)
            {
                char value = a[i];

                int pos = Array.FindIndex(bCharArr, x => x == value);
                if (pos > -1)
                {
                    aCharArr[i] = '-';
                    bCharArr[pos] = '-';
                }
            }
        }

        else if (b.Length <= a.Length)
        {
            for (int i = 0; i < b.Length; i++)
            {
                char value = b[i];

                int pos = Array.FindIndex(aCharArr, x => x == value);
                if (pos > -1)
                {
                    bCharArr[i] = '-';
                    aCharArr[pos] = '-';
                }
            }
        }

        var count = 0;

        foreach (var item in aCharArr)
        {
            if (item != '-')
            {
                count++;
            }
        }
        foreach (var item in bCharArr)
        {
            if (item != '-')
            {
                count++;
            }
        }

        return count;
    }

    public static void Main(string[] args)
    {
        var reader = BasicApp.Program.ReadFile();

        string a = reader.ReadLine();

        string b = reader.ReadLine();

        int res = makeAnagram(a, b);

        Console.WriteLine($"{res}");
    }
}

