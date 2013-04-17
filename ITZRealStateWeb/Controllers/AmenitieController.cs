using ITZRealStateWeb.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITZRealStateWeb.Models;

namespace ITZRealStateWeb.Controllers
{
    public class AmenitieController : BaseWebController
    {
        //
        // GET: /Amenitie/

        public ActionResult Index()
        {
            BaseClient client = new BaseClient(baseApiUrl, "amenitie", "getAmenities");
            List<Amenitie> amenities = new List<Amenitie>();
            amenities= client.Get<List<Amenitie>>();
            return View(amenities);
        }

        //
        // GET: /Amenitie/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Amenitie/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Amenitie/Create

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
            return View();
        }

        //
        // POST: /Amenitie/Delete/5

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
