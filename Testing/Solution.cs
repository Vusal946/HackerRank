using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    //class Program
    //{
    //    //static void Main(string[] args)
    //    //{
    //    //}
    //}

    public class Solution
    {

        public static int minimum_index(int[] seq)
        {
            if (seq.Length == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot get the minimum value index from an empty sequence");
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
                // complete this function
                return new int[0];
            }
        }

        static class TestDataUniqueValues
        {
            public static int[] get_array()
            {
                // complete this function
                return new int[] { 2, 1 };
            }

            public static int get_expected_result()
            {
                // complete this function
                int minValue = get_array()[0];
                int index = 0;
                for (int i = 0; i < get_array().Length; i++)
                {
                    minValue = minValue < get_array()[i] ? minValue : get_array()[i];
                    index = minValue < get_array()[i] ? index : i;
                }
                return index;
            }
        }

        static class TestDataExactlyTwoDifferentMinimums
        {
            public static int[] get_array()
            {
                // complete this function
                return new int[]{1,1,3};
            }

            public static int get_expected_result()
            {
                // complete this function
                int minValue = get_array()[0];
                int index = 0;
                for (int i = 0; i < get_array().Length; i++)
                {
                    minValue = minValue <= get_array()[i] ? minValue : get_array()[i];
                    index = minValue <= get_array()[i] ? index : i;
                }
                return index;
            }
        }


        public static void TestWithEmptyArray()
        {
            try
            {
                int[] seq = TestDataEmptyArray.get_array();
                int result = minimum_index(seq);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return;
            }

            throw new Exception("Exception wasn't thrown as expected");
        }

        public static void TestWithUniqueValues()
        {
            int[] seq = TestDataUniqueValues.get_array();
            if (seq.Length < 2)
            {
                throw new Exception("less than 2 elements in the array");
            }

            int[] tmp = new int[seq.Length];
            for (int i = 0; i < seq.Length; ++i)
            {
                tmp[i] = seq[i];
            }

            if (!((new HashSet<int>(tmp)).Count() == seq.Length))
            {
                throw new Exception("not all values are unique");
            }

            int expected_result = TestDataUniqueValues.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                throw new Exception("result is different than the expected result");
            }
        }

        public static void TestWithExactlyTwoDifferentMinimums()
        {
            int[] seq = TestDataExactlyTwoDifferentMinimums.get_array();
            if (seq.Length < 2)
            {
                throw new Exception("less than 2 elements in the array");
            }

            int[] tmp = (int [])seq.Clone();
            Array.Sort(tmp);
            if (!(tmp[0] == tmp[1] && (tmp.Length == 2 || tmp[1] < tmp[2])))
            {
                throw new Exception("there are not exactly two minimums in the array");
            }

            int expected_result = TestDataExactlyTwoDifferentMinimums.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                throw new Exception("result is different than the expected result");
            }
        }

        public static void Main(String[] args)
        {
            TestWithEmptyArray();
            TestWithUniqueValues();
            TestWithExactlyTwoDifferentMinimums();
            Console.WriteLine("OK");
        }
    }
}