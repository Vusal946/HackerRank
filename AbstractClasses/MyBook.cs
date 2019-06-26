using System;

namespace AbstractClasses
{
    class MyBook:Book
    {
        public int price;
        public MyBook(string t, string a, int b) : base(t, a)
        {
            price = b;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
}