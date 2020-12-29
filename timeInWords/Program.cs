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

    // Complete the timeInWords function below.
    public static string timeInWords(int h, int m)
    {
        string hours = "";
        string minutes = "";

        if (m >30)
        {
            h = h + 1;
        }
        

        switch (h)
        {
            case 1:
                hours = "one";
                break;
            case 2:
                hours = "two";
                break;
            case 3:
                hours = "three";
                break;
            case 4:
                hours = "four";
                break;
            case 5:
                hours = "five";
                break;
            case 6:
                hours = "six";
                break;
            case 7:
                hours = "seven";
                break;
            case 8:
                hours = "eight";
                break;
            case 9:
                hours = "nine";
                break;
            case 10:
                hours = "ten";
                break;
            case 11:
                hours = "eleven";
                break;
            case 12:
                hours = "twelve";
                break;
            default:
                break;
        }

        switch (m)
        {
            case 0:
                minutes = " o' clock";
                break;

            case 1:
                minutes = "one minute past ";
                break;
            case 2:
                minutes = "two minutes past ";
                break;
            case 3:
                minutes = "three minutes past ";
                break;
            case 4:
                minutes = "four minutes past ";
                break;
            case 5:
                minutes = "five minutes past ";
                break;
            case 6:
                minutes = "six minutes past ";
                break;
            case 7:
                minutes = "seven minutes past ";
                break;
            case 8:
                minutes = "eight minutes past ";
                break;
            case 9:
                minutes = "nine minutes past ";
                break;
            case 10:
                minutes = "ten minutes past ";
                break;
            case 11:
                minutes = "eleven minutes past ";
                break;
            case 12:
                minutes = "twelve minutes past ";
                break;
            case 13:
                minutes = "thirteen minutes past ";
                break;
            case 14:
                minutes = "fourteen minutes past ";
                break;
            case 15:
                minutes = "quarter past ";
                break;
            case 16:
                minutes = "sixteen minute past ";
                break;
            case 17:
                minutes = "seventeen minutes past ";
                break;
            case 18:
                minutes = "eighteen minutes past ";
                break;
            case 19:
                minutes = "nineteen minutes past ";
                break;
            case 20:
                minutes = "twenty minutes past ";
                break;
            case 21:
                minutes = "twenty one minutes past ";
                break;
            case 22:
                minutes = "twenty two minutes past ";
                break;
            case 23:
                minutes = "twenty three minutes past ";
                break;
            case 24:
                minutes = "twenty four minutes past ";
                break;
            case 25:
                minutes = "twenty five minutes past ";
                break;
            case 26:
                minutes = "twenty six minutes past ";
                break;
            case 27:
                minutes = "twenty seven minutes past ";
                break;
            case 28:
                minutes = "twenty eight minutes past ";
                break;
            case 29:
                minutes = "twenty nine minutes past ";
                break;
            case 30:
                minutes = "half past ";
                break;           

            case 31:
                minutes = "twenty nine minutes to ";
                break;
            case 32:
                minutes = "twenty eight minutes to ";
                break;
            case 33:
                minutes = "twenty seven minutes to ";
                break;
            case 34:
                minutes = "twenty six minutes to ";
                break;
            case 35:
                minutes = "twenty five minutes to ";
                break;
            case 36:
                minutes = "twenty four minutes to ";
                break;
            case 37:
                minutes = "twenty three minutes to ";
                break;
            case 38:
                minutes = "twenty two minutes to ";
                break;
            case 39:
                minutes = "twenty one minutes to ";
                break;
            case 40:
                minutes = "twenty minutes to ";
                break;
            case 41:
                minutes = "nineteen minutes to ";
                break;
            case 42:
                minutes = "eighteen minutes to ";
                break;
            case 43:
                minutes = "seventeen minutes to ";
                break;
            case 44:
                minutes = "sixteen minutes to ";
                break;
            case 45:
                minutes = "quarter to ";
                break;
            case 46:
                minutes = "fourteen minute to ";
                break;
            case 47:
                minutes = "thirteen minutes to ";
                break;
            case 48:
                minutes = "twelve minutes to ";
                break;
            case 49:
                minutes = "eleven minutes to ";
                break;
            case 50:
                minutes = "ten minutes to ";
                break;
            case 51:
                minutes = "nine minutes to ";
                break;
            case 52:
                minutes = "eight minutes to ";
                break;
            case 53:
                minutes = "seven minutes to ";
                break;
            case 54:
                minutes = "six minutes to ";
                break;
            case 55:
                minutes = "five minutes to ";
                break;
            case 56:
                minutes = "four minutes to ";
                break;
            case 57:
                minutes = "three minutes to ";
                break;
            case 58:
                minutes = "two minutes to ";
                break;
            case 59:
                minutes = "one minute to ";
                break;

            default:
                break;
        }
        string result = "";
        if (m>=1 && m<=30)
        {
            result = minutes + hours;
        }
        else if (m>30)
        {
            result = minutes + hours;
        }

        else if(m==0)
        {
            result = hours + minutes;
        }

        return result;
        
    }

    public static void Main()
    {
        var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\timeInWords\input.txt");

        int h = Convert.ToInt32(reader.ReadLine());

        int m = Convert.ToInt32(reader.ReadLine());

        string result = timeInWords(h, m);
    }
}

