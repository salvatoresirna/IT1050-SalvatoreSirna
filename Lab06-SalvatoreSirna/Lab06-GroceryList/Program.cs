using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_GroceryList
{
    class Grocery
    {
        static void Main()
        {
            string groceryItem = "";
            double groceryCost = 0d;
            double totalCost = 0d;
            string output = "";

            while (true)
            {
                Console.Write("Enter grocery item (E to end): ");
                groceryItem = Console.ReadLine();
                if (groceryItem == "E")
                {
                    break;
                }
                Console.Write("Enter grocery cost (numbers only): ");
                groceryCost = Convert.ToDouble(Console.ReadLine());

                totalCost += groceryCost;
                output = output + groceryItem + "\t$" + string.Format("{0:0.00}", groceryCost) + "\n";
            }
            Console.WriteLine(output);
            Console.WriteLine("Total Cost $" + string.Format("{0:0.00}", totalCost));
        }
    }
        }
    }
}
