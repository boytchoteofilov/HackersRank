using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = 1; j < elements.Length; j++)
            {
                var diff = Math.Abs(elements[i] - elements[j]);

                if (diff > maximumDifference)
                {
                    var temp = diff;
                    maximumDifference = diff;
                    diff = temp;
                }
            }
        }
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}