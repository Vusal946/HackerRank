using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RunningTimeAndComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());
            var count = T;

            var numbers = new HashSet<int>();
            while (T-- > 0)
                numbers.Add(int.Parse(Console.ReadLine()));

            TestSpeed(numbers);


            //var numbers = new int[T];
            //while (T-- > 0)
            //    numbers[T] = (int.Parse(Console.ReadLine()));
            // TestSpeedwithfor(numbers);

            //var startTime = DateTime.Now;
            //while (count-- > 0)
            //    Console.WriteLine((isPrime(numbers[count]) ? "Prime" : "Not prime"));
            //Console.WriteLine(DateTime.Now - startTime);




        }
        public static bool isPrime(int n)
        {
            if (n < 0 || n == 1)
                return false;

            if (n == 2)
                return true;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void TestSpeed(HashSet<int> hashSet)
        {
            var startTime = DateTime.Now;
            foreach (var item in hashSet)
            {
                if (item < 0 || item == 1)
                    Console.WriteLine("Not prime");
                else if (item <= 3)
                    Console.WriteLine("Prime");
                else
                {
                    int divisionCount = 0;
                    if (item % 2 == 0)
                        divisionCount++;
                    else
                    {
                        for (int i = 2; i*i <= item; i++)
                        {
                            if (item % i == 0)
                            {
                                divisionCount++;
                                break;
                            }
                        }
                    }
                    Console.WriteLine(divisionCount == 0 ? "Prime" : "Not prime");
                }
            }
            var endTime = DateTime.Now;
            Console.WriteLine(endTime - startTime);
        }

        public static void TestSpeed(int[] hashSet)
        {
            var startTime = DateTime.Now;

            foreach (var item in hashSet)
            {
                if (item < 0 || item == 1)
                    Console.WriteLine("Not prime");
                else
                {
                    int divisionCount = 0;
                    for (int i = 1; i <= item - 1; i++)
                    {
                        if (item % i == 0 && i != 1)
                        {
                            divisionCount++;
                            break;
                        }
                    }
                    Console.WriteLine(divisionCount == 0 ? "Prime" : "Not prime");
                }
            }
            var endTime = DateTime.Now;
            Console.WriteLine(endTime - startTime);
        }

        public static void TestSpeedwithfor(int[] hashSet)
        {
            var startTime = DateTime.Now;

            for (int i = hashSet.Length - 1; i >= 0; i--)
            {
                if (hashSet[i] < 0 || hashSet[i] == 1)
                    Console.WriteLine("Not prime");
                else if (hashSet[i] <= 3)
                    Console.WriteLine("Prime");
                else
                {
                    int divisionCount = 0;
                    if (hashSet[i] % 2 == 0)
                        divisionCount++;
                    else
                    {
                        for (int j = 2; j <= hashSet[i] - 1; j++)
                        {
                            if (hashSet[i] % j == 0)
                            {
                                divisionCount++;
                                break;
                            }
                        }
                    }
                    Console.WriteLine(divisionCount == 0 ? "Prime" : "Not prime");
                }
            }
            var endTime = DateTime.Now;
            Console.WriteLine(endTime - startTime);
        }
    }
}
