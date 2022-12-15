
using System;
using System.Collections.Generic;

public class UC5_FirstDelete
{
    static public void Main()
    {
     
        LinkedList<String> my_list = new LinkedList<String>();
       
        my_list.AddLast("56");
        my_list.AddLast("30");
        my_list.AddLast("70");
        
        // Initial number of elements
        Console.WriteLine("Linked List:");

        
        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Final sequence are:");
        my_list.Remove(my_list.First);

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }                
                    
    }
}

