using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITZRealStateWeb.Models;

namespace ITZRealStateWeb.Controllers
{
    [Authorize]
    public class DashboardController : BaseWebController
    {
        //
        // GET: /Dashboard/

        public ActionResult Index(RegisterModel userprof)
        {
            return View();
        } 
    }
}
