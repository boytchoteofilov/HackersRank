using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
    class Program
    {
//        bonAppetit has the following parameter(s) :

//bill: an array of integers representing the cost of each item ordered
//k: an integer representing the zero-based index of the item Anna doesn't eat
//b: the amount of money that Anna contributed to the bill
        static void bonAppetit(List<int> bill, int k, int b)
        {
            var billAnnaShouldPay = bill;
            billAnnaShouldPay.RemoveAt(k);
            var sum = billAnnaShouldPay.Sum(x => x);

            if (sum/2==b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(Math.Abs(sum/2-b));
            }
        }


        static void Main(string[] args)
        {
            var reader = new StreamReader(@"C:\Users\boytcho\source\repos\HackersRank\BonAppetit\input.txt");

            string[] nk = reader.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = reader.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(reader.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }
    }
}
