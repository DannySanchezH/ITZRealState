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
    public class RoomListingController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/RoomListing
        public IEnumerable<RoomListing> GetRoomListings()
        {
            return db.RoomListings.AsEnumerable();
        }

        // GET api/RoomListing/5
        public RoomListing GetRoomListing(long id)
        {
            RoomListing roomlisting = db.RoomListings.Find(id);
            if (roomlisting == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return roomlisting;
        }

        // PUT api/RoomListing/5
        public HttpResponseMessage PutRoomListing(long id, RoomListing roomlisting)
        {
            if (ModelState.IsValid && id == roomlisting.IdListing)
            {
                db.Entry(roomlisting).State = EntityState.Modified;

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

        // POST api/RoomListing
        public HttpResponseMessage PostRoomListing(RoomListing roomlisting)
        {
            if (ModelState.IsValid)
            {
                db.RoomListings.Add(roomlisting);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, roomlisting);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = roomlisting.IdListing }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/RoomListing/5
        public HttpResponseMessage DeleteRoomListing(long id)
        {
            RoomListing roomlisting = db.RoomListings.Find(id);
            if (roomlisting == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.RoomListings.Remove(roomlisting);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, roomlisting);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}