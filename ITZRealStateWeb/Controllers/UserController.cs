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
    public class UserController : BaseWebController
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            return PartialView();
        }

        //
        // POST: /User/Create

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
        // GET: /User/Edit/5

        public ActionResult Edit(string id)
        {
            BaseClient client = new BaseClient(baseApiUrl, "User", "GetUser");
            User user = client.Get<User>(id);
            return PartialView(user);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult EditUserAjax(User model)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    BaseClient client = new BaseClient(baseApiUrl, "User", "PutUser");
                    string result = client.Put<User>(model.IdUser.ToString(), model);
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
        // GET: /User/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /User/Delete/5

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
