using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface ICalculator
    {
        public void Add(int a, int b);
        public void Sub(int a, int b);
        public void Mul(int a, int b);
        public void Div(int a, int b);

    }
}
