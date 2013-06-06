﻿using System;
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

        public ActionResult MyListings(int id)
        {
            BaseClient client = new BaseClient(baseApiUrl, "Listing", "GetMyList");
            List<Listing> listings = client.Get<List<Listing>>(id.ToString());
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

        public ActionResult Create(int id)
        {
            Listing listing = new Listing();
            listing.IdUser = id;
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
            BaseClient client = new BaseClient(baseApiUrl, "Listing", "GetListing");
            Listing listing = client.Get<Listing>(id.ToString());
            return PartialView(listing);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult EditListingAjax(Listing model)
        {
           
                try
                {
                    BaseClient client = new BaseClient(baseApiUrl, "Listing", "PutListing");
                    string result = client.Put<Listing>(model.IdListing.ToString(), model);
                    return Redirect("/Dashboard");
                }
                catch
                {
                    return Redirect("/Dashboard");
                }
        }

        //
        // GET: /Listing/Delete/5

        
        public ActionResult DeleteListingAjax(string id)
        {
            try
            {
                BaseClient client = new BaseClient(baseApiUrl, "Listing", "DeleteListing");
                string result = client.Delete(id);
                return Redirect("/Dashboard");
            }
            catch
            {
                return Redirect("/Dashboard");
            }
        }


    }
}
