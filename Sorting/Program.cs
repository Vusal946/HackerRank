using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            // Write Your Code Here

            Sort(a);
        }

        static void Sort(int[] array)
        {
            int numSwaps = 0;
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        numSwaps++;
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
            Console.WriteLine($"First Element: {array[0]}");
            Console.WriteLine($"Last Element: {array[array.Length-1]}");
        }
    }
}
