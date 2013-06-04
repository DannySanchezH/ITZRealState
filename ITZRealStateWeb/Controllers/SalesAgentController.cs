using ITZRealStateWeb.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITZRealStateWeb.Models;

namespace ITZRealStateWeb.Controllers
{
    public class SalesAgentController : BaseWebController
    {
        //
        // GET: /SalesAgent/

        public ActionResult Index()
        {
            BaseClient client = new BaseClient(baseApiUrl, "SalesAgent", "GetSalesAgents");
            List<SalesAgent> agents = client.Get<List<SalesAgent>>();
            return PartialView(agents);
        }

        //
        // GET: /SalesAgent/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SalesAgent/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SalesAgent/Create

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
        // GET: /SalesAgent/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SalesAgent/Edit/5

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
        // GET: /SalesAgent/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SalesAgent/Delete/5

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
