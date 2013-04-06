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
    public class RoomController : ApiController
    {
        private ITZRealStateContext db = new ITZRealStateContext();

        // GET api/Room
        public IEnumerable<Room> GetRooms()
        {
            return db.Rooms.AsEnumerable();
        }

        // GET api/Room/5
        public Room GetRoom(int id)
        {
            Room room = db.Rooms.Find(id);
            if (room == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return room;
        }

        // PUT api/Room/5
        public HttpResponseMessage PutRoom(int id, Room room)
        {
            if (ModelState.IsValid && id == room.IdRoom)
            {
                db.Entry(room).State = EntityState.Modified;

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

        // POST api/Room
        public HttpResponseMessage PostRoom(Room room)
        {
            if (ModelState.IsValid)
            {
                db.Rooms.Add(room);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, room);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = room.IdRoom }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Room/5
        public HttpResponseMessage DeleteRoom(int id)
        {
            Room room = db.Rooms.Find(id);
            if (room == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Rooms.Remove(room);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, room);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}