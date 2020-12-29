using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class BaseClass
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }
    }
    
    public class Program
    {
        // add array to dictionary.Value and increment dictionary.Key by one as integer
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>add array to dictionary.Value and increment dictionary.Key by one as integer</returns>
        //static Dictionary<int, string> CopyStringArrayToDictionary(string[] input)
        //{
        //    Dictionary<int, string> dictionary = new Dictionary<int, string>();
        //    int i = 0;
        //    foreach (string s in input)
        //    {
        //        dictionary.Add(i++, s);
        //    }

        //    return dictionary;
        //}
        
        //static Dictionary<int, int> GroupByFromArrayToDictionary(BaseClass[] input)
        //{
            

        //    var tmp = from x in input
        //              group x by x.Id;
        //    var result = from y in tmp
        //                 select new
        //                 {
        //                     Id = y.Key,
        //                     Quantity = y.Sum(x => x.Quantity)
        //                 };

        //    tmp = input.GroupBy(x => x.Id)
        //              .Select(y => new {
        //                  Id = y.Key,
        //                  Quantity = y.Sum(x => x.Quantity)
        //              });

        //    return result;
        //}

        public static void TimeWatch(Action function)
        {
            var watch = new Stopwatch();

            watch.Start();
            function();
            watch.Stop();

            Console.WriteLine($"Elapsed: {watch.Elapsed}");
        }

        static void Main(string[] args)
        {
            var list = new DoublyLinkedList<int>();

            while (true)
            {                
                var strs = Console.ReadLine().Split(' ');

                if (strs[0][0] == 'f')
                {
                    list.PushFront(int.Parse(strs[1]));
                }
                if (strs[0][0] == 'b')
                {
                    list.PushBack(int.Parse(strs[1]));
                }

                var line = new StringBuilder();
                for (var node = list.First; node != null; node = node.Next)
                {
                    line.Append(node.Value.ToString() + " ");
                    Console.WriteLine(line);
                }
                
            }
            
            
            //string[] one = new string[5];
            //var two = CopyStringArrayToDictionary(one);

            //var listOfInts = new List<int>();

            //TimeWatch(() =>
            //{
            //    for (int i = 0; i < 11; i++)
            //    {
            //        listOfInts.PushBack(i);
            //    }
            //});  

            //while (true)
            //{
            //    var input = Console.ReadLine().Split(' ');
            //    var index = int.Parse(input[0]);
            //    var value = int.Parse(input[1]);

            //    listOfInts.InsertAt(index, value);

            //    var line = new StringBuilder();

            //    for (int i = 0; i < listOfInts.Size; i++)
            //    {
            //        line.Append($" {listOfInts[i]}");
            //    }

            //    Console.WriteLine(line);
            //}
        }
    }
}
