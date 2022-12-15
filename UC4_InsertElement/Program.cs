
using System;
using System.Collections.Generic;

public class UC4_InsertElement
{
    static public void Main()
    {

        LinkedList<String> my_list = new LinkedList<String>();

        my_list.AddLast("56");
        my_list.AddLast("30");
        my_list.AddLast("70");
        
        Console.WriteLine("Sequence are: ");

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }
    }
}
