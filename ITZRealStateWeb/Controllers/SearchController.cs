using ITZRealStateWeb.Helpers;
using ITZRealStateWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ITZRealStateWeb.Controllers
{
    public class SearchController : BaseWebController
    {
        //
        // GET: /Search/

        public ActionResult SearchLog(int id)
        {
            BaseClient client = new BaseClient(baseApiUrl, "User", "GetUser");
            User user = client.Get<User>(id.ToString());
            Search search = new Search();
            search.zipcode = user.Zipcode;
            return PartialView(search);
        }

        //
        // GET: /Search/Details/5
        public ActionResult MyNewSearchL(Search model)
        {
            BaseClient client = new BaseClient(baseApiUrl, "Listing", "GetZCList");
            List<Listing> listings = client.Get<List<Listing>>(model.zipcode.ToString());
            return PartialView(listings);
        }

        public ActionResult AddFavorite(int id, int idu)
        {
            Desire desire = new Desire();
            desire.IdListing = id;
            desire.IdUser = idu;
            try
            {
                BaseClient client = new BaseClient(baseApiUrl, "Desire", "PostDesire");
                string result = client.Post<Desire>(desire);
            }
            catch
            {
                return Redirect("/Dashboard");
            }
            return Redirect("/Dashboard");
        }

        //
        // GET: /Search/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Search/Create

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

        //
        // GET: /Search/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Search/Edit/5

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
        // GET: /Search/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Search/Delete/5

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
    public class Search {
        public int zipcode { get; set; }
    }
}
