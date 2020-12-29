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

public class Solution
{

    public static void ConvertBinaryToDecimal(string binaryNumber)
    {
        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[binaryNumber.Length - i - 1] == '1')
            {
                decimalNumber += (long)Math.Pow(2, i);
            }
        }

        Console.WriteLine(decimalNumber);
    }

    public static List<char> ConvertDecimalToBinary(int number)
    {
        var binary = new StringBuilder();
        

        while (number != 0)
        {
            var reminder = number % 2;
            binary.Append(reminder);
            number /= 2;
        }

        var result = binary.ToString().Reverse().ToList();
        return result;        
    }

    public static int FindMaxConsecutiveOfAChar(List<char> input)
    {
        var count = 0;
        var max = 0;
        var temp = 0;

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] == '1')
            {
                count++;
            }

            if (input[i] == '0')
            {
                count = 0;
            }

            if (count >= max)
            {
                temp = count;
                max = count;
                count = temp;
            }
        }

        return max;
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
                
        var x = ConvertDecimalToBinary(n);        

        Console.WriteLine(FindMaxConsecutiveOfAChar(x));

        ConvertBinaryToDecimal(Console.ReadLine());
    }
}

