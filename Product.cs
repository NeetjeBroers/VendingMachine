using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachien
{
    class Product
    {
        private string Name;
        private int Price;
        private int Stock;
        private int ProductsSold = 0;
        private bool Available;
        public Product(string name, int price, int stock, bool available)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Available = available;
        }

    }
}
