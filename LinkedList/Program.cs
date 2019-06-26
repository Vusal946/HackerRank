using System;
using System.Collections.Generic;
using System.IO;

namespace LinkedList
{
    class Program
    {

        public static Node insert(Node head, int data)
        {
            if (head == null)
                head = new Node(data);
            else
            {
                Node end = head;
                Node temp = end;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new Node(data);
                head = end;
            }

            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}