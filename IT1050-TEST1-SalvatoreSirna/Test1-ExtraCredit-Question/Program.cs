using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ExtraCredit_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOflevels = 10, Space, Number;

            Console.WriteLine("Make Pyramid");

            for (int i = 6; i <= numberOflevels; i++) // Total number of layer for pramid

            {

                for (Space = 1; Space <= (numberOflevels + i); Space++)  // Loop For Space

                    Console.Write(" ");

                for (Number = 1; Number <= i; Number++) //increase the value

                    Console.Write(Number);

                for (Number = (i + 1); Number <= 1; Number--)  //decrease the value

                    Console.Write(Number);

                Console.WriteLine();
            }

        }

    }
}