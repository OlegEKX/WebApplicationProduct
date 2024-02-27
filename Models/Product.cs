using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebApp.Models
{
    public class Product
    {
        static int unicId = 0;

        public int Id { get; }
        public string Name { get; }
        public Decimal Cost { get; }
        public string Description { get; }
        public string PathImage { get; }

        public Product(string name, Decimal cost, string description, string pathImage)
        {
            Name = name;
            Cost = cost;
            Description = description;
            PathImage = pathImage;
            Id = unicId++;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Cost} {Description}";
        }

    }
}
