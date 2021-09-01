using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 15;
            int result;

            Console.WriteLine("x is " + x);
            result = x++;
            Console.WriteLine("Post increment of x is " + x);

            Console.WriteLine("x is " + x);
            result = x--;
            Console.WriteLine("Post decrement of x is " + x);

            Console.WriteLine("x is " + x);
            result = ++x;
            Console.WriteLine("Pre increment of x is " + x);

            Console.WriteLine("x is " + x);
            result = --x;
            Console.WriteLine("Pre decrement of x is " + x);
            Console.ReadLine();
        }
    }
}
