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

        public ActionResult Edit(int id)
        {
            BaseClient client = new BaseClient(baseApiUrl, "User", "GetUser");
            string idu = id.ToString();
            User user = client.Get<User>(idu);
            if (user == null)
            {
                user = new User();
                user.IdUser = id;
            }
            return PartialView(user);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult EditUserAjax(User model)
        {
            BaseClient client = new BaseClient(baseApiUrl, "User", "GetUser");
            User user = client.Get<User>(model.IdUser.ToString()); 
            if (ModelState.IsValid == true)
            {
            if (user==null)
            {
                client = new BaseClient(baseApiUrl, "User", "PostUser");
                string result = client.Post<User>(model);
                return Json(new { success = true });
            }
                try
                {
                    client = new BaseClient(baseApiUrl, "User", "PutUser");
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
