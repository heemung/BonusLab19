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

            //init dictionary and init other arrays for card
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
            //prints menu of all items  in a formated way. and ask for inital user input
            //calls the other methods
            while (contYN)
            {
                Console.WriteLine("{0,-20}{1,0}", "Item", "Price");
                Console.WriteLine("==============================");


                for (int i = 0; i < storeItems.Count; i++)
                {
                    Console.WriteLine("{0,-20} ${1,0}", storeItems[i], storePrice[i]);
                }


                Console.Write("\nWhat item would you like to order? ");
                userSelect = Console.ReadLine();
                AddingToCart(userSelect, menuOfItems);

                Console.Write("Would you like to order anything else? ");
                contYN = Continue(Console.ReadLine(), contYN);
            }
            //calls order compelte method
            OrderComplete();
            Console.ReadLine();

        }
        
        //finds the average of the array price 
        public static double AverageItems()
        {
            double avg = 0;
            foreach(double d in userCartPrice)
            {
                avg += d;
            }
            avg = avg / userCartPrice.Count;
            avg = Math.Round(avg, 2);
            Console.WriteLine("The average price of all items in cart is: ${0}", avg);
            return avg;
        }

        //highest cost goes through the array and find thes highest price in cart,
        //matches the lowest index of lowest item and prints.
        public static double HighestCost()
        {
            double tempDoub = 0;
            int index =0;

            foreach(double d in userCartPrice)
            {
                if (tempDoub < d)
                {
                    tempDoub = d;
                }

            }
            index = userCartPrice.IndexOf(tempDoub);
            Console.WriteLine("The highest cost item is {0} at ${1}", userCart[index], tempDoub);
            return tempDoub;
        
        }
        //lowest cost goes through the array and find thes lowest price in cart,
        //matches the lowest index of lowest item and prints.
        public static double LowestCost()
        {
            double tempDoub = HighestCost();
            int index = 0;

            foreach (double d in userCartPrice)
            {
                if (tempDoub > d)
                {
                    tempDoub = d;
                }

            }
            index = userCartPrice.IndexOf(tempDoub);
            Console.WriteLine("The lowest cost item is {0} at ${1}", userCart[index], tempDoub);
            return tempDoub;

        }

        //goes through the dictonary list for the user input if its true it adds the 
        //user input to array and the value of the dictonay to array price
        public static void AddingToCart(string selection, Dictionary<string, 
            double> menuOfItems)
        {
            while(true)
                {
                if (menuOfItems.ContainsKey(selection))
                {
                    userCart.Add(selection);
                    userCartPrice.Add(menuOfItems[selection]);
                    Console.WriteLine("Adding {0} to card at {1}.\n",userCart[userCart.Count -1] ,
                        userCartPrice[userCartPrice.Count - 1]);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry that item isn't on the menu. Please choose " +
                        "something on the menu.\n");
                    break;
                }
            }
        }

        //user continue method
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

        //order complete method writes all items in users cart and displays average
        //highest and lowest
        public static void OrderComplete()
        {
            Console.Clear();
            Console.WriteLine("Thank you for your order! \nHere's what you got");

            for(int i = 0; i < userCart.Count; i++)
            {
                Console.WriteLine("{0,-20}{1,0}",userCart[i],userCartPrice[i]);
            }
            AverageItems();
            HighestCost();
            LowestCost();
        }

        //adding items to dictonary
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
