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
    public class ClientController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/Client
        public IEnumerable<Client> GetClients()
        {
            return db.Clients.AsEnumerable();
        }

        // GET api/Client/5
        public Client GetClient(long id)
        {
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return client;
        }

        // PUT api/Client/5
        public HttpResponseMessage PutClient(long id, Client client)
        {
            if (ModelState.IsValid && id == client.IdUser)
            {
                db.Entry(client).State = EntityState.Modified;

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

        // POST api/Client
        public HttpResponseMessage PostClient(Client client)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(client);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, client);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = client.IdUser }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Client/5
        public HttpResponseMessage DeleteClient(long id)
        {
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Clients.Remove(client);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, client);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}