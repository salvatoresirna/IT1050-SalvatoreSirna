using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question3
{
    class Program
    {
        static void Main()
        {
            string loop49 = ",";
            int num;
            for (num = 49; num >=1 ; --num)
            {
                Console.Write(num);
                if (num>=2)
                {
                    Console.Write(loop49);
                }
            }                       
        }
    }
}
