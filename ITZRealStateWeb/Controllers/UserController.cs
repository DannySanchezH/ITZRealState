using ITZRealStateWeb.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITZRealStateWeb.Models;
using System.Web.Security;
using WebMatrix.WebData;

namespace ITZRealStateWeb.Controllers
{
    public class UserController : BaseWebController
    {
        //
        // GET: /SalesAgent/

        public ActionResult Index()
        {
            BaseClient client=new BaseClient(baseApiUrl, "User", "GetUsers");
            List<User> agents = client.Get<List<User>>();
            List<User> _agents = new List<User>();
            foreach (User item in agents)
            {
                if (Roles.IsUserInRole(item.UserName, "SalesAgent"))
                {
                    _agents.Add(item);
                }
            }
            return PartialView(_agents);
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
            RegisterModel agent = new RegisterModel();
            return PartialView(agent);
        }


        public ActionResult CreateAgentAjax(RegisterModel model)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    WebSecurity.CreateUserAndAccount(model.UserName, model.Password, new { FirstName = model.FirstName, LastName = model.LastName, Email = model.Email, ZipCode = model.Zipcode, phone = model.phone, cellular = model.cellular });
                    Roles.AddUserToRole(model.UserName, "SalesAgent");
                    return Json(new { success = true });
                }
                catch
                {
                    return Json(new { success = false });
                }

            }
            return Json(new { success = false });
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
