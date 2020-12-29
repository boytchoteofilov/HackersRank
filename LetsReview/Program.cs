using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        int n;
        string input;
        int.TryParse(Console.ReadLine(), out n);

        var evenIndexedList = new StringBuilder();
        var oddIndexedList = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();

            for (int j   = 0; j < input.Length; j++)
            {
                if (j % 2 == 0)
                {
                    evenIndexedList.Append(input[j].ToString());                    
                }
                else
                {
                    oddIndexedList.Append(input[j].ToString());
                }
            }

            Console.WriteLine($"{evenIndexedList} {oddIndexedList}");

            evenIndexedList.Clear();
            oddIndexedList.Clear();
        }

        /*
        * print its even-indexed and odd-indexed characters
        * as  space-separated strings on a single line (see the Sample below for more detail).

Note:  is considered to be an even index.
        * 
        * Print output to STDOUT. 
        * 
        * Your class should be named Solution */
    }
}
