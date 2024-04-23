using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calculator
    {
        public int Add(int a,int b)
        {
            //Console.WriteLine("Addition of 2 numbers " + Add(4,5));
            return a + b;
        }
        public int Sub(int a, int b)
        {
            //Console.WriteLine("Addition of 2 numbers " + Add(4, 5));
            return a - b;
        }
        public int Mul(int a, int b)
        {
            //Console.WriteLine("Addition of 2 numbers " + Add(4, 5));
            return a * b;
        }
        public int Div(int a, int b)
        {
            //Console.WriteLine("Addition of 2 numbers " + Add(4, 5));
            return a / b;
        }
    }
}
