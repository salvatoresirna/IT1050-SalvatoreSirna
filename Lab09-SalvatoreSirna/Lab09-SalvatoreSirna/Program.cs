using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_SalvatoreSirna
{
    class MyMath
    {
        static void Main()
        {
            int operand1 = 45;
            int operand2 = 35;

            double product = Multiply(operand1, operand2);
            Console.WriteLine(product);
            
            // Correct division for double:
            double number1 = (double)operand1 / operand2;
            Console.WriteLine(number1);

            // Correct multiplication for double:
            double number2 = (double)operand1 * operand2;
            Console.WriteLine(number2);

            // Correct addition for double:
            double number3 = (double)operand1 + operand2;
            Console.WriteLine(number3);

            // Correct subtraction for double:
            double number4 = (double)operand1 - operand2;
            Console.WriteLine(number4);
            result();
        }

        //Mulitply Method
        static void Multiply(double operand1, double operand2)
        {
           result = operand1 * operand2;
        }
        // Divide Method
        static void Divide(double operand1, double operand2)
        {
            result = operand1 / operand2;
        }
        //Subtract Method
        static void Subtract(double operand1, double operand2)
        {
            result = operand1 - operand2;
        }
        //Add Method
        static void Add(double operand1, double operand2)
        {
            result = operand1 + operand2;
        }
        //Results Method
        static double GetResult()
        {
            return result;
        }
    }
}
