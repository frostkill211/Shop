using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Products
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public Products(string productName, string description, double price, int amount)
        {
            ProductName = productName;
            Description = description;
            Price = price;
            Amount = amount;
        }


    }
}
