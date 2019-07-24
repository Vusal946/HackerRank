using System;
using System.Collections.Generic;
using System.IO;

namespace LinkedList
{
    class Program
    {

        public static Node insert(Node head, int data)
        {
            // First Algoritm
            //if (head == null)
            //    return new Node(data);
            //else if (head.next == null)           
            //    head.next = new Node(data);            
            //else            
            //    insert(head.next, data);

            //Second Algoritm

            if (head == null)
                return new Node(data);

            Node current = head;
            Node last = head;
            while (current != null)
            {
                if (current.next == null)
                    last = current;

                current = current.next;
            }

            last.next = new Node(data);

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