using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Question2
{
    class Program
    {
        static void Main()
        {
            string[] array = { "1- January", "2- February", "3- March", "4- April", "5- May", "6- June", "7- July", "8- August", "9- September", "10- October", "11- November", "12- December" };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(array[i]); //months order
            }
            //output

            for (int counter = 0; counter < array.Length; ++counter) ;
           

            
        }
    }
}
