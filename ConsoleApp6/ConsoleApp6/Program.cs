using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{

    static void Main(string[] args)
    {
        Employee[] EmployeeArray =
        {
            new Employee { Id = 1,Name="John",Age=12 },
            new Employee { Id = 2,Name="Rob",Age=13 },
            new Employee { Id = 3,Name="Dov",Age=14},
            new Employee { Id = 4,Name="Dev",Age=24},
            new Employee { Id = 5,Name="Iman",Age=45},
            new Employee { Id = 6,Name="Rah",Age=22},
            new Employee { Id = 7,Name="Ram",Age=24}
        };
        Employee[] employees = EmployeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
        var sortedByName=EmployeeArray.OrderBy(e=>e.Name);
        var namesstartingwithr = EmployeeArray.Where(e => e.Name.StartsWith("R"));
        var oldest = EmployeeArray.OrderByDescending(e => e.Age).FirstOrDefault();
        var avg=EmployeeArray.Average(e=>e.Age);
        foreach (var employee in sortedByName)
        {
            Console.WriteLine(employee.Name);
        }
        Console.WriteLine("Names starting with R: ");
        foreach (var employee in namesstartingwithr)
        {
            Console.WriteLine(employee.Name);
        }
        Console.WriteLine("Oldest Age "+oldest);
        Console.WriteLine("Average of ages is " + avg);

        //Console.ReadLine();
    }
}

/*public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{

    static void Main(string[] args)
    {
        Employee[] EmployeeArray =
        {
            new Employee { Id = 1,Name="John",Age=12 },
            new Employee { Id = 2,Name="Rob",Age=13 },
            new Employee { Id = 3,Name="Dov",Age=14},
            new Employee { Id = 4,Name="Dev",Age=24},
            new Employee { Id = 5,Name="Iman",Age=45},
            new Employee { Id = 6,Name="Rah",Age=22},
            new Employee { Id = 7,Name="Ram",Age=24}
        };
        Employee[] employees = EmployeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
        foreach(var employee in employees)
        {
            Console.WriteLine(employee.Name);
        }
        Console.ReadLine();
    }
}*/

