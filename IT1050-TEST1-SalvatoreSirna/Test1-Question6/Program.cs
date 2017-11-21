using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question6
{
    class Program
    {
        static void Main(String[] args)
        {
            Boolean sunnyDay = true, icyRain = false, tornadoWarning = false;
            
            if (icyRain && tornadoWarning && sunnyDay)
            {
                Console.Write("Lets Go Outside");
            }
            else

            if (icyRain || tornadoWarning || sunnyDay)
            {
                Console.Write("Lets Go Outside");
            }
        }
    }
}
