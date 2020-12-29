using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string s = Console.ReadLine();

        try
        {
            int result = Int32.Parse(s);
            Console.WriteLine(result);
        }
        catch (Exception)
        {
            Console.WriteLine("Bad String");
        }
    }
}
