using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ITZRealState.Models;
using BusinessLMS.Models;

namespace ITZRealState.Controllers
{
    public class AdministratorController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/Administrator
        public IEnumerable<Administrator> GetAdministrators()
        {
            return db.Administrators.AsEnumerable();
        }

        // GET api/Administrator/5
        public Administrator GetAdministrator(long id)
        {
            Administrator administrator = db.Administrators.Find(id);
            if (administrator == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return administrator;
        }

        // PUT api/Administrator/5
        public HttpResponseMessage PutAdministrator(long id, Administrator administrator)
        {
            if (ModelState.IsValid && id == administrator.IdUser)
            {
                db.Entry(administrator).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Administrator
        public HttpResponseMessage PostAdministrator(Administrator administrator)
        {
            if (ModelState.IsValid)
            {
                db.Administrators.Add(administrator);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, administrator);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = administrator.IdUser }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Administrator/5
        public HttpResponseMessage DeleteAdministrator(long id)
        {
            Administrator administrator = db.Administrators.Find(id);
            if (administrator == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Administrators.Remove(administrator);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, administrator);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}