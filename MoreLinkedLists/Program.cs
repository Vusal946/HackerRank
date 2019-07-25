using System;
using System.Collections.Generic;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}
class Solution
{
    public static Node removeDuplicates(Node head)
    {
        // if head is null or list only has 1 element
        if (head == null || head.next == null)
        {
            return head;
        }

        // if list is more than 2 elements
        Node current = head;
        while (current.next != null)
        {
            // If current is a duplicate of previous
            if (current.data == current.next.data)
            {
                // set previous' next pointer to skip over current node
                current.next = current.next.next;
            }
            else
            { // node is not duplicate of previous
                current = current.next;
            }
        }
        return head;
    }
    public static Node removeDuplicates8(Node head)
    {
        // if head is null or list only has 1 element
        if (head == null || head.next == null)
        {
            return head;
        }

        // if list is more than 2 elements
        Node current = head.next;
        Node previous = head;
        while (current != null)
        {
            // If current is a duplicate of previous
            if (previous.data == current.data)
            {
                // set previous' next pointer to skip over current node
                previous.next = current.next;
                // set current to next node in list, previous should not move
                current = current.next;
            }
            else
            { // node is not duplicate of previous
                previous = current;
                current = current.next;
            }
        }
        return head;
    }
    public static Node removeDuplicates2(Node head)
    {
        if (head?.next == null)
            return head;
        
        if (head.data == head.next.data)
        {
            head.next = head.next.next;
            removeDuplicates(head);
        }
        else
            removeDuplicates(head.next);

        return head;
    }
    public static Node removeDuplicates7(Node head)
    {
        // Empty list case:
        if (head == null)
        {
            return head;
        }

        Node current = head;
        while (current.next != null)
        {
            // If data is equal, reset the next pointer
            if (current.data == (current.next).data)
            {
                current.next = (current.next).next;
            }
            else
            {
                // If data is not equal, go
                // to the next element
                current = current.next;
            }
        }

        return head;
    }

    public static Node removeDuplicates3(Node head)
    {
        //Write your code here
        if (head == null)
            return null;
        HashSet<int> set = new HashSet<int>();
        Node prevNode = head;
        Node n = prevNode.next;
        if (n == null)
            return head;
        set.Add(prevNode.data);

        while (n != null)
        {
            if (set.Contains(n.data))
            {
                prevNode.next = n.next;
                n = n.next;
            }
            else
            {
                set.Add(n.data);
                prevNode = n;
                n = n.next;
            }
        }
        return head;
    }
    public static Node removeDuplicates5(Node head)
    {
        if (head == null)
            return null;
        Node s = head;
        while (s.next != null)
        {
            if (s.data == s.next.data)
                s.next = s.next.next;
            else
                s = s.next;
        }
        return head;
        //return head;
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
