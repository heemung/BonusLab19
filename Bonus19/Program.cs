using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guenther's Market\n\n Menu:");

            int numberOfItems;
            Dictionary<string, double> menuOfItems = new Dictionary<string, double>();
            AddingItems(menuOfItems);
            numberOfItems = menuOfItems.Count;
            ArrayList[] storeItems = new ArrayList[numberOfItems];
            ArrayList[] storePrice = new ArrayList[numberOfItems];

            Console.WriteLine("{0,-20}{1,0}", "Item", "Menu");
            Console.WriteLine("==============================");


            for (int i = 0; i <  storeItems.Length; i++) 
            {
                Console.WriteLine("{0,-20}",storeItems[i]);
                Console.WriteLine(storePrice[i]);
            }
            /*
            foreach (var d in menuOfItems) //keyValuePair <string, double>
            {
                Console.WriteLine(d);
            }
            */
            Console.ReadLine();

        }
        /*
        public int AverageItems()
        {

        }
        public int HighestCost()
        {

        }
        public int LowestCost()
        {

        }
        */
        public static void AddingItems(Dictionary<string, double> menuOfItems)
        {
            menuOfItems.Add("apple", 0.99);
            menuOfItems.Add("banana", 0.59);
            menuOfItems.Add("cauliflower", 1.59);
            menuOfItems.Add("dragonfruit", 2.19);
            menuOfItems.Add("Elderberry", 1.79);
            menuOfItems.Add("figs", 2.09);
            menuOfItems.Add("grapefruit", 1.99);
            menuOfItems.Add("honeydew", 3.49);
        }

    }

}
