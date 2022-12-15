// C# program to illustrate how
// to create a LinkedList
using System;
using System.Collections.Generic;

public class UC3_CreateLinkedList
{
    static public void Main()
    {

        // Creating a linkedlist
      
        LinkedList<String> my_list = new LinkedList<String>();

        my_list.AddLast("56");
        my_list.AddLast("30");
        my_list.AddLast("70");
        

        Console.WriteLine("Linked List are:");

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }
    }
}

