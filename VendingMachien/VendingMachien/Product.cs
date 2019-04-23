using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachien
{
    class Product
    {
        private string name;
        private int price;
        private int stock;
        private int productsSold = 0;
        private bool available;
        public Product(string name, int price, int stock, bool available)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.available = available;
        }
    }
}
