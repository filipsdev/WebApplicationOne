using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationOne.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName ("Item Name")]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Description { get; set; }

        public ItemModel()
        {
            Id = -1;
            Name = "Nothing";
            Type = "No Type available yet";
            Size = "No Size available yet";
            Price = "No Price available yet";
            Description = "No Description yet.";

        }

        public ItemModel(int id, string name, string type, string size, string price, string description)
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