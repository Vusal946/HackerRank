using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptions
{
    class Calculator
    {
        public int power(int value, int power)
        {
            if (value < 0 || power < 0)
                throw new ArgumentOutOfRangeException("n and p should be non - negative", new Exception());

            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result = result * value;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {                  

                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}
