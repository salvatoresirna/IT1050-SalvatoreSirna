using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question2
{
    class Program
    {
        static void Main()
        {
            int number = 2;
            while (number <= 200)
            {
                {
                    if ((number % 2) == 0)
                    {
                        Console.WriteLine("[{0}]", number);//I used a short version 
                                                            //without "else" -- will have to figureout how I did it
                    }
                    else if ((number % 2) != 0)
                    {
                        Console.Write("");
                    }
                    number *= 2;
                }
            }
        }
    }
}
