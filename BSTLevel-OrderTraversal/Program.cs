using System;
using System.Collections;
using System.Collections.Generic;

namespace BSTLevel_OrderTraversal
{
    class Solution
    {
        static void A(Node root)
        {
            if (root != null)
            {
                var queue = new Queue();
                queue.Enqueue(root);
                Console.Write(root.data + " ");
                while (queue.Count!=0)
                {
                    var tree = (Node)queue.Dequeue();

                    if (tree.left != null)
                        Console.Write(tree.left.data + " ");

                    if (tree.right != null)
                        Console.Write(tree.right.data + " ");

                    if (tree.left != null)
                        queue.Enqueue(tree.left);

                    if (tree.right != null)
                        queue.Enqueue(tree.right);
                }

            }
        }

        static void LevelOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");

                int count = 1;
                Node current = root;
                Node next = root;
                Node previous = root;
                Node other = root;
                while (current != null)
                {
                    if (current.left != null)
                        Console.Write(current.left.data + " ");

                    if (current.right != null)
                        Console.Write(current.right.data + " ");

                    count++;

                    if (count % 2 == 0)
                    {
                        if (previous.left?.left != null)
                            previous = previous.left;
                        else if (previous.right != null)
                            previous = previous.right;

                        current = previous;
                    }
                    else
                    {
                        //if (count != 3 && (next.left?.left != null || next.left?.right != null))
                        //{
                        //    other = next.left;
                        //    current = other;
                        //}
                        //else if (next.right != null)
                        //{
                        //    next = next.right;
                        //    current = next;
                        //}

                        if (next.left?.left != null || next.left?.right != null)
                        {
                            other = next.left;
                            current = other;
                        }
                        else if (next.right != null)
                        {
                            next = next.right;
                            current = next;
                        }

                        current = next;
                    }
                }
            }
        }

        static void LevelOrderRecursiv(Node root)
        {
            if (root == null)
                return;

            Console.Write(root.data + " ");

            MethodName(root);
        }

        public static void MethodName(Node root)
        {
            if (root != null)
            {
                if (root.left != null)
                    Console.Write(root.left.data + " ");

                if (root.right != null)
                    Console.Write(root.right.data + " ");

                root = root.left;

                MethodName(root);
            }

        }
        static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                root = Insert(root, data);
            }

            Console.WriteLine();
            Console.WriteLine();
            A(root);
            Console.ReadLine();

        }
    }
}