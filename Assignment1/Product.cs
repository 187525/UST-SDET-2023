using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
     class Product
    {
        private string? productname;
        private double price;
        private double quantity;

        public Product(string? productname, double price, double quantity)
        {
           Productname = productname;
           Price = price;
           Quantity = quantity;
        }

        public string? Productname { get => productname; set => productname = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        public void SetPrice(double newPrice)
        {
            this.Price = newPrice;
        }

        public double ProductValue()
        {
           double totalvalue=price*quantity;
            return totalvalue;
        }



    }
}
