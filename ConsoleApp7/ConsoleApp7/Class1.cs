using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
class Action
{
    public static void Main(string[] args)
    {
        Action<int> printActionDel = ConsolePrint;
        printActionDel(10);
    }
    public static void ConsolePrint(int i)
    {
        Console.WriteLine(i);   
    }
}
/*class Program
{
    static int Sum(int x,int y)
    {
        return x + y;
    }
    static void Main(string[] args)
    {
        Func<int, int, int> add = Sum;
        int result = add(10, 10);
        Console.WriteLine(result);
        Console.ReadLine();
    }

}*/
/*public class Product
{
    public int ProductID { get; set;}
    public string Name { get; set;}
    public string Category { get; set;}
    public decimal Price { get; set;}
}
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>() 
        {
            new Product() { ProductID = 1, Name = "Apple", Category = "Fruits", Price = 1.00m },
            new Product() { ProductID = 2, Name = "Milk", Category = "Dairy", Price = 0.99m },
            new Product() { ProductID = 3, Name = "Cheese", Category = "Dairy", Price = 2.50m },
            new Product() { ProductID = 4, Name = "Banana", Category = "Fruits", Price = 0.50m },
            new Product() { ProductID = 5, Name = "Yogurt", Category = "Dairy", Price = 1.50m }
        };
        //Employee[] employees = EmployeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
        //Product[] products1 = products.Where(c=>c.Equals="Dairy").ToArray();
        //Console.WriteLine(products1);
        var diaryproducts = products.Where(p => p.Category == "Dairy");
        Console.WriteLine("Dairy Products");
        foreach(var product in diaryproducts)
        {
            Console.WriteLine(product.Name);
        }
        var sorted = products.OrderBy(p => p.Price);
        Console.WriteLine("Sorted by Price");
        foreach (var product in sorted)
        {
            Console.WriteLine(product.Price);
        }
        var expensive=products.Max(p => p.Price);
        var mostExpensiveProduct = products.First(p => p.Price == expensive);
        Console.WriteLine("Most expensive product:");
        Console.WriteLine($"Name:{mostExpensiveProduct.Name}");
        var calculate = products.Where(p => p.Category == "Fruits")
            .Sum(p=>p.Price);
        Console.WriteLine($"Total price of fruits:{calculate}");
        Console.WriteLine("Products with prices formatted as currency:");
        foreach (var product in products)
        {
            Console.WriteLine($"ProductID: {product.ProductID}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price:C}");
        }
        var grouped = products.GroupBy(p => p.Category);
        Console.WriteLine("Products grouped by category:");
        foreach (var group in grouped)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach (var product in group)
            {
                Console.WriteLine($"Name: {product.Name}");
            }
        }
        var cheap = products.Where(p => p.Price < 1.00m);
        Console.WriteLine("Product names lessthan 1.00");
        foreach(var product in cheap)
        {
            Console.WriteLine(product.Name);
        }

    }
}*/

/*delegate void StatusUpdateHandler(string statusMessage);
class Abc
{
    public static void LoggingService(string statusMessage)
    {
        Console.WriteLine(statusMessage);
    }
    public static void NotificationService(string statusMessage) 
    {
        Console.WriteLine(statusMessage);
    }
    public static void AduitService(string statusMessage)
    {
        Console.WriteLine(statusMessage);
    }
    public static void Main(string statusMessage)
    {
        Console.WriteLine(statusMessage);
    }
    public static void Main()
    {

        StatusUpdateHandler aduitService = AduitService,log=LoggingService,Not=NotificationService;
        Console.WriteLine("Invoking delegate LoggingService:");
        AduitService("Logged in");
        Console.WriteLine("Invoking delegate NotificationService:");
        AduitService("Notified");
        Console.WriteLine("Invoking delegate AduitService:");
        AduitService("Aduit");

    }
}*/
/*delegate void MathOperation(int number);
class MathOperations
{
    public static void AddTen(int number)
    {
        Console.WriteLine($"{number}+10={number+10}");
    }
    public static void MultiplyTwo(int number)
    {
        Console.WriteLine($"{number}*2={number*2}");
    }
    public static void SubtractFive(int number)
    {
        Console.WriteLine($"{number}-5={number-5}");
    }
    static void Main()
    {
        MathOperation mo = new MathOperation(MathOperations.AddTen);
        mo += MathOperations.MultiplyTwo;
        mo += MathOperations.SubtractFive;
        Console.WriteLine("Invoking delegate with the number 5:");
        mo(5);
        Console.ReadLine();
    }
}*/

/*namespace ConsoleApp7
{
    //define a custom delegate that has a string parameter and returns void.
    delegate void CustomDel(string s);
    class TestClass
    {
        //define two methods that have the same signature as customdel
        static void Hello(string s)
        {
            Console.WriteLine($" Hello,{s}:");
        }
        static void GoodBye(string s)
        {
            Console.WriteLine($" GoodBye,{s}:");
        }
        static void Main()
        {
            //declare instances of the custom delegate
            CustomDel hiDel,ByeDel,Multidel,multiminusdel;
            hiDel = Hello;
            //Console.WriteLine("Invoking delegate hiDel:");
            //hiDel("Chandana");
            ByeDel = GoodBye;
            //Console.WriteLine("Invoking delegate byedel:");
            //ByeDel("Pulluri");
            Multidel = hiDel + ByeDel;
            multiminusdel = Multidel - hiDel;
            Console.WriteLine("Invoking delegate multidel:");
            Multidel("c");
            Console.WriteLine("Invoking delegate multiminusdel:");
            Multidel("D");
            Console.Read();
        }
    }
}*/
