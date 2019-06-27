using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks
{
    class Program
    {
        private List<char> Word;
        void pushCharacter(char value)
        {
            if (Word == null)
                Word = new List<char>();

            Word.Add(value);
        }
        void enqueueCharacter(char value)
        {
            var temp = new List<char>();
            for (int i = Word.Count; i > 0; i--)
            {
                temp.Add(Word[i]);
            }
            Word = temp;
        }
        List<char> popCharacter()
        {
            Word.RemoveAt(Word.Count - 1);
            return Word;
        }
        List<char> dequeueCharacter()
        {
            var temp = new List<char>();
            for (int i = 0; i < Word.Count; i++)
            {
                temp.Add(Word[i]);
            }
            Word = temp;

            return Word;
        }
        static void Main(string[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Program obj = new Program();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
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
        }
    }
}