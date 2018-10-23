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
        static List<string> userCart = new List<string>();
        static List<double> userCartPrice = new List<double>();
        static void Main(string[] args)
        {
            string userSelect;
            bool contYN = true;

            Console.WriteLine("Welcome to Guenther's Market\n");
            Console.WriteLine("{0,15}", "Menu");

            int numberOfItems;
            Dictionary<string, double> menuOfItems = new Dictionary<string, double>();
            AddingItems(menuOfItems);
            numberOfItems = menuOfItems.Count;
            ArrayList storeItems = new ArrayList();
            ArrayList storePrice = new ArrayList();
            foreach(KeyValuePair<string,double> d in menuOfItems)
            {
                storeItems.Add(d.Key.ToString());
                storePrice.Add(d.Value.ToString());
            }

            while (contYN)
            {
                Console.WriteLine("{0,-20}{1,0}", "Item", "Price");
                Console.WriteLine("==============================");


                for (int i = 0; i < storeItems.Count; i++)
                {
                    Console.WriteLine("{0,-20} ${1,0}", storeItems[i], storePrice[i]);
                }


                Console.Write("What item would you like to order? ");
                userSelect = Console.ReadLine();
                contYN = AddingToCart(userSelect, menuOfItems);
            }
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
        public static bool AddingToCart(string selection, Dictionary<string, 
            double> menuOfItems)
        {
            while(true)
                {
                if (menuOfItems.ContainsKey(selection))
                {
                    userCart.Add(selection);
                    userCartPrice.Add(menuOfItems[selection]);
                    return true;
                }
                else
                {
                    Console.WriteLine("That isn't on the menu! Please choose " +
                        "something on the menu.");
                    return false;
                }
            }
        }
        public static bool Continue(string userCont, bool temp)
        {
            temp = true;
            while (temp)
            {
                userCont.ToLower();
                if (userCont == "yes")
                {
                    temp = false;
                    return true;
                }
                else if (userCont == "no")
                {
                    temp = false;
                    return false;
                }
                else
                {
                    Console.Write("That is not a valid input. Please type 'yes' or 'no'");
                    userCont = Console.ReadLine();
                    
                }
            }
            Console.WriteLine("Something didn't return");
            return false;
        }

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
