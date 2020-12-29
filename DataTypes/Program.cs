using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and string variables.
        int j;
        double e;
        string t;

        // Read and save an integer, double, and string to the variables.
        j = Int32.Parse(Console.ReadLine());
        e = Double.Parse(Console.ReadLine());
        t = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine($"{i + j}");

        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:0.0}", d + e));

        // Concatenate and print the string variables on a new line
        Console.WriteLine($"{s + t}");
    }
}