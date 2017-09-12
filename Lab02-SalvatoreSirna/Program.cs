using System;

namespace Lab02_SalvatoreSirna
{
    class Addition
    {
        static void Main()
        {
            int number1; // declare first number to add
            int number2; // declare second number to add
            int sum; // declare sum of number1 and number2

            Console.Write("Enter first integer: ");  // prompt user
            // read the first number from user
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");  // prompt user
            // read the second number from user
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2; // add numbers 

            Console.WriteLine($"Sum is {sum}");   // display sum
            sum = int.Parse(Console.ReadLine());  // display total
            Console.WriteLine("Press any key to exit"); // exit program
            Console.ReadKey();

        } //end Main1

    }     // end class Addition

} // end namespace Lab02_SalvatoreSirna
