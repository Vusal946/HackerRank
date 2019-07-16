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
            var b = Sort(a);


            Console.ReadLine();
        }

        static int[] Sort(int[] array)
        {
            int swapCount = 0;
            int[] temp = new int[array.Length];
          
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array.Length - 1; j++)
                {
                   
                    if (array[i] > array[j + 1])
                    {
                        swapCount += 1;
                        temp[j] = array[j + 1];
                    }
                    else
                    {
                        temp[j] = array[j];
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {swapCount} swaps.");
            Console.WriteLine($"First Element: {temp[0]}");
            Console.WriteLine($"Last Element: {temp[array.Length - 1]}");
            array = temp;
            return array;
        }
    }
}
