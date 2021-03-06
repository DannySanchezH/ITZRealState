﻿using ITZRealStateWeb.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITZRealStateWeb.Models;

namespace ITZRealStateWeb.Controllers
{
    [Authorize]
    public class AmenitieController : BaseWebController
    {
        //
        // GET: /Amenitie/

        public ActionResult Index()
        {
            BaseClient client = new BaseClient(baseApiUrl, "amenitie", "getAmenities");
            List<Amenitie> amenities = client.Get<List<Amenitie>>();
            return PartialView(amenities);
        }

        public ActionResult Create()
        {
            Amenitie amenitie = new Amenitie();
            amenitie.IdAmenitie = 0;
            return PartialView(amenitie);
        }

        //
        // POST: /Amenitie/Create

        [HttpPost]
        public ActionResult CreateAmenitie(Amenitie model)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    BaseClient client = new BaseClient(baseApiUrl, "Amenitie", "PostAmenitie");
                    string result = client.Post<Amenitie>(model);

                }
                catch
                {
                    return Redirect("/Dashboard");
                }
            }

            return Redirect("/Dashboard");
        }

        //
        // GET: /Amenitie/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Amenitie/Edit/5

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
        // GET: /Amenitie/Delete/5

        public ActionResult Delete(int id)
        {
            try
            {
                BaseClient client = new BaseClient(baseApiUrl, "Amenitie", "DeleteAmenitie");
                string result = client.Delete(id.ToString());
                return Redirect("/Dashboard");
            }
            catch
            {
                return Redirect("/Dashboard");
            }
        }
    }
}
