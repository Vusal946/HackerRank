using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = GetFactorial(number);
            Console.WriteLine(factorial);
        }

       static int GetFactorial(int number)
        {
            int factorial=1;
            if (number != 1)
            {             
                factorial = number * GetFactorial(number-1);
                number += -1;
            }            
            return factorial;
        }
    }
}