/*public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{

    static void Main(string[] args)
    {
        Employee[] EmployeeArray =
        {
            new Employee { Id = 1,Name="John",Age=12 },
            new Employee { Id = 2,Name="Rob",Age=13 },
            new Employee { Id = 3,Name="Dov",Age=14},
            new Employee { Id = 4,Name="Dev",Age=24},
            new Employee { Id = 5,Name="Iman",Age=45},
            new Employee { Id = 6,Name="Rah",Age=22},
            new Employee { Id = 7,Name="Ram",Age=24}
        };
        Employee[] employees = new Employee[10];
        int i = 0;
    foreach (Employee employee in EmployeeArray)
    {
        if (employee.Age >= 12 && employee.Age < 20)
        {
            employees[i] = employee;
            Console.WriteLine(employee.Name);
            i++;
        }
    //Console.ReadLine();
    }
    }
}*/
/*class Program
{
static void Main(string[] args)
{
    LinqReadXml();
}
private static void LinqReadXml()
{
    string myXml = @"<Department>
                    <Department>Sales</Department>
                    <Department>Account</Department>
                     <Department>pre-Sales</Department>
                    <Department>Marketing</Department>
                    </Department>";
    XDocument xdoc = new XDocument();
    xdoc = XDocument.Parse(myXml);
    var result = xdoc.Element("Department").Descendants();
    xdoc.Element("Department").Add(new XElement("Department", "Finance"));//adding a element
    xdoc.Element("Department").AddFirst(new XElement("Department", "Support"));//adding an element to the first
    xdoc.Descendants().Where(s => s.Value == "Sales").Remove();//removing an element
    foreach ( XElement item in result )
    {
        Console.WriteLine("Department Name: "+item.Value);
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadLine();


}
}*/
/*class Program
{
static void Main(string[] args)
{
    int[] numbers = { 2, 8, 5, 6, 1, 4, 7, 3, 9, 10 };
    UsingLinqEven(numbers);
    UsingLinqGreat(numbers);
    UsingSum(numbers);
}
private static void UsingSum(int[] numbers)
{
    int sum = numbers.Sum();
    Console.WriteLine("The sum of all numbers in the array " + sum);
}
private static void UsingLinqEven(int[] numbers)
{
    IEnumerable<int> query = numbers.Where(n=>n % 2 == 0);
    Console.WriteLine("Even Number");
    foreach (int n in query)
    {
        Console.WriteLine(n);

    }
}
private static void UsingLinqGreat(int[] numbers)
{
    IEnumerable<int> query = numbers.Where(n => n > 5 && n % 2 != 0);
    Console.WriteLine("Greatest Number");
    foreach (int n in query)
    {
        Console.WriteLine($"{n}");
    }
}
}*/
/*class Program
{
static void Main(string[] args)
{
    int[] numbers = { 2, 8, 5, 6, 1, 4, 7, 3, 9, 10 };
    UsingLinqEven(numbers);
    UsingLinqGreatest(numbers);
    UsingLinqSmall(numbers);
    UsingLinqSum(numbers);
    UsingLinqMaxMin(numbers);
    UsingLinqAvg(numbers);
    UsingLinqSquare(numbers);
    UsingLinqFliter(numbers);
}
private static void UsingLinqEven(int[] numbers)
{
    var even = numbers.Where(n => n % 2 == 0);
    Console.WriteLine("Even Numbers");

    foreach (int n in even)
    {
        Console.WriteLine(n);
    }
    
}
private static void UsingLinqGreatest(int[] numbers)
{
    var great = numbers.Where(n => n % 2 != 0 && n > 5);
    
    Console.WriteLine("Greaterthan 5");
    foreach (int n in great)
    {
        Console.WriteLine(n);
    }
    
}
private static void UsingLinqSmall(int[] numbers)
{
    var small = numbers.OrderBy(n => n).Skip(2).First();
    Console.WriteLine("Third smallest integer is " + small);
}
private static void UsingLinqSum(int[] numbers)
{
    var sum = numbers.Sum(n => n);
    Console.WriteLine("The sum of all numbers in the array " + sum);
}
private static void UsingLinqMaxMin(int[] numbers)
{
    var max = numbers.Max(n => n);
    Console.WriteLine("Maximum number is " + max);
    var min = numbers.Min(n => n);
    Console.WriteLine("Minimum number is " + min);
}
private static void UsingLinqAvg(int[] numbers)
{
    var avg= numbers.Average(n => n);
    Console.WriteLine("Average of numbers: " + avg);
}
private static void UsingLinqSquare(int[] numbers)
{
    var square= numbers.Select(n=> new {number=n,square=n*n});
    //Console.WriteLine("square of a number: "+square);
    Console.WriteLine("Number\tSquare");
    foreach (var item in square)
    {
        Console.WriteLine($"{item.number}\t{item.square}");
    }
}
private static void UsingLinqFliter(int[] numbers)
{
    var fliter=numbers.Where(n => n % 2 == 0 || n%2!=0)
                       .OrderByDescending(n => n);
    Console.WriteLine("Flitered and descending order: ");
    foreach(var item in fliter)
    {
        Console.WriteLine(item);
    }
}
}*/
/*namespace ConsoleApp6
{
class Program
{
     static void Main(string[] args)
    {
        string[] names = { "suman", "Anil", "Shyam", "Shreya", "sreya", "Suraj","Imran" };
        //UsingLinq(names);
        //UsingLinqExtensions(names);
        //UsingLinqFunctions(names);
        //UsingLinqAnonymousMethods(names);
    }
    /*private static void UsingLinq(string[] names)
    {
        IEnumerable<string> query=from s in names //for loop
                                  where s.Length==5
                                  orderby s
                                  select s.ToUpper();
        foreach(string s in query)
        {
            Console.WriteLine(s);
            
        }
    Console.ReadLine();
    }*/
/*private static void UsingLinqExtensions(string[] names)
{
    IEnumerable<string> query = names
                               .Where(s=>s.Length == 5)
                                .OrderBy(s=>s)
                                .Select (s=>s.ToUpper());
    foreach (string s in query)
    {
        Console.WriteLine(s);

    }
    Console.ReadLine();
}*/
/*private static void UsingLinqFunctions(string[] names)
{
    Func<string,bool> fliter= s => s.Length == 5;
    Func<string, string> extract = s => s;
    Func<string, string> project = s => s.ToUpper();
    IEnumerable<string> query = names
                               .Where(fliter)
                                .OrderBy(extract)
                                .Select(project);
    foreach (string s in query)
    {
        Console.WriteLine(s);

    }
    Console.ReadLine();
}
*/
//write more lines of code
/*private static void UsingLinqAnonymousMethods(string[] names)
{

    Func<string, bool> fliter = delegate (string s)
    {
        return s.Length == 5;
    };
    Func<string, string> extract = delegate (string s)
    {
        return s;
    };
    Func<string, string> project = delegate(string s)
    {
        return s.ToUpper();
    };
    IEnumerable<string> query = names
                               .Where(fliter)
                                .OrderBy(extract)
                                .Select(project);
    foreach (string s in query)
    {
        Console.WriteLine(s);

    }
    Console.ReadLine();
}*/

//}
//}