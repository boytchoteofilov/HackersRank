using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblem1
{
    // Lisa's Workbook

    public class Program
    {
        public static int GetPagesPerChapter(int maxNumberOfProblemsPerPage, int problemsCount)
        {
            var currentCahpterPages = 0;

             

                if (problemsCount < maxNumberOfProblemsPerPage)
                {
                    currentCahpterPages = 1;
                }
                else if (problemsCount >= maxNumberOfProblemsPerPage)
                {

                    currentCahpterPages = problemsCount / maxNumberOfProblemsPerPage;

                    if (problemsCount % maxNumberOfProblemsPerPage != 0)
                    {
                        currentCahpterPages++;
                    }

                }
           
            return currentCahpterPages;
            
        }
        // Complete the workbook function below.
        public static int workbook(int n, int k, int[] arr)
        {
            int numberOfChapters = n;
            int maxNumberOfProblemsPerPage = k;

            int specialProblemsCount = 0;

            int currentPageNumber = 0;
            int currentProblemNumber = 0;

            

            foreach (var problemsPerChapter in arr)
            { 
                var pagesPerChapter =  GetPagesPerChapter(maxNumberOfProblemsPerPage, problemsPerChapter);
                for (int i = 0; i < problemsPerChapter; i++)
                {
                    currentProblemNumber++;
                    if (i%maxNumberOfProblemsPerPage==0)
                    {
                        currentPageNumber++;
                    }
                    if (currentProblemNumber == currentPageNumber)
                    {
                        specialProblemsCount++;
                    }
                }
                currentProblemNumber = 0;
            }
            

            return specialProblemsCount;

        }

        public static int CheckIfSpecial(int currentPage, int currentProblem)
        {
            int result = 0;
            if (currentPage == currentProblem)
            {
                result++;
            }
            return result;
        }

        public static int WorkBook(int n, int k, int[] arr)
        {
            for (int i = 0; i < arr[i]; i++)
            {
                //CheckIfSpecial();
            }
        }

        public static void Main(string[] args)
        {
            var reader = new StreamReader(@"C:\Users\boytc\source\repos\HackersRank\AlgoProblem1\input.txt");

            string[] nk = reader.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(reader.ReadLine().TrimEnd().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = workbook(n, k, arr);

            Console.WriteLine(result);
        }
    }
}
