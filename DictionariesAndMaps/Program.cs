using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesAndMaps
{
    public class Program
    {
        public static void FindInDictionary()
        {

        }

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var lineFromConsole = Console.ReadLine().Split(' ');
                phoneBook.Add(lineFromConsole[0], lineFromConsole[1]);
            }


            while (true)
            {                
                var nameFromInput = Console.ReadLine();
                if (nameFromInput == string.Empty)
                {
                    break;
                }

                if (phoneBook.ContainsKey(nameFromInput))
                {
                    string phone = string.Empty;
                    phoneBook.TryGetValue(nameFromInput, out phone);
                    Console.WriteLine($"{nameFromInput}={phone}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                
            }
            
        }
    }
}
