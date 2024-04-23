using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
class GrandFather
{
    public void Land()
    {
        Console.Write("GrandFathers land");
    }
}
class Father:GrandFather
{
    public void Car()
    {
        Console.WriteLine("Father's Car");
    }
}
class Son : Father
{
    public void Mobile()
    {
        Console.WriteLine("Son's Mobile");
    }
}
class Program
{
    public static void Main()
    {
        Son s = new Son();
        s.Mobile();
        s.Car();
        s.Land();
    }
}
/*class Nature
{
    public void Smell()
    {
        Console.WriteLine("Raining Smell");
    }
}
class Tree : Nature
{
    public void Long()
    {
        Console.WriteLine("Long Trees");
    }
}
class Neem : Tree
{
    public void Ne()
    {
        Console.WriteLine("Neem Tree");
    }
}
class Program
{
    public static void Main()
    {
        Neem n = new Neem();
        n.Smell();
        n.Long();
        n.Ne();
    }
}*/
/*class Fruit
{
    public void Taste()
    {
        Console.WriteLine("Fruit");
    }
}
/*class Grapes : Fruit
{
    public void Ta()
    {
        Console.WriteLine("Grapes");
    }
}
class Program
{
    public static void Main()
    {
        Grapes gr=new Grapes();
        gr.Ta();
        gr.Taste();
    }
}*/

/*class Car
{
    public virtual void Brake()
    {
        Console.WriteLine("Generic break applied");
    }
}
class SportsCar:Car
{
    public override void Brake()
    {
        Console.WriteLine("High performance break applied");
    }
}
class Program
{
    public static void Main()
    {
        Car c= new SportsCar();
        c.Brake();
        
    }
}*/
/*class Rectangle
{
    public int CalculateArea(int l,int b)
    {
        int area = l * b;
        return area;
    }
    public double CalculateArea(double l, double b)
    {
       double area = l * b;
        return area;
    }
    public int CalculateArea(int l)
    {
        int area = l * l;
        return area;
    }
    public static void Main()
    {
        Rectangle rect = new Rectangle();
        int area=rect.CalculateArea(2, 3);
        Console.WriteLine("Calculating area of a rectangle with 2 parameters:"+area);
        double area1=rect.CalculateArea(5.5, 3.5);
        Console.WriteLine("Calculating area of a rectangle with 2 parameters in double format:" + area1);
        int area3=rect.CalculateArea(2);
        Console.WriteLine("Calculating area of a square with 1 parameters:" + area3);
    }
}*/
/*class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Generic sound");
    }
}
class Cat:Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
class Program
{
    public static void Main()
    {
        Animal ani= new Cat();
        Animal ani1=new Dog();
        ani.MakeSound();
        ani1.MakeSound();
    }
}*/
/*class StringFormatter
{
    public string Format(String str)
    {
        //return str.ToLower();
        return str.ToUpper();
    }
    public string Format(String str,int i)
    {
        string res = string.Empty;
        for(int j = 0; j < i; j++)
        {
            res += str;
        }
        return res;
    }
    public string Format(String str,String str1)
    {
        string str2=str+str1;
        return str2;
    }
    public static void Main()
    {
        StringFormatter stringFormatter = new StringFormatter();
        string str=stringFormatter.Format("hello");
        //string str1 = stringFormatter.Format("HELLO");
        Console.WriteLine(str);
        // Console.WriteLine(str1);
        String str1 = stringFormatter.Format("hello", 3);
        Console.WriteLine(str1);
        String str2 = stringFormatter.Format("hello", "world");
        Console.WriteLine(str2);
    }
}*/

/*namespace ConsoleApp3
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public double Add(double a, double b, double c)
        {
            double sum = a + b + c;
            return a + b + c;
        }
        public int Mul(int a, int b)
        {
            int mul = a * b;
            return mul;
        }
        public int Mul(int a,int b,int c)
        {
            int mul = a * b * c;
            return mul;
        }
        public double Mul(double a,double b,double c)
        {
            double mul = a * b + c;
            return mul;
        }
        public int Sub(int a, int b)
        {
            int sub = a - b;
            return sub;
        }
        public int Sub(int a,int b,int c)
        {
            int sub = a - b - c;
            return sub;
        }
        public double Sub(double a,double b,double c)
        {
            double sub= a - b - c;
            return sub;
        }
    }
    class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            //Method Overriding is run-time polymorphism
            //Method overloading is static time polymorphism or compile time polymorphism
            int sum1 = calculator.Add(1, 2);
            Console.WriteLine("Sum of two integer value is:" + sum1);
            int sum2 = calculator.Add(2, 3, 4);
            Console.WriteLine("Sum of three integer value is:" + sum2);
            double sum3 = calculator.Add(3.1, 4.2, 5.3);
            Console.WriteLine("Sum of three double value is:" + sum3);
            int mul1 = calculator.Mul(2, 3);
            Console.WriteLine("Multiplication of two integer values is:" + mul1);
            int mul2 = calculator.Mul(2, 3, 4);
            Console.WriteLine("Multiplication of three integer values is:" + mul2);
            double mul3 = calculator.Mul(2.2, 3.4, 5.2);
            Console.WriteLine("Multiplication of three double values is:" + mul3);
            int sub1=calculator.Sub(10,7);
            Console.WriteLine("Subtraction of two integer values is:" + sub1);
            int sub2 = calculator.Sub(10, 7, 5);
            Console.WriteLine("Subtraction of three integer values is:" + sub2);
            double sub3 = calculator.Sub(13.3, 7.5, 6.5);
            Console.WriteLine("Subtraction of two integer values is:" + sub3);
        }
    }
}*/
