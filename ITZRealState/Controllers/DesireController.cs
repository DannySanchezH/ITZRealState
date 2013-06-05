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
    public class DesireController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/Desire
        public IEnumerable<Desire> GetDesires()
        {
            return db.Desires.AsEnumerable();
        }

        
        // GET api/Desire/5
        public Desire GetDesire(long id)
        {
            Desire desire = db.Desires.Find(id);
            if (desire == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return desire;
        }

        public IEnumerable<Desire> GetMyListDesires(int id)
        {
            List<Desire> _desires = new List<Desire>();
            _desires = (from desire in db.Desires
                        where desire.IdUser == id
                        select desire).ToList();
            return _desires;
        }

        public IEnumerable<Listing> GetMyDesires(long id)
        {
            List<int> _desires = new List<int>();
            _desires=(from desire in db.Desires
                          where desire.IdUser==id
                          select desire.IdListing).ToList();
            List<Listing> listing = new List<Listing>();
            listing = (from _listing in db.Listings
                       where _desires.Contains(_listing.IdListing)
                       select _listing).ToList();
            return listing;
        }

        // PUT api/Desire/5
        public HttpResponseMessage PutDesire(long id, Desire desire)
        {
            if (ModelState.IsValid && id == desire.IdUser)
            {
                db.Entry(desire).State = EntityState.Modified;

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

        // POST api/Desire
        public HttpResponseMessage PostDesire(Desire desire)
        {
            if (ModelState.IsValid)
            {
                db.Desires.Add(desire);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, desire);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = desire.IdUser }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Desire/5
        public HttpResponseMessage DeleteDesire(int id)
        {
            Desire desire = db.Desires.Find(id);
            
            if (desire == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Desires.Remove(desire);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, desire);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}