using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
        
        class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> menuOfItems = new Dictionary<string, double>();

        }
        static void MenuOfItemsAdd(Dictionary<string,double> item)
        {
            item.Add("apple",.99);
            item.Add("banana", .89);
            item.Add("jeans", 24.99);
            item.Add("t-shirt", 10.99);
            item.Add("cat food", 12.50);
            item.Add("lotto ticket", .50);
            item.Add("toy", 99.95);
            item.Add("car", 24000.00);
            //control rr
        }
    }
}
