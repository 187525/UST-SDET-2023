using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DigitalElectronics:ElectronicProduct
    {
        public DigitalElectronics(string? productname, double price, double quantity, int warrantyPeriod,string? fileformat)
            : base(productname, price, quantity,warrantyPeriod)
        {
            Productname = productname;
            Price = price;
            Quantity = quantity;
            WarrantyPeriod = warrantyPeriod;
            FileFormat = fileformat;

        }
        public string? FileFormat { get; set; }

        public void DisplayFileformat()
        {
            Console.WriteLine("FileFormat:" + FileFormat);
        }
    }
}
