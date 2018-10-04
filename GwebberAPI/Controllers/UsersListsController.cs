using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GwebberAPI.Models;

namespace GwebberAPI.Controllers
{
    public class UsersListsController : ApiController
    {
        private GwebberAPIContext db = new GwebberAPIContext();

        // GET: api/UsersLists
        public IQueryable<UsersList> GetUsersLists()
        {
            return db.UsersLists;
        }

        // GET: api/UsersLists/5
        [ResponseType(typeof(UsersList))]
        public IHttpActionResult GetUsersList(int id)
        {
            UsersList usersList = db.UsersLists.Find(id);
            if (usersList == null)
            {
                return NotFound();
            }

            return Ok(usersList);
        }

        // PUT: api/UsersLists/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsersList(int id, UsersList usersList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usersList.Id)
            {
                return BadRequest();
            }

            db.Entry(usersList).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersListExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/UsersLists
        [ResponseType(typeof(UsersList))]
        public IHttpActionResult PostUsersList(UsersList usersList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UsersLists.Add(usersList);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = usersList.Id }, usersList);
        }

        // DELETE: api/UsersLists/5
        [ResponseType(typeof(UsersList))]
        public IHttpActionResult DeleteUsersList(int id)
        {
            UsersList usersList = db.UsersLists.Find(id);
            if (usersList == null)
            {
                return NotFound();
            }

            db.UsersLists.Remove(usersList);
            db.SaveChanges();

            return Ok(usersList);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersListExists(int id)
        {
            return db.UsersLists.Count(e => e.Id == id) > 0;
        }
    }
}