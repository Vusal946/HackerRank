using System;
using System.Collections.Generic;
using System.IO;

namespace LinkedList
{
    class Program
    {

        public static Node insert(Node head, int data)
        {
            //First Algoritm
            //var newNode = new Node(data);           

            //if (head == null)
            //    head = newNode;
            //else
            //{
            //    var count = 0;
            //    Node end = head;
            //    while (end != null)
            //    {
            //        end = end.next;
            //        count += 1;
            //    }

            //    if (count == 1)
            //        head.next = newNode;
            //    else if (count == 2)
            //        head.next.next = newNode;
            //    else if (count == 3)
            //        head.next.next.next = newNode;
            //    else if (count == 4)
            //        head.next.next.next.next = newNode;
            //    else if (count == 5)
            //        head.next.next.next.next.next = newNode;
            //}
            //return head;

            // Second Algoritm
            //if (head == null)
            //    return new Node(data);
            //else if (head.next == null)           
            //    head.next = new Node(data);            
            //else            
            //    insert(head.next, data);

            ///Third Algoritm
           
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