using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_LinkedList
{
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.Write(" Linked list is empty ");
                return;
            }
            while(temp != null)
            {
                Console.Write( temp.data + " " );
                temp = temp.next;
            }
        }
    }
}
