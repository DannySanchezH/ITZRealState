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

        public ActionResult SearchNL()
        {
            Search search = new Search();
            return PartialView(search);
        }

        //
        // GET: /Search/Details/5
        public ActionResult MyNewSearchL(Search model)
        {
            List<Listing> listZ= new List<Listing>();
            List<Listing> listMin = new List<Listing>();
            List<Listing> listMax = new List<Listing>(); 
            List<Listing> listings = new List<Listing>();

            if (model.zipcode != 0)
            {
                BaseClient client = new BaseClient(baseApiUrl, "Listing", "GetZCList");
                listZ=client.Get<List<Listing>>(model.zipcode.ToString());
                if (model.maxprice != 0)
                {
                    foreach (Listing itemz in listZ)
                    {
                        if (itemz.price <= model.maxprice)
                        {
                            listMax.Add(itemz);
                        }
                    }
                    foreach (Listing itemMax in listMax)
                    {
                        if (itemMax.price >= model.minprice)
                        {
                            listMin.Add(itemMax);
                        }
                    }
                    return PartialView(listMin);
                }
                return PartialView(listZ);
            }
            else if (model.maxprice != 0)
            {
                BaseClient client = new BaseClient(baseApiUrl, "Listing", "GetMinList");
                listMin = client.Get<List<Listing>>(model.minprice.ToString());
                foreach (Listing item in listMin)
                {
                    if (item.price <= model.maxprice)
                    {
                        listMax.Add(item);
                    }
                }
                return PartialView(listMax);
            }
            else
            {
                return RedirectToAction("SearchLog");
            }

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
    }


    public class Search {
        public int zipcode { get; set; }
        public int minprice { get; set; }
        public int maxprice { get; set; }
    }
}
