using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string S = Console.ReadLine();
                Console.WriteLine(int.Parse(S));
            }
            catch (FormatException )
            {
                Console.WriteLine("Bad String");
            }
            catch (Exception)
            {
                Console.WriteLine(0);
            }

        }
    }
}
