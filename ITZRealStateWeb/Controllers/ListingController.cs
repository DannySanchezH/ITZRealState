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
            BaseClient client = new BaseClient(baseApiUrl, "Amenitie", "GetAmenities");
            List<Amenitie> amenities = client.Get<List<Amenitie>>();
            ViewBag.amenities = amenities;

            client = new BaseClient(baseApiUrl, "Room", "GetRooms");
            List<Room> rooms = client.Get<List<Room>>();
            ViewBag.rooms = rooms;

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
            BaseClient client = new BaseClient(baseApiUrl, "Listing", "GetListing");
            Listing listing = client.Get<Listing>(model.IdListing.ToString());
            if (ModelState.IsValid == true)
            {
                if (user == null)
                {
                    client = new BaseClient(baseApiUrl, "Listing", "PostListing");
                    string result = client.Post<Listing>(model);
                    return Json(new { success = true });
                }
                try
                {
                    client = new BaseClient(baseApiUrl, "Listing", "PutListing");
                    string result = client.Put<Listing>(model.IdListing.ToString(), model);
                    return Json(new { success = true });
                }
                catch
                {
                    return Json(new { success = false, message = "There was an issue with the server, please try again latter." });
                }
            }
            else
            {
                return Json(new { success = false, message = "Please correct all the issues." });
            }
        }

        //
        // GET: /Listing/Delete/5


        public ActionResult DeleteListingAjax(string id)
        {
            try
            {
                BaseClient client = new BaseClient(baseApiUrl, "Listing", "DeleteListing");
                string result = client.Delete(id.ToString());
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }
     public ActionResult CreateComplet(int id)
        {
            BaseClient client = new BaseClient(baseApiUrl, "Amenitie", "GetAmenities");
            List<Amenitie> amenities = client.Get<List<Amenitie>>();
            ViewBag.amenities = amenities;

            client = new BaseClient(baseApiUrl, "Room", "GetRooms");
            List<Room> rooms = client.Get<List<Room>>();
            ViewBag.rooms = rooms;
            
            Listing listing = new Listing();
            listing.IdUser = id;
            return PartialView();
        }

    }

    public class CompletListing
    {
        public Listing Listing { get; set; }
        public Room_Listing Rooms { get; set; }
        public Amenitie Amenities { get; set; }
    }
}
