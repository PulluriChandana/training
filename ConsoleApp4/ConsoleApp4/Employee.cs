using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee: IEmployee
    { 
        public void GetFirstName()
        {
            Console.WriteLine("Pulluri");
        }
        public void GetLastName()
        {
            Console.WriteLine("Chandana");
        }
    }
}
