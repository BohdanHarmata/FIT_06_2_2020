using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Addres
    {
        private int index { get; set; }
        private string country { get; set; }
        private string city { get; set; } 
        private string street { get; set; }
        private int house { get; set; }
        private int apartament { get; set; }
        public Addres(int index, string country, string city, string street, int house, int apartament)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartament = apartament;
        }
        public void AddresOut()
        {
            Console.WriteLine($"Index {index}");
            Console.WriteLine($"country {country}");
            Console.WriteLine($"City {city}");
            Console.WriteLine($"Street {street}");
            Console.WriteLine($"House {house}");
            Console.WriteLine($"Apartament {apartament}");
        }
    }
}
