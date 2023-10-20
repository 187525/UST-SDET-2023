using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ElectronicProduct:Product
    {

        public ElectronicProduct(string? productname, double price, double quantity, int warrantyPeriod) 
            : base(productname, price, quantity)
        {
           Productname = productname;
            Price = price;
            Quantity = quantity;
            WarrantyPeriod = warrantyPeriod;

            
        }

        
     public int WarrantyPeriod { get; set; }

        public void DisplayWarrantyPeriod()
        {
            Console.WriteLine("Warranty period:" +WarrantyPeriod);
        }

    }
}
