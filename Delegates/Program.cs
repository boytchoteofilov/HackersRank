using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A delegate is simply a reference to a method. 
 * Delegates can be stored and passed around in a variable, and hence they must have a type definition:
 */
namespace Delegates
{
    public class Program
    {
        private delegate int FuncTwoInts(int one, int two);
        private delegate string SayHello(string person);

        private static readonly SayHello FuncHello = person => $"Hello, {person}!";

        private static int Add(FuncTwoInts twoInts)
        {
            return twoInts(1,2);
        }

        FuncTwoInts TheFunc = (one, two) => /*return*/(one + two);
       

        public static void Main(string[] args)
        {          

            var list = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(" ", list));
            list.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();

            Console.WriteLine(FuncHello(Console.ReadLine()));
        }
    }
}
