using Supermarket_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Supermarket_MVC.Controllers
{
    public class ItemController : Controller
    {
        // GET: AddItem
        public ActionResult Index()
        {
            SuperMarketcontext Dbcontext = new SuperMarketcontext();
            var Details = Dbcontext.ItemDetails.ToList();
            ViewData["ItemData"] = Details;
            return View();
        }




        [HttpPost]
        public ActionResult Index(Item_Details ItemDetails)
        {
            SuperMarketcontext Dbcontext = new SuperMarketcontext();
            if (ItemDetails.Id == 0)
            {
                Dbcontext.ItemDetails.Add(ItemDetails);
                Dbcontext.SaveChanges();
            }
            else
            {
                var Details = Dbcontext.ItemDetails.Find(ItemDetails.Id);
                if(Details!=null)
                {
                    Details.Name = ItemDetails.Name;
                    Details.Price = ItemDetails.Price;
                    Details.Quantity = ItemDetails.Quantity;
                    Dbcontext.SaveChanges();                }

            }

            return RedirectToAction("Index");

        }
      [HttpGet]
      public ActionResult EditDetails(int id)
        {
            SuperMarketcontext Dbcontext = new SuperMarketcontext();
            var Details = Dbcontext.ItemDetails.Find(id);
            var ListDetails = Dbcontext.ItemDetails.ToList();
            ViewData["ItemData"] = ListDetails;

            return View("index",Details);
        }
        [HttpGet]
        public ActionResult DeleteDetails(int Id)
        {
            SuperMarketcontext Dbcontext = new SuperMarketcontext();
            var Details = Dbcontext.ItemDetails.Find(Id);
            Dbcontext.ItemDetails.Remove(Details);
            Dbcontext.SaveChanges();
            var ListDetails = Dbcontext.ItemDetails.ToList();
            ViewData["ItemData"] = ListDetails;
            return View("Index");
        }


        // GET: AddItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddItem/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddItem/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddItem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
