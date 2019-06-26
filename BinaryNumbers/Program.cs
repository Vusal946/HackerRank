using System;
using System.Collections.Generic;
namespace BinaryNumbers
{
    class Program
    {
        static void Main()
        {
            try
            {
                var decimalNumber = Convert.ToInt32(Console.ReadLine());

                if (decimalNumber < 1 || decimalNumber > 1000000)
                    throw new ArgumentOutOfRangeException();

                int s = 0, max = 0;
                while (decimalNumber > 0)
                {
                    var remainder = decimalNumber % 2;
                    decimalNumber = decimalNumber / 2;
                    if (remainder == 1)
                    {
                        s++;
                        if (s >= max)
                            max = s;
                    }
                    else
                        s = 0;
                }

                Console.WriteLine(max);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
