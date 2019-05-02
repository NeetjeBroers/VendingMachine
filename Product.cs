using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachien
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        private int Stock { get; set; }        

        public Product(string name, int price, int stock, bool available)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;            
        }

    }
}
