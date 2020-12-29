using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{


    public class Solution
    {

        public static int minimum_index(int[] seq)
        {
            if (seq.Length == 0)
            {
                throw new ArgumentException("Cannot get the minimum value index from an empty sequence");
            }
            int min_idx = 0;
            for (int i = 1; i < seq.Length; ++i)
            {
                if (seq[i] < seq[min_idx])
                {
                    min_idx = i;
                }
            }
            return min_idx;
        }

        static class TestDataEmptyArray
        {
            public static int[] get_array()
            {
                return new int[0];
            }
        }

        static class TestDataUniqueValues
        {
            public static int[] get_array()
            {
                return new int[] { 1, 23, 28 };
            }

            public static int get_expected_result()
            {
                return 0;
            }
        }

        static class TestDataExactlyTwoDifferentMinimums
        {
            public static int[] get_array()
            {
                return new int[] { 1, 1 };
            }

            public static int get_expected_result()
            {
                return 0;
            }
        }


    }
}