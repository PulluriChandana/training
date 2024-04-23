using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Shape : IShape
    {
        public void CalculateArea(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Area of Rectangle:" + c);
        }
        public void CalculatePerimeter(int a, int b)
        {
            int c = 2 * (a + b);
            Console.WriteLine("Perimeter of a rectangle:" + c);
        }
        public void CalculateArea(int a)
        {
            int c = a * a;
            Console.WriteLine("Area of Rectangle:" + c);
        }
        public void CalculatePerimeter(int a)
        {
            int c = 4 * a;
            Console.WriteLine("Perimeter of a rectangle:" + c);
        }
    }
}
