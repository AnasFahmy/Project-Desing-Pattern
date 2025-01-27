using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Structural.Facade.BadExample
{
    public class OrderFulfillment
    {
        private Inventory _inventory;

        public OrderFulfillment(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Fulfill(string name, string address, string[] items)
        {
            System.Console.WriteLine("Inserting order into database");
            foreach (var item in items)
            {
                _inventory.ReduceInventory(item, 1);
            }
        }
    }
}