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
    public class ListingController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/Listing
        public IEnumerable<Listing> GetListings()
        {
            return db.Listings.AsEnumerable();
        }

        // GET api/Listing/5
        public Listing GetListing(long id)
        {
            Listing listing = db.Listings.Find(id);
            if (listing == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return listing;
        }


        // PUT api/Listing/5
        public HttpResponseMessage PutListing(long id, Listing listing)
        {
            if (ModelState.IsValid && id == listing.IdListing)
            {
                db.Entry(listing).State = EntityState.Modified;

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

        // POST api/Listing
        public HttpResponseMessage PostListing(Listing listing)
        {
            if (ModelState.IsValid)
            {
                db.Listings.Add(listing);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, listing);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = listing.IdListing }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Listing/5
        public HttpResponseMessage DeleteListing(long id)
        {
            Listing listing = db.Listings.Find(id);
            if (listing == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Listings.Remove(listing);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, listing);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}