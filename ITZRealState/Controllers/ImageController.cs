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
    public class ImageController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/Image
        public IEnumerable<Image> GetImages()
        {
            return db.Images.AsEnumerable();
        }

        // GET api/Image/5
        public Image GetImage(long id)
        {
            Image image = db.Images.Find(id);
            if (image == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return image;
        }

        // PUT api/Image/5
        public HttpResponseMessage PutImage(long id, Image image)
        {
            if (ModelState.IsValid && id == image.IdListing)
            {
                db.Entry(image).State = EntityState.Modified;

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

        // POST api/Image
        public HttpResponseMessage PostImage(Image image)
        {
            if (ModelState.IsValid)
            {
                db.Images.Add(image);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, image);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = image.IdListing }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Image/5
        public HttpResponseMessage DeleteImage(long id)
        {
            Image image = db.Images.Find(id);
            if (image == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Images.Remove(image);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, image);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}