﻿using System;
using System.Collections;

namespace MoreLinkedLists
{
    class Program
    {

        public static Node removeDuplicates(Node head)
        {
            if (head == null)
                return null;

            Node current = head;
            Node real = head;
            bool isFirst = true;

            while (current != null)
            {
                if (!isFirst && real.data == current.data)                                  
                    real = current;
               
                isFirst = false;

                current = current.next;
            }

            real.next = new Node(5);

            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);

            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

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
            head = removeDuplicates(head);
            display(head);
            Console.ReadLine();
        }
    }
}
