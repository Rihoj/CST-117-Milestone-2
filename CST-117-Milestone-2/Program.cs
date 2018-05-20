using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_Milestone_2
{
    class Inventory
    {
        static void Main(string[] args)
        {
            InventoryItem item = new InventoryItem("Chips", "A Bag of chips", 10, 2.99M, 0.5M);
            Console.WriteLine("An item has been created.");
            Console.WriteLine("Item Name: " + item.Name);
            Console.WriteLine("Description: " + item.Description);
            Console.WriteLine("Quantity: " + item.Quantity);
            Console.WriteLine("Price: " + item.Price);
            Console.WriteLine("Weight: " + item.Weight);

            Console.ReadKey();
        }
    }
}
