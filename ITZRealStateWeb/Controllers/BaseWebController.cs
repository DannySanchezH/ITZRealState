using ITZRealStateWeb.Helpers;
using ITZRealStateWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web.Mvc;
using WebMatrix.WebData;
using System.Web.Security;

namespace ITZRealStateWeb.Controllers
{
    public class BaseWebController : Controller
    {
        public BaseWebController()
        {
            if (WebSecurity.Initialized == false)
            {
                SimpleMembershipInitializer();
            }
        }
    
        public bool SimpleMembershipInitializer()
        {
            Database.SetInitializer<UsersContext>(null);
            try
            {
                using (var context = new UsersContext())
                {
                    if (!context.Database.Exists())
                    {
                        ((IObjectContextAdapter)context).ObjectContext.CreateDatabase();
                    }
                }
                if (!(WebSecurity.Initialized))
                {
                    WebSecurity.InitializeDatabaseConnection("ITZRealStateContext", "UserProfile", "UserId", "UserName", autoCreateTables: true);
                }
                if (!Roles.RoleExists("Administrator"))
                    Roles.CreateRole("Administrator");
                if (!Roles.RoleExists("SalesAgent"))
                    Roles.CreateRole("SalesAgent");
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("The ASP.NET Simple Membership database could not be initialized. For more information, please see http://go.microsoft.com/fwlink/?LinkId=256588", ex);
            }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            String actionName = filterContext.ActionDescriptor.ActionName;
            String controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            try
            {
                    if ((WebSecurity.IsAuthenticated) && (actionName != "LogOff"))
                    {
                        ViewBag.user = user;
                        ViewBag.id = userid;
                        ViewBag.rol = userRol;
                    }
                }
            catch { }
            ViewBag.actionName = actionName;
            ViewBag.controllerName = controllerName;
            base.OnActionExecuted(filterContext);
        }

        public string baseApiUrl
        {
            get { return ConfigurationManager.AppSettings["ApiUrl"]; }
        }

        public string user
        {
            get
            {
              if (!(WebSecurity.Initialized)) {
                WebSecurity.InitializeDatabaseConnection("ITZRealStateContext", "UserProfile", "UserId", "UserName", autoCreateTables: true);
              }
                string user = WebSecurity.CurrentUserName.ToString();
                return user;
            }
        }
        public string userid
        {
            get
            {
                if (!(WebSecurity.Initialized))
                {
                    WebSecurity.InitializeDatabaseConnection("ITZRealStateContext", "UserProfile", "UserId", "UserName", autoCreateTables: true);
                }
                string user = WebSecurity.CurrentUserId.ToString();
                return user;
            }
        }

        public string userRol
        {
            get
            {
                if (!(WebSecurity.Initialized))
                {
                    WebSecurity.InitializeDatabaseConnection("ITZRealStateContext", "webpages_Roles", "RoleId", "RoleName", autoCreateTables: true);
                }
                string[] roles = Roles.GetRolesForUser();
                string firstRol = roles[0];
                return firstRol;
            }
        }

    }
}