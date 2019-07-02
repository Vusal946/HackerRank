using System;
using System.Collections.Generic;

namespace QueuesAndStacks
{
    class Program
    {
        private Stack<char> _wordStack;
        private Queue<char> _wordQueue;
        void PushCharacter(char value)
        {
            if (_wordStack == null)
                _wordStack = new Stack<char>();

            _wordStack.Push(value);
        }
        void EnqueueCharacter(char value)
        {
            if (_wordQueue==null)
            {
                _wordQueue=new Queue<char>();
            }
            _wordQueue.Enqueue(value);
        }
        char PopCharacter()
        {
            return _wordStack.Pop();
        }
        char DequeueCharacter()
        {
            return _wordQueue.Dequeue();
        }
        static void Main()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Program obj = new Program();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.PushCharacter(c);
                obj.EnqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.PopCharacter() != obj.DequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }

            Console.ReadLine();
        }
    }
}