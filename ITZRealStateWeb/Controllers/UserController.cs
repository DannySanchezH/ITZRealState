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
                }
                catch
                {
                    return Redirect("/Dashboard");
                }

            }
            return Redirect("/Dashboard");
        }


        //
        // GET: /SalesAgent/Edit/5

        public ActionResult Edit(int id)
        {
            BaseClient client = new BaseClient(baseApiUrl, "User", "GetUser");
            User agent = client.Get<User>(id.ToString());
            return PartialView(agent);
        }

        [HttpPost]
        public ActionResult EditAjax(User model)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    BaseClient client = new BaseClient(baseApiUrl, "User", "PutUser");
                    string result = client.Put<User>(model.UserId.ToString(), model);
                }
                catch
                {
                    return Redirect("/Dashboard");
                }
            }
                return Redirect("/Dashboard");
        }


        public ActionResult DeleteAgentAjax(string id)
        {
            try
            {
                BaseClient client = new BaseClient(baseApiUrl, "User", "GetUser");
                User agent = client.Get<User>(id.ToString());
                Roles.RemoveUserFromRole(agent.UserName, "SalesAgent");
               client = new BaseClient(baseApiUrl, "User", "DeleteUser");
                string result = client.Delete(id);
                return Redirect("/Dashboard");
            }
            catch
            {
                BaseClient client = new BaseClient(baseApiUrl, "User", "GetUser");
                User agent = client.Get<User>(id.ToString());
                Roles.AddUserToRole(agent.UserName, "SalesAgent");
                return Redirect("/Dashboard");
            }
        }

        public ActionResult UpgrateAgent(string id)
        {
            try
            {
                Roles.AddUserToRole(id, "Administrator");
                Roles.RemoveUserFromRole(id, "SalesAgent");
                return Redirect("/Dashboard");
            }
            catch
            {
                return Redirect("/Dashboard");
            }
        }

    }
}
