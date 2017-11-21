using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question4
{
    class Program
    {
        static void Main()
        {
            int number = 1;
            while (number <= 21)
            {
                {
                    if ((number % 2) == 0)
                    {
                        Console.Write("   ");//3 spaces created..
                    }
                    else if ((number % 2) != 0)
                    {
                        Console.Write(number);
                    }
                    number++;
                }
            }


        }
    }
}
