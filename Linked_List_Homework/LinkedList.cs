using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            Node newNode = new Node(val);
            if (First == null)
            {
                First = newNode;
            }
            else
            {
                Node last = First;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newNode;
            }
        }
        public void RemoveKey(int key)
        {
            if (First == null)
            {
                Console.WriteLine("List is empty. Cannot remove key.");
                return;
            }

            if (First.Data == key)
            {
                First = First.Next;
                return;
            }

            Node current = First;
            Node previous = null;

            while (current != null && current.Data != key)
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine($"Key {key} not found in the list.");
                return;
            }

            previous.Next = current.Next;
        }
        public void Merge(LinkedList other_list)
        {
            if (other_list == null || other_list.First == null)
            {
                Console.WriteLine("Cannot merge with an empty list.");
                return;
            }

            Node last = First;
            while (last.Next != null)
            {
                last = last.Next;
            }

            last.Next = other_list.First;
        }
        public void Reverse()
        {
           Node prev = null;
    Node current = First;
    Node next = null;

    while (current != null)
    {
        next = current.Next;
        current.Next = prev;
        prev = current;
        current = next;
    }

    First = prev;
        }
    }
}
