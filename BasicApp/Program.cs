using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApp
{   

    public class Program
    {
        public static void Main()
        {
            var reader = ReadFile();
        }

       

        public static StreamReader ReadFile()
        {
            var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\BasicApp\input.txt");

            return reader;
        }

        public static void PrintArrayOnConsole()
        {

        }

        public static void PrintListOnConsole(List<char> list)
        {
            list.ForEach(x => Console.Write(x.ToString()+ " "));
            Console.WriteLine();
        }

        public static void PrintStringBuilderOnConsole()
        {

        }
    }
}
