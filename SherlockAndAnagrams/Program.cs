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



public static class Solution
{

    public static class PermutationsAndCombinations
    {
        public static long nCr(int n, int r)
        {
            // naive: return Factorial(n) / (Factorial(r) * Factorial(n - r));
            return nPr(n, r) / Factorial(r);
        }

        public static long nPr(int n, int r)
        {
            // naive: return Factorial(n) / Factorial(n - r);
            return FactorialDivision(n, n - r);
        }

        private static long FactorialDivision(int topFactorial, int divisorFactorial)
        {
            long result = 1;
            for (int i = topFactorial; i > divisorFactorial; i--)
                result *= i;
            return result;
        }

        private static long Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
    }

    static Dictionary<string, string> getAllSubstrings(string input)
    {
        var result = new Dictionary<string, string>();

        for (int i = 1; i < input.Length; i++)
        {
            for (int start = 0; start <= input.Length - i; start++)
            {
                string substring = input.Substring(start, i);
                var ii = i; // 
                var startt = start;
                result.Add((i.ToString() + "x" + start), substring); // "x" is to evade problem 11 + 0 and 1 + 10 key same value
             }
        }

        return result;
    }

    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s)
    {       
        // get all substrings from a string
        var dictionaryWithAllSubstring = getAllSubstrings(s);

        // sort each of the values
        var sorted = new List<string>();
        foreach (var item in dictionaryWithAllSubstring)
        {
            string value = String.Concat(item.Value.OrderBy(x=>x)); 
            sorted.Add(value);
        }

        // sort the List
        sorted = sorted.OrderBy(x => x).ToList();

        // populate Dictionary with repetitive items's count
        //
        Dictionary<string, int> counts = sorted
            .GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());

        int result = 0;

        foreach (var item in counts)
        {
            if (item.Value > 1)
            {
                result += (int)(PermutationsAndCombinations.nCr(item.Value, 2));
            }
        }
        
        return result;
    }

    static void Main(string[] args)
    {

        var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\SherlockAndAnagrams\input.txt");

        int q = Convert.ToInt32(reader.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = reader.ReadLine();

            int result = sherlockAndAnagrams(s);
            Console.WriteLine(result);
        }
    }
}
