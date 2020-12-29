using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkMagazine
{
    public class Program
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            if (magazine.Length < note.Length)
            {
                Console.WriteLine("No");
                return;
            }
            Dictionary<int, string> magWords = new Dictionary<int, string>();
            int i = 0;
            foreach (string s in magazine)
            {
                magWords.Add(i++, s);
            }

            //Dictionary<int, string> magWords = magazine.ToDictionary(x => Array.IndexOf(magazine, x));


            foreach (var word in note)
            {
                if (!magWords.ContainsValue(word))
                {
                    Console.WriteLine("No");
                    return;
                }
                magWords.Remove(magWords.FirstOrDefault(x => x.Value == word).Key);
            }

            Console.WriteLine("Yes");
        }

        static void Main(string[] args)
        {

            var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\checkMagazine\input.txt");

            string[] mn = reader.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = reader.ReadLine().Split(' ');

            string[] note = reader.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}
