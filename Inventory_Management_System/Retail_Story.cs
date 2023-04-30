using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Retail_Store
    {
        private static int nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Double Price { get; set; }

        public Retail_Store(string name, int quantity,double price)
        {
            Id = nextId++;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
