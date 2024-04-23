using ConsoleApp4;
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
//frequency of elements
/*class Program
{
    public static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6,1,2,3,4,5,6,1,2,3,4,5,6,1,2,3,4 };
        var g=list.GroupBy(x => x);
        foreach ( var grp in g)
        {
            Console.WriteLine("{0} {1}",grp.Key,grp.Count());
        }
    }
}*/
//Implement a stack using list
/*class Program
{
    public static void Main ()
    {
        Stack st = new Stack();
        st.Push(1);
        st.Push(2);
        st.Push(3);
        st.Push(4);
        st.Push(5);
        st.Push(6);
        st.Pop();
        foreach(var item in st)
        {
            Console.WriteLine(item);
        }
        if(st.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Stack is not empty");
        }
    }
}*/
//merge two lists
class Program
{
    public static void Main()
    {
        List<int> li=new List<int>() { 10, 20, 30, 40, 50 };
        List<int> li2 = new List<int>() { 10, 20, 40, 70, 80, 90 };
        
        var result=li.Union(li2).ToList();
        List<int> uniqueList = result.Distinct().ToList();
        result.Sort();
        Console.WriteLine(result);
    }
}
//Reversing a list
/*class Program
{
    public static void Main()
    {
        List<int> li = new List<int> { 10,20,30,40,50,60};

        for (int i = 0, j = li.Count - 1; i < j; i++)
        {
            int temp = li[j];
            li.RemoveAt(j);
            li.Insert(i, temp);
        }

        Console.WriteLine(String.Join(',', li));
    }

}*/
//finding min and max in a list
/*public static class A
{
    public static int FindMin(this IList<int> items)
    {
        int minval = int.MaxValue;
        foreach (int i in items)
        {
            if (i < minval)
            {
                minval = i;
            }
        }
        return minval;

    }
    
public static int FindMax(this IList<int> items)
    {
        int maxval = int.MinValue;
        foreach (int i in items)
        {
            if (i > maxval)
            {
                maxval = i;
            }
        }
        return maxval;
    }
}
class Program
{   public static void Main()
    {
        List<int> li = new List<int>() { 1, 2, 3, 4, 4, 5 };
        //Console.WriteLine(li.Max());
        //Console.WriteLine(li.Min());
        Console.WriteLine("Maximum element " + li.FindMax());
        Console.WriteLine("Minimum element " + li.FindMin());
    }
}*/
//set of operations to be done like adding removing 
/*class Program
{
    public static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, };
        list.Add(9);
        list.Remove(1);
        list.RemoveAt(3);
        for(int i=0;i<list.Count;i++)
        {
            Console.WriteLine(list[i]);
        }
        Console.WriteLine(list.Contains(9));
    }
}*/
/*class Program
{
    public static void Main()
    {
        SortedList list= new SortedList();
        list.Add(3, "Three");
        list.Add(5, "Five");
        list.Add(2, "Two");
        list.Add(4, "Four");
        list.Add(1, "One");
        foreach (DictionaryEntry pair in list)
        {
            Console.WriteLine("{0} {1}",
                      pair.Key, pair.Value);
        }
    }
}*/
/*class Program
{
    public static void Main()
    {
        ArrayList arr = new ArrayList();
        arr.Add(1);
        arr.Add("Chandana");
        arr.Add(2);
        arr.Add(3.4f);
        int firstelement=(int)arr[0];
        Console.WriteLine(firstelement);
        string secondelement = (string)arr[1];
        Console.WriteLine(secondelement);
        int thirdelement= (int)arr[2];
        Console.WriteLine(thirdelement);
        float fourthelement= (float)arr[3];
        Console.WriteLine(fourthelement);
    }
}*/
/*class Program
{
    public static void Main()
    {
        List<string> list = new List<string>();
        list.Add("One");
        list.Add("Two");
        list.Add("Three");
        list.Add("Four");
        list.Add("Five");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        foreach(var el in list) 
        { 
        Console.WriteLine(el);
        }
    }
}*/
/*class Program
{
    public static void Main()
    {
        List<int> intList = new List<int>() { 10, 20, 30, 40 };
        //intList.Add(10);
        //intList.Add(20);
        //intList.Add(30);
        //intList.Add(40);
        intList.Remove(20);//removes the element from the array
        intList.RemoveAt(1);//removes the index element from the array index starts from 0
        
        foreach (var el in intList)
        {
            Console.WriteLine(el);
        }
        
    }
}*/

//collections
/*class Program
{
    public static void Main()
    {
        List<int> intList= new List<int>() { 10, 20, 30, 40 };
        //intList.Add(10);
        //intList.Add(20);
        //intList.Add(30);
        //intList.Add(40);
        //for(int i=intList.Count-1;i<intList.Count;i++)
        for(int i=0; i<intList.Count; i++)
        {
            Console.WriteLine(intList[i]);
        }
        foreach(var el in intList)
        {
            Console.WriteLine(el);
        }
        intList.ForEach(el => Console.WriteLine(el)) ;
    }
}*/

/*abstract class ArtPiece
{
    public abstract void Describe(string title,string artist,int year);
}
class Painting: ArtPiece
{
    public int CanvaSize(int size)
    {
        return size * size;
    }
    public override void Describe(string title, string artist, int year)
    {
        Console.WriteLine("Title:" + title);
        Console.WriteLine("Artist:" + artist);
        Console.WriteLine("Year:" + year);
    }
}
class Sculpture:ArtPiece
{
    public void Material(String name)
    {
        Console.WriteLine("Material Name:" + name);
    }
    public override void Describe(string title, string artist, int year)
    {
        Console.WriteLine("Title:" + title);
        Console.WriteLine("Artist:" + artist);
        Console.WriteLine("Year:" + year);
    }
}
class Program
{
    public static void Main()
    {
        Painting painting = new Painting();
        Sculpture sc = new Sculpture();
        int a=painting.CanvaSize(8);
        Console.WriteLine("Canva size is:" + a);
        painting.Describe("ArtPiece is good", "Chandana", 2024);
        sc.Material("Gold");
        sc.Describe("Rings", "Pulluri", 2024);
    }
}*/
//creating abstract class
/*abstract class Abclass
{
    //Non-abstract method
    public int AddTwoNumbers(int num1,int num2)
    {
        return num1+num2;
    }
//abstract method to be overridden in derived class
    public abstract int MulTwoNumbers(int num1, int num2);
}
class AbDerived : Abclass
{
    public override int MulTwoNumbers(int num1, int num2)
    {
        return num1 * num2;
    }
}
class Program
{
    public static void Main()
    {
        AbDerived ab=new AbDerived();
        int added=ab.AddTwoNumbers(1,2);
        int multiplied = ab.MulTwoNumbers(3, 4);
        Console.WriteLine("Added:{0},Multiplied:{1}",added,multiplied);
    }
}*/
/*class Program
{
    public static void Main()
    {
        Shape s=new Shape();
        s.CalculateArea(3, 4);
        s.CalculatePerimeter(5, 3);
        s.CalculateArea(3);
        s.CalculatePerimeter(5);
    }
}*/

/*class Program
{
    public static void Main(string[] args)
    {
       Calculator calculator = new Calculator();
        calculator.Add(3, 4);
        calculator.Sub(8, 3);
        calculator.Mul(3, 4);
        calculator.Div(12, 2);
    }
}*/
/*class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.GetFirstName();
        emp.GetLastName();
    }
}*/