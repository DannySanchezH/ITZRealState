using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITZRealStateWeb.Models;
using WebMatrix.WebData;

namespace ITZRealStateWeb.Controllers
{
    [Authorize]
    public class DashboardController : BaseWebController
    {
        //
        // GET: /Dashboard/

        public ActionResult Index()
        {
            return View();
        } 
    }
}
