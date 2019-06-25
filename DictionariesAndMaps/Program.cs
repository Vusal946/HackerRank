using System;
using System.Collections.Generic;
using System.Linq;
namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            var count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var words = Console.ReadLine().Split(' ');
                phoneBook.Add(words[0], Convert.ToInt32(words[1]));
            }

            List<string> searchParametrs = new List<string>();
            for (int i = 0; i < count; i++)
            {
                searchParametrs.Add(Console.ReadLine());
            }

            foreach (var searchParametr in searchParametrs)
            {
                if (!phoneBook.ContainsKey(searchParametr))
                    Console.WriteLine("Not found");
                else
                {
                    int number;
                    phoneBook.TryGetValue(searchParametr, out number);
                    Console.WriteLine(searchParametr + "=" + number);
                }                        
            }
            Console.ReadKey();
        }
    }
}
