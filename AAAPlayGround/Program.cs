using System;
using System.Collections.Generic;
using System.Linq;

class Demo
{
    static void Main()
    {
        SortDictionary();
    }

    public static void SortDictionary()
    {

        // Create a dictionary with string key and Int16 value pair
        Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
        AuthorList.Add("Mahesh Chand", 35);
        AuthorList.Add("Mike Gold", 25);
        AuthorList.Add("Praveen Kumar", 29);
        AuthorList.Add("Raj Beniwal", 21);
        AuthorList.Add("Dinesh Beniwal", 84);

        // Sorted by Key

        Console.WriteLine("Sorted by Key");
        Console.WriteLine("=============");
        foreach (KeyValuePair<string, Int16> author in AuthorList.OrderBy(key => key.Key))
        {
            Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
        }
        Console.WriteLine("=============");

        // Sorted by Value
        Console.WriteLine("Sorted by Value");
        Console.WriteLine("=============");
        foreach (KeyValuePair<string, Int16> author in AuthorList.OrderBy(key => key.Value))
        {
            Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
        }
    }
}
