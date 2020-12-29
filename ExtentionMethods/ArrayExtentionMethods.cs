using System;
using System.Linq;

namespace ExtentionMethods
{
    public static class ArrayExtentionMethods
    {
        public static int[] SwapArrayElementsAtIndeces(this int[] array, int valueBeingSwappedIndex, int valueToBeSwappedIndex)
        {
            try
            {
                int n = array.Count();
               
                    var tempValue = array[valueToBeSwappedIndex];
                    array[valueToBeSwappedIndex] = array[valueBeingSwappedIndex];
                    array[valueBeingSwappedIndex] = tempValue;
                    return array;
               
                
            }
            catch (IndexOutOfRangeException e)
            {
                
                Console.WriteLine(" Out of array range! {0}", e.Message);
                return array;
            }
        }
    }
}
