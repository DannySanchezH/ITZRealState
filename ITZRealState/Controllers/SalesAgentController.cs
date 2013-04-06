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
    public class SalesAgentController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/SalesAgent
        public IEnumerable<SalesAgent> GetSalesAgents()
        {
            return db.SalesAgents.AsEnumerable();
        }

        // GET api/SalesAgent/5
        public SalesAgent GetSalesAgent(long id)
        {
            SalesAgent salesagent = db.SalesAgents.Find(id);
            if (salesagent == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return salesagent;
        }

        // PUT api/SalesAgent/5
        public HttpResponseMessage PutSalesAgent(long id, SalesAgent salesagent)
        {
            if (ModelState.IsValid && id == salesagent.IdUser)
            {
                db.Entry(salesagent).State = EntityState.Modified;

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

        // POST api/SalesAgent
        public HttpResponseMessage PostSalesAgent(SalesAgent salesagent)
        {
            if (ModelState.IsValid)
            {
                db.SalesAgents.Add(salesagent);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, salesagent);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = salesagent.IdUser }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/SalesAgent/5
        public HttpResponseMessage DeleteSalesAgent(long id)
        {
            SalesAgent salesagent = db.SalesAgents.Find(id);
            if (salesagent == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.SalesAgents.Remove(salesagent);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, salesagent);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}