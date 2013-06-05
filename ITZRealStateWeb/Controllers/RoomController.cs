using ITZRealStateWeb.Helpers;
using ITZRealStateWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITZRealStateWeb.Controllers
{
    public class RoomController : BaseWebController
    {
        //
        // GET: /Room/

        public ActionResult Index()
        {
            BaseClient client = new BaseClient(baseApiUrl, "Room", "GetRooms");
            List<Room> rooms = client.Get<List<Room>>();
            return PartialView(rooms);
        }

        //
        // GET: /Room/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Room/Create

        public ActionResult Create()
        {
            Room room = new Room();
            room.IdRoom = 0;
            return PartialView(room);
        }

        //
        // POST: /Room/Create

        [HttpPost]
        public ActionResult CreateRoom(Room model)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    BaseClient client = new BaseClient(baseApiUrl, "Room", "PostRoom");
                    string result = client.Post<Room>(model);

                }
                catch
                {
                    return Redirect("/Dashboard");
                }
            }

            return Redirect("/Dashboard");
        }

        //
        // GET: /Room/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Room/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Room/Delete/5

        public ActionResult Delete(int id)
        {
            try
            {
                BaseClient client = new BaseClient(baseApiUrl, "Room", "DeleteRoom");
                string result = client.Delete(id.ToString());
                return Redirect("/Dashboard");
            }
            catch
            {
                return Redirect("/Dashboard");
            }
        }

        //
        // POST: /Room/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
