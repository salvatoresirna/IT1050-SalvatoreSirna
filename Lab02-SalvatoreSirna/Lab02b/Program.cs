using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02b
{
    class Equation
    {
        static void Main()
        {
            int numberx; // declare integer numberx
            int numbery; // declare integer numbery 
            int numberz; // declare integer numberz
            int equals; // declare equals formula

            Console.Write("Enter first integer: ");  // prompt user
            // read the numberx from user
            numberx = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");  // prompt user
            // read the numbery from user
            numbery = int.Parse(Console.ReadLine());

            Console.Write("Enter third integer: ");  // prompt user
            // read the numberz from user
            numberz = int.Parse(Console.ReadLine());

            equals = (numberx + numbery) * (numberz + 10); // add numbers

            Console.WriteLine($"Equals is {equals}");   // display equals
            equals = int.Parse(Console.ReadLine());  // display equals

            Console.WriteLine("Press any key to exit"); // exit program
            Console.ReadKey();

        }  // end Main(1)

    } // end class Equation
}
