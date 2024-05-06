// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}
class Order
{
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Amount { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerID = 1, Name = "John Doe", City = "New York" },
            new Customer { CustomerID = 2, Name = "Jane Smith", City = "Los Angeles" },
            new Customer { CustomerID = 3, Name = "Emily Johnson", City = "Chicago" }
        };
        List<Order> orders = new List<Order>
        {
            new Order { OrderID = 1, CustomerID = 1, OrderDate = new DateTime(2023, 1, 20), Amount = 250.00m },
            new Order { OrderID = 2, CustomerID = 1, OrderDate = new DateTime(2023, 1, 22), Amount = 75.00m },
            new Order { OrderID = 3, CustomerID = 2, OrderDate = new DateTime(2023, 1, 25), Amount = 125.00m },
            new Order { OrderID = 4, CustomerID = 3, OrderDate = new DateTime(2023, 2, 1), Amount = 200.00m }
        };
        var johnDoeOrders = from order in orders
                            join customer in customers on order.CustomerID equals customer.CustomerID
                            where customer.Name == "John Doe"
                            select order;
        Console.WriteLine("Orders placed by John Doe:");
        foreach (var order in johnDoeOrders)
        {
            Console.WriteLine($"OrderID: {order.OrderID}, CustomerID: {order.CustomerID}, OrderDate: {order.OrderDate.ToShortDateString()}, Amount: {order.Amount:C}");
        }
    }
}*/

