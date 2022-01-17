using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMeth ex = new VoidMeth();
            ex.sum(20, 10);
            ex.sum(num1: 7, num2: 5);
            Console.ReadLine();
        }
    }
}
