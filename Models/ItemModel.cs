using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationOne.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public ItemModel()
        {
            Id = -1;
            Name = "Nothing";
            Type = "No Type available yet";
            Size = 0;
            Price = 0;
            Description = "No Description yet.";

        }

        public ItemModel(int id, string name, string type, int size, double price, string description)
        {
            Id = id;
            Name = name;
            Type = type;
            Size = size;
            Price = price;
            Description = description;
        }
    }
}