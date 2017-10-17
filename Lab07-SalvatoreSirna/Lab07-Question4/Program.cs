using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2) == 0)
                    { Console.WriteLine("Number is even"); }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is odd");
                    }
                }
              
                Console.Write(" i ");
            }
        }       
    }
}
