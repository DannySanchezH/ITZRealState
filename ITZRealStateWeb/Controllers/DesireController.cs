using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITZRealStateWeb.Models;
using ITZRealStateWeb.Helpers;

namespace ITZRealStateWeb.Controllers
{
    public class DesireController : BaseWebController
    {
        //
        // GET: /Desire/

        public ActionResult Index()
        {
            BaseClient client = new BaseClient(baseApiUrl, "Listing", "GetListings");
            List<Listing> listings = client.Get<List<Listing>>();
            return PartialView(listings);
        }

        //
        // GET: /Desire/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Desire/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Desire/Create

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
        // GET: /Desire/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Desire/Edit/5

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
        // GET: /Desire/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult DeleteDesireAjax(string idL,string idU)
        {
            try
            {
                BaseClient client = new BaseClient(baseApiUrl, "Books", "DeleteBook");
                string result = client.Delete(idL);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

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
