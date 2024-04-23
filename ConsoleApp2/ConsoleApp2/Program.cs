// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
class Program
{
    class Loan
    {
        public virtual void CalculateIntrest()
        {
            Console.WriteLine("CalculateIntrest");
        }
    }
    class Personal : Loan
    {
        public  Personal()
        {
            Console.WriteLine("personal Constructor");
        }
        public override void CalculateIntrest()
        {
            Console.WriteLine("Calculate Intrest");
        }
    }
    class Education : Loan
    {
        public Education()
        {
            Console.WriteLine("Education Constructor");
        }
        public override void CalculateIntrest()
        {
            Console.WriteLine("Calculate Intrest");
        }
    }
    public static void Main()
    {
        Loan lo = new Personal();
        lo.CalculateIntrest();
        Loan lon = new Education();
        lon.CalculateIntrest();
    }
}
/*class Program
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal sings");
        }
    }
    class Dog : Animal
    {
        public Dog() {
            Console.WriteLine("Dog Constructor");
        }
        public void Talk()
        {
            Console.WriteLine("Dog talks");
        }
        public override void Sing()
        {
            Console.WriteLine("Dog sings");
        }
    }
    public static void Main()
    {
        Animal ani = new Dog();
        ani.Sing();
    }
}*/
/*class Program
{
    public static void Main()
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter the array");
        for(int i=0;i<arr.Length;i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Remove duplicates from the array ");
        int[] distinct = arr.Distinct().ToArray();

        Console.WriteLine(String.Join(",", distinct));
    }
}*/
/*class Program
{
    public static void Main()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter the array elements: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Reverse of an array is ");
        for(int i=0;i<arr.Length/2;i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}*/
/*class Program
{
    public static void Main()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter the array elements: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Square of array elements: ");
        for (int i=0;i<arr.Length; i++)
        {
            int res = arr[i] * arr[i];
            Console.WriteLine(res + " ");
        }
        
    }
}*/
/*namespace Inheritence
{
    class Department
    {
        public string name,location; 
        public void GetDeptName()
        {
            Console.WriteLine("Deaprtment name is " + name);
        }
        public void GetDeptLocation()
        {
            Console.WriteLine("Department location is " + location);
        }
    }
    class Employee : Department
    {
        string fname="Pulluri", lname="Chandana";
        public void getfname()
        {
            Console.WriteLine("First Name is: "+fname);
        }
        public void getlname()
        {
            Console.WriteLine("Last Name is: "+lname);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Employee emp = new Employee();
            emp.name = "Consulting";
            emp.location = "Hyderabad";
            emp.GetDeptName();
            emp.GetDeptLocation();
            emp.getfname();
            emp.getlname();

        }
    }
}*/
/*namespace Inheritence
{
    //base class
    class Animal
    {
        public string name;
        public void Display()
        {
            Console.WriteLine("My name is " + name);

        }

    }
    //derived class of Animal
    class Dog : Animal
    {
        public void getname()
        {
            Console.WriteLine("My name is " + name);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            //object class of derived class
            Dog laborder = new Dog();
            //access field and method of base class
            laborder.name = "Cutie";
            laborder.Display();
            //access method of own class
            laborder.getname();
            Console.ReadLine();
        }
    }
}*/

/*namespace Inheritence
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }
    }
    class Dog:Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }
        public void Talk()
        {
            Console.WriteLine("Dog says bow bow");
        }
    }
    class Program
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.Talk();
            dog.Greet();
        }
    }
}*/

/*class Program 
{
    public static void Main()
    {*/
/*Calculator cal = new Calculator();
Console.WriteLine("Please enter two numbers: ");
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
int y = 0;*/
/*int add = cal.Add(m, n);
int sub=cal.Sub(m, n);  
int mul=cal.Mul(m, n);
int div=cal.Div(m, n);*/
/*Console.WriteLine("Select Operation:");
Console.WriteLine("1.Addition");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Division");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        y = cal.Add(m, n);
        break;
    case 2:
        y= cal.Sub(m, n);
        break;
    case 3:
        y= cal.Mul(m, n);
        break;
    case 4:
        y= cal.Div(m, n);
        break;
    default:
        Console.WriteLine("Invalid Operation");
        break;

}
Console.WriteLine("Result: "+ y);*/
/*string s,revs = "";
Console.WriteLine("Enter string");
s= Console.ReadLine();
for(int i = s.Length-1; i >= 0; i--)
{
    revs += s[i].ToString();
}
if(revs == s)
{
    Console.WriteLine("Entered String is a palindrome "+ s);
}
else
{
    Console.WriteLine("Entered string is not a palindrome "+ s);
}*/

/*string s;
Console.WriteLine("enter a string");
s= Console.ReadLine();
string s1 = "";
for(int i = s.Length-1;i>=0;i--)
{
    s1 = s1 + s[i];
}
Console.WriteLine(s1);*/
/*string str = Console.ReadLine();
str = str + ' ';
string s = "";
string temp = "";
for (int i = 0; i < str.Length; i++)
{
    if (str[i] != ' ')
    {
        temp = temp + str[i];
    }
    else
    {
        s = temp + ' ' + s;
        temp = "";
    }
}
Console.WriteLine(s)*/
/*string str = Console.ReadLine();
string final = str.Substring(0, 2) + ' ' + str.Substring();
Console.WriteLine(final);*/
/*Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for(i=1;i<=10;i++)
    {
        Console.WriteLine(n+ " * "+ (i)+ " = " + (n * (i)));
    }
}*/
/*Passing By  value:When a variable is assigned to the another variable the value in the variable is 
 copied to the new variable
static void Increment(int i)
{
    i = i + 1;
}

    int x = 1;
    Increment(x);
    Console.WriteLine("The value of x is: "+ x);
    Console.Read();*/
/*static void Increment(ref int i)
{
    i = i + 1;
}

int x = 1;
Increment(ref x);
Console.WriteLine("The value of x is: " + x);
Console.Read(); */
/* Dog dog = new Dog();
 dog.Talk();
 dog.Greet();

}
}*/
