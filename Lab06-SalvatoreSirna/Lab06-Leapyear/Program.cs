using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Leapyear
{
    class Program
    {
        static void Main()
        {
            int counter = 2016; //declare increments of 4 years for next 20 leapyears

            for (counter = 4; counter <= 20; ++counter)
            {
                if (counter == 4) //loop leapyar 4yrs
                {
                    {
                        break;
                    }
                    Console.Write($"{counter} ");

                }

                Console.WriteLine($"\n break loop = {counter}");

            }
        }

    }
}