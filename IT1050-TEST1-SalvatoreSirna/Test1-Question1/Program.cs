using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question1
{
    class Program
    {
        static void Main()
        {
            int num = 20; Boolean runningLoop = true; while (runningLoop)
            {
                if (num <= 19) runningLoop = false;
                num++;
                Console.WriteLine(num);
            }
        }
    }
}