/*class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int> { 1, 4, 5, 8, 9, 12, 3, 4, 5, 9, 7, 5 };
        var greater = list.Where(n => n > 5).Average();
        Console.WriteLine(greater);
        var distinct = list.Distinct();
        Console.WriteLine("Distinct elements in a array: ");
        foreach (var item in distinct)
            Console.WriteLine(item);
    }
}*/
/*class Program
{
    public static void Main(string[] args)
    {
        List<string> list= new List<string> { "joe", "raghav", "john","sam", "ravi","somesh", "jack" };
        Console.WriteLine("Original lsit: ");
        foreach(string s in list) 
            Console.WriteLine(s);
        var startswith = list.Where(l => l.StartsWith("j"));
        Console.WriteLine("Starts with j: ");
        foreach(string str in startswith)
        {
            Console.WriteLine(str);
        }
        var fliterlist=from str in
                               (from str in list
                                where str.StartsWith("r") 
                                select str)
        where str.Length != 3
        select str;
        Console.WriteLine("Fliterd list: ");
        foreach(string str in fliterlist)
        {
            Console.WriteLine(str);
        }

    }
}*/
/*class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = Enumerable.Range(1, 1000).Select(_ => random.Next(1, 1001)).ToArray();
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
        var avg= numbers.Average(n=>n);
        Console.WriteLine("Average of numbers: "+avg);
        var max= numbers.Max(n=>n);
        Console.WriteLine("Maximum of 1000 numbers: " + max);
        var min= numbers.Min(n=>n);
        Console.WriteLine("Minimum of 1000 numbers: " + min);
        var even =numbers.Where(n=>n%2==0);
        var count=even.Count();
        Console.WriteLine("Count of Even numbers: "+count);
        var odd=numbers.Where(n=>n%2!=0).Sum();
        Console.WriteLine("Sum of odd numbers: " + odd);
        var top=numbers.OrderByDescending(n=>n).Take(10);
        Console.WriteLine("Top 10 highest values: ");
        foreach (int number in top)
        {
            Console.WriteLine(number);
        }
        var unique = numbers.Distinct();
        var count1=unique.Count();
        Console.WriteLine("Count of unique numbers: " + count1);
        Console.WriteLine("Unique numbers: ");
        //foreach(int number in unique)
        //{
            //Console.WriteLine(number);
        //}
        var groupbyeven=numbers.GroupBy(n=>n%2==0 ? "even" : "odd");
        Console.WriteLine("Group by even or odd");
        foreach(var number in groupbyeven)
        {
            Console.WriteLine(number.Key+ "numbers: ");
            foreach(int num in  number)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }
        var sumgreat = numbers.Where(n => n > 500).Sum();
        Console.WriteLine("Sum of numbers greaterthan 500: " + sumgreat);
    }
}*/
/*class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}
class Order
{
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Amount { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerID = 1, Name = "John Doe", City = "New York" },
            new Customer { CustomerID = 2, Name = "Jane Smith", City = "Los Angeles" },
            new Customer { CustomerID = 3, Name = "Emily Johnson", City = "Chicago" }
        };
        List<Order> orders = new List<Order>
        {
            new Order { OrderID = 1, CustomerID = 1, OrderDate = new DateTime(2023, 1, 20), Amount = 250.00m },
            new Order { OrderID = 2, CustomerID = 1, OrderDate = new DateTime(2023, 1, 22), Amount = 75.00m },
            new Order { OrderID = 3, CustomerID = 2, OrderDate = new DateTime(2023, 1, 25), Amount = 125.00m },
            new Order { OrderID = 4, CustomerID = 3, OrderDate = new DateTime(2023, 2, 1), Amount = 200.00m }
        };
        var johnDoeOrders = from order in orders
                            join customer in customers on order.CustomerID equals customer.CustomerID
                            where customer.Name == "John Doe"
                            select order;
        Console.WriteLine("Orders placed by John Doe:");
        foreach (var order in johnDoeOrders)
        {
            Console.WriteLine($"OrderID: {order.OrderID}, CustomerID: {order.CustomerID}, OrderDate: {order.OrderDate.ToShortDateString()}, Amount: {order.Amount:C}");
        }
        var janesmithorders = from order in orders
                              join customer in customers on order.CustomerID equals customer.CustomerID
                              where customer.Name == "Jane Smith"
                              select order;
        Console.WriteLine("Orders placed by Jane Smith");
        foreach(var result in janesmithorders)
        {
            Console.WriteLine($"OrderID: {result.OrderID}, CustomerID: {result.CustomerID}, OrderDate: {result.OrderDate.ToShortDateString()}, Amount: {result.Amount:C}");
        }
        var emilyorders = from order in orders
                          join customer in customers on order.CustomerID equals customer.CustomerID
                          where customer.Name == "Emily Johnson"
                          select order;
        Console.WriteLine("Orders placed by Emily johnson");
        foreach(var result in emilyorders)
        {
            Console.WriteLine($"OrderID: {result.OrderID}, CustomerID: {result.CustomerID}, OrderDate: {result.OrderDate.ToShortDateString()}, Amount: {result.Amount:C}");
        }
        var totalsales = from order in orders
                         join customer in customers on order.OrderID equals customer.CustomerID
                         group order.Amount by customer.City into customerorder
                         select new
                         {
                             City = customerorder.Key,
                             TotalSales = customerorder.Sum()
                         };
        Console.WriteLine("Calculate Total Sales by City");
        foreach (var order in totalsales)
        {
            Console.WriteLine($"City: {order.City}, TotalSales: {order.TotalSales:C}");
        }
        var customersWithNoOrders = from customer in customers
                                    join order in orders on customer.CustomerID equals order.CustomerID into customerOrders
                                    where !customerOrders.Any()
                                    select customer;


        Console.WriteLine("Customers with no orders:");
        foreach (var customer in customersWithNoOrders)
        {
            Console.WriteLine($"CustomerID: {customer.CustomerID}, Name: {customer.Name}, City: {customer.City}");
        }
        var mostrecent = from order in orders
                         group order by order.CustomerID into customerOrders
                         select customerOrders.OrderByDescending(o => o.OrderDate).FirstOrDefault();
        Console.WriteLine("Most Recent Order for Each Customer");
        foreach (var order in orders)
        {
            Console.WriteLine($"CustomerID: {order.CustomerID}, OrderID: {order.OrderID}, OrderDate: {order.OrderDate.ToShortDateString()}, Amount: {order.Amount:C}");
        }
    }
}*/

/*public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}
public class Order
{
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Amount { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {

    }
}*/