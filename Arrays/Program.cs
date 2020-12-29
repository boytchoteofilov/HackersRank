using System.Text;
using System;

class Solution
{
    public static StringBuilder PrintArrayReverse(int[] array)
    {
        var result = new StringBuilder();

        for (int i = array.Length-1; i >= 0; i--)
        {
            result.Append(array[i] + " ");
        }

        return result;
    }



    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        Console.WriteLine(PrintArrayReverse(arr));
    }
}

