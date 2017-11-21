using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 80; // counter upto number 80
            int counter = 10; // initialize counter - starts at 10
            do
            {
                Console.Write($"{counter}  ");
                counter++; // executes after the body, and if "false" it doesn't execute. it executes after the body and at least 1 time
            }
            while (counter <= n); // Executes loop continuation "BEFORE" the loop
            Console.Write("  ");
        }
    }
}
    

