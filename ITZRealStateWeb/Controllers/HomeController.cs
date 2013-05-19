using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITZRealStateWeb.Controllers
{
    public class HomeController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            //string cultureName = null;
            //HttpCookie cultureCookie = Request.Cookies["_ibovirtualculture"];
            //if (cultureCookie != null)
            //    cultureName = cultureCookie.Value;
            //else
            //    cultureName = Request.UserLanguages[0];

            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            //Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            base.OnActionExecuted(filterContext);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contacto.";

            return View();
        }
    }
}
