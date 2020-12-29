using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                int penalty = 0;
                
                int[] actualy = Array.ConvertAll(Console.ReadLine().Split(' '), item => Convert.ToInt32(item));
                int[] due = Array.ConvertAll(Console.ReadLine().Split(' '), item => Convert.ToInt32(item));
                

                int dayDue = due[0];
                int monthDue = due[1];
                int yearDue = due[2];

                int dayAct = actualy[0];
                int monthAct = actualy[1];
                int yearAct = actualy[2];

                var yDiff = yearDue - yearAct;
                var mDiff = monthDue - monthAct;
                var dDiff = dayDue - dayAct;

                if (yDiff < 0)
                {
                    penalty = 10000;
                    Console.WriteLine($"{penalty}");
                }

                else if(yDiff == 0)
                {
                    
                    if (mDiff < 0)
                    {
                        penalty = -500 * mDiff;
                        Console.WriteLine($"{penalty}");
                    }
                    else 
                    {
                        
                        if (dDiff < 0)
                        {
                            penalty = -15 * dDiff;
                            Console.WriteLine($"{penalty}");
                        }
                        else
                        {
                            penalty = 0;
                            Console.WriteLine($"{penalty}");
                        }
                    }
                }

                else if (yDiff > 0)
                {

                   
                            penalty = 0;
                            Console.WriteLine($"{penalty}");
                        
                }
            }


        }
    }
}
