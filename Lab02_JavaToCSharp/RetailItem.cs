using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_JavaToCSharp
{
    class RetailItem
    {
        //Fields
        private string description = "";
        private int unitsOnHand = 0;
        private double price = 0;

        //Constructors
        public RetailItem() { }

        public RetailItem(string desc, int units, double pric)
        {
            description = desc;
            unitsOnHand = units;
            price = pric;
        }

        // Mutators in Java are SetMethods().
        // Accessors in Java are GetMethods().

        public void SetDescription(string d)
        {
            description = d;
        }
        public string GetDescription()
        {
            return description;
        }

        public void SetUnitsOnHand(int u)
        {
            unitsOnHand = u;
        }
        public int GetUnitsOnHand()
        {
            return unitsOnHand;
        }

        public void SetPrice(double p)
        {
            price = p;
        }
        public double GetPrice()
        {
            return price;
        }
    }
}
