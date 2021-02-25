using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationOne.Data;
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

            //items.Add(new ItemModel(0, "T-Shirt Adidas", "Men", "65", "10", "Original t-shirt."));
            //items.Add(new ItemModel(0, "Skirt", "Woman", "55", "15", "Great Scirt."));
            //items.Add(new ItemModel(0, "Men's Jacket", "Men", "65", "150", ""));

            ItemDAO itemDAO = new ItemDAO();
            items = itemDAO.FetchAll();

            return View("Index", items);
        }

        public ActionResult Details(int id)
        {
            ItemDAO itemDAO = new ItemDAO();
            ItemModel item = itemDAO.FetchOne(id);

            return View("Details", item);
        }

        public ActionResult Create()
        {
            return View("ItemForm");
        }
        public ActionResult Edit(int id)
        {
            ItemDAO itemDAO = new ItemDAO();
            ItemModel item = itemDAO.FetchOne(id);

            return View("ItemForm", item);
        }
        public ActionResult Delete(int id)
        {
            ItemDAO itemDAO = new ItemDAO();
            itemDAO.Delete(id);

            List<ItemModel> items = itemDAO.FetchAll();

            return View("Index", items);
        }

        public ActionResult ProcessCreate(ItemModel itemModel)
        {
            // save to the DB
            ItemDAO itemDAO = new ItemDAO();

            itemDAO.CreateOrUpdate(itemModel);

            return View("Details", itemModel);
        }

        public ActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {
            // get a list of search results from the DB.

            ItemDAO itemDAO = new ItemDAO();

            List<ItemModel> searchResults = itemDAO.SearchForName(searchPhrase);

            return View("Index", searchResults);
        }
        public ActionResult SearchForDescription(string searchPhrase)
        {
            // get a list of search results from the DB.

            ItemDAO itemDAO = new ItemDAO();

            List<ItemModel> searchResults = itemDAO.SearchForName(searchPhrase);

            return View("Index", searchResults);
        }


    }
}