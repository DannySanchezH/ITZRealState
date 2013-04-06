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
    public class AmenitieController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/Amenitie
        public IEnumerable<Amenitie> GetAmenities()
        {
            return db.Amenities.AsEnumerable();
        }

        // GET api/Amenitie/5
        public Amenitie GetAmenitie(int id)
        {
            Amenitie amenitie = db.Amenities.Find(id);
            if (amenitie == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return amenitie;
        }

        // PUT api/Amenitie/5
        public HttpResponseMessage PutAmenitie(int id, Amenitie amenitie)
        {
            if (ModelState.IsValid && id == amenitie.IdAmenitie)
            {
                db.Entry(amenitie).State = EntityState.Modified;

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

        // POST api/Amenitie
        public HttpResponseMessage PostAmenitie(Amenitie amenitie)
        {
            if (ModelState.IsValid)
            {
                db.Amenities.Add(amenitie);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, amenitie);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = amenitie.IdAmenitie }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Amenitie/5
        public HttpResponseMessage DeleteAmenitie(int id)
        {
            Amenitie amenitie = db.Amenities.Find(id);
            if (amenitie == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Amenities.Remove(amenitie);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, amenitie);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}