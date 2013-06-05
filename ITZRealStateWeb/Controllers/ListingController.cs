using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITZRealStateWeb.Models;
using ITZRealStateWeb.Helpers;

namespace ITZRealStateWeb.Controllers
{
    public class ListingController : BaseWebController
    {
        //
        // GET: /Listing/
        
        public ActionResult Index()
        {
            BaseClient client = new BaseClient(baseApiUrl, "Listing", "GetListings");
            List<Listing> listings = client.Get<List<Listing>>();
            return PartialView(listings);
        }

        //
        // GET: /Listing/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Listing/Create

        public ActionResult Create()
        {
            Listing listing = new Listing();
            return PartialView(listing);
        }
        
      

        //
        // POST: /Listing/Create

        [HttpPost]
        public ActionResult CreateListingAjax(Listing model)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    BaseClient client = new BaseClient(baseApiUrl, "Listing", "PostListing");
                    string result = client.Post<Listing>(model);
                    
                }
                catch
                {
                    return Redirect("/Dashboard");
                }
            }
           
                return Redirect("/Dashboard");
        }

        //
        // GET: /Listing/Edit/5

        public ActionResult Edit(int id)
        {
            return PartialView();
        }

        //
        // POST: /Listing/Edit/5

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

        //
        // GET: /Listing/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Listing/Delete/5

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
