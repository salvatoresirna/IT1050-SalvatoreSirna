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

        private static void result()
        {
            throw new NotImplementedException();
        }

        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        double number4 = double.Parse(Console.ReadLine());

        public double Number1 { get => number1; set => number1 = value; }
        public double Number2 { get => number2; set => number2 = value; }
        public double Number3 { get => number3; set => number3 = value; }
        public double Number4 { get => number4; set => number4 = value; }
    }
        

   
}
