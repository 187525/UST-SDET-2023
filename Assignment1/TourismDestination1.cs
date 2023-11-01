using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TourismDestination1
    {
        public TourismDestination1(string? name, string? country, int rating, double pricePerNight)
        {
            Name = name;
            Country = country;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }

        public int Rating { get; set; }
        public double PricePerNight{ get; set; }

        public static List<TourismDestination1> tourismDestination1 = new List<TourismDestination1>();

        public static void DisplayTopRated()
        {
            var data = tourismDestination1.FindAll(x => x.Rating > 3);
            if (data != null)
            {
                foreach (var item in data)
                {
                    Console.WriteLine("Top Rated tourist Destination:" + item.Name);
                 }
            }
            else
            {
                Console.WriteLine("No details found");

            }
        }

        public static void SortedDestination()
        {
            Console.WriteLine("Sorted Destination based on price per night:");
            var data = tourismDestination1.OrderBy(x => x.PricePerNight);
            foreach (var item in data)
            {
                Console.WriteLine();
                Console.WriteLine("Destination:" + item.Name + "\t" + "Country:" + item.Name + "\t" + "Rating:" + item.Rating + "\t" + "Price Per Night:" + item.PricePerNight);
            }
        }
        
        public static void FilterDestination()
        {
            Console.WriteLine();
            Console.WriteLine("filter Destination");
            var data = tourismDestination1.FindAll(x => x.Country == "India");
            if(data != null)
            {
                foreach(var item in data)
                {
                    Console.WriteLine();
                    Console.WriteLine("Destination:" + item.Name + "\t" + "Country:" + item.Name + "\t" + "Rating:" + item.Rating + "\t" + "Price Per Night:" + item.PricePerNight);
                }
            }

        }
     }
}

            

                
        
