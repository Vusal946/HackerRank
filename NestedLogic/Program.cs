using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NestedLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            var fwords = first.Split(' ');
            var swords = second.Split(' ');
            
            var endDate = new DateTime(int.Parse(fwords[2]), int.Parse(fwords[1]), int.Parse(fwords[0]));
            var begDate = new DateTime(int.Parse(swords[2]), int.Parse(swords[1]), int.Parse(swords[0]));

            var days = (endDate - begDate).Days;
            var months = days / 31;
            int fine=0;
            if (days > 0)
            {
                if (endDate.Year-begDate.Year>=1)
                    fine = 10000;
                else if(days < 31)
                    fine = days * 15;
                else if (days < 365)
                    fine = months * 500;
            }
            Console.WriteLine(fine);

        }
    }
}
