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

    // Complete the twoStrings function below.
    static string twoStrings(string s1, string s2)
    {
        var string1UniqueLetters = new Dictionary<char, string>();
        var string2UniqueLetters = new Dictionary<char, string>();

        var uniqueLetters1 = new String(s1.Distinct().ToArray());
        var uniqueLetters2 = new String(s2.Distinct().ToArray());

        foreach (var item in uniqueLetters1)
        {
            string1UniqueLetters.Add(item, item.ToString());
        }

        foreach (var item in uniqueLetters2)
        {
            string2UniqueLetters.Add(item, item.ToString());
        }

        if (uniqueLetters1.Length <= uniqueLetters2.Length)
        {
            for (int i = 0; i < uniqueLetters1.Length; i++)
            {
                if (string2UniqueLetters.ContainsKey(uniqueLetters1[i]))
                {
                    return "YES";
                }
            }
        }

        else 
        {
            for (int i = 0; i < uniqueLetters2.Length; i++)
            {
                if (string1UniqueLetters.ContainsKey(uniqueLetters2[i]))
                {
                    return "YES";
                }
            }
        }


        return "NO";

    }
    static void Main(string[] args)
    {
        var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\twoStrings\input.txt");

        int q = Convert.ToInt32(reader.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = reader.ReadLine();

            string s2 = reader.ReadLine();

            string result = twoStrings(s1, s2);

            Console.WriteLine(result);
        }

        
    }
}
