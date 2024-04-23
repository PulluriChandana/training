//using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Collections.Immutable;
class Program
{
    public static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);
        Console.WriteLine("The number of elements present in queue: {0}", queue.Count);
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        Console.WriteLine("The number of elements present in queue: {0}", queue.Count);
    }
}

