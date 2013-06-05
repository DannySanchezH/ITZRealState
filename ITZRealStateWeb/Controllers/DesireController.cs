using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITZRealStateWeb.Models;
using ITZRealStateWeb.Helpers;

namespace ITZRealStateWeb.Controllers
{
    [Authorize]
    public class DesireController : BaseWebController
    {
        //
        // GET: /Desire/

        public ActionResult Index(int id)
        {
            BaseClient client = new BaseClient(baseApiUrl, "Desire", "GetMyDesires");
            List<Listing> listings = client.Get<List<Listing>>(id.ToString());
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

        public ActionResult DeleteDesireAjax(int id, int idu)
        {
            try
            {
                BaseClient client = new BaseClient(baseApiUrl, "Desire", "GetMyListDesires");
                List<Desire> Desires = client.Get<List<Desire>>(idu.ToString());
                String idDesire = "";
                foreach (Desire item in Desires)
                {
                    if (item.IdListing == id)
                    {
                        idDesire = item.IdDesire.ToString();
                    }
                }
                client = new BaseClient(baseApiUrl, "Desire", "DeleteDesire");
                string result = client.Delete(idDesire);
                return Redirect("/Dashboard");
            }
            catch
            {
                return Redirect("/Dashboard");
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
