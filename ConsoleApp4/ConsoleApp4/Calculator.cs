using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Calculator: ICalculator
    {
        public void Add(int a, int b)
        {
            int x = a + b;
            Console.WriteLine("Add:" + x);
        }
        public void Sub(int x, int y)
        {
            int r=x - y;
            Console.WriteLine("Sub:" + r);
        }
        public void Mul(int x, int y)
        {
            int p= x * y;
            Console.WriteLine("Mul:" + p);
        }
        public void Div(int x, int y)
        {
            int d= x / y;
            Console.WriteLine("Div:" + d);
        }
    }
}
