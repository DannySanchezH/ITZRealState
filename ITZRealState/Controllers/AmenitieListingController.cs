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
    public class AmenitieListingController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/AmenitieListing
        public IEnumerable<AmenitieListing> GetAmenitieListings()
        {
            return db.AmenitieListings.AsEnumerable();
        }

        // GET api/AmenitieListing/5
        public AmenitieListing GetAmenitieListing(long id)
        {
            AmenitieListing amenitielisting = db.AmenitieListings.Find(id);
            if (amenitielisting == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return amenitielisting;
        }

        // PUT api/AmenitieListing/5
        public HttpResponseMessage PutAmenitieListing(long id, AmenitieListing amenitielisting)
        {
            if (ModelState.IsValid && id == amenitielisting.IdListing)
            {
                db.Entry(amenitielisting).State = EntityState.Modified;

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

        // POST api/AmenitieListing
        public HttpResponseMessage PostAmenitieListing(AmenitieListing amenitielisting)
        {
            if (ModelState.IsValid)
            {
                db.AmenitieListings.Add(amenitielisting);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, amenitielisting);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = amenitielisting.IdListing }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/AmenitieListing/5
        public HttpResponseMessage DeleteAmenitieListing(long id)
        {
            AmenitieListing amenitielisting = db.AmenitieListings.Find(id);
            if (amenitielisting == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.AmenitieListings.Remove(amenitielisting);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, amenitielisting);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}