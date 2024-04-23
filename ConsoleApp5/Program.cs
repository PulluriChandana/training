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
using System.Reflection;

class Program
{
    public static void Main()
    {
        ArrayList ar= new ArrayList();
        ar.Add(10);
        ar.Add(20);
        ar.Add(30);
        ar.Add(40);
        ar.Add("hi");
        ar.Add(45.6f);
        ar.RemoveAt(1);
        ar.Add(DateTime.Now);
        int find = 45;
        int list = ar.IndexOf(find);
        if(list != -1)
        {
            Console.WriteLine(String.Format("Element {0} is found at index {1}", find, list));
        }
        else
        {
            Console.WriteLine(String.Format("Element is not found at index"));
        }
        foreach (var item in ar)
        {
            Console.WriteLine(item);
        }

    }
}
/*class Program
{
    public static void Main()
    {
        Stack<double> st = new Stack<double>();
        st.Push(32.01);
        st.Push(76.45);
        st.Push(12.01);
        st.Push(74.45);
        st.Push(39.01);
        st.Push(66.45);
        double PopedItem = st.Pop();
        Console.WriteLine($"Poped Item is: {PopedItem}");
        double PeekedItem = st.Peek();
        Console.WriteLine($"Peeked Item is: {PeekedItem}");
        bool Contains = st.Contains(23.5);
        Console.WriteLine($"Contains: {Contains}");
        foreach (double item in st)
            Console.WriteLine(item);
    }
}/*
/*class Program
{
    public static void Main()
    {
        Queue<string> myQueue = new Queue<string>();
        myQueue.Enqueue("Training");
        myQueue.Enqueue("Bye");
        myQueue.Enqueue("hi");
        myQueue.Enqueue("Hello");
        myQueue.Enqueue(".net");
        myQueue.Peek();
        string peerlitem=myQueue.Peek();
        Console.WriteLine($"Peeked Item:{peerlitem}");
        string removedItem = myQueue.Dequeue();
        Console.WriteLine($"Removed item: {removedItem}");
        bool Contains=myQueue.Contains("hi");
        Console.WriteLine($"String is present or not : {Contains}");
        foreach (var ele in myQueue)
        {
            Console.WriteLine(ele);
        }
    }
}*/
/*class Program
{
    public static void Main()
    {
        List<int> li = new List<int>() { 10, 20, 30, 40, 50 };
        int value = 10;
        li.Add(60);
        li.Add(7);
        li.Remove(20);
        bool isFound=li.Contains(value);
        if (isFound)
        {
            Console.WriteLine($"The value {value} exists in the list");
        }
        else
        {
            Console.WriteLine("The value {value} does not exists in the list");
        }
        for(int i=0;i< li.Count; i++)
        {
            Console.WriteLine(li[i]);
        }
    }
}*/
//Hashtable
/*class Program
{
    public static void Main()
    {
        Hashtable h = new Hashtable();
        h.Add(1, "One");
        h.Add(2, "Two");
        h.Add(3, "Three");
        h.Add(4, "Four");
        h.Add(5.8F, 8.4F);
        h.Add("Val", "ue");
         string strinteger = (string)h[2];
         string str1integer= (string)h["Val"];
         float inte = (float)h[5.8F];
         Console.WriteLine(strinteger);
         Console.WriteLine(str1integer);
         Console.WriteLine(inte);
    }
}*/
//Stack
/*class Program
{
    public static void Main()
    {
        Stack s = new Stack();
        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Push("Hello");
        s.Push(5);
        foreach(var x in s)
        {
            Console.WriteLine(x);
        }
    }
}*/
//Queue
/*class Program
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
}*/

