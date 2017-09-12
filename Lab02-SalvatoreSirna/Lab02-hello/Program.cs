using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_hello
{
    class Hello1
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.WriteLine("  World!");

            Console.Write("Hello");
            Console.WriteLine("\n World");

            Console.WriteLine("\" Hello World! \"");

            Console.WriteLine(" Hello\\ World! ");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
   
    }
}