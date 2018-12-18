using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_JavaToCSharp
{
    class Program
    {
        //Class RetailItemDemo but using the 'static void Main(string[] args)'
        static void Main(string[] args)
        {
            // Create Item #1
            RetailItem item1 = new RetailItem("Jacket", 12, 59.95);
            // Create Item #2
            RetailItem item2 = new RetailItem("Designer Jeans", 40, 34.95);
            // Create Item #3
            RetailItem item3 = new RetailItem("Shirt", 20, 24.95);

            // Read Item1 & Item2 & Item3
            Console.WriteLine("Item1 - Description: " + item1.GetDescription() + " - UnitsOnHand: " + item1.GetUnitsOnHand() + " - Price: " + item1.GetPrice());
            Console.WriteLine("Item2 - Description: " + item2.GetDescription() + " - UnitsOnHand: " + item2.GetUnitsOnHand() + " - Price: " + item2.GetPrice());
            Console.WriteLine("Item3 - Description: " + item3.GetDescription() + " - UnitsOnHand: " + item3.GetUnitsOnHand() + " - Price: " + item3.GetPrice());
            Console.WriteLine();
            Console.WriteLine("Before changing values on item1 (Using SetMethods)");
            Console.WriteLine("Item 1 - Description: " + item1.GetDescription() + " - UnitsOnHand: " + item1.GetUnitsOnHand() + " - Price: " + item1.GetPrice());
            // Use Mutator methods on Item1 to change the values.
            Console.WriteLine();
            Console.WriteLine("After changing values on item1 (Using SetMethods)");
            Console.WriteLine();
            item1.SetDescription("Brewers Hat");
            Console.WriteLine("item1.SetDescription('Brewers Hat')");
            item1.SetUnitsOnHand(5);
            Console.WriteLine("item1.SetUnitsOnHand(5)");
            item1.SetPrice(49.99);
            Console.WriteLine("item1.SetPrice(49.99)");
            Console.WriteLine();
            Console.WriteLine("Item1 - Description: " + item1.GetDescription() + " - UnitsOnHand: " + item1.GetUnitsOnHand() + " - Price: " + item1.GetPrice());
            Console.ReadLine();
        }
    }
}
