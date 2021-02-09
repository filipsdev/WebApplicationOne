using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationOne.Models;

namespace WebApplicationOne.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {
            // generate some fake data and send it to a view
            List<ItemModel> items = new List<ItemModel>();

            items.Add(new ItemModel(0, "T-Shirt Adidas", "Men", 65, 10, "Original t-shirt."));
            items.Add(new ItemModel(0, "Skirt", "Woman", 55, 15, "Great Scirt."));
            items.Add(new ItemModel(0, "Men's Jacket", "Men", 65, 150, ""));

            return View("Index", items);
        }
    }
}